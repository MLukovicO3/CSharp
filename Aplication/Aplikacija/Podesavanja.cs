using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija
{
    class Podesavanja
    {
        public static int W { get; set; }
        public static int H { get; set; }
        public static string directions;
        public Podesavanja()
        {
            W = 16;
            H = 16;
            directions = "left";
        }
    }
}
