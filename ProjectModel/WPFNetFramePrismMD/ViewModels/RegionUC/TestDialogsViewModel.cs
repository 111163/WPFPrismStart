using HandyControl.Controls;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFNetFramePrismMD.ViewModels.RegionUC
{
    public class TestDialogsViewModel : BindableBase, IConfirmNavigationRequest
    {
        IDialogService _dialogService;
        public TestDialogsViewModel(IDialogService dialogService)
        {
            ViewTitle = "TestDialogsView";
            _dialogService=dialogService;
            OpenDialogCommand =new DelegateCommand<String>(OpenDialog);
        }

        private void OpenDialog(string obj)
        {
            switch (obj)
            {
                case "Dialog":
                    var message = $"导航的命名空间不存在，请检查";

                    _dialogService.ShowDialog("MessageShowDialogView", new DialogParameters($"message={DialogInfo}"), DialogClosedcallback);
                    break;
                case "LoginDialog":
                    _dialogService.ShowDialog("LoginDialogView", new DialogParameters(), LoginDialogClosedcallback);
                    break;
            }
        }

        private void LoginDialogClosedcallback(IDialogResult result)
        {
            if (result.Result == ButtonResult.OK)
            {
                UserName = result.Parameters.GetValue<string>("UserName");
                Password = result.Parameters.GetValue<string>("Password");
            }
        }
        private string _UserName;

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; RaisePropertyChanged(); }
        }
        //Password
        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; RaisePropertyChanged(); }
        }
        private string _DialogInfo;

        public string DialogInfo
        {
            get { return _DialogInfo; }
            set { _DialogInfo = value;RaisePropertyChanged(); }
        }



        private void DialogClosedcallback(IDialogResult result)
        {
            //拿回Dialog的返回值，是确定还是Cancel
            if (result.Result == ButtonResult.OK)
            {

                HandyControl.Controls.MessageBox.Show("你点击了确定");
            }
            else
            {
                HandyControl.Controls.MessageBox.Show("你点击了取消");
            }
        }

        private string _ViewTitle;

        public string ViewTitle
        {
            get { return _ViewTitle; }
            set { _ViewTitle = value; RaisePropertyChanged(); }
        }

        public DelegateCommand<String> OpenDialogCommand { get; set; }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            Console.WriteLine("导航进入TestViewB");
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            //重新实例化
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            Console.WriteLine("导航离开ViewB");
        }

        public void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
        {
            //base.ConfirmNavigationRequest(navigationContext, continuationCallback);
            bool result = true;
            var IsSelf = navigationContext.Uri.ToString().Contains("ViewB");
            if (!IsSelf)
            {
                if (HandyControl.Controls.MessageBox.Show("确认导航", "温馨提示", MessageBoxButton.YesNo) == MessageBoxResult.No)
                    result = false;
                continuationCallback(result);
            }
            
        }
    }
}
