using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class Welcome
    {
        public static string Greet(string language)
        {
            var translation = new Dictionary<string, string>(){
          {"english", "Welcome"},
          {"czech", "Vitejte"},
          {"danish", "Velkomst"},
          {"dutch", "Welkom"},
          {"estonian", "Tere tulemast"},
          {"finnish", "Tervetuloa"},
          {"flemish", "Welgekomen"},
          {"french", "Bienvenue"},
          {"german", "Willkommen"},
          {"irish", "Failte"},
          {"italian", "Benvenuto"},
          {"latvian", "Gaidits"},
          {"lithuanian", "Laukiamas"},
          {"polish", "Witamy"},
          {"spanish", "Bienvenido"},
          {"swedish", "Valkommen"},
          {"welsh", "Croeso"}
            };
            return translation.ContainsKey(language.ToLower()) ? translation[language.ToLower()] : "Welcome";

        }
    }
}
