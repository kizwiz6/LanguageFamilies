namespace LanguageFamilies
{
    internal class Language
    {
        protected string name;
        protected int numSpeakers;
        protected string regionsSpoken;
        protected string wordOrder;

        public Language(string langName, int speakers, string regions, string wdOrder)
        {
            this.name = langName;
            this.numSpeakers = speakers;
            this.regionsSpoken = regions;
            this.wordOrder = wdOrder;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"{name} is spoken by {numSpeakers} people mainly in {regionsSpoken}.");
            Console.WriteLine($"The language follows the word order: {wordOrder}");
        }

        static void Main(string[] args)
        {
            Language English = new Language("English", 6999, "East", "subject-verb-object");
            English.GetInfo();
            Mayan kiche = new Mayan("Ki'che'", 2330000);
            kiche.GetInfo();
            SinoTibetan mandarin = new SinoTibetan("Mandarin Chinese", 111000000);
            mandarin.GetInfo();
            SinoTibetan burmese = new SinoTibetan("Burmese", 43000000);
            burmese.GetInfo();
        }
    }
}
