using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZNCaseTest
{
    internal class Globals
    {
        public static List<string> foundWords = NZNCase.WordHandler.FindWords(NZNCase.Globals.targetString);
    }

}
