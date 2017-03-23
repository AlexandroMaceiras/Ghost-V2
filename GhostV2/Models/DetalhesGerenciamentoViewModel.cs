
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace GhostV2.Models
{
    public class DetalhesGerenciamentoViewModel
    {
        [Key]
        public int NR_CARGA { get; set; }

        //public int NR_CARGA_B { get; set; } 

        [StringLength(14)]
        public string CD_CPF_CNPJ { get; set; }

        [StringLength(1)]
        public string SG_TP_PESSOA { get; set; }

        [StringLength(70)]
        public string NM_PESSOA { get; set; }

        [StringLength(40)]
        public string NM_GRUPO_ECONOMICO { get; set; }

        [StringLength(50)]
        public string NM_LOGRADOURO { get; set; }

        [StringLength(5)]
        public string NR_LOGRADOURO { get; set; }

        [StringLength(20)]
        public string NM_COMPLEMENTO { get; set; }

        [StringLength(50)]
        public string NM_BAIRRO { get; set; }

        [StringLength(50)]
        public string NM_CIDADE { get; set; }

        [StringLength(2)]
        public string SG_UF { get; set; }

        [StringLength(8)]
        public string CD_CEP { get; set; }

        [StringLength(15)]
        public string NM_PAIS { get; set; }

        public int? NR_DDD { get; set; }

        public int? NR_TELEFONE { get; set; }

        public int? NR_DDD_CELULAR { get; set; }

        public int? NR_CELULAR { get; set; }

        [StringLength(60)]
        public string NM_EMAIL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_NASCIMENTO_OU_FUNDACAO { get; set; }

        [StringLength(30)]
        public string NM_CONTATO { get; set; }

        [StringLength(15)]
        public string NR_RG { get; set; }

        [StringLength(6)]
        public string NM_EMISSOR_RG { get; set; }

        [StringLength(20)]
        public string DS_NATURALIDADE { get; set; }

        [StringLength(25)]
        public string DS_NACIONALIDADE { get; set; }

        [StringLength(70)]
        public string NM_PAI { get; set; }

        [StringLength(70)]
        public string NM_MAE { get; set; }

        [StringLength(70)]
        public string NM_CONJUGE { get; set; }

        [StringLength(1)]
        public string CD_ESTADO_CIVIL { get; set; }

        [StringLength(11)]
        public string DS_ESTADO_CIVIL { get; set; }

        [StringLength(2)]
        public string CD_REGIME_CIVIL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_CADASTRO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_ATUALIZACAO { get; set; }





        [StringLength(14)]
        public string CD_CPF_CNPJ_SOCIO { get; set; }

        [StringLength(2)]
        public string PF_PJ_PESSOA_SOCIO { get; set; }

        public int? CD_SOLVERE_OPER_SOCIO { get; set; }

        [StringLength(60)]
        public string DS_PAPEL_SOCIO { get; set; }

        [StringLength(14)]
        public string CD_CPF_CNPJ_PESSOA { get; set; }

        [StringLength(70)]
        public string NM_SOCIO { get; set; }

        [StringLength(1)]
        public string SG_TP_PESSOA_SOCIO { get; set; }

        public int? NR_DDD_SOCIO { get; set; }

        public int? NR_TELEFONE_SOCIO { get; set; }

        public int? NR_DDD_CELULAR_SOCIO { get; set; }

        public int? NR_CELULAR_SOCIO { get; set; }

        [StringLength(60)]
        public string NM_EMAIL_SOCIO { get; set; }

        [StringLength(30)]
        public string NM_CONTATO_SOCIO { get; set; }

        [StringLength(30)]
        public string NM_GRUPO_ECONOMICO_SOCIO { get; set; }

        [StringLength(70)]
        public string NM_CONJUGE_SOCIO { get; set; }

        [StringLength(50)]
        public string NM_LOGRADOURO_SOCIO { get; set; }

        [StringLength(5)]
        public string NR_LOGRADOURO_SOCIO { get; set; }

        [StringLength(20)]
        public string NM_COMPLEMENTO_SOCIO { get; set; }

        [StringLength(50)]
        public string NM_BAIRRO_SOCIO { get; set; }

        [StringLength(50)]
        public string NM_CIDADE_SOCIO { get; set; }

        [StringLength(2)]
        public string SG_UF_SOCIO { get; set; }

        [StringLength(15)]
        public string NM_PAIS_SOCIO { get; set; }




        public DateTime? DT_PROCESSAMENTO { get; set; }

        [StringLength(38)]
        public string CD_CHAVE_KOPE_IMOVEIS { get; set; }

        public int? CD_SOLVERE_GARA { get; set; }

        public int? CD_SOLVERE_OPER { get; set; }

        public int? NR_SEQ_GARA { get; set; }

        [StringLength(20)]
        public string DS_TP_GRAVAME { get; set; }

        [StringLength(50)]
        public string CD_GRAU_HIPOTECA { get; set; }

        [StringLength(20)]
        public string NR_MATRICULA { get; set; }

        [StringLength(20)]
        public string NR_CARTORIO_REGISTRO { get; set; }

        [StringLength(50)]
        public string NM_CARTORIO_REGISTRO { get; set; }

        [StringLength(8)]
        public string CD_CEP_IMOV { get; set; }

        [StringLength(100)]
        public string NM_LOGRADOURO_IMOV { get; set; }

        [StringLength(30)]
        public string NR_LOGRADOURO_IMOV { get; set; }

        [StringLength(30)]
        public string NM_COMPLEMENTO_IMOV { get; set; }

        [StringLength(50)]
        public string NM_BAIRRO_IMOV { get; set; }

        [StringLength(50)]
        public string NM_CIDADE_IMOV { get; set; }

        [StringLength(2)]
        public string SG_UF_IMOV { get; set; }

        [StringLength(20)]
        public string CD_TIPO_IMOVEL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VL_AREA { get; set; }

        [StringLength(25)]
        public string NR_IPTU { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VL_REGISTRO_MATRICULA { get; set; }

        [StringLength(300)]
        public string DS_OBSERVACOES_IMOV { get; set; }

        [StringLength(1)]
        public string IC_PESQUISA_REALIZADA { get; set; }

        [StringLength(100)]
        public string DS_PESQUISA_DETALHES { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_PESQUISA { get; set; }

        [StringLength(1)]
        public string IC_IMOVEL_FORMALIZADO { get; set; }

        [StringLength(100)]
        public string DS_IMOVEL_FORMALIZADO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_IMOVEL_FORMALIZADO { get; set; }

        [StringLength(1)]
        public string IC_IMOVEL_TOMADO { get; set; }

        [StringLength(100)]
        public string DS_IMOVEL_TOMADO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_IMOVEL_TOMADO { get; set; }

        [StringLength(1)]
        public string IC_IMOVEL_VENDIDO_BAIXADO { get; set; }

        [StringLength(100)]
        public string DS_IMOVEL_VENDIDO_BAIXADO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_IMOVEL_VENDIDO_BAIXADO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_AVALIACAO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VL_GARANTIA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VL_VENDA_FORCADA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VL_VENDA_MERCADO { get; set; }

        [StringLength(14)]
        public string CD_CPF_CNPJ_IMOV { get; set; }

        [StringLength(1)]
        public string SG_TP_PESSOA_IMOV { get; set; }






        public DateTime? DT_CARGA { get; set; }

        public DateTime? DT_PROCESSAMENTO_MAQ { get; set; }

        [StringLength(38)]
        public string CD_CHAVE_KOPE_VEICULOS { get; set; }

        [StringLength(38)]
        public string CD_CHAVE_KOPE_MAQUINA { get; set; }

        public int? CD_SOLVERE_GARA_MAQ { get; set; }

        public int? CD_SOLVERE_OPER_MAQ { get; set; }

        public int? NR_SEQ_GARA_MAQ { get; set; }

        [StringLength(20)]
        public string NR_CHASSI { get; set; }

        [StringLength(2)]
        public string CD_TIPO_CHASSI { get; set; }

        [StringLength(2)]
        public string SG_UF_LICENCIAMENTO { get; set; }

        [StringLength(2)]
        public string SG_UF_PLACA { get; set; }

        [StringLength(7)]
        public string NR_PLACA { get; set; }

        [StringLength(11)]
        public string NR_RENAVAM { get; set; }

        public int? NR_ANO_FABRICACAO { get; set; }

        public int? NR_ANO_MODELO { get; set; }

        [StringLength(1)]
        public string CD_TP_GRAVAME { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_GRAVAME { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_BAIXA_GRAVAME { get; set; }

        [StringLength(70)]
        public string DS_MODELO { get; set; }

        [StringLength(30)]
        public string DS_MARCA { get; set; }

        [StringLength(30)]
        public string DS_COR { get; set; }

        [StringLength(30)]
        public string DS_COMBUSTIVEL { get; set; }

        [StringLength(100)]
        public string DS_VEICULO_MAQUINA { get; set; }

        [StringLength(30)]
        public string NR_SERIE { get; set; }

        [StringLength(50)]
        public string DS_FABRICANTE { get; set; }

        [StringLength(20)]
        public string DS_TIPO_BEM { get; set; }

        [StringLength(300)]
        public string DS_OBSERVACOES_GERAIS_MAQ { get; set; }

        [StringLength(1)]
        public string IC_PESQUISA_REALIZADA_MAQ { get; set; }

        [StringLength(200)]
        public string DS_PESQUISA_DETALHES_MAQ { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_PESQUISA_MAQ { get; set; }

        [StringLength(1)]
        public string IC_BEM_FORMALIZADO { get; set; }

        [StringLength(100)]
        public string DS_BEM_FORMALIZADO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_BEM_FORMALIZADO { get; set; }

        [StringLength(1)]
        public string IC_BEM_TOMADO { get; set; }

        [StringLength(100)]
        public string DS_BEM_TOMADO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_BEM_TOMADO { get; set; }

        [StringLength(1)]
        public string IC_BEM_VENDIDO { get; set; }

        [StringLength(100)]
        public string DS_BEM_VENDIDO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_BEM_VENDIDO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VL_GARANTIA_MAQ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VL_MOLICAR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VL_FORCADA { get; set; }

        [StringLength(10)]
        public string CD_MOLICAR { get; set; }

        [StringLength(14)]
        public string CD_CPF_CNPJ_MAQ { get; set; }

        [StringLength(1)]
        public string SG_TP_PESSOA_MAQ { get; set; }

        [StringLength(1)]
        public string IC_GARANTIA { get; set; }

        public int? QT_MAQUINAS { get; set; }
    } 
}