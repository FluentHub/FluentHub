﻿using FluentHub.Octokit.Queries.Users;
using FluentHub.ViewModels.UserControls.ButtonBlocks;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.ObjectModel;
using System.Threading;

namespace FluentHub.ViewModels.Home
{
    public class UserHomeViewModel : ObservableObject
    {
        #region constructor
        public UserHomeViewModel(IMessenger messenger = null, ILogger logger = null)
        {
            _messenger = messenger;
            _logger = logger;

            _userRepositories = new();
            UserRepositories = new(_userRepositories);

            _userNotifications = new();
            UserNotifications = new(_userNotifications);

            LoadHomeContentsCommand = new AsyncRelayCommand(LoadHomeContentsAsync);
        }
        #endregion

        #region fields and properties
        private readonly IMessenger _messenger;
        private readonly ILogger _logger;

        private readonly ObservableCollection<Repository> _userRepositories;
        public ReadOnlyObservableCollection<Repository> UserRepositories { get; }

        private readonly ObservableCollection<Notification> _userNotifications;
        public ReadOnlyObservableCollection<Notification> UserNotifications { get; }

        public IAsyncRelayCommand LoadHomeContentsCommand { get; }
        #endregion

        #region methods
        private async Task LoadHomeContentsAsync(CancellationToken token)
        {
            try
            {
                RepositoryQueries repositoryQueries = new();
                var repositoryResponse = await repositoryQueries.GetAllAsync(App.Settings.SignedInUserName);

                foreach (var item in repositoryResponse) _userRepositories.Add(item);

                NotificationQueries notificationQueries = new();
                OctokitOriginal.ApiOptions options = new()
                {
                    PageCount = 1,
                    PageSize = 3,
                    StartPage = 1
                };

                var notificationResponse = await notificationQueries.GetAllAsync(options);

                foreach (var item in notificationResponse) _userNotifications.Add(item);
            }
            catch (OperationCanceledException) { }
            catch (Exception ex)
            {
                _logger?.Error("LoadHomeContentsAsync", ex);
                if (_messenger != null)
                {
                    UserNotificationMessage notification = new("Something went wrong", ex.Message, UserNotificationType.Error);
                    _messenger.Send(notification);
                }
                throw;
            }
        }
        #endregion
    }
}