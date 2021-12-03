using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Solutions.Year2021
{

    class Day03 : ASolution
    {
        private const char BIT_0 = '0';
        private const char BIT_1 = '1';
        char[,] _columns;
        public Day03() : base(03, 2021, "")
        {
            string[] lines = Input.SplitByNewline();
            _columns = new char[lines[0].Length, lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                for (int j = 0; j < line.Length; j++)
                    _columns[j, i] = line[j];
            }
        }

        protected override string SolvePartOne()
        {
            StringBuilder gammaRateBuilder = new();
            StringBuilder epsilonRateBuilder = new();


            for (int i = 0; i < _columns.GetLength(0); i++)
            {
                int count0 = 0;
                int treshold = _columns.GetLength(1) / 2;
                for (int j = 0; j < _columns.GetLength(1); j++)
                {
                    var bit = _columns[i, j];
                    if (bit == BIT_0)
                        ++count0;
                    if (count0 >= treshold)
                        break;
                }
                if (count0 >= treshold)
                {
                    gammaRateBuilder.Append(BIT_0);
                    epsilonRateBuilder.Append(BIT_1);
                }
                else
                {
                    gammaRateBuilder.Append(BIT_1);
                    epsilonRateBuilder.Append(BIT_0);
                }
            }

            int gammaRate = Convert.ToInt32(gammaRateBuilder.ToString(), 2);
            int epsilonRate = Convert.ToInt32(epsilonRateBuilder.ToString(), 2);
            return (gammaRate * epsilonRate).ToString();
        }

        protected override string SolvePartTwo()
        {
            return null;
        }
    }
}
