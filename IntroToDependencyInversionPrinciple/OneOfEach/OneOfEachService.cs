using System.Net;
using System.Text.Json;

namespace IntroToDependencyInversionPrinciple.OneOfEach
{
    internal class OneOfEachService
    {
        private IDataFetcher _dataFetcher;

        public OneOfEachService(IDataFetcher dataFetcher)
        {
            _dataFetcher = dataFetcher;
        }

        public Example[] GetIt()
        {
            var categories = _dataFetcher.GetCategories();
            var examples = new List<Example>();
            foreach (var category in categories)
            {
                var value = _dataFetcher.GetExample(category);
                var example = new Example(category, value);
                examples.Add(example);
            }
            return examples.ToArray();
        }
    }
}
