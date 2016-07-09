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
    [Activity(Label = "AddProjectActivity")]
    public class AddProjectActivity : Activity
    {
        private Button _mainButton;
        private Button _historyButton;
        private Button _settingButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.AddProject);

            _mainButton = FindViewById<Button>(Resource.Id.buttonMain);
            _mainButton.Click += _mainButton_Click;
            _historyButton = FindViewById<Button>(Resource.Id.buttonHistory);
            _historyButton.Click += _historyButton_Click;
            _settingButton = FindViewById<Button>(Resource.Id.buttonSetting);
            _settingButton.Click += _settingButton_Click;
        }

        private void _settingButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(SettingActivity));
            this.StartActivity(intent);
        }

        private void _historyButton_Click(object sender, EventArgs e)
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