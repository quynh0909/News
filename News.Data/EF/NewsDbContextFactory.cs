using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace News.Data.EF
{
    public class NewsDbContextFactory : IDesignTimeDbContextFactory<NewsDbContext>
    {
        public NewsDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();
            var connectionString = configuration.GetConnectionString("NewsDb");

            var optionsBuilder = new DbContextOptionsBuilder<NewsDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new NewsDbContext(optionsBuilder.Options);
        }

        
    }
}
