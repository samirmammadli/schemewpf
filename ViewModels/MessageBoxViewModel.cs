using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchemeWpf.ViewModels
{
    class MessageBoxViewModel : ViewModelBase
    {
        public MessageBoxViewModel() { }

        private string message;
        public string Message
        {
            get => message;
            set { Set(ref message, value); }
        }

        private RelayCommand okCommand;
        public RelayCommand OkCommand
        {
            get
            {
                return okCommand ?? (okCommand = new RelayCommand(
                    () =>
                    {
                        Messenger.Default.Send(this);
                    }
                ));
            }
        }
    }
}
