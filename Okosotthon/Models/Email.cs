using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon.Models
{
    internal class Email : Ertesites
    {
        public string Cim { get; set; }
        public string Targy { get; set; }

        public Email(string uzenet, DateTime idobelyeg, string cim, string targy) : base(uzenet, idobelyeg)
        {
            Cim = cim;
            Targy = targy;
        }

        public override void Kuld(string uzenet)
        {
            throw new NotImplementedException();
        }
    }
}
