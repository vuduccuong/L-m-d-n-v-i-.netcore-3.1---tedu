using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace LCR.Data.EF
{
    class LDbContextFactory : IDesignTimeDbContextFactory<LDBContext>
    {
        public LDBContext CreateDbContext(string[] args)
        {
            //Lấy dữ liệu trong appsetting.json
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<LDBContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("LDatabase"));
            return new LDBContext(optionsBuilder.Options);
        }
    }
}
