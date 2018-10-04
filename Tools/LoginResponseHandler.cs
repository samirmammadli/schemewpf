using GalaSoft.MvvmLight.Messaging;
using RestSharp;
using RestSharp.Deserializers;
using SchemeWpf.Navigation;
using SchemeWpf.Tools.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchemeWpf.Tools
{
    class LoginResponseHandler : IResponseHandler
    {
        public void Handle(INavigationService navigation, IRestResponse response, IRequestForm form)
        {
            if (response.IsSuccessful)
                navigation.NavigateTo(VM.MainNavigationViewModel);
            else
            {
                try
                {
                    var ser = new JsonDeserializer();
                    var msg = ser.Deserialize<AccountErrorMessages>(response);
                    if (msg == AccountErrorMessages.NotConfirmed)
                    {
                        Messenger.Default.Send(form as CodeInputForm);
                        navigation.NavigateTo(VM.RegistrationConfirmCodeViewModel);
                    }
                }
                catch (Exception)
                {
                    throw new ArgumentException("Something went wrong: " + response.Content);
                }
                
            }
        }
    }
}
