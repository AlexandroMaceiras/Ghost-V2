namespace GhostV2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SLV_TB_FIN_GERE_SOCIOS
    {
        public long? NR_SEQ { get; set; }

        [Key]
        public DateTime DT_PROCESSAMENTO { get; set; }

        [StringLength(14)]
        public string CD_CPF_CNPJ { get; set; }

        [StringLength(1)]
        public string SG_TP_PESSOA { get; set; }

        [StringLength(14)]
        public string CD_CPF_CNPJ_PESSOA { get; set; }

        [StringLength(2)]
        public string PF_PJ_PESSOA { get; set; }

        public int? CD_SOLVERE_OPER { get; set; }

        public string DS_PAPEL { get; set; }

        [StringLength(70)]
        public string NM_PESSOA { get; set; }

        public int? NR_DDD { get; set; }

        public int? NR_TELEFONE { get; set; }

        public int? NR_DDD_CELULAR { get; set; }

        public int? NR_CELULAR { get; set; }

        [StringLength(60)]
        public string NM_EMAIL_SOCIO { get; set; }

        [StringLength(30)]
        public string NM_CONTATO_SOCIO { get; set; }

        [StringLength(40)]
        public string NM_GRUPO_ECONOMICO { get; set; }

        [StringLength(70)]
        public string NM_CONJUGE { get; set; }

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

        [StringLength(15)]
        public string NM_PAIS { get; set; }
    }
}
