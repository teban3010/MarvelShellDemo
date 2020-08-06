using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MarvelShellDemo
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            SetNavBarIsVisible(this, false);
        }
    }
}
