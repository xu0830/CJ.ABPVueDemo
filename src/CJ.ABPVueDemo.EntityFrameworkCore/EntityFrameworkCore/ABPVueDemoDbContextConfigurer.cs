using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CJ.ABPVueDemo.EntityFrameworkCore
{
    public static class ABPVueDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABPVueDemoDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABPVueDemoDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
