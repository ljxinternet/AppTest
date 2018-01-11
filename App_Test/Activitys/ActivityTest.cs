using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Net.Wifi;
using Android.Views;
using Android.Widget;

namespace App_Test.Activitys
{
    [Activity(Label = "测试界面")]
    public class ActivityTest : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //跟换主题
            this.SetTheme(Android.Resource.Style.ThemeLight);

            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layoutTest);
        }
    }
}