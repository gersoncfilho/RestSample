using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSample.Model;
using System.Net.Http;

namespace RestSample.Classes
{
    class DataServices
    {
        public async void GetServiceData()
        {
            HttpClient client = new HttpClient();
            string ResponceResult = await client.GetStringAsync(new Uri("http://example.com/datalist.aspx"));
        }
    }
}