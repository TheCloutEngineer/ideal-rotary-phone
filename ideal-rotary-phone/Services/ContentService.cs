//using System;
//using System.Collections.Generic;
//using System.Net.Http;
//using System.Text.Json;
//using System.Threading.Tasks;

//namespace ideal_rotary_phone.Services
//{
//    public class ContentService
//    {
//        public HttpClient Client { get; }

//        public ContentService(HttpClient client)
//        {
//            client.BaseAddress = new Uri("http://localhost:3000");
//            // Backend API
//            client.DefaultRequestHeaders.Add("Accept", "application/json");
//            Client = client;
//        }

//        public async Task<> GetAspNetDocsIssues()
//        {
//            var response = await Client.GetAsync("/data");

//            response.EnsureSuccessStatusCode();

//            using var responseStream = await response.Content.ReadAsStreamAsync();

//            return await JsonSerializer.DeserializeAsync<>(responseStream);
//        }
//    }
//}
