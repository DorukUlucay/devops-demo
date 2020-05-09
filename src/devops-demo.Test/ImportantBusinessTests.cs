using devops_demo.Core.Contracts;
using devops_demo.Core.Services;
using Microsoft.Extensions.Configuration;
using Moq;
using Xunit;

namespace devops_demo.Test
{
    public class ImportantBusinessTests
    {

        readonly IImportantBusiness subject;
        readonly Mock<IConfiguration> configurationMock = new Mock<IConfiguration>();
        readonly static string environment = "Staging";
        readonly string environmentConfigKey = "Environment";
        readonly string expectedMessage = $"Hello World. This is {environment}";

        public ImportantBusinessTests()
        {
            configurationMock.Setup(o => o.GetSection(environmentConfigKey).Value).Returns(environment);
            subject = new ImportantBusiness(configurationMock.Object);
        }

        [Fact]
        public void Can_Return_Valid_Message()
        {
            var message = subject.GetGreetingMessage();

            Assert.Equal(expectedMessage, message.Message);
        }
    }
}
