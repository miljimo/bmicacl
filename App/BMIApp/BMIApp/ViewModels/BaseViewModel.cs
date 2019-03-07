﻿

namespace ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;

    public  class BaseViewModel
    {
        private ResourceDictionary _Res;

        BaseViewModel(ResourceDictionary Res)
        {

        }

        /// <summary>
        ///  Get the application resource object.
        /// </summary>
        public ResourceDictionary Resource
        {
            get
            {
                return _Res;
            }
        }
    }
}