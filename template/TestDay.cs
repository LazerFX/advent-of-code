namespace aoc.template;

public class TestDay
{
    private IDay? _dayToTest;
    private string _input = "";
    private string _expectedOutput = "";

    public TestDay WithDay(IDay dayToTest) {
        _dayToTest = dayToTest;
        return this;
    }

    public TestDay WithInput(string input) {
        _input = input;
        return this;
    }

    public TestDay WithExpectedOutput(string expectedOutput) {
        _expectedOutput = expectedOutput;
        return this;
    }

    [MemberNotNull(nameof(_dayToTest))]
    private void ValidateDay() {
        if (_dayToTest == null) {
            throw new InvalidDataException($"You need to run {nameof(WithDay)} first");
        }
    }

    [Fact]
    public void TestPart1() {
        ValidateDay();

        _dayToTest.GetPart1(_input).Should().Equals(_expectedOutput);
    }

    [Fact]
    public void TestPart2() {
        ValidateDay();

        _dayToTest.GetPart1(_input).Should().Equals(_expectedOutput);
    }

    public TestDay() {}
}
