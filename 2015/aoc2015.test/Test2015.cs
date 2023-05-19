namespace aoc2015.test;

public class Test2015
{
    [Fact]
    public void Part1_OneDown_ShouldBeMinus1()
    {
        var test = new TestDay();

        test.WithDay(new Day1())
            .WithInput(")")
            .WithExpectedOutput("-1");
        
        test.TestPart1();
    }
}