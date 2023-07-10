using Loteria.Server.Service;
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
        public DbSet<Shared.Code> codes { get; set; }
        public DbSet<Shared.User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Shared.Code>().HasIndex(x => x.code).IsUnique();
            modelBuilder.Entity<Shared.User>().HasIndex(x => x.Code).IsUnique();
        }

    }
}
