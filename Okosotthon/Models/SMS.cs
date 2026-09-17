using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon.Models
{
    internal class SMS : Ertesites
    {
        public string Telefonszam { get; set; }

        public SMS(string uzenet, DateTime idobelyeg, string telefonszam) : base(uzenet, idobelyeg)
        {
            Telefonszam = telefonszam;
        }

        public override void Kuld(Ertesites ertesites)
        {
            throw new NotImplementedException();
        }
    }
}
