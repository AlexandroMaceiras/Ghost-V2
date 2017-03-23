namespace GhostV2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GerenciamentoViewContexto : DbContext
    {
        public GerenciamentoViewContexto()
            : base("name=GerenciamentoConexao")
        {
        }

        public virtual DbSet<SLV_VW_GERE_DADOS_CADASTRAIS> SLV_VW_GERE_DADOS_CADASTRAIS { get; set; }
        public virtual DbSet<SLV_VW_GERE_PROCESSOS> SLV_VW_GERE_PROCESSOS { get; set; }
        public virtual DbSet<SLV_TB_FIN_GARA_IMOVEIS> SLV_TB_FIN_GARA_IMOVEIS { get; set; }
        public virtual DbSet<SLV_TB_FIN_GARA_VEIC_MAQ> SLV_TB_FIN_GARA_VEIC_MAQ { get; set; }
        public virtual DbSet<SLV_TB_FIN_GERE_SOCIOS> SLV_TB_FIN_GERE_SOCIOS { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.CD_CPF_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.SG_TP_PESSOA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.NM_PESSOA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.NM_GRUPO_ECONOMICO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.NM_LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.NR_LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.NM_COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.NM_BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.NM_CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.SG_UF)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.CD_CEP)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.NM_PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.NM_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.NM_CONTATO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.NR_RG)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.NM_EMISSOR_RG)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.DS_NATURALIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.DS_NACIONALIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.NM_PAI)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.NM_MAE)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.NM_CONJUGE)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.CD_ESTADO_CIVIL)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.DS_ESTADO_CIVIL)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_DADOS_CADASTRAIS>()
                .Property(e => e.CD_REGIME_CIVIL)
                .IsUnicode(false);





            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.CD_CPF_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.SG_TP_PESSOA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.NM_PESSOA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.CD_CAUSA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.NR_PROCESSO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.NR_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.NM_ESCRITORIO_COBRANCA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.IC_STATUS_PROCESSUAL)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.IC_STATUS_OPERACIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.NM_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.NM_GRUPO_ECONOMICO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_VW_GERE_PROCESSOS>()
                .Property(e => e.CD_CARTEIRA)
                .IsUnicode(false);





            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.CD_CHAVE_KOPE_IMOVEIS)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.DS_TP_GRAVAME)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.CD_GRAU_HIPOTECA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.NR_MATRICULA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.NR_CARTORIO_REGISTRO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.NM_CARTORIO_REGISTRO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.CD_CEP)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.NM_LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.NR_LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.NM_COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.NM_BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.NM_CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.SG_UF)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.CD_TIPO_IMOVEL)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.VL_AREA)
                .HasPrecision(5, 2);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.NR_IPTU)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.DS_OBSERVACOES)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.IC_PESQUISA_REALIZADA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.DS_PESQUISA_DETALHES)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.IC_IMOVEL_FORMALIZADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.DS_IMOVEL_FORMALIZADO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.IC_IMOVEL_TOMADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.DS_IMOVEL_TOMADO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.IC_IMOVEL_VENDIDO_BAIXADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.DS_IMOVEL_VENDIDO_BAIXADO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.CD_CPF_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_IMOVEIS>()
                .Property(e => e.SG_TP_PESSOA)
                .IsFixedLength()
                .IsUnicode(false);







            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.CD_CHAVE_KOPE_VEICULOS)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.CD_CHAVE_KOPE_MAQUINA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.NR_CHASSI)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.CD_TIPO_CHASSI)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.SG_UF_LICENCIAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.SG_UF_PLACA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.NR_PLACA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.NR_RENAVAM)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.CD_TP_GRAVAME)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.DS_MODELO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.DS_MARCA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.DS_COR)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.DS_COMBUSTIVEL)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.DS_VEICULO_MAQUINA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.NR_SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.DS_FABRICANTE)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.DS_TIPO_BEM)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.DS_OBSERVACOES_GERAIS)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.IC_PESQUISA_REALIZADA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.DS_PESQUISA_DETALHES)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.IC_BEM_FORMALIZADO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.DS_BEM_FORMALIZADO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.IC_BEM_TOMADO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.DS_BEM_TOMADO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.IC_BEM_VENDIDO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.DS_BEM_VENDIDO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.CD_MOLICAR)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.CD_CPF_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.SG_TP_PESSOA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GARA_VEIC_MAQ>()
                .Property(e => e.IC_GARANTIA)
                .IsFixedLength()
                .IsUnicode(false);






            modelBuilder.Entity<SLV_TB_FIN_GERE_SOCIOS>()
                .Property(e => e.CD_CPF_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GERE_SOCIOS>()
                .Property(e => e.SG_TP_PESSOA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GERE_SOCIOS>()
                .Property(e => e.CD_CPF_CNPJ_PESSOA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GERE_SOCIOS>()
                .Property(e => e.PF_PJ_PESSOA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GERE_SOCIOS>()
                .Property(e => e.DS_PAPEL)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GERE_SOCIOS>()
                .Property(e => e.NM_PESSOA)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GERE_SOCIOS>()
                .Property(e => e.NM_EMAIL_SOCIO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GERE_SOCIOS>()
                .Property(e => e.NM_CONTATO_SOCIO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GERE_SOCIOS>()
                .Property(e => e.NM_GRUPO_ECONOMICO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GERE_SOCIOS>()
                .Property(e => e.NM_CONJUGE)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GERE_SOCIOS>()
                .Property(e => e.NM_LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GERE_SOCIOS>()
                .Property(e => e.NR_LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GERE_SOCIOS>()
                .Property(e => e.NM_COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GERE_SOCIOS>()
                .Property(e => e.NM_BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GERE_SOCIOS>()
                .Property(e => e.NM_CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GERE_SOCIOS>()
                .Property(e => e.SG_UF)
                .IsUnicode(false);

            modelBuilder.Entity<SLV_TB_FIN_GERE_SOCIOS>()
                .Property(e => e.NM_PAIS)
                .IsUnicode(false);
        }        
    }
}
