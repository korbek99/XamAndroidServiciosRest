using Android.App;
using Android.Widget;
using Android.OS;
using System;
using XamAndroidServiciosRest.REST;
using System.Collections.Generic;

namespace XamAndroidServiciosRest
{
    [Activity(Label = "XamAndroidServiciosRest", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button button = FindViewById<Button>(Resource.Id.myButton);
            button.Click += Send_Click;
        }
        private async void Send_Click(object sender, EventArgs e)
        {
          var list = await  "http://jsonplaceholder.typicode.com/users".GetRequest<List<Users>>();
            if (default(List<Users>) != list)
            {
                foreach (var user in list)
                {
                    System.Diagnostics.Debug.WriteLine(user.name);
                }
                
            }
        }
    }
}

