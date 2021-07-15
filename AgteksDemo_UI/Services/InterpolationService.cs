using AgteksDemo_UI.Models;
using AgteksDemo_UI.Models.Helpers;
using AgteksDemo_UI.Models.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AgteksDemo_UI.Services
{
    public class InterpolationService
    {
        public string apiUrl = "https://localhost:44368/api/interpolations/";
        static HttpClient client = new HttpClient();
        Interpolation interpolation = new Interpolation();

        public static async Task<HttpResponseMessage> Add(Interpolation interpolation)
        {
            string apiAdd = "https://localhost:44368/api/interpolations/add";
            //var myHttpContent = JsonConvert.SerializeObject(interpolation);
            //var buffer = Encoding.UTF8.GetBytes(myHttpContent);
            //var byteContent = new ByteArrayContent(buffer);
            //byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            //var client = HttpClientFactory.Create();

            //return await client.PostAsync<Interpolation>(client, apiAdd, interpolation, new JsonMediaTypeFormatter());

          
        }

        public static async Task<HttpResponseMessage> Delete(Interpolation interpolation)
        {
            string apiDelete = "https://localhost:44368/api/interpolations/delete";
            return await client.DeleteAsync(apiDelete,);

        }
    }

    //public static async Task<Interpolation> Update(Interpolation interpolation)
    //{
    //    string apiUpdate = "https://localhost:44368/api/interpolations/update";
    //    return await client.PutAsync(apiUpdate, interpolation);
    //}

    //public static async Task<Interpolation> Get(Interpolation ınterpolation)
    //{
    //    Interpolation interpolation = null;
    //    HttpResponseMessage response = await client.GetAsync(interpolation.ImagePath);
    //    if (response.IsSuccessStatusCode)
    //    {
    //        interpolation = await response.Content.ReadAsAsync<Interpolation>();
    //    }
    //    return interpolation;
    //}

    //public static async Task<Interpolation> GetAll(Interpolation ınterpolation)
    //{
    //    Interpolation interpolation = null;
    //}
}
