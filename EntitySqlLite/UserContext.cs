using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitySqlLite
{
    class UserContext: DbContext
    {

        public DbSet<User> Users { get; set; }

        public UserContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Users2.db");
        }
    }
}
