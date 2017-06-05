using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Forms.Http
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            button1.Clicked += Button_Clicked;
            
            
        }

        private  async void Button_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url1.Text);
            
            var response = await client.GetAsync("api/values/1");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var sample = JsonConvert.DeserializeObject<SampleModel>(content);
            label1.Text =sample.Id+"\n"+sample.Name+"\n"+sample.Data;
            }

        }
    }
    public class SampleModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
    }
}
