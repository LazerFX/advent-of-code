namespace aoc.template;

public class TestDay
{
    private IDay _dayToTest;

    public void TestPart1(DayTestData testData)
    {
        _dayToTest.GetPart1(testData.input).Should().Be(testData.expectedOutput, testData.why);
    }

    public void TestPart2(DayTestData testData)
    {
        _dayToTest.GetPart2(testData.input).Should().Be(testData.expectedOutput, testData.why);
    }

    public TestDay(IDay day) { _dayToTest = day; }
}

public record DayTestData(string input, string expectedOutput, string why);