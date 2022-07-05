using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WarehouseManagement.ViewModel
{
    public class ControlBarViewModel : BaseViewModel
    {
        #region commands
        public ICommand CloseWindowCommand { get; set; }
        public ICommand MinimizeWindowCommand { get; set; }
        public ICommand MaximizeWindowCommand { get; set; }
        public ICommand DragWindowCommand { get; set; }
        #endregion
        public ControlBarViewModel()
        {
            CloseWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) =>
            {
                FrameworkElement windowSelected = GetWindowParent(p);
                var window = windowSelected as Window;
                if (window != null)
                {
                    window.Close();
                }
            });
            MinimizeWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) =>
            {
                FrameworkElement windowSelected = GetWindowParent(p);
                var window = windowSelected as Window;
                if (window != null)
                {
                    if (window.WindowState != WindowState.Minimized)
                        window.WindowState = WindowState.Minimized;
                }
            });
            MaximizeWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) =>
            {
                FrameworkElement windowSelected = GetWindowParent(p);
                var window = windowSelected as Window;
                if (window != null)
                {
                    if (window.WindowState != WindowState.Maximized)
                        window.WindowState = WindowState.Maximized;
                    else
                        window.WindowState = WindowState.Normal;
                }

            });
            DragWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) =>
            {
                FrameworkElement windowSelected = GetWindowParent(p);
                var window = windowSelected as Window;
                if (window != null)
                {
                    window.DragMove();
                }

            });
        }
        FrameworkElement GetWindowParent(UserControl p)
        {
            FrameworkElement parent = p;
            while (parent.Parent != null)
            {
                parent = parent.Parent as FrameworkElement;
            }
            return parent;
        }
    }
}
