using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Limsapp.API
{
    class APICalls<T>
    {
        public static List<T> GetList(string Collection,string Parameters = "")
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://6143a99bc5b553001717d06a.mockapi.io/testapi/v1//");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            HttpResponseMessage response = client.GetAsync(Collection).Result;
            if (!response.IsSuccessStatusCode)
            {

                Assert.Fail("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            client.Dispose();

            var page = JsonConvert.DeserializeObject<List<T>>(response.Content.ReadAsStringAsync().Result);

            return page;
        }

        public static void CreateAPI(string Collection, T Object)
        {


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://6143a99bc5b553001717d06a.mockapi.io/testapi/v1//" + Collection);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string output = JsonConvert.SerializeObject(Object);

            StringContent queryString = new StringContent(output);

            var method = new HttpMethod("POST");


            // call sync
            HttpResponseMessage response = client.PostAsync(new Uri("https://6143a99bc5b553001717d06a.mockapi.io/testapi/v1//" + Collection), queryString).Result;

            if (!response.IsSuccessStatusCode)
            {

                Assert.Fail("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            client.Dispose();
        }
    }
}
