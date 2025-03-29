using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNetFramePrismMD.ViewModels.RegionUC
{
    public class TestCViewModel : BindableBase
    {
        public TestCViewModel()
        {
            ViewTitle = "TestCView";
        }
        private string _ViewTitle;

        public string ViewTitle
        {
            get { return _ViewTitle; }
            set { _ViewTitle = value; RaisePropertyChanged(); }
        }

    }
}
