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
using System.Threading.Tasks;
using System.Windows;

namespace SchemeWpf.ViewModels
{
    class ProjectsListViewModel : ViewModelInternal
    {
        public ProjectsListViewModel(LoadingViewModel loadingViewModel,
            NavigationServiceInternal InternalNavigationService, Repo repository, 
            LoginResponseHandler responseHandler, BoardViewModel boardViewModel, MessageBoxViewModel messageBoxViewModel)
            : base(loadingViewModel, InternalNavigationService, repository, responseHandler, messageBoxViewModel)
        {
            #region MockData
            var projectsFromDataBase = new ObservableCollection<Project>()
            {
                new Project { Name = "Some project", BoardLists = new List<BoardList>()
                {
                    new BoardList()
                    { Name = "ToDo" , Cards = new List<Card>()
                        {
                            new Card() {Name = "Create database"},
                            new Card() {Name = "adasdasd"},
                            new Card() {Name = "asdasdasdasdasdasd database"},
                            new Card() {Name = "Creaasdasdasd asd asd asd asdasdasd asdasdas te database"},
                        }
                    },
                    new BoardList()
                    { Name = "Doing" , Cards = new List<Card>()
                        {
                            new Card() {Name = "adasdasd"},
                            new Card() {Name = "asdasd asdasad sdasadasdas dasd aadasdas"},
                            new Card() {Name = "Creaasdasdasd asd asd asd asda"},
                        }
                    },
                    new BoardList() { Name = "Done" ,  Cards = new List<Card>() }
                },
                Notifications = new List<Notification>()
                {
                    new Notification() { Name = "sgfsd" },
                    new Notification() { Name = "sdssdfs dfsdfsdf" },
                }},
                new Project { Name = "Another", BoardLists = new List<BoardList>()
                {
                    new BoardList()
                    { Name = "ToDo" , Cards = new List<Card>()
                        {
                            new Card() {Name = "Creadsadasdasnda sdasd  asd asd asd a sdasd asdasdasd ate database"},
                            new Card() {Name = "adasasd asd asd asdasddasd"},
                            new Card() {Name = "asdasdasdasdasdasd database"},
                        }
                    },
                    new BoardList() { Name = "Doing" , Cards = new List<Card>() },
                    new BoardList() { Name = "Done" ,  Cards = new List<Card>() }
                } , Notifications = new List<Notification>()
                {
                    new Notification() { Name = "sgfs  ssdd" },
                    new Notification() { Name = "sdsssd fsdf sdaaaaa aaa" },
                    new Notification() { Name = "sds sdfs dfsdf sdf" }
                }},
                new Project { Name = "Project", BoardLists = new List<BoardList>()
                {
                    new BoardList()
                    { Name = "ToDo" , Cards = new List<Card>()
                        {
                            new Card() {Name = "Creasasda sdnas d as d asd asate database"},
                            new Card() {Name = "adaasd as das d assdasd"},
                            new Card() {Name = "asdasasdasd asd asd as d asd as d asd asd as d asd asd asd as d s s s s s ssssdasdasdasdasd database"},
                            new Card() {Name = "Creaasdasdasd asd asd asd asdasdasd asdasdas te database"},
                            new Card() {Name = "Create database"},
                            new Card() {Name = "adasdasd"},
                            new Card() {Name = "asdasdasdasdasdasd database"},
                            new Card() {Name = "Creaasdasdasd asd asd asd asdasdasd asdasdas te database"},
                        }
                    },
                    new BoardList() { Name = "Doing" , Cards = new List<Card>() },
                    new BoardList() { Name = "Done" ,  Cards = new List<Card>() }
                } , Notifications = new List<Notification>()},
                new Project(){ Name = "sdfsdf" , BoardLists = new List<BoardList>(), Notifications = new List<Notification>()},
                new Project(){ Name = "sdfsdf" , BoardLists = new List<BoardList>(), Notifications = new List<Notification>()},
                new Project(){ Name = "sdfsdf" , BoardLists = new List<BoardList>(), Notifications = new List<Notification>()},
                new Project(){ Name = "sdfsdf" , BoardLists = new List<BoardList>(), Notifications = new List<Notification>()}

            }; 
            #endregion

            CurrentViewModel = boardViewModel;
            Projects = new ObservableCollection<MyProject>();

            foreach (var item in projectsFromDataBase)
            {
                Projects.Add(Converter(item));
            } 

            for (int i = 0; i < 1000; i++)
            {
                Projects
                .FirstOrDefault()
                .Notifications.Add(new Notification() { Name = "sgfsd" });
            }

            SetProject(Projects.FirstOrDefault());
        }

        private MyProject Converter(Project project)
        {
            MyProject myProject = new MyProject();
            myProject.BoardLists = new ObservableCollection<ColumnViewModel>();
            myProject.Name = project.Name;
            foreach (var item in project.BoardLists)
            {
                ColumnViewModel columnVM = new ColumnViewModel();
                columnVM.Name = item.Name;
                columnVM.Cards = new ObservableCollection<CardViewModel>();
                foreach (var card in item.Cards)
                {
                    columnVM.Cards.Add(new CardViewModel() { Name = card.Name });
                }
                myProject.BoardLists.Add(columnVM);
            }

            return myProject;
        }

        private ObservableCollection<MyProject> projects;
        public ObservableCollection<MyProject> Projects  
        {
            get => projects;
            set => Set(ref projects, value);
        }

        private object currentViewModel;
        public object CurrentViewModel
        {
            get => currentViewModel;
            set => Set(ref currentViewModel, value);
        }

        private object currentProjectIndex;
        public object CurrentProjectIndex
        {
            get => currentProjectIndex;
            set => Set(ref currentProjectIndex, value);
        }

        private RelayCommand<MyProject> selectedProjectCommand;
        public RelayCommand<MyProject> SelectedProjectCommand
        {
            get
            {
                return selectedProjectCommand ?? (selectedProjectCommand = new RelayCommand<MyProject>(
                    param =>
                    {
                        if (param != null)
                        {
                            SetProject(param);
                        }
                    }
                ));
            }
        }

        public void SetProject(MyProject project)
        {
            (CurrentViewModel as BoardViewModel).BoardLists = project.BoardLists;
            CurrentProjectIndex = Projects.IndexOf(Projects.Where(p => p == project).FirstOrDefault());
            Messenger.Default.Send(project.Notifications);
            Messenger.Default.Send(project);
        }

        private RelayCommand addNewProjectCommand;
        public RelayCommand AddNewProjectCommand
        {
            get
            {
                return addNewProjectCommand ?? (addNewProjectCommand = new RelayCommand(
                    () => NavigationService.NavigateTo(VM.ProjectConfigurationView)));
            }
        }
    }
}


