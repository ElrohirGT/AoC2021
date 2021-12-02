using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Solutions.Year2021
{
    partial class Day02 : ASolution
    {
        readonly IList<ISubmarineInstruction> _part1Instructions = new List<ISubmarineInstruction>();
        readonly IList<ISubmarineInstruction> _part2Instructions = new List<ISubmarineInstruction>();
        public Day02() : base(02, 2021, "")
        {
            int aim = 0;
            foreach (var line in Input.SplitByNewline())
            {
                _part1Instructions.Add(new FirstSubmarineInstruction(line));
                
                _part2Instructions.Add(new SecondSubmarineInstruction(line, ref aim));
            }
        }

        protected override string SolvePartOne() => SolveUsingInstructions(_part1Instructions);
        protected override string SolvePartTwo() => SolveUsingInstructions(_part2Instructions);

        private static string SolveUsingInstructions(IList<ISubmarineInstruction> instructions)
        {
            int submarineX = 0;
            int submarineDepth = 0;
            foreach (var instruction in instructions)
            {
                submarineX += instruction.XDelta;
                submarineDepth += instruction.DepthDelta;
            }

            return (submarineDepth * submarineX).ToString();
        }

    }
}
