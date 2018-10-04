using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchemeWpf.Models
{
    class Project
    {
        public string Name { get; set; }
        public List<BoardList> BoardLists { get; set; }
        public List<Notification> Notifications { get; set; }
    }
}
