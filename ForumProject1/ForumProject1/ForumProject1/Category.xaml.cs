using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ForumProject1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Category : ContentPage
    {
        private ObservableCollection<Topics> _topics;

        public Category()
        {
            InitializeComponent();

            _topics = new ObservableCollection<Topics>
            {
                new Topics{Name="Android Zone", ImageUrl ="http://lorempixel.com/100/100/people/1"},
                new Topics{Name="apple Zone", ImageUrl ="http://lorempixel.com/100/100/people/2"},
                new Topics{Name="apple Zone", ImageUrl ="http://lorempixel.com/100/100/people/3"},
                new Topics{Name="apple Zone", ImageUrl ="http://lorempixel.com/100/100/people/4"},
                new Topics{Name="apple Zone", ImageUrl ="http://lorempixel.com/100/100/people/5"},
                new Topics{Name="apple Zone", ImageUrl ="http://lorempixel.com/100/100/people/6"},
                new Topics{Name="apple Zone", ImageUrl ="http://lorempixel.com/100/100/people/7"},
                new Topics{Name="apple Zone", ImageUrl ="http://lorempixel.com/100/100/people/8"},
                new Topics{Name="apple Zone", ImageUrl ="http://lorempixel.com/100/100/people/9"},
                new Topics{Name="apple Zone", ImageUrl ="http://lorempixel.com/100/100/people/1"},
                new Topics{Name="apple Zone", ImageUrl ="http://lorempixel.com/100/100/people/2"},
                new Topics{Name="apple Zone", ImageUrl ="http://lorempixel.com/100/100/people/3"},
                new Topics{Name="apple Zone", ImageUrl ="http://lorempixel.com/100/100/people/2"},
                new Topics{Name="apple Zone", ImageUrl ="http://lorempixel.com/100/100/people/2"},
                new Topics{Name="apple Zone", ImageUrl ="http://lorempixel.com/100/100/people/2"},
                new Topics{Name="apple Zone", ImageUrl ="http://lorempixel.com/100/100/people/2"}


            };

           // listView.ItemsSource = new List<ContactGroup>
            //{
            //     new ContactGroup("P", "P")
            //     {
            //    new Contact{Name="Parami", ImageUrl ="http://lorempixel.com/100/100/people/1"},
            //     },
            //     new ContactGroup("N","N"){
            //    new Contact{Name="Naveen", ImageUrl ="http://lorempixel.com/100/100/people/2", Status="Hey! lets talk!" }
            //     }
            // };

           listView.ItemsSource = _topics;
          
        }

        async void ViewCell_Tapped(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new SubCategory());
        }
    }
}