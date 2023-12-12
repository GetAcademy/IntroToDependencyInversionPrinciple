using System.Net;
using System.Text.Json;

namespace IntroToDependencyInversionPrinciple.OneOfEach
{
    internal class ChuckNorrisApiDataFetcher : IDataFetcher
    {
        private WebClient _webClient;
        private const string baseUrl = "https://api.chucknorris.io/jokes/";

        public ChuckNorrisApiDataFetcher()
        {
            _webClient = new WebClient();

        }

        public string[] GetCategories()
        {
            var categoriesJson = _webClient.DownloadString(baseUrl + "categories");
            var categories = JsonSerializer.Deserialize<string[]>(categoriesJson);
            return categories;
        }

        public string GetExample(string category)
        {
            var jokeJson = _webClient.DownloadString(baseUrl + $"random?category={category}");
            var jokeObj = JsonSerializer.Deserialize<Joke>(jokeJson);
            return jokeObj.value;
        }
    }
}
