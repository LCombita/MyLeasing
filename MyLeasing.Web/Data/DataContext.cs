using Microsoft.EntityFrameworkCore;
using MyLeasing.Web.Data.Entities;

//To register the models of database, and generate conection' context
namespace MyLeasing.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }
    }
}
