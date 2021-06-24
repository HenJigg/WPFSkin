using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NativeSkin.Themes
{
    public class SkinResourceDictionary : ResourceDictionary
    {
        public SkinResourceDictionary()
        {
            MergedDictionaries.Add(SkinManager.ResourceDictionary);
        }
    }
}
