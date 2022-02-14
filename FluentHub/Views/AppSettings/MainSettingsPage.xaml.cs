﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace FluentHub.Views.AppSettings
{
    public sealed partial class MainSettingsPage : Page
    {
        public MainSettingsPage()
        {
            this.InitializeComponent();
        }

        private void SettingsNavView_SelectionChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            string tag = args.SelectedItemContainer.Tag.ToString();

            switch (tag)
            {
                case "Appearance":
                    SettingsContentFrame.Navigate(typeof(AppearancePage));
                    NavViewFrameTitleTextBlock.Text = "Appearance";
                    break;
                case "About":
                    SettingsContentFrame.Navigate(typeof(AboutPage));
                    NavViewFrameTitleTextBlock.Text = "About";
                    break;
                case "Account":
                    //SettingsContentFrame.Navigate(typeof(AccountPage));
                    NavViewFrameTitleTextBlock.Text = "Account";
                    break;
                case "TextEditor":
                    //SettingsContentFrame.Navigate(typeof(TextEditorPage));
                    NavViewFrameTitleTextBlock.Text = "Text editor";
                    break;
            }

        }
    }
}
