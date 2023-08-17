using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace DapperRealEstateWebApi.Models.DapperContext
{
    public class Context
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public Context(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("LocalDbDapper");
        }

        public IDbConnection CreateConnection()=> new SqlConnection(_connectionString);

        //Yuxarida olan kod asagidaki ile eyni meqsed dasiyir { return } evez edir => bu isare

        //public IDbConnection createConnection()
        //{
        //   return new SqlConnection(_connectionString);

        //}
    }
}
