using System.Net;
using System.Text.Json;

namespace IntroToDependencyInversionPrinciple.OneOfEach
{
    internal class OneOfEachService
    {
        public static Example[] GetIt()
        {
            var baseUrl = "https://api.chucknorris.io/jokes/";
            var webClient = new WebClient();
            var categoriesJson = webClient.DownloadString(baseUrl + "categories");
            var categories = JsonSerializer.Deserialize<string[]>(categoriesJson);
            var examples = new List<Example>();
            foreach (var category in categories)
            {
                var jokeJson = webClient.DownloadString(baseUrl + $"random?category={category}");
                var joke = JsonSerializer.Deserialize<Joke>(jokeJson);
                examples.Add(new Example(category, joke.value));
            }
            return examples.ToArray();
        }
    }
}
