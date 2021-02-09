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

namespace InClass_02_09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {
            Pet mypet = new Pet()
            {
                Breed = txtBreed.Text,
                Name = txtName.Text,
                Picture = txtPic.Text
            };

            lstPets.Items.Add(mypet);

            txtBreed.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPic.Text = string.Empty;

        }

        private void lstPets_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pet selectedPet = (Pet)lstPets.SelectedItem;
            Uri petURI = new Uri(selectedPet.Picture);
            BitmapImage pic = new BitmapImage(petURI);
            imgPet.Source = pic;

        }
    }
}
