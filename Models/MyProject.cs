using SchemeWpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchemeWpf.Models
{
    class MyProject
    {
        public MyProject()
        {
            Notifications = new ObservableCollection<Notification>();
        }
        public string Name { get; set; }
        public ObservableCollection<ColumnViewModel> BoardLists { get; set; }
        public ObservableCollection<Notification> Notifications { get; set; }
    }
}
