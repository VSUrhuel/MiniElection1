using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniElection1.Builders;
namespace MiniElection1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Position> position = new List<Position>();
            PositionBuilder builder = new PositionBuilder();
            position.Add(builder.Name("President").Build());

            builder = new PositionBuilder();
            position.Add(builder.Name("P.I.O").IsMultiple(true).NumberOfSlots(2).Build());

            foreach(var pos in position)
            {
                Console.WriteLine(pos);
            }
            Console.ReadKey();

        }
    }
}
