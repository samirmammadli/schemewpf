using GalaSoft.MvvmLight;
using SchemeWpf.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SchemeWpf.ViewModels
{
    class CardViewModel : ObservableObject, IViewModelsState
    {
        public CardViewModel()
        {
            ImageSource = "/Images/edit.png";
        }

        public string name;
        public string Name
        {
            get => name;
            set => Set(ref name, value);
        }

        private bool _isEnabled = false;

        public bool IsEnabled
        {
            get => _isEnabled;
            set => Set(ref _isEnabled, value);
        }

        private string imageSource;
        public string ImageSource
        {
            get => imageSource;
            set => Set(ref imageSource, value);
        }

        public void ChangeLastState()
        {
            IsEnabled = false;
            ImageSource = "/Images/edit.png";
        }
    }
}
