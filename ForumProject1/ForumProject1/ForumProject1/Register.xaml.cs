using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Org.BouncyCastle.Crypto.Digests;

namespace ForumProject1
{
    //class for users
    public class Users
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public string url = "http://introtoapps.com/datastore.php?";
        private HttpClient _client = new HttpClient();

       
        public Register()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
                //encryting the password
                EncryPassword encry = new EncryPassword();
                var hashedPassword = encry.Sha256encrypt(pass.Text);
                 //adding the post 
                var post = new Users { Email = email.Text, Username = username.Text, Password = hashedPassword, DateOfBirth = dob.Date };    
            //serializing the user
                var newContent = JsonConvert.SerializeObject(post);
                var content = newContent.ToString();
            //users added to url
                var actualUrl = new UriBuilder(url + "action=append&appid=215411492&objectid=users&data=" + content);
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, actualUrl.ToString());
                var response = _client.SendAsync(request);
            //goes to login page
                await Navigation.PushAsync(new Login());
            
            
        }

    }

    public class EncryPassword
    { 
        //encryption of data
        public string  Sha256encrypt(string password)
        {
            
            var encData = Encoding.UTF8.GetBytes(password);
            Sha256Digest newHash = new Sha256Digest();
            newHash.BlockUpdate(encData, 0, encData.Length);
            byte[] compArr = new byte[newHash.GetDigestSize()];
            newHash.DoFinal(compArr, 0);
            return Convert.ToBase64String(compArr);
            

        }
    }


}