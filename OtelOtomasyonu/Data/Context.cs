using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OtelOtomasyonu.Models;



namespace OtelOtomasyonu.Data
{
    
        public class MyContext : DbContext
        {
            public MyContext(DbContextOptions<MyContext> options) : base(options)
            {
            }
            public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MyContext>
            {
                public MyContext CreateDbContext(string[] args) // Unable to create an object of type 'MyContext' hatasını gideren kod
                {
                    var builder = new DbContextOptionsBuilder<MyContext>();
                    var connectionString = "workstation id=hotellll.mssql.somee.com;packet size=4096;user id=ugur01_SQLLogin_1;pwd=5pk6u42iae;data source=hotellll.mssql.somee.com;persist security info=False;initial catalog=hotellll; encrypt=false; trust server certificate=false ";
                    builder.UseSqlServer(connectionString);
                    return new MyContext(builder.Options);
                }
            }
            public DbSet<Odalar> Odalars { get; set; }
           

        }
    
}
