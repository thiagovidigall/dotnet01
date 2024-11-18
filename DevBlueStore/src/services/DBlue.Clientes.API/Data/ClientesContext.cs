using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DBlue.Clientes.API.Models;
using DBlue.Core.Data;
using DBlue.Core.DomainObjects;

namespace DBlue.Clientes.API.Data
{
    public sealed class ClientesContext : DbContext, IUnitOfWork
    {

        public ClientesContext(DbContextOptions<ClientesContext> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Ignore<Event>();
            //modelBuilder.Entity<Cliente>()
            //    .Ignore(c => c.Cpf);

            //modelBuilder.Entity<Cliente>()
            //    .Ignore(c => c.Email);

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            modelBuilder.Entity<Cpf>().HasNoKey();

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ClientesContext).Assembly);
        }

        public async Task<bool> Commit()
        {
            var sucesso = await base.SaveChangesAsync() > 0;

            return sucesso;
        }
    }
}