﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sutemenyek
{
    class Sutemenyek
    {
        public string Nev { get; set; }
        public int Ar { get; set; }

        public Sutemenyek(string nev, int ar)
        {
            Nev = nev;
            Ar = ar;
        }
    }
}
