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
    class ForgotPasswordViewModel : ViewModelBaseExtension
    {
        public ForgotPasswordViewModel(LoadingViewModel loading, NavigationService navigationService,
            Repo repository, LoginResponseHandler responseHandler, MessageBoxViewModel messageBoxViewModel)
            : base(loading, navigationService, repository, responseHandler, messageBoxViewModel)
        {
            Messenger.Default.Register<ChangePasswordForm>(this, param => Form = param);
        }

        public ChangePasswordForm Form { get; set; }

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

        private string code;
        public string Code
        {
            get => code;
            set { Set(ref code, value); }
        }

        private RelayCommand resetPasswordCommand;
        public RelayCommand ResetPasswordCommand
        {
            get
            {
                return resetPasswordCommand ?? (resetPasswordCommand = new RelayCommand(
                    async () =>
                    {
                        LoadingStart();
                        try
                        {
                            if (Password == ConfirmPassword)
                            {
                                await Repository.ResetPassword(
                                new ChangePasswordForm()
                                {
                                    Email = Form.Email,
                                    Code = Convert.ToInt32(Code),
                                    Password = Password,
                                    ConfirmPassword = ConfirmPassword
                                });

                                NavigationService.NavigateTo(VM.LoginViewModel);
                            }
                            else
                            {
                                throw new ArgumentException("Confirm password does not match!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBoxShow(ex.Message);
                        }
                        finally
                        {
                            UpperWindowClose();
                        }
                    }
                ));
            }
        }
    }
}
