namespace AchadosPerdidos.Winform.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cor")]
    public partial class CorData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCor { get; set; }

        [Required]
        [StringLength(50)]
        public string Descricao { get; set; }
    }
}
