using SVG.Forms.Plugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace SvgSample
{
    public class SvgPageCS : ContentPage
    {
        public SvgPageCS()
        {
            var appStore = new SvgImage
            {
                SvgPath = "SvgSample.Resources.AppStore.svg",
                SvgAssembly = typeof(App).GetTypeInfo().Assembly,
                WidthRequest = 135,
                HeightRequest = 40,
                HorizontalOptions = LayoutOptions.Center
            };
            var coolMask = new SvgImage
            {
                SvgPath = "SvgSample.Resources.CoolMask.svg",
                SvgAssembly = typeof(App).GetTypeInfo().Assembly,
                WidthRequest = 100,
                HeightRequest = 100,
                HorizontalOptions = LayoutOptions.Center
            };
            var tiger = new SvgImage
            {
                SvgPath = "SvgSample.Resources.Tiger.svg",
                SvgAssembly = typeof(App).GetTypeInfo().Assembly,
                WidthRequest = 300,
                HeightRequest = 300,
                HorizontalOptions = LayoutOptions.Center
            };

            Title = "SVG via CSharp";
            Content = new ScrollView
            {
                Padding = new Thickness(8),
                Content = new StackLayout
                {
                    Children =
                    {
                        appStore,
                        coolMask,
                        tiger
                    }
                }
            };
        }
    }
}
