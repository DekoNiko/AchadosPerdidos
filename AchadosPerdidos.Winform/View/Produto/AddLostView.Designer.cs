namespace AchadosPerdidos.Winform.View
{
	partial class AddLostView
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ckbNovoitem = new System.Windows.Forms.CheckBox();
			this.txbObs = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txbEntregador = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cbxSetor = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxMaterial = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbxCor = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txbProduto = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnDescartar = new System.Windows.Forms.Button();
			this.pnlImagem = new System.Windows.Forms.Panel();
			this.pnlArquivoLoad = new System.Windows.Forms.Panel();
			this.txbRegistro = new System.Windows.Forms.TextBox();
			this.txbUsuario = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ckbNovoitem);
			this.groupBox1.Controls.Add(this.txbObs);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txbEntregador);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.cbxSetor);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.cbxMaterial);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cbxCor);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txbProduto);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(3, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(266, 346);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Cadastro";
			// 
			// ckbNovoitem
			// 
			this.ckbNovoitem.AutoSize = true;
			this.ckbNovoitem.Location = new System.Drawing.Point(135, 8);
			this.ckbNovoitem.Name = "ckbNovoitem";
			this.ckbNovoitem.Size = new System.Drawing.Size(75, 17);
			this.ckbNovoitem.TabIndex = 12;
			this.ckbNovoitem.Text = "Novo Item";
			this.ckbNovoitem.UseVisualStyleBackColor = true;
			this.ckbNovoitem.CheckedChanged += new System.EventHandler(this.ckbNovoitem_CheckedChanged);
			// 
			// txbObs
			// 
			this.txbObs.Location = new System.Drawing.Point(9, 308);
			this.txbObs.Name = "txbObs";
			this.txbObs.Size = new System.Drawing.Size(251, 20);
			this.txbObs.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 292);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "Obs.:";
			// 
			// txbEntregador
			// 
			this.txbEntregador.Location = new System.Drawing.Point(9, 198);
			this.txbEntregador.Name = "txbEntregador";
			this.txbEntregador.Size = new System.Drawing.Size(174, 20);
			this.txbEntregador.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 182);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 13);
			this.label7.TabIndex = 8;
			this.label7.Text = "Entregue por:";
			// 
			// cbxSetor
			// 
			this.cbxSetor.FormattingEnabled = true;
			this.cbxSetor.Location = new System.Drawing.Point(9, 159);
			this.cbxSetor.Name = "cbxSetor";
			this.cbxSetor.Size = new System.Drawing.Size(121, 21);
			this.cbxSetor.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 143);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Local:";
			// 
			// cbxMaterial
			// 
			this.cbxMaterial.FormattingEnabled = true;
			this.cbxMaterial.Location = new System.Drawing.Point(9, 119);
			this.cbxMaterial.Name = "cbxMaterial";
			this.cbxMaterial.Size = new System.Drawing.Size(121, 21);
			this.cbxMaterial.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 103);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Material:";
			// 
			// cbxCor
			// 
			this.cbxCor.FormattingEnabled = true;
			this.cbxCor.Location = new System.Drawing.Point(9, 80);
			this.cbxCor.Name = "cbxCor";
			this.cbxCor.Size = new System.Drawing.Size(121, 21);
			this.cbxCor.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Cor predominante:";
			// 
			// txbProduto
			// 
			this.txbProduto.Location = new System.Drawing.Point(9, 41);
			this.txbProduto.Name = "txbProduto";
			this.txbProduto.Size = new System.Drawing.Size(251, 20);
			this.txbProduto.TabIndex = 1;
			this.txbProduto.TextChanged += new System.EventHandler(this.txbProduto_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Produto:";
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(275, 362);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(100, 23);
			this.btnSalvar.TabIndex = 1;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			// 
			// btnDescartar
			// 
			this.btnDescartar.Location = new System.Drawing.Point(684, 362);
			this.btnDescartar.Name = "btnDescartar";
			this.btnDescartar.Size = new System.Drawing.Size(100, 23);
			this.btnDescartar.TabIndex = 2;
			this.btnDescartar.Text = "Descartar";
			this.btnDescartar.UseVisualStyleBackColor = true;
			// 
			// pnlImagem
			// 
			this.pnlImagem.Location = new System.Drawing.Point(275, 42);
			this.pnlImagem.Name = "pnlImagem";
			this.pnlImagem.Size = new System.Drawing.Size(509, 276);
			this.pnlImagem.TabIndex = 3;
			// 
			// pnlArquivoLoad
			// 
			this.pnlArquivoLoad.Location = new System.Drawing.Point(275, 324);
			this.pnlArquivoLoad.Name = "pnlArquivoLoad";
			this.pnlArquivoLoad.Size = new System.Drawing.Size(509, 32);
			this.pnlArquivoLoad.TabIndex = 4;
			// 
			// txbRegistro
			// 
			this.txbRegistro.Location = new System.Drawing.Point(292, 16);
			this.txbRegistro.Name = "txbRegistro";
			this.txbRegistro.Size = new System.Drawing.Size(100, 20);
			this.txbRegistro.TabIndex = 5;
			// 
			// txbUsuario
			// 
			this.txbUsuario.Location = new System.Drawing.Point(665, 16);
			this.txbUsuario.Name = "txbUsuario";
			this.txbUsuario.Size = new System.Drawing.Size(100, 20);
			this.txbUsuario.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(289, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Nº Registro";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(721, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Usuario";
			// 
			// AddLostView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txbUsuario);
			this.Controls.Add(this.txbRegistro);
			this.Controls.Add(this.pnlArquivoLoad);
			this.Controls.Add(this.pnlImagem);
			this.Controls.Add(this.btnDescartar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.groupBox1);
			this.Name = "AddLostView";
			this.Size = new System.Drawing.Size(800, 396);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnDescartar;
		private System.Windows.Forms.Panel pnlImagem;
		private System.Windows.Forms.Panel pnlArquivoLoad;
		private System.Windows.Forms.TextBox txbRegistro;
		private System.Windows.Forms.TextBox txbUsuario;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbObs;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txbEntregador;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbxSetor;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbxMaterial;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbxCor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txbProduto;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox ckbNovoitem;
	}
}
