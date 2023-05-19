namespace aoc2015.test;

public class Test2015_Day1
{
    [Theory]
    [InlineData(")", "-1", "One Down should return -1")]
    [InlineData("(", "1", "One Up should return 1")]
    [InlineData("(())", "0", "Going up and Down should return to zero")]
    [InlineData("()()", "0", "Going up and Down should return to zero")]
    public void Part1_ShouldReturnRightAnswer(string input, string expectedOutput, string why)
    {
        var test = new TestDay();
        
        test.WithDay(new Day1())
            .WithInput(input)
            .WithExpectedOutput(expectedOutput);
        
        test.TestPart1(why);
    }
}