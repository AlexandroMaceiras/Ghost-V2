namespace GhostV2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AcordosViewContexto : DbContext
    {
        public AcordosViewContexto()
            : base("name=GerenciamentoConexao")
        {
        }

        public virtual DbSet<SLV_VW_ACRD_PESQUISAS> SLV_VW_ACRD_PESQUISAS { get; set; }
        public virtual DbSet<SLV_TB_FIN_GARA_IMOVEIS> SLV_TB_FIN_GARA_IMOVEIS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SLV_VW_ACRD_PESQUISAS>()
                .Property(e => e.CD_CPF_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_ACRD_PESQUISAS>()
                .Property(e => e.TIPO_PESSOA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_ACRD_PESQUISAS>()
                .Property(e => e.NM_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_ACRD_PESQUISAS>()
                .Property(e => e.NM_GRUPO_ECONOMICO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_ACRD_PESQUISAS>()
                .Property(e => e.NR_OPERACAO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_ACRD_PESQUISAS>()
                .Property(e => e.NM_GESTOR)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_ACRD_PESQUISAS>()
                .Property(e => e.CD_CAUSA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_ACRD_PESQUISAS>()
                .Property(e => e.NM_ESCRITORIO_COBRANCA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_ACRD_PESQUISAS>()
                .Property(e => e.NR_PROCESSO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_ACRD_PESQUISAS>()
                .Property(e => e.NR_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_ACRD_PESQUISAS>()
                .Property(e => e.TP_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_ACRD_PESQUISAS>()
                .Property(e => e.SG_TP_ACORDO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_ACRD_PESQUISAS>()
                .Property(e => e.SG_TP_INSTRUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_ACRD_PESQUISAS>()
                .Property(e => e.IC_STATUS_ACORDO)
                .IsFixedLength()
                .IsUnicode(false);
        }


    }
}
