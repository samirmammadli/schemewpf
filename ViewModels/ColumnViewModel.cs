using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using SchemeWpf.Models;
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
    class ColumnViewModel : ObservableObject, IViewModelsState
    {
        public ColumnViewModel()
        {
            AddAnotherCardIsVisible = true;
            
        }

        public string LastState { get; set; }

        

        private RelayCommand<CardViewModel> _changeState;
        public RelayCommand<CardViewModel> ChangeState
        {
            get
            {
                return _changeState ?? (_changeState = new RelayCommand<CardViewModel>(
                    param =>
                    {
                        if (param != null)
                        {
                            Messenger.Default.Send(param as IViewModelsState);
                            
                            param.IsEnabled = !param.IsEnabled;
                            if (param.ImageSource == "/Images/ok.png")
                                param.ImageSource = "/Images/edit.png";
                            else
                                param.ImageSource = "/Images/ok.png";

                            if (string.IsNullOrWhiteSpace(param.Name))
                            {
                                param.Name = LastState;
                                return;
                            }
                            LastState = param.Name;
                        }
                    }
                ));
            }
        }

        private RelayCommand test;
        public RelayCommand Test
        {
            get
            {
                return test ?? (test = new RelayCommand(
                    () =>
                    {
                        Task.Run(() => Messenger.Default.Send(true));
                    }
                ));
            }
        }

        private RelayCommand<ColumnViewModel> addAnotherCardCommand;
        public RelayCommand<ColumnViewModel> AddAnotherCardCommand
        {
            get
            {
                return addAnotherCardCommand ?? (addAnotherCardCommand = new RelayCommand<ColumnViewModel>(
                    param =>
                    {
                        if (param != null)
                        {
                            Messenger.Default.Send(param as IViewModelsState);
                            param.AddAnotherCardIsVisible = false;
                            param.AddCardIsVisible = true;
                        }
                    }
                ));
            }
        }

        private RelayCommand<ColumnViewModel> addACardCommand;
        public RelayCommand<ColumnViewModel> AddACardCommand
        {
            get
            {
                return addACardCommand ?? (addACardCommand = new RelayCommand<ColumnViewModel>(
                    param =>
                    {
                        if (param != null)
                        {
                            if (string.IsNullOrWhiteSpace(NewCardText))
                                return;

                            param.AddAnotherCardIsVisible = true;
                            param.AddCardIsVisible = false;
                            param.Cards.Add(new CardViewModel() { Name = NewCardText });
                            NewCardText = "";
                        }
                    }
                ));
            }
        }

        private RelayCommand<ColumnViewModel> exitCardCommand;
        public RelayCommand<ColumnViewModel> ExitCardCommand
        {
            get
            {
                return exitCardCommand ?? (exitCardCommand = new RelayCommand<ColumnViewModel>(
                    param =>
                    {
                        if (param != null)
                        {
                            param.AddAnotherCardIsVisible = true;
                            param.AddCardIsVisible = false;
                            NewCardText = "";
                        }
                    }
                ));
            }
        }

        private string name;
        public string Name
        {
            get => name;
            set => Set(ref name, value);
        }

        private string newCardText;
        public string NewCardText
        {
            get => newCardText;
            set => Set(ref newCardText, value);
        }

        private ObservableCollection<CardViewModel> _cards;
        public ObservableCollection<CardViewModel> Cards
        {
            get => _cards;
            set => Set(ref _cards, value);
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

        public void ChangeLastState()
        {
            AddAnotherCardIsVisible = true;
            AddCardIsVisible = false;
        }
    }
}


