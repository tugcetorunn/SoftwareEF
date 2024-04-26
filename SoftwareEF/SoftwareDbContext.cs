using System.Data.Entity;

namespace SoftwareEF
{
    public class SoftwareDbContext : DbContext
    {
        public SoftwareDbContext() : base("SoftwareConnStr")
        {
            
        }

        public virtual DbSet<SoftwareList> SoftwareList { get; set; }
    }
}
