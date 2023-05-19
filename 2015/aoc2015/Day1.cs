namespace aoc2015;

public class Day1 : IDay
{
    public string GetPart1(string input)
    {
        int interator = 0;

        foreach (var step in input)
        {
            if (step == '(') { interator += 1; }
            else interator -= 1;
        }

        return interator.ToString();
    }

    public string GetPart2(string input)
    {
        throw new NotImplementedException();
    }
}
