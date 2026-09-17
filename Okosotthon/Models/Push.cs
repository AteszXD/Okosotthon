using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon.Models
{
    internal class Push : Ertesites
    {
        public string Eszkoz { get; set; }
        public Push(string uzenet, DateTime idobelyeg, string eszkoz) : base(uzenet, idobelyeg)
        {
            Eszkoz = eszkoz;
        }
        public override void Kuld(Ertesites ertesites)
        {
            throw new NotImplementedException();
        }
    }
}
