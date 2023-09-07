using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceStorage.Sauces
{
    internal class SauceImage : Sauce
    {
        public SauceImage(int id, string name, string author)
        {
            this.id = id;
            this.name = name;
            this.author = author;
        }
    }
}
