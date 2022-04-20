using Xunit;

namespace HybridFlowTest
{
    public class UnitTests
    {
        [Fact]
        public void HybridFlowTest()
        {
            HybridFlow.SystemBrowser.OpenBrowser = new OpenTestBrowser();
            Assert.True(HybridFlow.Program.MainAsync(true).Result);
        }
    }
}
