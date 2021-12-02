namespace AdventOfCode.Solutions.Year2021;

internal interface ISubmarineInstruction
{
    int DepthDelta { get; }
    int XDelta { get; }
}