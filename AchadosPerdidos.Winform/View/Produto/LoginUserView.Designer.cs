namespace AchadosPerdidos.Winform.View
{
    partial class LoginUserView
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
			this.btnEntrarLogin = new System.Windows.Forms.Button();
			this.btnSairLogin = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txbLoginUser = new System.Windows.Forms.TextBox();
			this.txbSenhaUser = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblGetUsuario = new System.Windows.Forms.Label();
			this.lblGetUsername = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnEntrarLogin
			// 
			this.btnEntrarLogin.Location = new System.Drawing.Point(7, 108);
			this.btnEntrarLogin.Name = "btnEntrarLogin";
			this.btnEntrarLogin.Size = new System.Drawing.Size(75, 23);
			this.btnEntrarLogin.TabIndex = 0;
			this.btnEntrarLogin.Text = "Entrar";
			this.btnEntrarLogin.UseVisualStyleBackColor = true;
			this.btnEntrarLogin.Click += new System.EventHandler(this.btnEntrarLogin_Click);
			// 
			// btnSairLogin
			// 
			this.btnSairLogin.Location = new System.Drawing.Point(98, 108);
			this.btnSairLogin.Name = "btnSairLogin";
			this.btnSairLogin.Size = new System.Drawing.Size(75, 23);
			this.btnSairLogin.TabIndex = 1;
			this.btnSairLogin.Text = "Sair";
			this.btnSairLogin.UseVisualStyleBackColor = true;
			this.btnSairLogin.Click += new System.EventHandler(this.btnSairLogin_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Login:";
			// 
			// txbLoginUser
			// 
			this.txbLoginUser.Location = new System.Drawing.Point(7, 30);
			this.txbLoginUser.Name = "txbLoginUser";
			this.txbLoginUser.Size = new System.Drawing.Size(167, 20);
			this.txbLoginUser.TabIndex = 3;
			// 
			// txbSenhaUser
			// 
			this.txbSenhaUser.Location = new System.Drawing.Point(6, 76);
			this.txbSenhaUser.Name = "txbSenhaUser";
			this.txbSenhaUser.PasswordChar = '*';
			this.txbSenhaUser.Size = new System.Drawing.Size(167, 20);
			this.txbSenhaUser.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Senha:";
			// 
			// lblGetUsuario
			// 
			this.lblGetUsuario.AutoSize = true;
			this.lblGetUsuario.Location = new System.Drawing.Point(4, 1);
			this.lblGetUsuario.Name = "lblGetUsuario";
			this.lblGetUsuario.Size = new System.Drawing.Size(46, 13);
			this.lblGetUsuario.TabIndex = 6;
			this.lblGetUsuario.Text = "Usuario:";
			// 
			// lblGetUsername
			// 
			this.lblGetUsername.AutoSize = true;
			this.lblGetUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGetUsername.Location = new System.Drawing.Point(-1, 19);
			this.lblGetUsername.Name = "lblGetUsername";
			this.lblGetUsername.Size = new System.Drawing.Size(183, 31);
			this.lblGetUsername.TabIndex = 7;
			this.lblGetUsername.Text = "GetUsername";
			// 
			// LoginUserView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txbSenhaUser);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txbLoginUser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSairLogin);
			this.Controls.Add(this.btnEntrarLogin);
			this.Controls.Add(this.lblGetUsername);
			this.Controls.Add(this.lblGetUsuario);
			this.Name = "LoginUserView";
			this.Size = new System.Drawing.Size(182, 139);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrarLogin;
        private System.Windows.Forms.Button btnSairLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbLoginUser;
        private System.Windows.Forms.TextBox txbSenhaUser;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblGetUsuario;
		private System.Windows.Forms.Label lblGetUsername;
	}
}
