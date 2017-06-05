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
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
            button1.Clicked += Button_Clicked;
            
            
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            XamarinMVVMSampleWebAPI api = new XamarinMVVMSampleWebAPI();
            var result = await api.Employees.GetEmployeesAsync();
            listView1.ItemsSource = result;
        }
    }
}
