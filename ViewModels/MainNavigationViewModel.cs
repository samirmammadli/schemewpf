using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace SchemeWpf.ViewModels
{
    class MainNavigationViewModel : ViewModelInternal
    {
        public NavigationService NavigationServiceExternal { get; set; }

        private object currentViewModel;
        public object CurrentViewModel
        {
            get => currentViewModel;
            set => Set(ref currentViewModel, value);
        }

        private int borderWidth;
        public int BorderWidth
        {
            get => borderWidth;
            set => Set(ref borderWidth, value);
        }

        private string countOfNotifications;
        public string CountOfNotifications
        {
            get => countOfNotifications;
            set => Set(ref countOfNotifications, value);
        }

        public MainNavigationViewModel(LoadingViewModel loading, NavigationService navigationService,
            NavigationServiceInternal navigationServiceInternal,
            Repo repository, LoginResponseHandler responseHandler, MessageBoxViewModel messageBoxViewModel)
            : base(loading, navigationServiceInternal, repository, responseHandler, messageBoxViewModel)
        {
            NavigationServiceExternal = navigationService;

            Messenger.Default.Register<ViewModelInternal>(this,
                CurrentViewScroller);

            Messenger.Default.Register<ObservableCollection<Notification>>(this,
                param => 
                {
                    try
                    {
                        CountOfNotifications = param.Count.ToString();
                        int count = CountOfNotifications.Length;

                     switch (count)
                        {
                            case 1:
                                BorderWidth = 17;
                                break;
                            case 2:
                                BorderWidth = 20;
                                break;
                            case 3:
                                BorderWidth = 30;
                                break;
                            case 4:
                                BorderWidth = 35;
                                CountOfNotifications = "999" + "+";
                                break;
                            default:
                                BorderWidth = 17;
                                break;
                        }
                    }
                    catch (Exception) { throw; }});
        }

        private void CurrentViewScroller(ViewModelInternal viewModelBaseInternal)
        {
            if (viewModelBaseInternal is ProjectsListViewModel)
                Messenger.Default.Send("ChangeButtonState");
            CurrentViewModel = viewModelBaseInternal;    
        }

        private RelayCommand signOut;
        public RelayCommand SignOut
        {
            get
            {
                return signOut ?? (signOut = new RelayCommand(
                    () =>{ NavigationServiceExternal.NavigateTo(VM.LoginViewModel);}));
            }
        }
    }
}
