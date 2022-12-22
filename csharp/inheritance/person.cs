using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class person : iatk
    {
        private string name;
        public string name_
        {
            get
            {
                return name;
            }
            private set
            { 
                name = value;
            }
        }

        public int phonenumber { get; private set; }
        public string emailadd { get; private set; }

        public person(string tname, int tpn, string temailadd)
        {
            name = tname;
            phonenumber= tpn;
            emailadd = temailadd;
        }

        public void purchasePP()
        {
            Console.WriteLine($"{name}(은)는 주차권을 구매했다");
        }

        public void atk()
        {
            Console.WriteLine($"{name}(이)가 공격했다");
        }
    }
}
