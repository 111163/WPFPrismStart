using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFNetFramePrismMD.Events;

namespace WPFNetFramePrismMD.ViewModels.RegionUC
{
    class TestEventViewModel : BindableBase, IConfirmNavigationRequest
    {
        private IEventAggregator _aggregator;
        public TestEventViewModel(IEventAggregator aggregator)
        {
            PubCode = 100;
            _aggregator =aggregator;
            SendMessageToMainViewCommand=new DelegateCommand(SendMessageToMainView);
        }
        private string _PubMsg;

        public string PubMsg
        {
            get { return _PubMsg; }
            set { _PubMsg = value; RaisePropertyChanged(); }
        }

        private int _PubCode;

        public int PubCode
        {
            get { return _PubCode; }
            set { _PubCode = value; RaisePropertyChanged(); }
        }

        private void SendMessageToMainView()
        {
            MessageModel message = new MessageModel() 
            { 
                Code= PubCode,
                Message = PubMsg
            };
            _aggregator.GetEvent<MessageEvent>().Publish(message);
        }

        public DelegateCommand SendMessageToMainViewCommand { get; set; }
        public void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
        {
            bool result = true;
            var IsSelf = navigationContext.Uri.ToString().Contains("TestEventView");
            if (!IsSelf)
            {
                if (HandyControl.Controls.MessageBox.Show("确认导航", "温馨提示", MessageBoxButton.YesNo) == MessageBoxResult.No)
                    result = false;
                continuationCallback(result);
            }
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            //导航离开
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            //导航进入
        }
    }
}
