namespace xunit_sample;

public static class TestDelayer
{
    private const double TestDurationS = 2.5;
    
    private static int TestDurationMs => Convert.ToInt32(TestDurationS * 1000);

    public static void Delay()
    {
        Thread.Sleep(TestDurationMs);
    }
}