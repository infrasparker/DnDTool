using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTool
{
    public class Monster
    {
        public string name { get; set; }
        public int cr { get; set; }

        public Monster(String name, int cr)
        {
            this.name = name;
            this.cr = cr;
        }

        public override string ToString()
        {
            return this.name + ", CR: " + this.cr;
        }
    }
}
