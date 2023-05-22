using Xunit.Abstractions;

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

public class DayTestData : IXunitSerializable {
    public string input {get;} = "";
    public string expectedOutput {get;} = "";
    public string why {get;} = "";
    public DayTestData(string input, string expectedOutput, string why) {
        this.input = input;
        this.expectedOutput = expectedOutput;
        this.why = why;
    }
    public DayTestData() {}

    public void Deserialize(IXunitSerializationInfo info) { }

    public void Serialize(IXunitSerializationInfo info)
    {
        info.AddValue(nameof(input), input);
        info.AddValue(nameof(expectedOutput), expectedOutput);
        info.AddValue(nameof(why), why);
    }
}