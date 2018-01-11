using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using App_Test.Activitys;

namespace App_Test
{
    [Activity(Label = "测试APP", MainLauncher = true)]
    public class MainActivity : BaseActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //跟换主题
            this.SetTheme(Android.Resource.Style.ThemeLight);
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            //
            var btnTest = FindViewById<Button>(Resource.Id.BtnTest);
            btnTest.Click += (sender, e) =>
            {
                StartActivity(new Intent(this,typeof(Activitys.ActivityTest)));
            };

        }
    }
}

