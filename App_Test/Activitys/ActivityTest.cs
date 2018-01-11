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
    //[IntentFilter]
    public class ActivityTest : BaseActivity
    {
        Button btnTest;
        TextView textView;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            //跟换主题
            this.SetTheme(Android.Resource.Style.ThemeLight);

            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layoutTest);


            //
            btnTest = FindViewById<Button>(Resource.Id.button1);
            textView = FindViewById<TextView>(Resource.Id.textView1);


            btnTest.Click += BtnTest_Click;


        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            textView.Text = "因此笔者建议iPhone 7及其以上的手机最好使用iOS 11系统，随着版本的更新目前已经趋于稳定，而iPhone 6S和iPhone 6则可以考虑选择使用iOS 10.3.3。至于iPhone 6以下的手机，看自己的需求随意选择吧，毕竟大部分都是备用机，选择低一些的版本不影响基础功能就好。不过目前并没有办法继续降级，通道已经关闭，不过可以继续等一等，万一呢...";

            //throw new NotImplementedException();
        }
    }
}