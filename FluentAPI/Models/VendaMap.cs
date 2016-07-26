using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace FluentAPI.Models
{
    public class VendaMap : EntityTypeConfiguration<Venda>
    {
        public VendaMap()
        {
            this.HasKey(v => v.venda_id);

            this.Property(v => v.status_venda).HasMaxLength(1); 
             
            this.ToTable("tb_venda", "DB_Vendas_Fluent");

            this.HasRequired(v => v.Cliente).WithMany(v => v.Vendas)
                .HasForeignKey(v => v.cliente_id);
        }


    }
}