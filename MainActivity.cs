using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TaskAndContact
{
    [Activity(Label = "TaskAndContact", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<string> _mListItem;
        private int _numberOfItem;
        private ListView _mListView;

        private Button _mAddProjectButton;
        private Button _mHistoryButton;
        private Button _settingButton;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            _mAddProjectButton = FindViewById<Button>(Resource.Id.buttonAddProject);
            _mAddProjectButton.Click += _mAddProjectButton_Click;

            _mHistoryButton = FindViewById<Button>(Resource.Id.buttonHistory);
            _mHistoryButton.Click += _mHistoryButton_Click;

            _settingButton = FindViewById<Button>(Resource.Id.buttonSetting);
            _settingButton.Click += _settingButton_Click;

            _numberOfItem = 20;

            _mListItem = new List<string>();
            for (int i = 0; i < _numberOfItem; i++)
            {
                _mListItem.Add("Project" + i + 1);
            }

            _mListView = FindViewById<ListView>(Resource.Id.listViewProject);

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, _mListItem);

            _mListView.Adapter = adapter;
        }

        private void _settingButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(SettingActivity));
            this.StartActivity(intent);
        }

        private void _mHistoryButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(HistoryActivity));
            this.StartActivity(intent);
        }

        private void _mAddProjectButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(AddProjectActivity));
            this.StartActivity(intent);
        }
    }
}

