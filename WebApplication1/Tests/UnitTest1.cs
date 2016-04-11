using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Success()
        {
            Assert.Equal("true", "true");
        }

        [Fact]
        public void Fail()
        {
            Assert.Equal("true", "false");
        }
    }
}
