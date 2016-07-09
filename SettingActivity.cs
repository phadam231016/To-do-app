using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TaskAndContact
{
    [Activity(Label = "SettingActivity")]
    public class SettingActivity : Activity
    {
        private Button _mainButton;
        private Button _histoyButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Setting);

            _mainButton = FindViewById<Button>(Resource.Id.buttonMain);
            _mainButton.Click += _mainButton_Click;
            _histoyButton = FindViewById<Button>(Resource.Id.buttonHistory);
            _histoyButton.Click += _histoyButton_Click;
        }

        private void _histoyButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(HistoryActivity));
            this.StartActivity(intent);
        }

        private void _mainButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
        }
    }
}