using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using AchadosPerdidos.Winform.Data.Model;

namespace AchadosPerdidos.Winform.Data.Context
{
	public partial class AchadosPerdidosContext : DbContext
	{
		public AchadosPerdidosContext()
			: base("name=AchadosPerdidosContext")
		{
		}

		public virtual DbSet<CorData> Cor { get; set; }
		public virtual DbSet<ProdutoData> Produto { get; set; }
		public virtual DbSet<SetorData> Setor { get; set; }
		public virtual DbSet<UsuarioData> Usuario { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			
		}
	}
}
