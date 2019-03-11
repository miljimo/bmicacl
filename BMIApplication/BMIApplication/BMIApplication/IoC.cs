
namespace BMIApplication
{
    using BMIApplication.Models;
    using BMIApplication.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class IoC
    {
        private static IRespositoryManager respositoryManager;



        public static IRespositoryManager RespositoryManager
        {
            get
            {
                return respositoryManager;
            }
        }


        public static BaseViewModel MainViewModel
        {
            get
            {
                return (App.Current.MainWindow.DataContext as BaseViewModel);
            }
        }

    }
}
