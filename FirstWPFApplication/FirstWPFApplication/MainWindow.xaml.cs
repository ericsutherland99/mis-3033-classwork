using System;
using System.Collections.Generic;
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

namespace FirstWPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            mainwindow.Background = Brushes.Red;
        }

        private void btn_click(object sender, RoutedEventArgs e)
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string answer = dateDOB.Text;
            DateTime DOB = Convert.ToDateTime(answer);
            //TimeSpan age = ((DateTime.Now.Date - DOB) / 365);

           


            MessageBox.Show($"Thanks for clicking me {firstname} {lastname}, you are {CalculateAgeCorrect(DOB, DateTime.Now)} years old!");
        }

        public int CalculateAgeCorrect(DateTime birthDate, DateTime now)
        {
            int age = now.Year - birthDate.Year;

            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                age--;

            return age;
        }

        private void btn_enter(object sender, MouseEventArgs e)
        {
            mainwindow.Background = Brushes.Yellow;
        }
        private void btn_leave(object sender, MouseEventArgs e)
        {
            mainwindow.Background = Brushes.Red;
        }
    }
}
