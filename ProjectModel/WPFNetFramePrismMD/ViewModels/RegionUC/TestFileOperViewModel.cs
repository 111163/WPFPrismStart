using FeiyaoAutoBaseLib;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNetFramePrismMD.ViewModels.RegionUC
{
    class TestFileOperViewModel:BindableBase
    {
        public TestFileOperViewModel()
        {
            csvRWTool = new CSVRWTool(path);
            ErrorCsvList = new ObservableCollection<ErrorInfo>();

            StuJsonList = new ObservableCollection<stuInfo>();

            BuildDefaultDataCommand = new DelegateCommand<string>(BuildDefaultData);
            SelectedJsonItemIndex=0;
            SelectedCsvItemIndex=0;
        }

        private void BuildDefaultData(string obj)
        {
            switch (obj)
            {
                default:
                case "Json":
                    StuJsonList = new ObservableCollection<stuInfo>()
                                    {
                                        new stuInfo{Id=1,Name="Tom",Age=20},
                                        new stuInfo{Id=2,Name="Jerry",Age=21},
                                        new stuInfo{Id=3,Name="Mary",Age=22}
                                    };
                    break;
                case "Csv":
                    ErrorCsvList = new ObservableCollection<ErrorInfo>() {
                                    new ErrorInfo
                                    {
                                        ErrorID=1,ErrType=ErrorType.Error,ErrorEnglishDetail="ErrorDetail1",ErrorChineseDetail="错误详情1"
                                    },
                                    new ErrorInfo
                                    {
                                        ErrorID=2,ErrType=ErrorType.Fatal,ErrorEnglishDetail="ErrorDetail2",ErrorChineseDetail="错误详情2"
                                    },
                                    new ErrorInfo
                                    {
                                        ErrorID=3,ErrType=ErrorType.Info,ErrorEnglishDetail="ErrorDetail3",ErrorChineseDetail="错误详情3"
                                    },
                                };
                    break;

            }
            

            
        }

        private ObservableCollection<stuInfo> _StuJsonList;

        public ObservableCollection<stuInfo> StuJsonList
        {
            get { return _StuJsonList; }
            set { _StuJsonList = value;RaisePropertyChanged(); }
        }

        //定义一个字段表示选中的JsonItem的索引SelectedJsonItemIndex
        private int _SelectedJsonItemIndex;

        public int SelectedJsonItemIndex
        {
            get { return _SelectedJsonItemIndex; }
            set { _SelectedJsonItemIndex = value; RaisePropertyChanged(); }
        }

        public DelegateCommand<string> BuildDefaultDataCommand { get; set; }

        //定义一个字段表示选中的CsvItem的索引SelectedCsvItemIndex
        private int _SelectedCsvItemIndex;

        public int SelectedCsvItemIndex
        {
            get { return _SelectedCsvItemIndex; }
            set { _SelectedCsvItemIndex = value; RaisePropertyChanged(); }
        }







        public string path= @"D:\test.csv";
        CSVRWTool csvRWTool { get; set; }

        private ObservableCollection<ErrorInfo> _ErrorCsvList;

        public ObservableCollection<ErrorInfo> ErrorCsvList
        {
            get { return _ErrorCsvList; }
            set { _ErrorCsvList = value; RaisePropertyChanged(); }
        }
        public void ReadCSV()
        {
            var result = csvRWTool.ReadCsvFile<List<ErrorInfo>>();
            //do something with data
        }

        public void WriteCSV()
        {
            csvRWTool.WriteCsvFile(ErrorCsvList);
        }
    }
    public class ErrorInfo
    {
        public int ErrorID { get; set; }
        public ErrorType ErrType { get; set; }
        public string ErrorEnglishDetail { get; set; }
        public string ErrorChineseDetail { get; set; }
    }
    public enum ErrorType
    {
        Fatal,
        Error,
        Warning,
        Info    
    }

    public class stuInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
