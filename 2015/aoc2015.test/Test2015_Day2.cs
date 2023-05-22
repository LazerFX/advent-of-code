namespace aoc2015.test;

public class Test2015_Day2
{
    private static string _daysInput = "";

    private TestDay testDay;

    public Test2015_Day2() {
        testDay = new TestDay(new Day2());
    }

    public static IEnumerable<object[]> Part1_TestData()
    {
        yield return new object[] { new DayTestData("", "", "") };
    }

    [Theory]
    [MemberData(nameof(Part1_TestData))]
    public void Part1_ShouldReturnRightAnswer(DayTestData testData)
    {
        testDay.TestPart1(testData);
    }

    public static IEnumerable<object[]> Part1_DayData()
    {
        yield return new object[] { new DayTestData(_daysInput, "", "the days input should be correct for Part 1") };
    }

    [Theory]
    [MemberData(nameof(Part1_DayData))]
    public void Part1_ForTheDay_ShouldBeRight(DayTestData testData)
    {
        testDay.TestPart1(testData);
    }

    public static IEnumerable<object[]> Part2_TestData()
    {
        yield return new object[] { new DayTestData("", "", "") };
    }


    [Theory]
    [MemberData(nameof(Part2_TestData))]
    public void Part2_ShouldReturnRightAnswer(DayTestData testData)
    {
        testDay.TestPart2(testData);
    }

    public static IEnumerable<object[]> Part2_DayData()
    {
        yield return new object[] { new DayTestData(_daysInput, "", "the days input should be correct for Part 2") };
    }

    [Theory]
    [MemberData(nameof(Part2_DayData))]
    public void Part2_ForTheDay_ShouldBeRight(DayTestData testData)
    {
        testDay.TestPart2(testData);
    }
}