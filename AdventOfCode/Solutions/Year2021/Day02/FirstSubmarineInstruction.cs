namespace AdventOfCode.Solutions.Year2021
{
    partial class Day02
    {
        internal struct FirstSubmarineInstruction : ISubmarineInstruction
        {
            public int DepthDelta { get; } = 0;
            public int XDelta { get; } = 0;
            public FirstSubmarineInstruction(string instructionText)
            {
                string[] command = instructionText.Split(' ');
                int value = int.Parse(command[1]);
                switch (command[0])
                {
                    case "forward":
                        XDelta = value;
                        break;
                    case "up":
                        DepthDelta = -value;
                        break;
                    case "down":
                        DepthDelta = value;
                        break;
                }
            }
        }
    }
}
