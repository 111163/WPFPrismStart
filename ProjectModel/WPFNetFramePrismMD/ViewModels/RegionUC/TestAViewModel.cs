using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNetFramePrismMD.ViewModels.RegionUC
{
    public class TestAViewModel:BindableBase
    {
        public TestAViewModel()
        {
            ViewTitle = "TestAView";
        }
        private string _ViewTitle;

        public string ViewTitle
        {
            get { return _ViewTitle; }
            set { _ViewTitle = value; RaisePropertyChanged(); }
        }

    }
}
