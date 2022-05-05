﻿using FluentHub.Services;
using FluentHub.ViewModels.Repositories.Projects;
using Microsoft.Extensions.DependencyInjection;
using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

namespace FluentHub.Views.Repositories.Projects
{
    public sealed partial class ProjectPage : Page
    {
        public ProjectPage()
        {
            this.InitializeComponent();

            var provider = App.Current.Services;
            ViewModel = provider.GetRequiredService<ProjectViewModel>();
            navigationService = provider.GetRequiredService<INavigationService>();
        }

        private readonly INavigationService navigationService;
        public ProjectViewModel ViewModel { get; }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var nameWithOwner = e.Parameter as string;
            var nameAndOwner = nameWithOwner.Split("/");

            var currentItem = navigationService.TabView.SelectedItem.NavigationHistory.CurrentItem;
            currentItem.Header = "PullRequests";
            currentItem.Description = "Viewer's pull requests";
            currentItem.Url = $"https://github.com/{nameAndOwner[0]}/{nameAndOwner[1]}/pulls";
            currentItem.Icon = new Microsoft.UI.Xaml.Controls.ImageIconSource
            {
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Icons/PullRequests.png"))
            };

            //var command = ViewModel.RefreshPullRequestsPageCommand;
            //if (command.CanExecute(nameWithOwner))
            //    command.Execute(nameWithOwner);
        }
    }
}
