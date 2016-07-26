using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FluentAPI.Models
{
    public class DB_Vendas_Fluent : DbContext
    {
        static DB_Vendas_Fluent()
        {
            Database.SetInitializer<DB_Vendas_Fluent>(null);
        }

        public DB_Vendas_Fluent()
            : base("Name=DB_Vendas_Fluent")
        {

        }

        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Produto> produto { get; set; }
        public DbSet<Venda> venda { get; set; }
        public DbSet<ItemVenda> item_venda { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new ItemVendaMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new VendaMap());
        }
    }
}