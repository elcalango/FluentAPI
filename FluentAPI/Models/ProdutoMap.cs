using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace FluentAPI.Models
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            this.HasKey(p => p.produto_id);

            this.Property(p => p.nome).HasMaxLength(50);
             
            this.ToTable("tb_produto", "DB_Vendas_Fluent");
        }


    }
}