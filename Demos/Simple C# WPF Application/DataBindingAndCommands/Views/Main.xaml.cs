using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using DataBindingAndCommands.Models;
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

        private void FilterTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            UserList.Items.Filter = FilterMethod;
        }

        private bool FilterMethod(object obj)
        {
            var user = (User)obj;
            return user.Name.Contains(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase);
        }
    }
}
