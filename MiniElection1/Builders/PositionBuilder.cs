using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniElection1.Classes;

namespace MiniElection1.Builders
{
    ///  Bulider Design Pattern 
    public class PositionBuilder
    {
        private Position position;

        public PositionBuilder() 
        {
            this.position = new Position();
        }

        public PositionBuilder Name(string name)
        {
            this.position.Name = name;
            return this;
        }

        public PositionBuilder IsMultiple(bool isMultiple)
        {
            this.position.IsMultiple = isMultiple;
            return this;
        }

        public PositionBuilder NumberOfSlots(int slots)
        {
            if (slots > 1 && this.position.IsMultiple)
                this.position.NumberOfSlots = slots;
            else
                throw new Exception("Cannot set number of slots if the position is not multiple.");
            return this;
        }

        public Position Build()
        {
            return this.position;
        }
    }
}
