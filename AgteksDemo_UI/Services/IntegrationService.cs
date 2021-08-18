using AgteksDemo_UI.Models;
using AgteksDemo_UI.Models.Helpers;
using AgteksDemo_UI.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AgteksDemo_UI.Services
{
    public static class IntegrationService
    {
        public static string apiUrl = "http://localhost:25709/api/integrations/";
        static HttpClient client = new HttpClient();

        // Sistemde yer alan ListResponseModel yapısı burada düzgün Parse yapılamadığından kullanılamadı. İleride eklenilmesi gerekmekte.
        public static DataTable GetAll()
        {
            DataTable rootObject = new DataTable();
            const string url = "http://localhost:25709/api/integrations/getall";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync(url).Result;
                var data = response.Content.ReadAsStringAsync().Result;
                data = data.TrimStart('\"');
                data = data.TrimEnd('\"');
                data = data.Replace("\\", "");
                rootObject = JsonConvert.DeserializeObject<DataTable>(data);
            }
            return rootObject;
        }
        public static HttpResponseMessage Add(Integration integration)
        {
            string apiAdd = "http://localhost:25709/api/integrations/add";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var json = JsonConvert.SerializeObject(integration);
                HttpContent content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = client.PostAsync(apiAdd, content).Result;
                return response;
            }
        }

        public static async Task<HttpStatusCode> Delete(Integration integration)
        {
            string apiDelete = "https://localhost:25709/api/integrations/delete=?{id}";
            HttpResponseMessage response = await client.DeleteAsync(apiDelete);

            return response.StatusCode;
        }

        //public async Task<Uri> Send(IFormFile file)
        //{
        //    string apiSend = "https://localhost:44368/api/interpolations/send";
        //    HttpResponseMessage response = await client.PostAsJsonAsync(apiSend, file);
        //    response.EnsureSuccessStatusCode();

        //    return response.Headers.Location;
        //}

        //public async Task<HttpStatusCode> Delete(int id)
        //{
        //    string apiDelete = "https://localhost:44368/api/interpolations/delete=?{id}";
        //    HttpResponseMessage response = await client.DeleteAsync(apiDelete);

        //    return response.StatusCode;
        //}

        //public async Task<Interpolation> Update(Interpolation interpolation)
        //{
        //    string apiUpdate = "https://localhost:44368/api/interpolations/update?={interpolation.ID}";
        //    HttpResponseMessage response = await client.PutAsJsonAsync(apiUpdate, interpolation);
        //    response.EnsureSuccessStatusCode();

        //    interpolation = await response.Content.ReadAsAsync<Interpolation>();
        //    return interpolation;
        //}

        //public async Task<Interpolation> GetAll(string path)
        //{
        //    //string apiGetAll = "https://localhost:44368/api/interpolations/getall"; 
        //    // kullandığımız yerde bu api verilecek ve çalışacak.
        //    Interpolation interpolation = null;
        //    HttpResponseMessage response = await client.GetAsync(path);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        interpolation = await response.Content.ReadAsAsync<Interpolation>();
        //    }
        //    return interpolation;
        //}

        //public async Task<Interpolation> Get(int id)
        //{
        //    Interpolation interpolation = null;
        //    HttpResponseMessage response = await client.GetAsync(interpolation.ImagePath);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        interpolation = await response.Content.ReadAsAsync<Interpolation>();
        //    }
        //    return interpolation;
        //}
    }

}
