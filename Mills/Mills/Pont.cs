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

        public List<Pont> Neighbors = new List<Pont>();

        public Pont(string name, List<Pont> neighbors)
        {
            Name = name;
            Neighbors = neighbors;
        }
    }
}
