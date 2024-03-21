using Xunit.Sdk;

[assembly: TestFramework("aoc.template.CustomTestFramework", "aoc.template")]

namespace aoc.template;

public class AocFactDiscoverer : IXunitTestCaseDiscoverer
{
    private readonly IMessageSink _diagnosticMessageSink;

    public AocFactDiscoverer(IMessageSink diagnosticMessageSink)
        => _diagnosticMessageSink = diagnosticMessageSink ?? throw new ArgumentNullException(nameof(diagnosticMessageSink));

    public IEnumerable<IXunitTestCase> Discover(ITestFrameworkDiscoveryOptions discoveryOptions,
        ITestMethod testMethod, IAttributeInfo factAttribute)
    {
        yield return new XunitTestCase(_diagnosticMessageSink, discoveryOptions.MethodDisplayOrDefault(), TestMethodDisplayOptions.None, testMethod);
    }
}

[AttributeUsage(AttributeTargets.Method)]
[XunitTestCaseDiscoverer("aoc.template." + nameof(AocFactDiscoverer), "aoc.template")]
public class AocFactAttribute : FactAttribute { }

// TODO: Once this is worked out, do a FACT version as well

// TODO: Somehow test this - pulling in the XUnit v3 core AcceptanceTestV3 base class /might/ work, but that's clunky...

public class SomeTest
{
    [Fact]
    public static void Hello_Should_Assert_True()
    {
        Assert.True(true);
    }

    [AocFact]
    public static void AocTheory_Hello_Should_Assert_True()
    {
        Assert.True(true);
    }

    [Fact]
    public void BasicFact()
    {
        Assert.True(true);
    }
}

public class CustomTestFramework : XunitTestFramework
{
    public CustomTestFramework(IMessageSink messageSink) : base(messageSink)
    {
        messageSink.OnMessage(new DiagnosticMessage("Using CustomTestFramework"));
    }
}

