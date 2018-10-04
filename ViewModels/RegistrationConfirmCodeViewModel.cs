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
    class RegistrationConfirmCodeViewModel : ViewModelBaseExtension
    {
        public CodeInputForm Form { get; set; }

        public RegistrationConfirmCodeViewModel(LoadingViewModel loading,
            NavigationService navigationService, Repo repository, 
            LoginResponseHandler responseHandler, MessageBoxViewModel messageBoxViewModel)
            :base(loading, navigationService, repository, responseHandler, messageBoxViewModel)
            => Messenger.Default.Register<CodeInputForm>(this, param => Form = param);

        private string code;
        public string Code
        {
            get => code;
            set { Set(ref code, value); }
        }

        private RelayCommand confirmCommand;
        public RelayCommand ConfirmCommand
        {
            get
            {
                return confirmCommand ?? (confirmCommand = new RelayCommand(
                    async () =>
                    {
                        LoadingStart();
                        try
                        {
                            Form.Code = Convert.ToInt32(Code);
                            await Repository.RegConfirm(Form);
                            NavigationService.NavigateTo(VM.LoginViewModel);
                            UpperWindowClose();
                        }
                        catch (Exception)
                        {
                            MessageBoxShow("ne korektno!");
                        }
                    }
                ));
            }
        }

        private RelayCommand resendCommand;
        public RelayCommand ResendCommand
        {
            get
            {
                return resendCommand ?? (resendCommand = new RelayCommand(
                    async () =>
                {
                    LoadingStart();
                    try
                    {
                        await Repository.ResendCode(Form.Email);
                        MessageBoxShow("Your code was sent successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBoxShow(ex.Message);
                        UpperWindowClose();
                    }
                }));
            }
        }
    }
}
