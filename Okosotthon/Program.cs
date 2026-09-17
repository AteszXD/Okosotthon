// 1. Okosotthon
using Okosotthon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon
{
    internal class Program
    {
        static void Main()
        {
            List<Ertesites> csatornak = new List<Ertesites>();
            string riasztasUzenet = "Nyitva maradt fagyasztó ajtó!!!!!";

            csatornak.Add(new Email(riasztasUzenet, DateTime.Now, "alegz@email.com", "Riasztás"));
            csatornak.Add(new SMS(riasztasUzenet, DateTime.Now, "+36304206969"));
            csatornak.Add(new Push(riasztasUzenet, DateTime.Now, "Alegz A32 Eszköze"));

            foreach (Ertesites csatorna in csatornak)
            {
                csatorna.Kuld(csatorna);
            }
        }
    }
}
