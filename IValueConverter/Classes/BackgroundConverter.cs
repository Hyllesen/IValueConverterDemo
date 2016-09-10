using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace IValueConverterProject.Classes
{
    public class BackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value != null)
            {
                if (value.ToString() == "Male")
                {
                    Console.WriteLine("Male");
                    return new SolidColorBrush(new Color()
                    {
                        A = 255,
                        R = 255,
                        G = 255,
                        B = 0
                    });
                }
                else
                {
                    Console.WriteLine("FeMale");
                    return new SolidColorBrush(new Color()
                    {
                        A = 255,
                        R = 0,
                        G = 255,
                        B = 255
                    });
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
