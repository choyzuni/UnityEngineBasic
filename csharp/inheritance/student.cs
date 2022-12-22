using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class student : person
    {
        public int studentnumber { get; set; }

        public char averagemark { get; set; }

        public bool istoenroll
        {
            get
            {
                return averagemark == 'A';
            }
        }

        private string[] seminarstaken;
        public bool takenseminar
        {
            get 
            {
                return seminarstaken != null && seminarstaken.Length > 0;
            }
        }

        public student(string tname, int tpn, string temailadd) : base(tname, tpn, temailadd)
        {

        }

        public void takeseminars(string[] seminars)
        {
            seminarstaken = seminars;
        }


    }
}
