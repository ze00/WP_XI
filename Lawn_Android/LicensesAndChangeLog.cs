using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lawn_Android
{
    [Activity(Label = "LicensesAndChangeLog")]
    public class LicensesAndChangeLog : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LincensesAndChangeLog);
            FindViewById<TextView>(Resource.Id.changelog).SetText(new StreamReader(Assets.Open("CHANGELOG.txt")).ReadToEnd(), TextView.BufferType.Normal);
            // Create your application here
        }
    }
}