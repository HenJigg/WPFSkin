using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NativeSkin
{
    public class SkinResourceExtension : DynamicResourceExtension
    {
        public new SkinResourceDictionaryKey ResourceKey
        {
            get
            {
                Enum.TryParse(base.ResourceKey.ToString(), out SkinResourceDictionaryKey key);

                return key;
            }
            set => base.ResourceKey = value.ToString();
        }
    }
}
