using SchemeWpf.Tools;
using SchemeWpf.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SchemeWpf
{
    public partial class App : Application
    {
        public App()
        {
            try
            {
                var app = new MainView
                {
                    DataContext = new ViewModelLoactor().MainViewModel
                };
                app.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
