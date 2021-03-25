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

namespace ExamPrep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Cupcake> cupcakes = new List<Cupcake>();
        public MainWindow()
        {
            InitializeComponent();

            var lines = File.ReadAllLines("multiTimeline.csv").Skip(3);

            foreach(var line in lines)
            {
                cupcakes.Add(new Cupcake(line));
            }
            foreach(var line in cupcakes)
            {
                lstdates.Items.Add(line);
            }
        }

        private void lstdates_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cupcake cupcake = new Cupcake();
            cupcake = (Cupcake)lstdates.SelectedItem;
            txttotalcupcakes.Text = cupcake.cupcake;
            

        }

        private void btntotalcupcakes_Click(object sender, RoutedEventArgs e)
        {
            int total = 0;
            foreach(Cupcake cupcake in cupcakes)
            {
                cupcake.intcupcake = Convert.ToInt32(cupcake.cupcake);
                total += cupcake.intcupcake;
            }
            lbltotalcupcakes.Content = total;
        }
    }
}
