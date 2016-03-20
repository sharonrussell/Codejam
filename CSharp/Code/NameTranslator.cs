using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class NameTranslator
    {
        public string Translate(string openingtext)
        {
            var names = new Dictionary<string, string>
            {
                {"C-3P0", "Sergei" },
                {"R2-D2", "Oleg" },
                {"Vader", "Vassilli" },
                {"Leia", "Maiya" },
                {"Luke", "Bogdan" },
                {"Obi-wan", "Alexander" },
                {"Solo", "Yakov" },
                {"Naboo", "Meerkat Manor" },
            };

            foreach (var key in names.Keys)
            {
                openingtext = openingtext.Replace(key, names[key]);
            }

            return openingtext;
        }
    }
}
