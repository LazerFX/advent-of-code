using System.Reflection;
using Xunit.Sdk;

public class AoCTheoryDiscoverer : TheoryDiscoverer
{
    public AoCTheoryDiscoverer(IMessageSink diagnosticMessageSink) : base(diagnosticMessageSink) { }

    protected override IEnumerable<IXunitTestCase> CreateTestCasesForTheory(ITestFrameworkDiscoveryOptions discoveryOptions, ITestMethod testMethod, IAttributeInfo theoryAttribute)
    {
        return base.CreateTestCasesForTheory(discoveryOptions, testMethod, theoryAttribute);
    }

    protected override IEnumerable<IXunitTestCase> CreateTestCasesForDataRow(ITestFrameworkDiscoveryOptions discoveryOptions, ITestMethod testMethod, IAttributeInfo theoryAttribute, object[] dataRow)
    {
        return base.CreateTestCasesForDataRow(discoveryOptions, testMethod, theoryAttribute, dataRow);
    }
}

[AttributeUsage(AttributeTargets.Method)]
[XunitTestCaseDiscoverer(nameof(AoCTheoryDiscoverer), "")]
public class AocTheoryAttribute : TheoryAttribute { }

// TODO: Once this is worked out, do a FACT version as well