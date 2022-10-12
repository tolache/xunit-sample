using Xunit.Abstractions;

namespace xunit_sample;

public class UnitTest1
{
    private readonly int _testDurationMs;
    private readonly ITestOutputHelper _testOutputHelper;

    public UnitTest1(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
        _testDurationMs = Convert.ToInt32(0.5 * 1000);
    }

    [Fact]
    [Repeat(4)]
    public void Test1()
    {
        Thread.Sleep(_testDurationMs);
        _testOutputHelper.WriteLine("Test1 complete.");
    }
    
    [Fact]
    public void Test2()
    {
        Thread.Sleep(_testDurationMs);
        _testOutputHelper.WriteLine("Test2 complete.");
    }
    
    [Fact]
    public void Test3()
    {
        Thread.Sleep(_testDurationMs);
        _testOutputHelper.WriteLine("Test3 complete.");
    }
    
    [Fact]
    public void Test4()
    {
        Thread.Sleep(_testDurationMs);
        _testOutputHelper.WriteLine("Test4 complete.");
    }
}