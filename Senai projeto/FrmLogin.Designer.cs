namespace Senai_projeto
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRecuperarSenha = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnLogin = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtSenhalogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmailLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(126, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnRecuperarSenha
            // 
            this.btnRecuperarSenha.AutoSize = true;
            this.btnRecuperarSenha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRecuperarSenha.Depth = 0;
            this.btnRecuperarSenha.Location = new System.Drawing.Point(142, 479);
            this.btnRecuperarSenha.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRecuperarSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRecuperarSenha.Name = "btnRecuperarSenha";
            this.btnRecuperarSenha.Primary = false;
            this.btnRecuperarSenha.Size = new System.Drawing.Size(150, 36);
            this.btnRecuperarSenha.TabIndex = 5;
            this.btnRecuperarSenha.Text = "Recuperar a Senha";
            this.btnRecuperarSenha.UseVisualStyleBackColor = true;
            this.btnRecuperarSenha.Click += new System.EventHandler(this.btnRecuperarSenha_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.AutoSize = true;
            this.BtnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLogin.BackColor = System.Drawing.Color.Red;
            this.BtnLogin.Depth = 0;
            this.BtnLogin.ForeColor = System.Drawing.Color.Red;
            this.BtnLogin.Location = new System.Drawing.Point(106, 385);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Primary = false;
            this.BtnLogin.Size = new System.Drawing.Size(56, 36);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Logar ";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(78, 246);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(78, 322);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = true;
            this.btnRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrar.BackColor = System.Drawing.Color.Red;
            this.btnRegistrar.Depth = 0;
            this.btnRegistrar.ForeColor = System.Drawing.Color.Red;
            this.btnRegistrar.Location = new System.Drawing.Point(231, 385);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Primary = false;
            this.btnRegistrar.Size = new System.Drawing.Size(84, 36);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtSenhalogin
            // 
            this.txtSenhalogin.Depth = 0;
            this.txtSenhalogin.Hint = "Senha";
            this.txtSenhalogin.Location = new System.Drawing.Point(116, 331);
            this.txtSenhalogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenhalogin.Name = "txtSenhalogin";
            this.txtSenhalogin.PasswordChar = '\0';
            this.txtSenhalogin.SelectedText = "";
            this.txtSenhalogin.SelectionLength = 0;
            this.txtSenhalogin.SelectionStart = 0;
            this.txtSenhalogin.Size = new System.Drawing.Size(218, 23);
            this.txtSenhalogin.TabIndex = 2;
            this.txtSenhalogin.UseSystemPasswordChar = false;
            this.txtSenhalogin.Click += new System.EventHandler(this.txtSenhalogin_Click);
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.Depth = 0;
            this.txtEmailLogin.Hint = "E-mail";
            this.txtEmailLogin.Location = new System.Drawing.Point(116, 255);
            this.txtEmailLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.PasswordChar = '\0';
            this.txtEmailLogin.SelectedText = "";
            this.txtEmailLogin.SelectionLength = 0;
            this.txtEmailLogin.SelectionStart = 0;
            this.txtEmailLogin.Size = new System.Drawing.Size(218, 23);
            this.txtEmailLogin.TabIndex = 22;
            this.txtEmailLogin.UseSystemPasswordChar = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(421, 530);
            this.Controls.Add(this.txtEmailLogin);
            this.Controls.Add(this.txtSenhalogin);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRecuperarSenha);
            this.Controls.Add(this.BtnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "          SENAI - FACULDADE DE TECNOLOGIA";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialFlatButton btnRecuperarSenha;
        private MaterialSkin.Controls.MaterialFlatButton BtnLogin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialFlatButton btnRegistrar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenhalogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmailLogin;
    }
}