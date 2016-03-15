using System.Collections.Generic;
using RestSharp;

namespace Code
{
    public class MikesThing
    {
        private readonly RestClient client = new RestClient("http://swapi.co/api/");

        public List<dynamic> GetFilms()
        {
            RestRequest request = new RestRequest("films", Method.GET);
            IRestResponse<List<dynamic>> response = client.Execute<List<dynamic>>(request);
            return response.Data;
        }
    }
}
