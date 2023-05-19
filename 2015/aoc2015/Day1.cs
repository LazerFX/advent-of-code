namespace aoc2015;

public class Day1 : IDay
{
    private int floor = 0;

    private int step = 0;

    private void Start() {
        floor = 0;
        step = 0;
    }

    private int Step(char direction) {
        step += 1;
        
        switch (direction) {
            case '(':
                floor += 1;
                break;
            case ')':
                floor -= 1;
                break;
            default:
                throw new ArgumentException($"Cannot make a step using {direction}", nameof(direction));
        }

        return floor;
    }

    public string GetPart1(string input)
    {
        Start();

        foreach (var step in input)
        {
            Step(step);
        }

        return floor.ToString();
    }

    public string GetPart2(string input)
    {
        Start();

        foreach (var stepDirection in input) {
            var floor = Step(stepDirection);
            if (floor < 0) {
                return step.ToString();
            }
        }

        return "-1";
    }
}
