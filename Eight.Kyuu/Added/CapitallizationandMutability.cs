using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Eight.Kyuu.Added
{
    public class CapitallizationandMutability
    {
        public static string CapitalizeWord(string word)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word);
        }
    }
}
