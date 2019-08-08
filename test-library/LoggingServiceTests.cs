using Xunit;

namespace library.common
{
    public class LoggingServiceTests
    {
        [Fact]
        public void LogAction_Success()
        {
        //Given
            var expected = "Action: Test Action";

        //When
            var actual = LoggingService.LogAction("Test Action");

        //Then
            Assert.Equal(expected,actual);
        }
    }
}