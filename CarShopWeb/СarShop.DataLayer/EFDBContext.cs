using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Text;
using СarShop.DataLayer.Entities;

namespace СarShop.DataLayer
{
    public class EFDBContext: DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public EFDBContext(DbContextOptions<EFDBContext> options): base(options)
        {

        }
        /// <summary>
        /// for migrations
        /// </summary>
        public class EFDBContextFactory : IDesignTimeDbContextFactory<EFDBContext>
        {
            public EFDBContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<EFDBContext>();
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CarShopDb;Trusted_Connection = True;MultipleActiveResultSets = true;");

                return new EFDBContext(optionsBuilder.Options);
            }
        }
    }
}
