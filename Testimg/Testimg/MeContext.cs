using System.Data.Entity;

namespace Testing
{
    public class MeContext : DbContext
    {
        public MeContext() : base("Data Source = (localdb)MSSQLLocalDB; Initial Catalog = DbTest; Integrated Security = True")
        {  
        }

        public DbSet<Video> Videos { get; set; }
    }
}