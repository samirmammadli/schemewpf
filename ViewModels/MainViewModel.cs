using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using SchemeWpf.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchemeWpf.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        private object currentViewModel;

        public object CurrentViewModel
        {
            get => currentViewModel;
            set => Set(ref currentViewModel, value);
        }

        public MainViewModel()
        {
            Messenger.Default.Register<ViewModelBase>(this,
                param => CurrentViewModel = param
            );
        }
    }
}
