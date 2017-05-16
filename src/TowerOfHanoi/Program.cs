using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char startPeg = 'A';
            char endPeg = 'C';
            char tempPeg = 'B';
            int totalDisks = 3;

            solveTowers(totalDisks, startPeg, endPeg, tempPeg);
        }

        private static void solveTowers(int n, char startPeg, char endPeg, char tempPeg)
        {
            if (n > 0)
            {
                solveTowers(n - 1, startPeg, tempPeg, endPeg);
                Console.WriteLine("Move disk from " + startPeg + " to " + endPeg);
                solveTowers(n - 1, tempPeg, endPeg, startPeg);
                Console.ReadLine();
            }
        }
    }
}
