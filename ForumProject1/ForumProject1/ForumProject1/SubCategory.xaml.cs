using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.Net.Http;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace ForumProject1
{
    public static class Load
    {
 

        //url for access to the database
        public static string Url = "http://introtoapps.com/datastore.php?appid=215411492";
        public static HttpResponseMessage httpResponse;
        //posts saved onto this list after loading them
        public static ObservableCollection<Posts> posts; //= new ObservableCollection<Posts>();

        // Method to load the posts created from the  database
        async public static Task CategoryPost()
        {
            var actualUrl = new UriBuilder(Url + "&action=load&objectid=discussionboard");
            var httpClient = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, actualUrl.ToString());
            httpResponse = await httpClient.SendAsync(requestMessage);
            var stream = await httpResponse.Content.ReadAsStringAsync();
            posts = JsonConvert.DeserializeObject<ObservableCollection<Posts>>(stream);
    

        }

    }


    public class Posts
    {

       public string newCreatedPost { get; set; }


    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubCategory : ContentPage
    {
       

        public SubCategory()
        {

            InitializeComponent();
            //load contents from database to list
            listView2.ItemsSource = Load.posts; 

        }


        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            //adding posts page
            Navigation.PushAsync(new NewPost());
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            //delete the first post in the list
            var delete = Load.posts[0];
            Load.posts.Remove(delete);

        }
    }
    
}

   
