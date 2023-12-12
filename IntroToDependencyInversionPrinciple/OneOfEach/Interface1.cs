namespace IntroToDependencyInversionPrinciple.OneOfEach
{
    internal interface IDataFetcher
    {
        string[] GetCategories();
        string GetExample(string categori);
    }
}
