using MVVM_Window_App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MVVM_Window_App.ViewModel;

namespace MVVM_Window_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Create an instance of the WindowService
            var windowService = new WindowService();

            // Set the data context for the main window to a new instance of the ViewModel,
            // passing in the WindowService as a dependency
            DataContext = new MainViewModel(windowService);
        }
    }
}
