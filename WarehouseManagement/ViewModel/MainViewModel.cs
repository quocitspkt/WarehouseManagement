using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace WarehouseManagement.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool Isloaded;
        public MainViewModel()
        {
            if (!Isloaded)
            {
                Isloaded = true;
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.Show();
            }
        }
    }
}
