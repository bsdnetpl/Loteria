using Loteria.Shared;
using Microsoft.EntityFrameworkCore;
using System;

namespace Loteria.Server.DATA
{
    public class ConnectMssql:DbContext
    {
        public ConnectMssql(DbContextOptions<ConnectMssql> options) : base(options)
        {
        }
        public DbSet<Code> codes { get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Code>().HasIndex(x => x.code).IsUnique();
        }

    }
}
