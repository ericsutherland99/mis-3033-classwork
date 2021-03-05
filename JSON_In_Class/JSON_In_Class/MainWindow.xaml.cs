using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using Newtonsoft.Json;

namespace JSON_In_Class
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //https://rickandmortyapi.com/api/character

            using (var client = new HttpClient())
            {
                string jsonData = client.GetStringAsync("https://rickandmortyapi.com/api/character").Result;
                RickAndMortyAPI api;
                api = JsonConvert.DeserializeObject<RickAndMortyAPI>(jsonData);
                foreach (var character in api.results)
                {
                    lstcharacters.Items.Add(character);
                }
                while (api.info.next != null)
                {
                    using (var link = new HttpClient())
                    {
                        var next = api.info.next;
                        jsonData = link.GetStringAsync(next.ToString()).Result;
                        api = JsonConvert.DeserializeObject<RickAndMortyAPI>(jsonData);
                        foreach (var character in api.results)
                        {
                            lstcharacters.Items.Add(character);
                        }
                    }
                }
            }

        }

        private void lstcharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedcharacter = (Character)lstcharacters.SelectedItem;
            if (selectedcharacter is null)
            {
                return;
            }
            NewWindow newWindow = new NewWindow();
            newWindow.Picture(selectedcharacter);
            newWindow.ShowDialog();
            

        }
    }
}
