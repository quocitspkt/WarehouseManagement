using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace WarehouseManagement.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool Isloaded;
        public ICommand LoadedMainWindowCommand { get; set; }
        public MainViewModel()
        {
            LoadedMainWindowCommand = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                Isloaded = true;
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.Show();
            });

        }
    }
}
