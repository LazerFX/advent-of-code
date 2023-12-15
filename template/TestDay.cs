using System.Net;

namespace aoc.template;

public class TestDay<T>
    where T : IDay, new()
{
    private string _dayInput { get; }
    private IEnumerable<DayTestData> Part1_TestData { get; }
    private IEnumerable<DayTestData> Part2_TestData { get; }
    private string Part1_Answer { get; }
    private string Part2_Answer { get; }

    public TestDay(string dayInput, IEnumerable<DayTestData> part1_TestData, IEnumerable<DayTestData> part2_TestData, string part1_Answer, string part2_Answer)
    {
        _dayInput = dayInput;
        Part1_Answer = part1_Answer;
        Part2_Answer = part2_Answer;
        Part1_TestData = part1_TestData;
        Part2_TestData = part2_TestData;
    }

    [Fact]
    public void TestPart1()
    {
        foreach (var testData in Part1_TestData)
        {
            var day = new T();
            day.GetPart1(testData.input).Should().Be(testData.expectedOutput, testData.why);
        }
    }

    [Fact]
    public void TestPart2()
    {
        foreach (var testData in Part2_TestData) {
            var day = new T();
            day.GetPart2(testData.input).Should().Be(testData.expectedOutput, testData.why);
        }
    }

    [Fact]
    public void TestAnswer_Part1()
    {
        var day = new T();
        day.GetPart1(_dayInput).Should().Be(Part1_Answer, "The day result for Part 1 should be output");
    }

    [Fact]
    public void TestAnswer_Part2()
    {
        var day = new T();
        day.GetPart2(_dayInput).Should().Be(Part2_Answer, "The day result for Part 2 should be output");
    }
}

public class DayTestData : IXunitSerializable
{
    public string input { get; } = "";
    public string expectedOutput { get; } = "";
    public string why { get; } = "";
    public DayTestData(string input, string expectedOutput, string why)
    {
        this.input = input;
        this.expectedOutput = expectedOutput;
        this.why = why;
    }
    public DayTestData() { }

    public void Deserialize(IXunitSerializationInfo info) { }

    public void Serialize(IXunitSerializationInfo info)
    {
        info.AddValue(nameof(input), input);
        info.AddValue(nameof(expectedOutput), expectedOutput);
        info.AddValue(nameof(why), why);
    }
}