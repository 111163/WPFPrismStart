using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNetFramePrismMD.ViewModels.RegionUC
{
    public class TestViewAModel:BindableBase,INavigationAware
    {
        public TestViewAModel()
        {
            ViewTitle = "TestViewA";
        }
        private string _ViewTitle;

        public string ViewTitle
        {
            get { return _ViewTitle; }
            set { _ViewTitle = value; RaisePropertyChanged(); }
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            Console.WriteLine("导航进入ViewA");
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            Console.WriteLine("导航离开ViewA");
        }
    }
}
