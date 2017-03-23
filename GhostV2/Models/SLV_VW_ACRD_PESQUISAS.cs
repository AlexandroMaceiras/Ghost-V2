namespace GhostV2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SLV_VW_ACRD_PESQUISAS
    {
        public long? NR_SEQ { get; set; }

        [StringLength(14)]
        public string CD_CPF_CNPJ { get; set; }


        [StringLength(8)]
        public string TIPO_PESSOA { get; set; }

        [StringLength(50)]
        public string NM_CLIENTE { get; set; }

        [StringLength(50)]
        public string NM_GRUPO_ECONOMICO { get; set; }

        [StringLength(30)]
        public string NR_OPERACAO { get; set; }

        [StringLength(39)]
        public string NM_GESTOR { get; set; }

        [StringLength(10)]
        public string CD_CAUSA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_ULTIMO_ANDAMENTO { get; set; }

        [StringLength(600)]
        public string NM_ESCRITORIO_COBRANCA { get; set; }

        [StringLength(30)]
        public string NR_PROCESSO { get; set; }

        [StringLength(50)]
        public string NR_CONTRATO { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CD_SOLVERE_OPER { get; set; }

        [StringLength(50)]
        public string TP_CONTRATO { get; set; }

        public int? CD_ACORDO { get; set; }

        [StringLength(50)]
        public string SG_TP_ACORDO { get; set; }

        [StringLength(50)]
        public string SG_TP_INSTRUMENTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_ACORDO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VL_ACORDO { get; set; }

        public int? QT_PARCELAS_TOTAL { get; set; }

        //public int? QT_PARCELAS_PAGAS { get; set; }

        [StringLength(1)]
        public string IC_STATUS_ACORDO { get; set; }
    }
}
