using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class professor : person
    {
        public int salary { get; set; }

        public professor(string tname, int tpn, string temailadd) : base(tname, tpn, temailadd)
        {
        }
    }
}
