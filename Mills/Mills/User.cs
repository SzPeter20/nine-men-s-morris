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
        public string Discnum { get; set; }
        public User(string name, string discnum)
        {
            Name = name;
            Discnum = discnum;
        }
    }
}
