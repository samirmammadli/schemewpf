using GalaSoft.MvvmLight.Messaging;
using SchemeWpf.Models;
using SchemeWpf.Navigation;
using SchemeWpf.Services;
using SchemeWpf.Tools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SchemeWpf.ViewModels
{
    class NotificationsViewModel : ViewModelInternal
    {
        public NotificationsViewModel(LoadingViewModel loading, NavigationService navigationService,
            Repo repository, LoginResponseHandler responseHandler, MessageBoxViewModel messageBoxViewModel)
            : base(loading, navigationService, repository, responseHandler, messageBoxViewModel)
        {
            Messenger.Default.Register<ObservableCollection<Notification>>(this, 
                param => Notifications = param);
        }

        private ObservableCollection<Notification> notifications;
        public ObservableCollection<Notification> Notifications
        {
            get => notifications;
            set => Set(ref notifications, value);
        }
    }
}
