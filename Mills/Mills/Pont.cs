using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mills
{
    class Pont
    {
        public string Name { get; set; }
        public string Contain { get; set; }
        public List<Pont> Neighbors = new List<Pont>();

        public Pont(string name, List<Pont> neighbors,string contain)
        {
            Name = name;
            Contain = contain;
            Neighbors = neighbors;
        }
    }
}
