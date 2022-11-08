using System;
using System.Linq;

namespace TrackTheRobot
{
    class Program
    {
        /// <summary>
        /// Function usage example.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", TrackRobot(new string[] { "right 10", "up 50", "left 30", "down 10" })));
            Console.ReadLine();
        }

        public static int[] TrackRobot(string[] instructions)
        {
            int x = 0, y = 0;

            instructions.Sum(instruction =>
                instruction.Contains("right") ? x += int.Parse(instruction.Split(' ')[1]) :
                instruction.Contains("left") ? x -= int.Parse(instruction.Split(' ')[1]) :
                instruction.Contains("up") ? y += int.Parse(instruction.Split(' ')[1]) :
                y -= int.Parse(instruction.Split(' ')[1]));

            return new int[] { x, y };
        }
    }
}
