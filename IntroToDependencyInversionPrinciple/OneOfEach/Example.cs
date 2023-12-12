namespace IntroToDependencyInversionPrinciple.OneOfEach
{
    internal class Example
    {
        public string Category { get; }
        public string Value { get; }
        public string Description => Category + " => " + Value;

        public Example(string category, string value)
        {
            Category = category;
            Value = value;
        }
    }
}
