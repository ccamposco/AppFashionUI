﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFashionUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.PopularFashionPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
