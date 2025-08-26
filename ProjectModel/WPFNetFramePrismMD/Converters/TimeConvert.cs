using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

namespace WPFNetFramePrismMD.Converters
{
    /// <summary>
    /// 自定义事件转换
    /// </summary>
    public class TimeConvert : IValueConverter
    {
        /// <summary>
        /// 当值从绑定源传播给绑定目标时，调用方法Convert
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return DependencyProperty.UnsetValue;
            DateTime date = (DateTime)value;
            return date.ToString("yyyy-MM-dd");
        }
        /// <summary>
        /// 当值从绑定目标传播给绑定源时，调用此方法ConvertBack
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string str = value as string;
            DateTime txtDate;
            if (DateTime.TryParse(str, out txtDate))
            {
                return txtDate;
            }
            return DependencyProperty.UnsetValue;
        }
    }
}
