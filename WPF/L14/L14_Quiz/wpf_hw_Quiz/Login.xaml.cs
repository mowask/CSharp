using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using wpf_hw_Quiz.ViewModel;

namespace wpf_hw_Quiz
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        LoginViewModel vm;
        public Login()
        {
            vm = new LoginViewModel(new DelegateCommand (LoginHandler));
            InitializeComponent();
            this.DataContext = vm;
            
        }

        public void LoginHandler (object obj)
        {
            if (vm.VerifyUser())
            {
                var mainWindow = new MainWindow(vm.CurrentUser);
                mainWindow.Show();
                this.Close();
            }
            else
            {
                _ = MessageBox.Show("Incorrect Login or Password");
            }
        }
    }
}
