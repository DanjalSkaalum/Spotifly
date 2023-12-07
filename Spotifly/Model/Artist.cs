using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifly.Model
{
    internal class Artist : Stamp
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime Birthday { get; set;}

        public int GetAge ()
        {
            return DateTime.Now.Year - new DateTime().Year;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nCountry: {Country}\nDoB: {Birthday.ToString("yyyy-MM-dd")}\n";
        }
    }
}
