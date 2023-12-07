using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifly.Model
{
    internal abstract class Stamp
    {
        public string User { get; set; } = "Anonymous";
        public DateTime TimeCreated { get; set; } = DateTime.Now;
    }
}
