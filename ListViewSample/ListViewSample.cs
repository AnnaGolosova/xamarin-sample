using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace ListViewSample
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new MyMainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=328b9dfd-16ee-4084-9f0c-b16a0ff4b99d;" +
                            "ios={bb37f15a-4054-48a1-b6c7-1478c830fc4d}",
                typeof(Analytics), typeof(Crashes));
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

