using Microsoft.EntityFrameworkCore;

namespace OTP_Generator.Model.data
{
    public class OtpDbContext : DbContext
    {
        public OtpDbContext(DbContextOptions<OtpDbContext> options) : base(options)
         {

        }

        public DbSet<User> Users { get; set; }
    }
}
