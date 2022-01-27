using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFTemplate.Infrastructure.Commands;
using WPFTemplate.ViewModels.Base;

namespace WPFTemplate.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Example
        private string _Val;
        public string Val { get => _Val; set => Set(ref _Val, value); }
        #endregion

        #region Commands

        #region ExampleCommand
        public static RelayCommand Show => new(_ => {
            MessageBox.Show("Hello!");
        },_=>true);
        #endregion
        #endregion
    }
}
