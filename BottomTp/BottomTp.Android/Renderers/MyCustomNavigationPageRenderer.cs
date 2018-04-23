﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using BottomTp.CustomControl;
using BottomTp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(MyNavigationPage), typeof(MyCustomNavigationPageRenderer))]
namespace BottomTp.Droid.Renderers
{
    class MyCustomNavigationPageRenderer : NavigationPageRenderer
    {
        public MyCustomNavigationPageRenderer(Context c) : base(c)
        { }

        protected override Task<bool> OnPopToRootAsync(Page page, bool animated)
        {
            return base.OnPopToRootAsync(page, false);
        }

        protected override Task<bool> OnPopViewAsync(Page page, bool animated)
        {
            return base.OnPopViewAsync(page, false);
        }

        protected override Task<bool> OnPushAsync(Page view, bool animated)
        {
            return base.OnPushAsync(view, false);
        }

    }
}