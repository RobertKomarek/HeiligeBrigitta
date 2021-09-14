using HeiligeBrigitta.ViewModels;
using HeiligeBrigitta.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HeiligeBrigitta
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(InfoPage), typeof(InfoPage));
            Routing.RegisterRoute(nameof(ImpressumPage), typeof(ImpressumPage));
            Routing.RegisterRoute(nameof(GebetePage), typeof(GebetePage));
        }

    }
}
