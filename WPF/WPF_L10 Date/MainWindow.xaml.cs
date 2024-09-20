using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_L10_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Appointment> appointments = new ObservableCollection<Appointment>();

        public MainWindow()
        {
            InitializeComponent();

            buttonSubmit.Click += ButtonSubmit_Click;
            appointmentListBox.ItemsSource = appointments;

        /////////////// DatePicker
        
            datePicker.DisplayDateStart = DateTime.Today;
            btnSubmit.Click += BtnSubmit_Click;

            
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (datePicker.SelectedDate == null) return;
            DateTime selectesDate = datePicker.SelectedDate.Value;

            TimeSpan timeDifferrence = selectesDate - DateTime.Now;

            int days = timeDifferrence.Days;
            int months = timeDifferrence.Days/ 30;
            int years = timeDifferrence.Days/ 365;

            resultTextBlock.Text = $"Days left: {days}\nMonths lest: {months}\nYears left: {years}";
        }

        private void ButtonSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (calendarAppointment.SelectedDate == null) return;
            int id  = appointments.Count+1;
            Appointment appointment = new Appointment
            {
                Date = calendarAppointment.SelectedDate.Value,
                Description = textBoxAppointment.Text,
                ID = id
            };

            appointments.Add(appointment);
            textBoxAppointment.Text = string.Empty;
            calendarAppointment.ClearValue(Calendar.SelectedDateProperty);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            int id =  (int) (sender as MenuItem).Tag;
            foreach(Appointment appointment in appointments)
            {
                if (appointment.ID == id)
                {
                    appointments.Remove(appointment);
                    break;
                }
            }
        }
    }
}
