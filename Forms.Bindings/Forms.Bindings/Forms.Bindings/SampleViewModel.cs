using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Bindings
{
    public class SampleViewModel
    {
        public string Text { get; set; }

        public List<string> List { get; set; }
        public SampleViewModel()
        {
            List = new List<string>();
            Text = "Welcome to Xamarin Forms from binding!!";
            //generate the data
            List.Add("Karol");
            List.Add("Łukasz");
            List.Add("Olena");
            List.Add("Maks");
            List.Add("Kamil");
            List.Add("Borys");
            List.Add("Rafał");
            List.Add("Tomek");
            List.Add("Darek");            
        }

    }
}
