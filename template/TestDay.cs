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

    public void TestPart1(string why) {
        ValidateDay();

        _dayToTest.GetPart1(_input).Should().Be(_expectedOutput, why);
    }

    public void TestPart2(string why) {
        ValidateDay();

        _dayToTest.GetPart1(_input).Should().Be(_expectedOutput, why);
    }

    public TestDay() {}
}
