using CubisMobilePortfolio.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace CubisMobilePortfolio.Services
{
    public class ApiData
    {
        public bool DoLogIn(string puser, string ppass)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri((string)Application.Current.Properties["BaseApiUrl"]);

            User user = new User();
            user.Username = puser;
            user.Password = ppass;

            var json = JsonConvert.SerializeObject(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync(@"CubisLogin/AuthUser", content).Result;

            Result result = JsonConvert.DeserializeObject<Result>(response.Content.ReadAsStringAsync().Result);
            Application.Current.Properties["GUID"] = result.payload;

            if (result.response == "OK")
                return true;
            else
            {
                return false;
            }
        }
    }
}
