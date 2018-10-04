using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchemeWpf.Models
{
    class Notification : ObservableObject
    {
        private string name;
        public string Name
        {
            get => name;
            set => Set(ref name, value);
        }
    }
}
