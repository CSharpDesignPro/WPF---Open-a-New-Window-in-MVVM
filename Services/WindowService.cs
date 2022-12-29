using MVVM_Window_App.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_Window_App.Services
{
    public class WindowService : IWindowService
    {
        public void OpenWindow()
        {
            // Create an instance of the new window
            var window = new NewWindow();

            // Show the new window
            window.ShowDialog();
        }

        public void CloseWindow()
        {
            // Get a reference to the current window
            var window = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);

            // Close the window
            if (window != null)
            {
                window.Close();
            }
        }
    }
}
