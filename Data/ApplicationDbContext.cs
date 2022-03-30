using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NdihmesTagLaborator.Models;
namespace NdihmesTagLaborator.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Evente> Eventet { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}