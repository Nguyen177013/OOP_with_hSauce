using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceStorage.Sauces
{
    internal class SauceCode : Sauce
    {
        private int codes;
        private List<string> types;
        public SauceCode(int id, string name, string author, int codes, List<string> types)
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.codes = codes;
            this.types = types;
        }

        public override string generateSauce()
        {
            string listType = "";
            types?.ForEach(type =>
            {
                listType += type + "\n";
            });
            return base.generateSauce() + $"\nCode: {codes}\nType: {listType}";
        }
    }
}
