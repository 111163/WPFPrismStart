using FeiyaoAutoBaseLib;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFNetFramePrismMD.Events;
using WPFNetFramePrismMD.Models;

namespace WPFNetFramePrismMD.ViewModels
{
    /// <summary>
    /// MainViewModel
    /// </summary>
    public class MainViewModel : BindableBase, INavigationAware
    {
        private readonly IRegionManager _region;
        private readonly IEventAggregator _aggregator;
        public MainViewModel(IRegionManager region, IEventAggregator aggregator)
        {
            _aggregator = aggregator;
            _region = region;
            NaviCommand = new DelegateCommand<string>(Navi);
            ConfirmLanCommand = new DelegateCommand(() =>
            {

               // if (LanguageTool.AppCurrentLanguage == CurrentLanguage.Key) return;

                StaysOpen = false;
                LanguageTool.SetLanguage(CurrentLanguage.Key);
                aggregator.GetEvent<LanguageEventBus>().Publish(true);
                //System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("zh-CN");
                //System.Threading.Thread.CurrentThread.CurrentUICulture = culture;
                //System.Windows.Application.Current.Resources.MergedDictionaries[0].Source = new Uri("/WPFNetFramePrismMD;component/Resources/zh-CN.xaml", UriKind.Relative);
            });
            LanguageInfos = new ObservableCollection<LanguageInfo>();
            InitLanguageInfos();
            CurrentLanguage = LanguageInfos[0];

            StaysOpen = true;
            Messages = new ObservableCollection<MessageModel>();
            _aggregator.GetEvent<MessageEvent>().Subscribe(ShowMessage,filter);
        }
        private bool _StaysOpen;

        public bool StaysOpen
        {
            get { return _StaysOpen; }
            set { _StaysOpen = value; }
        }

        private ObservableCollection<LanguageInfo> languageInfos;

        public ObservableCollection<LanguageInfo> LanguageInfos
        {
            get { return languageInfos; }
            set { languageInfos = value; RaisePropertyChanged(); }
        }
        private void InitLanguageInfos()
        {
            LanguageInfos.Add(new LanguageInfo() { Key = "zh-CN", Value = "中文" });
            LanguageInfos.Add(new LanguageInfo() { Key = "en-US", Value = "English" });
        }
        private LanguageInfo currentLanguage;
        public LanguageInfo CurrentLanguage
        {
            get { return currentLanguage; }
            set
            {
                currentLanguage = value;
                StaysOpen = true;
                LanguageChanged();
                RaisePropertyChanged();
            }
        }

        private void LanguageChanged()
        {
            if (LanguageTool.AppCurrentLanguage == CurrentLanguage.Key) return;

            LanguageTool.SetLanguage(CurrentLanguage.Key);
            _aggregator.GetEvent<LanguageEventBus>().Publish(true);
        }

        private bool _EnalbeEventFliter;

        public bool EnalbeEventFliter
    {
            get { return _EnalbeEventFliter; }
            set
            {
                _EnalbeEventFliter = value; 
                RaisePropertyChanged(); 
            }
        }

        private bool filter(MessageModel obj)
        {
            if (EnalbeEventFliter)
            {
                return obj.Code ==100;
            }
            else
            {
                return true;
            }
        }
        

        private ObservableCollection<MessageModel> _messages;

        public ObservableCollection<MessageModel> Messages
        {
            get { return _messages; }
            set { SetProperty(ref _messages, value); }
        }
        private void ShowMessage(MessageModel model)
        {
            Messages.Add(model);
        }

        private void Navi(string obj)
        {
            if (obj == null || string.IsNullOrWhiteSpace(obj)) return;

            _region.Regions["MainRegion"].RequestNavigate(obj, callBack =>
            {
                if (!(bool)callBack.Result)
                    System.Diagnostics.Debug.WriteLine(callBack.Error.Message);
            });
        }
        public DelegateCommand ConfirmLanCommand { get; set; }
        public DelegateCommand<string> NaviCommand { get;set; }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }
    }
}
