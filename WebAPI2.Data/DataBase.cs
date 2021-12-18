using Microsoft.Extensions.Configuration;

namespace WebAPI2.Data
{
    public class DataBase
    {
        public IConfiguration Configuration { get; }
        public DataBase(IConfiguration configuration)
        {
            Configuration = configuration;
        }
    }
}