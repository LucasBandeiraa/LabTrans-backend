using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        } 
        public DbSet<User> Users {get; set;}
        public DbSet<Wallet> Wallets {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.CPF)
                .IsUnique();

            modelBuilder.Entity<Wallet>(entity =>
            {
                entity.ToTable("Wallets");
                entity.HasKey(w => w.Id); //primary key
                entity.Property(w => w.ValorAtual).HasColumnType("decimal(18,2)");
                entity.Property(w => w.UltimaAtualizacao).HasDefaultValueSql("GETDATE()"); // Data padrão
            });
        }
    }
}
