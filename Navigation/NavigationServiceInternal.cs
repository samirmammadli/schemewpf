
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using SchemeWpf.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchemeWpf.Navigation
{
    class NavigationServiceInternal : NavigationService
    {
        public override void NavigateTo(VM name)
        {
            try
            {
                Messenger.Default.Send(pages[name] as ViewModelInternal);
            }
            catch (Exception)
            {
                throw new Exception("Page not found!");
            }
        }
    }
}
