using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniElection1.Classes
{
    public class ElectionEvent
    {
        public string Name { get; private set; }
        public List<Position> positions { get; private set; }
        public DateTime StartEventDateTime;
        public DateTime EndEventDateTime;
        public ElectionEvent(string name) 
        {
            this.Name = name;
            this.StartEventDateTime = DateTime.Now;
            this.EndEventDateTime = DateTime.Now.AddDays(1);
            this.positions = new List<Position>();
        }
    }
}
