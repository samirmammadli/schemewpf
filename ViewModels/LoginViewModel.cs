using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using SchemeWpf.Navigation;
using SchemeWpf.Services;
using SchemeWpf.Tools;
using SchemeWpf.Tools.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SchemeWpf.ViewModels
{
    class LoginViewModel : ViewModelBaseExtension
    {
        #region Constructor
        public LoginViewModel(LoadingViewModel loading, NavigationService navigationService,
            Repo repository, LoginResponseHandler responseHandler, MessageBoxViewModel messageBoxViewModel)
            : base(loading, navigationService, repository, responseHandler, messageBoxViewModel) { }
        #endregion

        #region Properties
        private string email;
        public string Email
        {
            get => email;
            set { Set(ref email, value); }
        }

        private string password;
        public string Password
        {
            get => password;
            set { Set(ref password, value); }
        }
        #endregion

        #region Commands
        private RelayCommand loginCommand;
        public RelayCommand LoginCommand
        {
            get
            {
                return loginCommand ?? (loginCommand = new RelayCommand(
                    async () =>
                    {
                        try
                        {
                            LoadingStart();
                            var response = await Repository.Login(Email, Password);
                            ResponseHandler.Handle(NavigationService, response,
                                new CodeInputForm() { Email = Email });
                            UpperWindowClose();
                        }
                        catch (Exception ex)
                        {
                            MessageBoxShow(ex.Message);
                            NavigationService.NavigateTo(VM.LoginViewModel);
                        }
                    }
                ));
            }
        } 
        #endregion
    }
}
