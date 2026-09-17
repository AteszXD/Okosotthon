using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon.Models
{
    internal abstract class Ertesites
    {
        public string Uzenet { get; set; }
        public DateTime Idobelyeg { get; set; }

        public Ertesites(string uzenet, DateTime idobelyeg)
        {
            this.Uzenet = uzenet;
            this.Idobelyeg = idobelyeg;
        }

        public abstract void Kuld(Ertesites ertesites);
    }
}
