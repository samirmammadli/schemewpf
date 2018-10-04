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
    class NavigationService : INavigationService
    {
        protected Dictionary<VM, ViewModelBase> pages = new Dictionary<VM, ViewModelBase>();

        public void AddPage(ViewModelBase page, VM name)
        {
            if (pages.ContainsKey(name))
                pages[name] = page;
            else
                pages.Add(name, page);
        }

        public virtual void NavigateTo(VM name)
        {
            try
            {
                Messenger.Default.Send(pages[name]);
            }
            catch (Exception)
            {
                throw new Exception("Page not found!");
            }
        }
    }
}
