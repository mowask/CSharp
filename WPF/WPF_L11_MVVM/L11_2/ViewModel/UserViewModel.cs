using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_L11_2.Model;

namespace Wpf_L11_2.ViewModel
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private User _currentUser;
        private User _temptUser;
        public User CurrentUser {
            get { return _currentUser; }
            set 
            { 
                _currentUser= value;
                OnPropertyChanged("CurrentUser");
            } 
        }
        public User TempUser {
            get { return _temptUser; }
            set
            {
                _temptUser = value;
                OnPropertyChanged("TempUser");
            }
        }

        public ICommand AddUser { get; set; }

        public UserViewModel() 
        {
            CurrentUser = new User();
            TempUser= new User();
            AddUser = new DelegateCommand(AddUserHandler);
        }

        public void AddUserHandler(object obj)
        {
            CurrentUser = new User()
            {
                Email = TempUser.Email,
                Password = TempUser.Password
            };            
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string param) 
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(param));
            }
        }

    }
}
