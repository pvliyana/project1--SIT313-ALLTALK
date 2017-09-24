using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ForumProject1
{
    // [XamlCompilation(XamlCompilationOptions.Compile)]
   

    public partial class NewPost : ContentPage
    {
        public string url = "http://introtoapps.com/datastore.php?";
      private HttpClient _client = new HttpClient();
     

        //first add list and remove this code 
      //  public List<Posts> discussions = new List<Posts>();

        public NewPost()
        {
            InitializeComponent();
            
        }

        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            //adding posts
            var post = new Posts { newCreatedPost = postContent.Text};
           // discussions.Add(post);
           //serializing the post
            var newContent = JsonConvert.SerializeObject(post);
            var content = newContent.ToString();
            //content added to url
            var actualUrl = new UriBuilder(url + "action=append&appid=215411492&objectid=discussionboard&data=" + content);
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, actualUrl.ToString());
            var response = _client.SendAsync(request);

            //goes to category page
            await Navigation.PushAsync(new Category());


        }
    }
   
}