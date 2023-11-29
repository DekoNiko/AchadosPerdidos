namespace AchadosPerdidos.Winform.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Setor")]
    public partial class SetorData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdSetor { get; set; }

        [Required]
        [StringLength(50)]
        public string Descricao { get; set; }
    }
}
