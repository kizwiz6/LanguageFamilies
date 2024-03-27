using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFamilies
{
    internal class SinoTibetan : Language
    {
        public SinoTibetan(string languageName, int speakers) : base(languageName, speakers, "Asia", "subject-object-verb")
        {
            if (languageName.Contains("Chinese"))
            {
                this.wordOrder = "subject-verb-object";
            }
        }
    }
}
