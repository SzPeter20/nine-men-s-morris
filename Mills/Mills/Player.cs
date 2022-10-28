using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mills
{
    class Player
    {
        public string Name { get; set; }
        public int Piececount { get; set; }
        public int Onmappieces { get; set; }
        public string Color { get; set; }
        public Player(string name, int piececount,int onmappieces,string color)
        {
            Name = name;
            Onmappieces = onmappieces;
            Piececount = piececount;
            Color = color;
        }
    }
}
