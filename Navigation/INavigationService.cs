using GalaSoft.MvvmLight;
using SchemeWpf.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchemeWpf.Navigation
{
    interface INavigationService
    {
        void NavigateTo(VM name);
        void AddPage(ViewModelBase page, VM name);
    }
}
