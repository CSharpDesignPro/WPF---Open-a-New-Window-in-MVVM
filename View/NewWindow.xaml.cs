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
using System.Windows.Shapes;
using MVVM_Window_App.Services;
using MVVM_Window_App.ViewModel;

namespace MVVM_Window_App.View
{
    /// <summary>
    /// Interaction logic for NewWindow.xaml
    /// </summary>
    public partial class NewWindow : Window
    {
        public NewWindow()
        {
            InitializeComponent();
            var windowService = new WindowService();
            DataContext = new MainViewModel(windowService);

            // Position the new window w/r to the WorkArea
            Top = (SystemParameters.WorkArea.Height - Height) / 2 + 50;
            Left = (SystemParameters.WorkArea.Width - Width) / 2 + 120;
        }
    }
}
