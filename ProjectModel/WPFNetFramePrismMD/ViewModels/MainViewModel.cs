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
            _region = region;
            NaviCommand = new DelegateCommand<string>(Navi);
            _aggregator = aggregator;
            
            Messages = new ObservableCollection<MessageModel>();
            _aggregator.GetEvent<MessageEvent>().Subscribe(ShowMessage,filter);
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
