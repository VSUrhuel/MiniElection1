using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniElection1
{
    public class Position
    {
        public string Name { get; set; }
        public bool IsMultiple { get; set; }
        public int NumberOfSlots { get; set; }
        public Position()
        {
            this.Name = string.Empty;
            this.IsMultiple = false;
            this.NumberOfSlots = 1;
        }

        public override string ToString()
        {
            return this.Name + ((this.IsMultiple) ? ("(" + this.NumberOfSlots + ")") : "");
        }
    }
}
