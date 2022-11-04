using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data
{
    public class LabTransContext : DbContext
    {
        public LabTransContext(DbContextOptions<LabTransContext> options) : base(options)
        {
        } 
        public DbSet<User> Users {get; set;}
        public DbSet<Reserva> Reserva {get; set;}
    }
}
