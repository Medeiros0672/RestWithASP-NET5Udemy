using Microsoft.EntityFrameworkCore;


namespace RestWithASPNETU5demy.Models.Context
{
    public class OracleContext : DbContext
    {
        public OracleContext()
        {
        }

        public OracleContext(DbContextOptions<OracleContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
    }
}
