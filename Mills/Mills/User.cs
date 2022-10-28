using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mills
{
    class User
    {
        public string Name { get; set; }
        public int Discnum { get; set; }
        public string Color { get; set; }
        public User(string name, int discnum, string color)
        {
            Name = name;
            Discnum = discnum;
            Color = color;
        }
    }
}
