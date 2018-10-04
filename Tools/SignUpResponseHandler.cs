using GalaSoft.MvvmLight.Messaging;
using RestSharp;
using SchemeWpf.Navigation;
using SchemeWpf.Tools.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchemeWpf.Tools
{
    class SignUpResponseHandler : IResponseHandler
    {
        public void Handle(INavigationService navigation, IRestResponse response, IRequestForm form)
        {
            if (response.IsSuccessful)
            {
                Messenger.Default.Send(form as CodeInputForm);
                navigation.NavigateTo(VM.RegistrationConfirmCodeViewModel);
                return;
            }
            throw new ArgumentException("Something went wrong: " + response.Content);
        }
    }
}
