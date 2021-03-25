using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExamJSONPrep
{
    /// <summary>
    /// Interaction logic for CatFactWindow.xaml
    /// </summary>
    public partial class CatFactWindow : Window
    {
        List<CatAPI> objcatlist = null;
        public CatFactWindow()
        {
            InitializeComponent();
            //CatAPI cat = null;
            //List<CatAPI> objcatlist = null;
            //string[] listofcats = null; ;
            string URL = "https://cat-fact.herokuapp.com/facts";

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(URL).Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    objcatlist = JsonConvert.DeserializeObject<List<CatAPI>>(json);
                }
                else
                {
                    MessageBox.Show("Sorry we cannot contact the webserver");
                    return;
                }
                foreach(var cats in objcatlist)
                {
                    lstid.Items.Add(cats._id);
                }

            }


        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selecteditem = lstid.SelectedItem;
            foreach(var cats in objcatlist)
            {
                if(cats._id == (string)selecteditem)
                {
                    txtcatfact.Text = cats.text;
                }
            }
            
        }
    }
}
