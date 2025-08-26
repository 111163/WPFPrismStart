using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WPFNetFramePrismMD.Converters
{
    public class RGBConverter : IMultiValueConverter
    {
        /// <summary>
        /// 正向修改，整合颜色值
        /// </summary>
        /// <param name="values"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null || values.Length < 3)
                return null;
            byte r = System.Convert.ToByte(values[0]);
            byte g = System.Convert.ToByte(values[1]);
            byte b = System.Convert.ToByte(values[2]);
            Color col = Color.FromRgb(r, g, b);
            SolidColorBrush brush = new SolidColorBrush(col);
            return brush;
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
