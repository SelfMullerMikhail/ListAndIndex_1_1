using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SercgingCycle
{
    internal class Program
    {
        public static IEnumerable<Tuple<int, int>> PlanSchedule(IEnumerable<Tuple<int, int>> meetings)
        {
            var leftEdge = int.MinValue;
            foreach (var meeting in meetings.OrderBy(m => m.Item2))
            {
                if (meeting.Item1 >= leftEdge)
                {
                    leftEdge= meeting.Item2;
                    yield return meeting;
                }
            }
        }

        public static void Main()
        {
            var meetings = new List<Tuple<int, int>>();
            meetings.Add(new Tuple<int, int>(8, 11));
            meetings.Add(new Tuple<int, int>(10, 13));
            meetings.Add(new Tuple<int, int>(12, 15));
            meetings.Add(new Tuple<int, int>(14, 16));
            meetings.Add(new Tuple<int, int>(15, 18));
            foreach (var e in PlanSchedule(meetings))
                Console.WriteLine(e);

        }
    }
}
