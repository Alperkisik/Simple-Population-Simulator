using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popülasyon
{
    class Human
    {
        public string name {get;set;}
        public string surName { get; set; }
        public Human mother { get; set; }
        public Human father { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string state { get; set; }
        public Human marriage { get; set; }
    }
}
