using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Solutions.Year2021
{

    class Day01 : ASolution
    {
        private string[] _lines;

        public Day01() : base(01, 2021, "")
        {
            _lines = Input.SplitByNewline();
        }

        protected override string SolvePartOne()
        {
            if (_lines.Length <= 1)
                return "0";

            int previousIsLowerCount = 0;
            int previousValue = int.Parse(_lines[0]);
            for (int i = 1; i < _lines.Length; i++)
            {
                int currentValue = int.Parse(_lines[i]);
                if (previousValue < currentValue)
                    previousIsLowerCount++;
            }
            return previousIsLowerCount.ToString();
        }

        protected override string SolvePartTwo()
        {
            return null;
        }
    }
}
