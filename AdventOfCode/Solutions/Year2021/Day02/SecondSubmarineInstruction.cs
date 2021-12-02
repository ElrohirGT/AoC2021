namespace AdventOfCode.Solutions.Year2021;

internal struct SecondSubmarineInstruction :ISubmarineInstruction
{
    public SecondSubmarineInstruction(string instructionText, ref int aim)
    {
        string[] command = instructionText.Split(' ');
        int value = int.Parse(command[1]);

        switch (command[0])
        {
            case "down":
                aim += value;
                break;
            case "up":
                aim -= value;
                break;
            case "forward":
                XDelta = value;
                DepthDelta = value * aim;
                break;
        }
    }

    public int DepthDelta { get; } = 0;
    public int XDelta { get; } = 0;
}