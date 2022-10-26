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
        public User(string name, int discnum)
        {
            Name = name;
            Discnum = discnum;
        }
    }
}
