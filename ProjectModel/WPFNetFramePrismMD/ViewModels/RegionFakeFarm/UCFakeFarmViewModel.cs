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
            // Constructor logic can be added here if needed

            Productlists= new ObservableCollection<ProductInfos>
            {
                new ProductInfos
                {
                    ProPicPath = Path.Combine(GetRootPath(),"2.png"),
                    ProName = "商品名称1",
                    ProPrice = 100,
                    BuyerNum = 10,
                    IsLastPrice = true
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
                new ProductInfos
                {
                    ProPicPath = Path.Combine(GetRootPath(),"1.png"),
                    ProName = "商品名称2",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                }
                ,
                new ProductInfos
                {
                    ProPicPath = "pack://application:,,,/Resources/Images/2.jpg",
                    ProName = "商品名称2",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                }
                ,
                new ProductInfos
                {
                    ProPicPath = "pack://application:,,,/Resources/Images/2.jpg",
                    ProName = "商品名称2",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                }
                ,
                new ProductInfos
                {
                    ProPicPath = "pack://application:,,,/Resources/Images/2.jpg",
                    ProName = "商品名称2",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                }
                ,
                new ProductInfos
                {
                    ProPicPath = "pack://application:,,,/Resources/Images/2.jpg",
                    ProName = "商品名称2",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                }
                ,
                new ProductInfos
                {
                    ProPicPath = "pack://application:,,,/Resources/Images/2.jpg",
                    ProName = "商品名称2",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                }
                ,
                new ProductInfos
                {
                    ProPicPath = "pack://application:,,,/Resources/Images/2.jpg",
                    ProName = "商品名称2",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                }
                ,
                new ProductInfos
                {
                    ProPicPath = "pack://application:,,,/Resources/Images/2.jpg",
                    ProName = "商品名称2",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                },
                new ProductInfos
                {
                    ProPicPath = "pack://application:,,,/Resources/Images/2.jpg",
                    ProName = "商品名称2",
                    ProPrice = 200,
                    BuyerNum = 20,
                    IsLastPrice = false
                }
            };
            Console.WriteLine(Productlists[0].ProPicPath );
        }

        private ObservableCollection<ProductInfos> _Productlists;

        public ObservableCollection<ProductInfos> Productlists
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



    }

    public class ProductInfos
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

    public class IncreasePointsInfo
    {

    }
}
