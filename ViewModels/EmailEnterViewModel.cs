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
    class EmailEnterViewModel : ViewModelBaseExtension
    {
        public EmailEnterViewModel(LoadingViewModel loading, NavigationService navigationService,
            Repo repository, LoginResponseHandler responseHandler, MessageBoxViewModel messageBoxViewModel)
            : base(loading, navigationService, repository, responseHandler, messageBoxViewModel)
        {

        }

        private string email;
        public string Email
        {
            get => email;
            set { Set(ref email, value); }
        }

        private RelayCommand sendCodeCommand;
        public RelayCommand SendCodeCommand
        {
            get
            {
                return sendCodeCommand ?? (sendCodeCommand = new RelayCommand(
                    async () =>
                    {
                        LoadingStart();
                        try
                        {
                            await Repository.ForgotPassword(Email);
                            Messenger.Default.Send(new ChangePasswordForm() { Email = Email });
                            NavigationService.NavigateTo(VM.ForgotPasswordViewModel);
                            UpperWindowClose();
                        }
                        catch (Exception)
                        {
                            MessageBoxShow("ne korrektno");
                        }
                    }
                ));
            }
        }
    }
}
