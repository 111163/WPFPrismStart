using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNetFramePrismMD.ViewModels.Dialogs
{
    class LoginDialogViewModel : BindableBase, IDialogAware
    {
        private DelegateCommand<string> _closeDialogCommand;
        public DelegateCommand<string> CloseDialogCommand =>
            _closeDialogCommand ?? (_closeDialogCommand = new DelegateCommand<string>(CloseDialog));

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private string _title = "Notification";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog()
        {
            return true;
        }

        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        private string _UserName;

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        private bool IsConfirmOK=false;
        public void OnDialogClosed()
        {
            //if (IsConfirmOK)
            //{
            //    DialogParameters keys = new DialogParameters();
            //    keys.Add("UserName", UserName);//返回的结果，名字为Value的变量，值为Hello
            //    keys.Add("Password", Password);//返回的结果，名字为Value的变量，值为18
            //    RequestClose?.Invoke(new DialogResult(ButtonResult.OK, keys));
            //}
            
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            Message = parameters.GetValue<string>("message");
        }
        protected virtual void CloseDialog(string parameter)
        {
            DialogParameters keys = new DialogParameters();
            ButtonResult result = ButtonResult.None;

            if (parameter?.ToLower() == "true")
            {
                result = ButtonResult.OK;
                keys.Add("UserName", UserName);//返回的结果，名字为Value的变量，值为Hello
                keys.Add("Password", Password);//返回的结果，名字为Value的变量，值为18
            }
                
            else if (parameter?.ToLower() == "false")
            {
                result = ButtonResult.Cancel;
            }
                

            RaiseRequestClose(new DialogResult(result, keys));
        }
        public virtual void RaiseRequestClose(IDialogResult dialogResult)
        {
            RequestClose?.Invoke(dialogResult);
        }
    }
}
