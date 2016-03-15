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
                {"Darth Vader", "Vassilli" },
                {"Leia", "Maiya" },
                {"Luke Skywalker", "Bogdan" },
                {"Obi-wan", "Alexander" },
                {"Han Solo", "Yakov" },
            };

            foreach (var key in names.Keys)
            {
                openingtext = openingtext.Replace(key, names[key]);
            }

            return openingtext;
        }
    }
}
