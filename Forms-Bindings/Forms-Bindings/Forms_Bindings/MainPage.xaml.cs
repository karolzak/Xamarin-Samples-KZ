using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Forms_Bindings
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SampleViewModel viewModel = new SampleViewModel();

            BindingContext = viewModel;

        }
    }

    

}
