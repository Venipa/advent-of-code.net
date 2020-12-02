using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdventOfCode.DayHandlers
{
    [AdventTask("Day 1: Report Repair", "In this list, the two entries that sum to 2020 are 1721 and 299. Multiplying them together produces 1721 * 299 = 514579, so the correct answer is 514579.")]
    public class DayOneTask : IDayHandler
    {
        public AdventTaskAttribute Meta { get; set; }
        public int[] Data { get; set; } = new int[] { };
        public async Task Start()
        {
            this.Data = File.ReadAllText(AdventOfCodeAssembly.GetPath("Input/DayOne.txt")).Split("\n").Where(x => int.TryParse(x.Trim(), out var i)).Select(x => int.Parse(x.Trim())).ToArray();
            var input = Data;
            int x = 0,
                y = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    for (int k = 0; k < input.Length; k++)
                    {
                        if (input[i] + input[j] == 2020)
                        {
                            x = input[i];
                            y = input[j];
                        }
                    }
                }
            }
            Console.WriteLine("Result: X={0}, Y={1}, Sum={2}", x, y, x * y);
        }
    }
}