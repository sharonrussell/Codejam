using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code;

namespace StarWarsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = new MikesThing();
            List<string> openings = api.GetOpeningCrawls();

            var rand = new Random();
            var opening = openings[rand.Next(0, 7)];

            var translator = new NameTranslator();
            var translatedOpening = translator.Translate(opening);

            Console.WriteLine(translatedOpening);
        }
    }
}
