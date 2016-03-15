using System.Collections.Generic;
using System.Linq;
using Code.Models;
using RestSharp;

namespace Code
{
    public class MikesThing
    {
        private readonly RestClient client = new RestClient("http://swapi.co/api/");

        public Films GetFilms()
        {
            RestRequest request = new RestRequest("films", Method.GET);
            IRestResponse<Films> response = client.Execute<Films>(request);
            return response.Data;
        }

        public List<string> GetOpeningCrawls()
        {
            var films = GetFilms();
            return films.results.Select(r => r.opening_crawl).ToList();
        }
    }
}
