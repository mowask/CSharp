using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wpf_hw_Quiz.Model;

namespace wpf_hw_Quiz.ViewModel
{
    internal class LoginViewModel : INotifyPropertyChanged  
    {
        public List<User> Users { get; set; }

        public User _currentUser { get; set; }
        public User CurrentUser
        {
            get { return _currentUser; }
            set
            {
                _currentUser = value;
                OnPropertyChanged("CurrentUser");
            }
        }


        public ICommand LoginCommand {  get; set; }


        public LoginViewModel(DelegateCommand command)
        {
            Users = User.GenerateUsers();
            CurrentUser = new User("", "");
            LoginCommand = command;
        }

        public bool VerifyUser()
        {
            foreach (var user in Users)
            {
                if (user.Login == CurrentUser.Login &&
                    user.Password == CurrentUser.Password)
                    return true;
            }

            return false;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
