using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
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
    class BoardViewModel : ViewModelInternal
    {
        #region Ctor
        public BoardViewModel(LoadingViewModel loading, NavigationServiceInternal navigationService, 
            Repo repository, LoginResponseHandler responseHandler, MessageBoxViewModel messageBoxViewModel)
            : base(loading, navigationService, repository, responseHandler, messageBoxViewModel) 
        {
            Messenger.Default.Register<IViewModelsState>(this, param => 
            {
                if (LastDisabled != null && LastDisabled != param)
                    LastDisabled.ChangeLastState(); LastDisabled = param;
                LastDisabled = param;
            });

            Messenger.Default.Register<ObservableCollection<ColumnViewModel>>
                (this, param => BoardLists = param);

            Messenger.Default.Register<MyProject>
                (this, param => CurrentProject = param);

            Messenger.Default.Register<string>(this, param => 
            ImageSource = "/Images/expand.png");

            Messenger.Default.Register<bool>(this, param => BackgroundColorStart = param);

            AddAnotherListButton = true;
            ImageSource = "/Images/expand.png";

            BackgroundColor = false;
            BackgroundColorStart = false;
        }
        #endregion

        #region Properties
        public IViewModelsState LastDisabled { get; set; }

        private ObservableCollection<ColumnViewModel> boardLists;
        public ObservableCollection<ColumnViewModel> BoardLists
        {
            get => boardLists;
            set { Set(ref boardLists, value); }
        }

        private string newListText;
        public string NewListText
        {
            get => newListText;
            set { Set(ref newListText, value); }
        }

        private bool backgroundColor;
        public bool BackgroundColor
        {
            get => backgroundColor;
            set { Set(ref backgroundColor, value); }
        }

        private bool backgroundColorStart;
        public bool BackgroundColorStart
        {
            get => backgroundColorStart;
            set { Set(ref backgroundColorStart, value); }
        }

        private bool borderIsVisible;
        public bool BorderIsVisible
        {
            get => borderIsVisible;
            set { Set(ref borderIsVisible, value); }
        }

        private bool addAnotherListButton;
        public bool AddAnotherListButton
        {
            get => addAnotherListButton;
            set { Set(ref addAnotherListButton, value); }
        }

        private string imageSource;
        public string ImageSource
        {
            get => imageSource;
            set => Set(ref imageSource, value);
        }

        private MyProject currentProject;
        public MyProject CurrentProject
        {
            get => currentProject;
            set => Set(ref currentProject, value);
        }
        #endregion

        #region Commands
        private RelayCommand addAnotherList;
        public RelayCommand AddAnotherList
        {
            get
            {
                return addAnotherList ?? (addAnotherList = new RelayCommand(
                    () =>
                    {
                        AddAnotherListButton = false;
                        BorderIsVisible = true;
                    }
                ));
            }
        }

        private RelayCommand addList;
        public RelayCommand AddList
        {
            get
            {
                return addList ?? (addList = new RelayCommand(
                    () =>
                    {
                        if (string.IsNullOrWhiteSpace(NewListText))
                            return;

                        AddAnotherListButton = true;
                        BorderIsVisible = false;
                        BoardLists.Add(new ColumnViewModel()
                        {
                            Name = NewListText,
                            Cards = new ObservableCollection<CardViewModel>()
                        });
                        NewListText = "";
                    }
                ));
            }
        }

        private RelayCommand exitListCommand;
        public RelayCommand ExitListCommand
        {
            get
            {
                return exitListCommand ?? (exitListCommand = new RelayCommand(
                    () =>
                    {
                        AddAnotherListButton = true;
                        BorderIsVisible = false;
                    }
                ));
            }
        }

        private RelayCommand maxMinProjectCommand;
        public RelayCommand MaxMinProjectCommand
        {
            get
            {
                return maxMinProjectCommand ?? (maxMinProjectCommand = new RelayCommand(
                    () =>
                    {
                        if (ImageSource == "/Images/expand.png")
                        {
                            ImageSource = "/Images/out.png";
                            Messenger.Default.Send<ViewModelInternal>(this);
                        }
                        else
                        {
                            ImageSource = "/Images/expand.png";
                            NavigationService.NavigateTo(VM.ProjectsListViewModel);
                        }
                    }));
            }
        }

        private RelayCommand enter;
        public RelayCommand Enter
        {
            get
            {
                return Enter ?? (enter = new RelayCommand(
                   async () =>
                    {
                        await Task.Run(() =>
                        {
                            BackgroundColor = true;
                            BackgroundColorStart = false;
                        });
                    }
                ));
            }
        }

        private RelayCommand exit;
        public RelayCommand Exit
        {
            get
            {
                return exit ?? (exit = new RelayCommand(
                   async () =>
                   {
                       await Task.Run(() =>
                       {
                           BackgroundColor = false;
                           BackgroundColorStart = true;
                       });
                   }
                ));
            }
        }
        #endregion
    }
}
