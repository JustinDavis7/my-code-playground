using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DataBindingAndCommands.ViewModel;

namespace DataBindingAndCommands.Views
{
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            MainViewModel mainViewModel = new MainViewModel(); // We now have the instance, next we need to bind it.
            this.DataContext = mainViewModel; // Sets default binding to the VM.
        }
    }
}
