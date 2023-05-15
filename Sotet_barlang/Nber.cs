using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sotet_barlang
{
    internal class Nber
    {
        private string nev;
        private int time;
        private bool lampa;

        public Nber(string nev, int time)
        {
            this.nev = nev;
            this.time = time;
            this.lampa = false;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Time { get => time; set => time = value; }
        public bool Lampa { get => lampa; set => lampa = value; }

        public override string ToString()
        {
            return $"{this.nev}, {this.time}";
        }
    }
}
