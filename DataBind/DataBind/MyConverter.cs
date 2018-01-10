using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace DataBind
{
    public class MyConverter : IValueConverter
    {
        //转换器
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //throw new NotImplementedException();
            var date = (DateTime)value;
            //判断类型
            switch (targetType.Name)
            {
                case "String":
                    return date.ToString("d",culture);
                case "Brush":
                    return Brushes.Blue;
                default:
                    return value;
            }
        }

        //public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    return null;
        //}
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => null;

    }
}
