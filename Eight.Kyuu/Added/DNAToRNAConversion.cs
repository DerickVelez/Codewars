using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public static class DNAToRNAConversion
    {
        public static string dnaToRna(string dna)
        {
            return dna.Replace("T", "U");
        }
    }
}
