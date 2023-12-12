namespace IntroToDependencyInversionPrinciple.OneOfEach
{
    internal class DirectoryDataFetcher : IDataFetcher
    {
        private string _path;

        public DirectoryDataFetcher(string path)
        {
            _path = path;
        }

        public string[] GetCategories()
        {
            try
            {
                return Directory.GetDirectories(_path);
            }
            catch
            {
                return new string[0];
            }
        }

        public string GetExample(string path)
        {
            try
            {
                return Directory.GetDirectories(path).FirstOrDefault() ?? "<tom>";
            }
            catch
            {
                return "<feilet>";
            }
        }
    }
}
