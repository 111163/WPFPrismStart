using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNetFramePrismMD.ViewModels.RegionFakeFarm
{
    public class UCFakeFarmViewModel : BindableBase
    {
        public UCFakeFarmViewModel()
        {
            ExeCmd = new DelegateCommand<BaseProduct>(ExeCmdDetail);
            // Constructor logic can be added here if needed

            Productlists = new ObservableCollection<BaseProduct>
            {
                new ProductInfos
                {
                    ProPicPath = Path.Combine(GetRootPath(),"1.png"),
                    ProName = "商品名称1",
                    ProPrice = 100,
                    BuyerNum = 10,
                    IsLastPrice = true
                },
                new IncreasePointsInfo
                {
                    NoteStr = "增加积分",
                    IsConfirm = false
                },
                new ProductInfos
                {
                    ProPicPath =Path.Combine(GetRootPath(),"2.png"),
                    ProName = "商品名称2",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                }
                ,
                new IncreasePointsInfo
                {
                    NoteStr = "增加积分",
                    IsConfirm = false
                },
                new ProductInfos
                {
                    ProPicPath = Path.Combine(GetRootPath(),"3.png"),
                    ProName = "商品名称3",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                }
                ,
                new ProductInfos
                {
                    ProPicPath = Path.Combine(GetRootPath(),"4.png"),
                    ProName = "商品名称4",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                }
                ,
                new ProductInfos
                {
                    ProPicPath = Path.Combine(GetRootPath(),"5.jpg"),
                    ProName = "商品名称5",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                }
                ,
                new ProductInfos
                {
                    ProPicPath = Path.Combine(GetRootPath(),"6.jpg"),
                    ProName = "商品名称6",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                }
                ,
                new ProductInfos
                {
                    ProPicPath = Path.Combine(GetRootPath(),"7.jpg"),
                    ProName = "商品名称7",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                }
                ,
                new ProductInfos
                {
                    ProPicPath = Path.Combine(GetRootPath(),"8.jpg"),
                    ProName = "商品名称8",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                }
                ,
                new ProductInfos
                {
                    ProPicPath = Path.Combine(GetRootPath(),"9.jpg"),
                    ProName = "商品名称9",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                }
                ,
                new ProductInfos
                {
                    ProPicPath = Path.Combine(GetRootPath(),"10.jpg"),
                    ProName = "商品名称10",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                },
                new ProductInfos
                {
                    ProPicPath = Path.Combine(GetRootPath(),"11.jpg"),
                    ProName = "商品名称11",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                }
                ,
                new ProductInfos
                {
                    ProPicPath = Path.Combine(GetRootPath(),"12.jpg"),
                    ProName = "商品名称12",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                }
            };
            //Console.WriteLine(Productlists[0].ProPicPath );
        }

        private void ExeCmdDetail(BaseProduct product)
        {
            if(product is ProductInfos productInfo)
            {
                // Handle ProductInfos specific logic
                Console.WriteLine($"Product Name: {productInfo.ProName}, Price: {productInfo.ProPrice}");
            }
            else if (product is IncreasePointsInfo increasePointsInfo)
            {
                // Handle IncreasePointsInfo specific logic
                Console.WriteLine($"Note: {increasePointsInfo.NoteStr}, Confirmed: {increasePointsInfo.IsConfirm}");
            }
        }

        private ObservableCollection<BaseProduct> _Productlists;

        public ObservableCollection<BaseProduct> Productlists
        {
            get { return _Productlists; }
            set { _Productlists = value; }
        }

        //写一个方法，获取软件执行根目录
        public string GetRootPath()
        {
            //获取当前执行路径
            string path = AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(path,"Asserts","Img","Pro");
        }


        public DelegateCommand<BaseProduct> ExeCmd { get; set; }


    }
    public class BaseProduct
    {

    }
    public class ProductInfos: BaseProduct
    {
        public string ProPicPath { get; set; }
        public string ProName { get; set; }
        public int ProPrice { get; set; }
        /// <summary>
        /// 买家人数
        /// </summary>
        public int BuyerNum { get; set; }
        /// <summary>
        /// 券后价
        /// </summary>
        public bool IsLastPrice { get; set; }
    }

    public class IncreasePointsInfo : BaseProduct
    {
        public string NoteStr { get; set; }
        public bool IsConfirm { get; set; }
    }
}
