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
    public class tblClients_Client
    {
        private string BASE_URL = "http://localhost:41795/api/";
        public IEnumerable<tblClients> findAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("aplication/json"));
                HttpResponseMessage response = client.GetAsync("tblClients").Result;
                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<IEnumerable<tblClients>>().Result;
                return null;
            }
            catch
            {
                return null;
            }
        }

    }
}