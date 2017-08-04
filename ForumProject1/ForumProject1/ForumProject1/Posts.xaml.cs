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
    public partial class Posts : ContentPage
    {
        private ObservableCollection<Topics> _topics;
        public Posts()
        {
            InitializeComponent();

            _topics = new ObservableCollection<Topics>
            {
                new Topics{Name="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", ImageUrl ="http://lorempixel.com/100/100/people/1"},
                new Topics{Name="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", ImageUrl ="http://lorempixel.com/100/100/people/2"},
                new Topics{Name="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", ImageUrl ="http://lorempixel.com/100/100/people/3"},
                 new Topics{Name="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", ImageUrl ="http://lorempixel.com/100/100/people/4"},
                  new Topics{Name="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", ImageUrl ="http://lorempixel.com/100/100/people/5"},
                   new Topics{Name="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", ImageUrl ="http://lorempixel.com/100/100/people/6"}



            };

            listPosts.ItemsSource = _topics;
        }
    }
}