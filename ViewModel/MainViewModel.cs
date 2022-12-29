using MVVM_Window_App.Services;
using Open_Window_Trial_1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Window_App.ViewModel
{
    public class MainViewModel
    {
        private IWindowService _windowService;
        public ICommand OpenWindowCommand { get; set; }
        public ICommand CloseWindowCommand { get; set; }

        private void OnOpenWindow()
        {
            _windowService.OpenWindow();
        }

        private void OnCloseWindow()
        {
            _windowService.CloseWindow();
        }

        public MainViewModel(IWindowService windowService)
        {
            _windowService = windowService;
            OpenWindowCommand = new RelayCommand(param => OnOpenWindow());
            CloseWindowCommand = new RelayCommand(param => OnCloseWindow());
        }
       
    }
}
