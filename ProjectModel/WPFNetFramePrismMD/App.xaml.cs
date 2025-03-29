using Prism.DryIoc;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPFNetFramePrismMD.ViewModels.Dialogs;
using WPFNetFramePrismMD.ViewModels.RegionUC;
using WPFNetFramePrismMD.Views;
using WPFNetFramePrismMD.Views.Dialogs;
using WPFNetFramePrismMD.Views.RegionUC;

namespace WPFNetFramePrismMD
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //Navigation 显示在ContentControl Region里
            containerRegistry.RegisterForNavigation<TestViewA, TestViewAModel>();
            containerRegistry.RegisterForNavigation<TestDialogsView, TestDialogsViewModel>();
            containerRegistry.RegisterForNavigation<TestViewC, TestViewCModel>();
            containerRegistry.RegisterForNavigation<TestEventView, TestEventViewModel>();
            containerRegistry.RegisterForNavigation<TestShowMsgView, TestShowMsgViewModel>();
            containerRegistry.RegisterForNavigation<TestFileOperView, TestFileOperViewModel>();


            //Dialogs 各种弹窗
            containerRegistry.RegisterDialog<MessageShowDialogView, MessageShowDialogViewModel>();
            containerRegistry.RegisterDialog<LoginDialogView, LoginDialogViewModel>();
        }
    }
}
