using NativeSkin.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NativeSkin
{
    public class SkinManager
    {
        static ResourceDictionary resourceDictionary;

        internal static ResourceDictionary ResourceDictionary
        {
            get
            {
                if (resourceDictionary != null)
                    return resourceDictionary;

                resourceDictionary = new ResourceDictionary();

                SetSkin(SkinType.Light);

                return resourceDictionary;
            }
        }

        public static SkinType SkinType { get; private set; }

        public static void SetSkin(SkinType skinType)
        {
            SkinType = skinType;

            switch (skinType)
            {
                case SkinType.Light:
                    {  
                        SetResourceValue(SkinResourceDictionaryKey.ContentBackground, "#FFFFFF"); 
                        SetResourceValue(SkinResourceDictionaryKey.ControlBackground, "#00BFFF");
                        SetResourceValue(SkinResourceDictionaryKey.ControlBorderground, "#00BFFF");
                        SetResourceValue(SkinResourceDictionaryKey.ControlForeground, "#000000");
                        break;
                    }

                case SkinType.Dark:
                    {
                        SetResourceValue(SkinResourceDictionaryKey.ContentBackground, "#222529");
                        SetResourceValue(SkinResourceDictionaryKey.ControlBackground, "#00BFFF");
                        SetResourceValue(SkinResourceDictionaryKey.ControlBorderground, "#00BFFF");
                        SetResourceValue(SkinResourceDictionaryKey.ControlForeground, "#FFFFFF");
                        break;
                    }
            }
        }

        static void SetResourceValue(SkinResourceDictionaryKey key, string value)
        {
            ResourceDictionary[key.ToString()] = value.ColorBrush();
        }
    }
}
