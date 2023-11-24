namespace AchadosPerdidos.Winform
{
    partial class fHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.achadosEPerdidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlHome = new System.Windows.Forms.Panel();
			this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.achadosEPerdidosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(801, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// achadosEPerdidosToolStripMenuItem
			// 
			this.achadosEPerdidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.estoqueToolStripMenuItem});
			this.achadosEPerdidosToolStripMenuItem.Name = "achadosEPerdidosToolStripMenuItem";
			this.achadosEPerdidosToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
			this.achadosEPerdidosToolStripMenuItem.Text = "Achados e Perdidos";
			// 
			// cadastrarToolStripMenuItem
			// 
			this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
			this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.cadastrarToolStripMenuItem.Text = "Cadastrar";
			this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
			// 
			// estoqueToolStripMenuItem
			// 
			this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
			this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.estoqueToolStripMenuItem.Text = "Estoque";
			// 
			// pnlHome
			// 
			this.pnlHome.Location = new System.Drawing.Point(0, 27);
			this.pnlHome.Name = "pnlHome";
			this.pnlHome.Size = new System.Drawing.Size(800, 396);
			this.pnlHome.TabIndex = 1;
			// 
			// estoqueToolStripMenuItem
			// 
			this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
			this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.estoqueToolStripMenuItem.Text = "Estoque";
			// 
			// fHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(801, 424);
			this.Controls.Add(this.pnlHome);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "fHome";
			this.Text = "DK Solutions";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem achadosEPerdidosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
		private System.Windows.Forms.Panel pnlHome;
	}
}

