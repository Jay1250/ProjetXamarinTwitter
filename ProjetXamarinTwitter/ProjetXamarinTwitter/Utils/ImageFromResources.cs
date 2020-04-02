using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projetXamarinTwitter.Utils
{
    [ContentProperty(nameof(Source))]
    class ImageFromResources : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Source != null ? ImageSource.FromResource(Source, typeof(ImageFromResources).GetTypeInfo().Assembly) : Source;
        }
    }
}
