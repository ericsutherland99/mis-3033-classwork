using System;
using System.Collections.Generic;
using System.IO;
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

namespace newexample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<noodledate> dates = new List<noodledate>();
        public MainWindow() 
        {
            InitializeComponent();
            var lines = File.ReadAllLines("multiTimeline.csv").Skip(3);
            foreach(var line in lines)
            {
                dates.Add(new noodledate(line));
            }
            populatelistbox(dates);
        }

        private void populatelistbox(List<noodledate> noodlezzz)
        {
            lstnoodle.Items.Clear();
            foreach (var date in noodlezzz)
            {
                lstnoodle.Items.Add(date);
            }
        }

        private void btnclick_Click(object sender, RoutedEventArgs e)
        {
            int max = 0;
            foreach(var date in dates)
            {
                int amt = Convert.ToInt32(date.Pho);
                if (amt > max)
                {
                    max = amt;
                }
            }
            lblmax.Content = max;
        }
    }
}
