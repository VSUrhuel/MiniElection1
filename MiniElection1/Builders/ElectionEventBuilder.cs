using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniElection1.Classes;
namespace MiniElection1.Builders
{
    internal class ElectionEventBuilder
    {
        private ElectionEvent electionEvent;
        public ElectionEventBuilder(string electionEventName)
        {
            this.electionEvent = new ElectionEvent(electionEventName);
        }
        public ElectionEventBuilder Position(Position position)
        {
            this.electionEvent.positions.Add(position);
            return this;
        }
        public ElectionEventBuilder StartEventDateTime(DateTime startEventDateTime)
        {
            this.electionEvent.StartEventDateTime = startEventDateTime;
            this.electionEvent.EndEventDateTime = startEventDateTime.AddDays(1);
            return this;
        }
        public ElectionEventBuilder EndEventDateTime(DateTime endEventDateTime)
        {
            if (endEventDateTime < this.electionEvent.StartEventDateTime)
                throw new Exception("End Event DateTime should be after the Start Event DateTime");
            this.electionEvent.EndEventDateTime = endEventDateTime;
            return this;
        }
        public ElectionEvent Build()
        {
            return this.electionEvent;
        }
    }
}
