using DataEntryApplication.Server.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataEntryApplication.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<CMD1> CMD1 { get; set; }
        public virtual DbSet<CMD2> CMD2 { get; set; }
        public virtual DbSet<CMD3Label1> CMD3Label1 { get; set; }
        public virtual DbSet<CMD3Lable3> CMD3Label3 { get; set; }
    }
}
