namespace GhostV2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SLV_TB_FIN_GARA_VEIC_MAQ
    {
        [Key]
        public int NR_CARGA { get; set; }

        public DateTime? DT_CARGA { get; set; }

        public DateTime? DT_PROCESSAMENTO { get; set; }

        [StringLength(38)]
        public string CD_CHAVE_KOPE_VEICULOS { get; set; }

        [StringLength(38)]
        public string CD_CHAVE_KOPE_MAQUINA { get; set; }

        public int? CD_SOLVERE_GARA { get; set; }

        public int? CD_SOLVERE_OPER { get; set; }

        public int? NR_SEQ_GARA { get; set; }

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
        public string DS_OBSERVACOES_GERAIS { get; set; }

        [StringLength(1)]
        public string IC_PESQUISA_REALIZADA { get; set; }

        [StringLength(200)]
        public string DS_PESQUISA_DETALHES { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_PESQUISA { get; set; }

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
        public decimal? VL_GARANTIA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VL_MOLICAR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VL_FORCADA { get; set; }

        [StringLength(10)]
        public string CD_MOLICAR { get; set; }

        [StringLength(14)]
        public string CD_CPF_CNPJ { get; set; }

        [StringLength(1)]
        public string SG_TP_PESSOA { get; set; }

        [StringLength(1)]
        public string IC_GARANTIA { get; set; }

        public int? QT_MAQUINAS { get; set; }
    }
}
