using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
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
    class ViewModelInternal : ViewModelBaseExtension
    {
        public ViewModelInternal(LoadingViewModel loading, NavigationService navigationService, 
            Repo repository, LoginResponseHandler responseHandler, MessageBoxViewModel messageBoxViewModel)
            : base(loading, navigationService, repository, responseHandler, messageBoxViewModel) { }
    }
}
