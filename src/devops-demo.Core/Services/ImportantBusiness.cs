using devops_demo.Core.Contracts;
using devops_demo.Core.Models;
using Microsoft.Extensions.Configuration;

namespace devops_demo.Core.Services
{
    public class ImportantBusiness : IImportantBusiness
    {
        readonly IConfiguration Configuration;
        public ImportantBusiness(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public GreetingMessage GetGreetingMessage()
        {
            return new GreetingMessage() { Message = $"Hello World. This is {Configuration.GetSection("Environment").Value}" };
        }

    }
}
