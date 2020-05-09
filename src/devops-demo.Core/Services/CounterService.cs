using Dapper;
using devops_demo.Core.Contracts;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Linq;

namespace devops_demo.Core.Services
{
    public class CounterService : ICounterService
    {
        readonly IConfiguration Configuration;
        readonly string ConnStrKey = "Default";

        public CounterService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(Configuration.GetConnectionString(ConnStrKey));
        }

        public int GetCount()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var value = connection.Query<int>("SELECT count FROM \"Counter\";");
                return value.First();
            }
        }

        public void Increment()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                connection.Execute("UPDATE \"Counter\" SET count=count+1;");
            }
        }
    }
}
