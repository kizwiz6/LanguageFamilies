using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFamilies
{
    internal class Mayan : Language
    {
        public Mayan(string languageName, int speakers) : base(languageName, speakers, "Central America", "verb-object-subject")
        {
        }

        public override void GetInfo()
        {
            Console.WriteLine($"{name} is spoken by {numSpeakers} people mainly in {regionsSpoken}.");
            Console.WriteLine($"The language follows the word order: {wordOrder}");
            Console.WriteLine($"Fun fact: {name} is an ergative language.");
        }
    }
}
