using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using SchemeWpf.Navigation;
using SchemeWpf.Services;
using SchemeWpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchemeWpf.Tools
{
    class ViewModelBaseExtension : ViewModelBase
    {
        #region Constructor
        public ViewModelBaseExtension(LoadingViewModel loadingViewModel,
            INavigationService navigationService, Repo repository, IResponseHandler responseHandler, MessageBoxViewModel messageBoxViewModel)
        {
            LoadingViewModel = loadingViewModel;
            MessageBoxViewModel = messageBoxViewModel;
            NavigationService = navigationService;
            Repository = repository;
            ResponseHandler = responseHandler;
            WindowIsActive = true;

            Messenger.Default.Register<MessageBoxViewModel>(this, param => UpperWindowClose());
        }
        #endregion

        #region Commands
        private RelayCommand<VM> navigationCommand;
        public RelayCommand<VM> NavigationCommand
        {
            get
            {
                return navigationCommand ?? (navigationCommand = new RelayCommand<VM>(
                    param => NavigationService.NavigateTo(param)));
            }
        }
        #endregion

        #region Properties
        protected Repo Repository { get; set; }
        protected INavigationService NavigationService { get; set; }
        protected LoadingViewModel LoadingViewModel { get; set; }
        protected MessageBoxViewModel MessageBoxViewModel { get; set; }
        public IResponseHandler ResponseHandler { get; set; }

        private bool blurIsVisible;
        public bool BlurIsVisible
        {
            get => blurIsVisible;
            set { Set(ref blurIsVisible, value); }
        }

        private bool windowIsActive;
        public bool WindowIsActive
        {
            get => windowIsActive;
            set { Set(ref windowIsActive, value); }
        }

        private object upperViewModel;
        public object UpperViewModel
        {
            get => upperViewModel;
            set => Set(ref upperViewModel, value);
        }
        #endregion

        #region Methods
        protected void LoadingStart()
        {
            UpperWindowStyle(true, LoadingViewModel);
        }

        protected void UpperWindowClose()
        {
            UpperWindowStyle(false, null);
        }

        protected void MessageBoxShow(string message)
        {
            MessageBoxViewModel.Message = message;
            UpperWindowStyle(true, MessageBoxViewModel);
        }


        private void UpperWindowStyle(bool state, object viewModel)
        {
            if (state == true)
            {
                BlurIsVisible = true;
                WindowIsActive = false;
                UpperViewModel = viewModel;
                return;
            }
            BlurIsVisible = false;
            WindowIsActive = true;
            UpperViewModel = null;
        }
        #endregion
    }
}
