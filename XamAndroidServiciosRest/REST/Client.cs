using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamAndroidServiciosRest.REST
{
    public static class Client
    {
       
        public async static Task<T> GetRequest<T>(this string url)
        {
           
            try {
                HttpClient client = new HttpClient();
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine(json);
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
            }
            catch {
                return default(T);

            }
        }
    }

    
}