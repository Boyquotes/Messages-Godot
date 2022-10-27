using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class UsersContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "server=localhost;database=Direct-Messages;user=sa;password=una_contra_segura_123");
        }
    }

    public class Users
    {
        public int UserId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}