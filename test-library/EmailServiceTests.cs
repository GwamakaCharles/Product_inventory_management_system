using Xunit;

namespace library.common
{
    public class EmailServiceTests
    {
        [Fact]
        public void SendMessage_Success()
        {
        //Given
            var email = new EmailService();
            var expected = "Message sent: Test Message";
        //When
            var actual = email.SendMessage("Test Message",
                "This is a test message", "abc@abc.com");
        //Then
            Assert.Equal(expected, actual);
        }
    }
}