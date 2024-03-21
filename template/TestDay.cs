using System.Net;

namespace aoc.template;

public class TestDay<T>
    where T : IDay, new()
{
    private string? _dayInput { get; set; }
    private IEnumerable<DayTestData>? Part1_TestData { get; set; }
    private IEnumerable<DayTestData>? Part2_TestData { get; set; }
    private string? Part1_Answer { get; set; }
    private string? Part2_Answer { get; set; }

    public TestDay()
    {
    }

    public TestDay<T> WithPart1TestData(IEnumerable<DayTestData> part1_TestData)
    {
        Part1_TestData = part1_TestData;
        return this;
    }

    //[Fact]
    public void TestPart1()
    {
        Part1_TestData.Should().NotBeNullOrEmpty("Part1_TestData should be assigned before running TestPart1");
        Parallel.ForEach(Part1_TestData ?? [], testData => {
            var day = new T();
            day.GetPart1(testData.input)
                .Should()
                .Be(testData.expectedOutput, testData.why);
        });

        foreach (var testData in Part1_TestData)
        {
            var day = new T();
            day.GetPart1(testData.input).Should().Be(testData.expectedOutput, testData.why);
        }
    }

    //[Fact]
    public void TestPart2()
    {
        foreach (var testData in Part2_TestData) {
            var day = new T();
            day.GetPart2(testData.input).Should().Be(testData.expectedOutput, testData.why);
        }
    }

    //[Fact]
    public void TestAnswer_Part1()
    {
        var day = new T();
        day.GetPart1(_dayInput).Should().Be(Part1_Answer, "The day result for Part 1 should be output");
    }

    //[Fact]
    public void TestAnswer_Part2()
    {
        var day = new T();
        day.GetPart2(_dayInput).Should().Be(Part2_Answer, "The day result for Part 2 should be output");
    }

    public void Test()
    {
        TestPart1();
        TestAnswer_Part1();
        TestPart2();
        TestAnswer_Part2();
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