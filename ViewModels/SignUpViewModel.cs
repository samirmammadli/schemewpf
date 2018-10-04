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
    class SignUpViewModel : ViewModelBaseExtension
    {
        #region Constructor
        public SignUpViewModel(LoadingViewModel loading, NavigationService navigationService,
            Repo repository, SignUpResponseHandler responseHandler, MessageBoxViewModel messageBoxViewModel)
            : base(loading, navigationService, repository, responseHandler, messageBoxViewModel) { }
        #endregion

        #region Properties
        private string name;
        public string Name
        {
            get => name;
            set { Set(ref name, value); }
        }

        private string surname;
        public string Surname
        {
            get => surname;
            set { Set(ref surname, value); }
        }

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

        private string confirmPassword;
        public string ConfirmPassword
        {
            get => confirmPassword;
            set { Set(ref confirmPassword, value); }
        }
        #endregion

        #region Commands
        private RelayCommand signUp;
        public RelayCommand SignUp
        {
            get
            {
                return signUp ?? (signUp = new RelayCommand(
                   async () =>
                    {
                        try
                        {
                            LoadingStart();
                            var response = await Repository.Register(new
                            {
                                email = Email,
                                password = Password,
                                confirmPassword = ConfirmPassword,
                                name = Name,
                                surname = Name
                            });

                            ResponseHandler.Handle(NavigationService, response,
                                new CodeInputForm() { Email = Email, Code = 0 });
                            UpperWindowClose();
                        }
                        catch (Exception ex)
                        {
                            MessageBoxShow(ex.Message);
                            NavigationService.NavigateTo(VM.SignUpViewModel);
                        }
                    }
                ));
            }
        } 
        #endregion
    }
}
