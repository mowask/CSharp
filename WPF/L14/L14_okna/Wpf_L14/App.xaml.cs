using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Wpf_L14
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Aplication_Startup (object sender, StartupEventArgs e)
        {
            //Create the window
            MainWindow window = new MainWindow();

            //Open the window
            window.Show();
        }
    }
}
