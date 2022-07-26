using Xunit.Abstractions;

namespace xunit_sample;

public class UnitTest1
{
    private readonly ITestOutputHelper _testOutputHelper;

    public UnitTest1(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Test1()
    {
        Thread.Sleep(1 * 1000);
        _testOutputHelper.WriteLine("Test1 complete.");
    }
    
    [Fact]
    public void Test2()
    {
        Thread.Sleep(1 * 1000);
        _testOutputHelper.WriteLine("Test2 complete.");
    }
    
    [Fact]
    public void Test3()
    {
        Thread.Sleep(1 * 1000);
        _testOutputHelper.WriteLine("Test3 complete.");
    }
    
    [Fact]
    public void Test4()
    {
        Thread.Sleep(1 * 1000);
        _testOutputHelper.WriteLine("Test4 complete.");
    }
}