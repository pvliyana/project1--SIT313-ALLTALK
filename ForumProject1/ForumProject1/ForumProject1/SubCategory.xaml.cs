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
    public partial class SubCategory : ContentPage
    {
        private ObservableCollection<Topics> _subtopics;

        public SubCategory()
        {
            InitializeComponent();
            _subtopics = new ObservableCollection<Topics>
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

            listView2.ItemsSource = _subtopics;

        }

        async void ViewCell_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Posts());
        }

        
    }
}