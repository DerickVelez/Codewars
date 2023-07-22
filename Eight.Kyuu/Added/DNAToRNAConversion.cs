using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class DNAToRNAConversion
    {
        public string dnaToRna(string dna)
        {
            return dna.Replace("T", "U");
        }
    }
}
