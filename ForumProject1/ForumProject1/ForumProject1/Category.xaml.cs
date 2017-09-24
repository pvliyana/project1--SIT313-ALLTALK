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
        //list of topics
        private ObservableCollection<Topics> _topics;

        public Category()
        {
            InitializeComponent();

            _topics = new ObservableCollection<Topics>
            {
                new Topics{Name="AllPosts"},

            };


           listView.ItemsSource = _topics;
          
        }

        //goes the page that contains all the posts
        async void ViewCell_Tapped(object sender, EventArgs e)
        {
            
           await Navigation.PushAsync(new SubCategory());
        }

        
    }
}