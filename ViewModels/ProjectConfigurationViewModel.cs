using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchemeWpf.Models;
using SchemeWpf.Navigation;
using SchemeWpf.Services;
using SchemeWpf.Tools;
using SchemeWpf.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SchemeWpf.ViewModels
{
    class ProjectConfigurationViewModel : ViewModelInternal
    {
        #region Ctor
        public ProjectConfigurationViewModel(LoadingViewModel loading, NavigationService navigationService,
            Repo repository, LoginResponseHandler responseHandler, MessageBoxViewModel messageBoxViewModel)
            : base(loading, navigationService, repository, responseHandler, messageBoxViewModel)
        {
            Sprints = new ObservableCollection<Sprint>()
            {
                new Sprint() { Name = "Some sprint" },
                new Sprint() { Name = "Other sprint" }
            };
            SomeUsers = new List<User>()
            {
                new User() { Name = "Zahid Abbasli" },
                new User() { Name = "Samir Mammadli" },
                new User() { Name = "Igor Zabolotin" },
                new User() { Name = "Ramil Aliyev" },
                new User() { Name = "Zakir Mammadli" },
                new User() { Name = "Samir Musayev" },
                new User() { Name = "Zaur Huseynov" }
            };
            Backlogs = new ObservableCollection<BackLog>();
            Users = new ObservableCollection<User>();
            AddAnotherCardIsVisible = true;
            UserListIsVisible = true;
        }
        #endregion

        #region Methods
        private void ClearAndExitUserSearch()
        {
            UserListIsVisible = true;
            SearchUserIsVisible = false;
            NewUserText = "";
        }
        #endregion

        #region Properties
        private ObservableCollection<Sprint> sprints;
        public ObservableCollection<Sprint> Sprints
        {
            get => sprints;
            set => Set(ref sprints, value);
        }

        private ObservableCollection<BackLog> backlogs;
        public ObservableCollection<BackLog> Backlogs
        {
            get => backlogs;
            set { Set(ref backlogs, value); }
        }

        public List<User> SomeUsers { get; set; }

        private ObservableCollection<User> users;
        public ObservableCollection<User> Users
        {
            get => users;
            set { Set(ref users, value); }
        }

        private ObservableCollection<User> findedUsers;
        public ObservableCollection<User> FindedUsers
        {
            get => findedUsers;
            set { Set(ref findedUsers, value); }
        }

        private bool addAnotherCardIsVisible;
        public bool AddAnotherCardIsVisible
        {
            get => addAnotherCardIsVisible;
            set => Set(ref addAnotherCardIsVisible, value);
        }

        private bool addCardIsVisible;
        public bool AddCardIsVisible
        {
            get => addCardIsVisible;
            set => Set(ref addCardIsVisible, value);
        }


        private bool userListIsVisible;
        public bool UserListIsVisible
        {
            get => userListIsVisible;
            set => Set(ref userListIsVisible, value);
        }

        private bool searchUserIsVisible;
        public bool SearchUserIsVisible
        {
            get => searchUserIsVisible;
            set => Set(ref searchUserIsVisible, value);
        }

        private string newCardText;
        public string NewCardText
        {
            get => newCardText;
            set => Set(ref newCardText, value);
        }

        private string newUserText;
        public string NewUserText
        {
            get => newUserText;
            set => Set(ref newUserText, value);
        }
        #endregion

        #region Commands
        private RelayCommand userSearchTextChanged;
        public RelayCommand UserSearchTextChanged
        {
            get
            {
                return userSearchTextChanged ?? (userSearchTextChanged = new RelayCommand(
                    () =>
                    {
                        if (string.IsNullOrWhiteSpace(NewUserText) || string.IsNullOrEmpty(NewUserText))
                        {
                            FindedUsers = null;
                            return;
                        }

                        List<User> matchingUsers = SomeUsers
                        .Where(userToCheck => userToCheck.Name
                        .ToUpper()
                        .Contains(NewUserText
                        .ToUpper()))
                        .ToList();

                        FindedUsers = new ObservableCollection<User>(matchingUsers);
                    }
                ));
            }
        }

        private RelayCommand addAnotherCardCommand;
        public RelayCommand AddAnotherCardCommand
        {
            get
            {
                return addAnotherCardCommand ?? (addAnotherCardCommand = new RelayCommand(
                    () =>
                    {
                        AddAnotherCardIsVisible = false;
                        AddCardIsVisible = true;
                    }
                ));
            }
        }

        private RelayCommand openUserSearchCommand;
        public RelayCommand OpenUserSearchCommand
        {
            get
            {
                return openUserSearchCommand ?? (openUserSearchCommand = new RelayCommand(
                    () =>
                    {
                        UserListIsVisible = false;
                        SearchUserIsVisible = true;
                    }
                ));
            }
        }

        private RelayCommand exitCardCommand;
        public RelayCommand ExitCardCommand
        {
            get
            {
                return exitCardCommand ?? (exitCardCommand = new RelayCommand(
                    () =>
                    {
                        AddAnotherCardIsVisible = true;
                        AddCardIsVisible = false;
                        NewCardText = "";
                    }
                ));
            }
        }

        private RelayCommand exitSearchUserCommand;
        public RelayCommand ExitSearchUserCommand
        {
            get
            {
                return exitSearchUserCommand ?? (exitSearchUserCommand = new RelayCommand(
                    () => ClearAndExitUserSearch()
                ));
            }
        }

        private RelayCommand addACardCommand;
        public RelayCommand AddACardCommand
        {
            get
            {
                return addACardCommand ?? (addACardCommand = new RelayCommand(
                    () =>
                    {
                        if (string.IsNullOrEmpty(NewCardText))
                            return;

                        AddAnotherCardIsVisible = true;
                        AddCardIsVisible = false;
                        Backlogs.Add(new BackLog() { Name = NewCardText });
                        NewCardText = "";
                    }
                ));
            }
        }

        private RelayCommand<User> selectedUserCommand;
        public RelayCommand<User> SelectedUserCommand
        {
            get
            {
                return selectedUserCommand ?? (selectedUserCommand = new RelayCommand<User>(
                    param =>
                    {
                        if (param != null)
                        {
                            if (Users.Contains(param))
                            {
                                MessageBoxWindow win2 = new MessageBoxWindow();
                                win2.ShowDialog();
                                //MessageBoxShow("User has already been added!");
                                return;
                            }

                            Users.Add(param);
                            ClearAndExitUserSearch();
                        }
                    }
                ));
            }
        }

        private RelayCommand<BackLog> deleteCard;
        public RelayCommand<BackLog> DeleteCard
        {
            get
            {
                return deleteCard ?? (deleteCard = new RelayCommand<BackLog>(
                    param =>
                    {
                        if (param != null)
                        {
                            Backlogs.Remove(param);
                        }
                    }
                ));
            }
        }

        private RelayCommand<User> deleteUser;
        public RelayCommand<User> DeleteUser
        {
            get
            {
                return deleteUser ?? (deleteUser = new RelayCommand<User>(
                    param =>
                    {
                        if (param != null)
                        {
                            Users.Remove(param);
                        }
                    }
                ));
            }
        }

        private RelayCommand scrollCommand;
        public RelayCommand ScrollCommand
        {
            get
            {
                return scrollCommand ?? (scrollCommand = new RelayCommand(
                    () =>
                    {
                        MessageBox.Show("sds");
                    }
                ));
            }
        }
        #endregion
    }
}
