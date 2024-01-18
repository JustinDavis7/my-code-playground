using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DataBindingAndCommands.ViewModel;

namespace DataBindingAndCommands.Views
{
    public partial class AddUser : Window
    {
        public AddUser()
        {
            InitializeComponent();
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            this.DataContext = addUserViewModel;
        }
    }
}
