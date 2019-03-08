using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ViewModels;

namespace BMIApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

       protected override void OnStartup(StartupEventArgs Args)
        {
            base.OnStartup(Args);
            //The Start Up Algorithm Here 
            this.MainWindow = new MainWindow();

            if(this.MainWindow != null)
            {
                this.MainWindow.DataContext = new MainModelView();
                this.MainWindow.Show();
            }

        }
    }
}
