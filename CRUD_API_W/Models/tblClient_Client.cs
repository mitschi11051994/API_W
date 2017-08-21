using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;

namespace CRUD_API_W.Models
{
    public class tblClient_Client
    {
        private string BASE_URL = "http://localhost:41795/api/";
        public IEnumerable<tblClient> findAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("aplication/json"));
                HttpResponseMessage response = client.GetAsync("tblClient").Result;
                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<IEnumerable<tblClient>>().Result;
                return null;
            }
            catch
            {
                return null;
            }
        }

    }
}