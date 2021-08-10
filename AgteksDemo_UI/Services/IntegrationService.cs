﻿using AgteksDemo_UI.Models;
using AgteksDemo_UI.Models.Helpers;
using AgteksDemo_UI.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AgteksDemo_UI.Services
{
    public class IntegrationService
    {
        public string apiUrl = "https://localhost:25709/api/integrations/";
        static HttpClient client = new HttpClient();

        public async Task<Integration> GetAll(string path)
        {
            //string apiGetAll = "https://localhost:44368/api/integrations/getall";  // kullandığımız yerde bu api verilecek ve çalışacak.
            Integration interpolation = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                interpolation = await response.Content.ReadAsAsync<Integration>();
            }
            return interpolation;
        }

        public async Task<Uri> Add(Integration integration)
        {
            string apiAdd = "https://localhost:25709/api/integrations/add";
            HttpResponseMessage response = await client.PostAsJsonAsync(apiAdd, integration);
            response.EnsureSuccessStatusCode();

            return response.Headers.Location;
        }

        public async Task<HttpStatusCode> Delete(Integration integration)
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