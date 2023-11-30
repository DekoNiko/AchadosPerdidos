namespace AchadosPerdidos.Winform.Data.Model
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.Spatial;

	[Table("Produto")]
	public partial class ProdutoData
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int IdProduto { get; set; }

		[Required]
		[StringLength(50)]
		public string Descricao { get; set; }

		public int IdCor { get; set; }

		public int IdSetor { get; set; }

		public DateTime DtCriacao { get; set; }

		public int IdUsuarioCriacao { get; set; }

		[ForeignKey("IdCor")]
		public virtual CorData Cor { get; set; }

		[ForeignKey("IdSetor")]
		public virtual SetorData Setor { get; set; }
		
		[ForeignKey("IdUsuarioCriacao")]
		public virtual UsuarioData Usuario { get; set; }
	}
}
