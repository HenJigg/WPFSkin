using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace NativeSkin.Extension
{
    public static class ColorExtension
    {
        public static SolidColorBrush ColorBrush(this string hexColor)
        {
            var color = (Color?)ColorConverter.ConvertFromString(hexColor)
                ?? Colors.Transparent;
            return new SolidColorBrush(color);
        }
    }
}
