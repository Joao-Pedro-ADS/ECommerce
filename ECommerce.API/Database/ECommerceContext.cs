using Microsoft.EntityFrameworkCore;

namespace ECommerce.API.Database
{
    
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        {
                
        }

        /* propriedade que representa a tabela Usuarios no banco de dados
         * public DbSet<genérico que vai gerar a tabela> nome da tabela no banco de dados{ get; set; }
         */

        public DbSet<Usuario> Usuarios { get; set; }
        
        public DbSet<Contato> Contatos { get; set; }
        
        public DbSet<EnderecoEntrega> EnderecosEntrega { get; set; }
        
        public DbSet<Departamento> Departamentos { get; set; }

        #region ECommerceContext conexão sem distinção de ambientes
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ECommerce;Integrated Security=True;");
        }
        #endregion

    }

}
