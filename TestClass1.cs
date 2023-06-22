using Xunit.Abstractions;

namespace xunit_sample;

public class TestClass1
{
    private readonly ITestOutputHelper _testOutputHelper;

    public TestClass1(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact (Skip = "test reason 1")]
    public void Test1()
    {
        string className = GetType().Name;
        string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
        string testName = $"{className}.{methodName}";
        TestDelayer.Delay();
        _testOutputHelper.WriteLine($"{testName} complete 1.");
    }
    
    [Fact (Skip = "test reason 2")]
    public void Test2()
    {
        string className = GetType().Name;
        string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
        string testName = $"{className}.{methodName}";
        TestDelayer.Delay();
        _testOutputHelper.WriteLine($"{testName} complete.");
    }
    
    [Fact]
    public void Test3()
    {
        string className = GetType().Name;
        string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
        string testName = $"{className}.{methodName}";
        TestDelayer.Delay();
        _testOutputHelper.WriteLine($"{testName} complete.");
    }
    
    [Fact]
    public void Test4()
    {
        string className = GetType().Name;
        string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
        string testName = $"{className}.{methodName}";
        TestDelayer.Delay();
        _testOutputHelper.WriteLine($"{testName} complete.");
    }
}
