using System;
using System.Collections.Generic;
using RestSharp;
using Xamarin.Forms;

namespace VsMacDemo01.Services
{
    public class DataStoreService:IDisposable
    {
        private string apiUrl;
        private RestClient client;

        public DataStoreService()
        {

#if DEBUG
            if (Device.RuntimePlatform == Device.Android)
                apiUrl = "http://10.0.2.2:5000/api";
            else if (Device.RuntimePlatform == Device.iOS)
                apiUrl = "http://localhost:5000/api";
            else
                throw new PlatformNotSupportedException();
#else
            apiUrl = "https://websiteurl/api";
#endif

            client = new RestClient(apiUrl);

        }

        public void Dispose()
        {
            client = null;
        }

        public IEnumerable<string> GetProducts(){

            RestRequest req = new RestRequest("Products");

            var result = client.Execute<List<string>>(req, Method.GET);

            if (result.IsSuccessful)
            {
                return result.Data;
            }

            return null;
        }
    }
}
