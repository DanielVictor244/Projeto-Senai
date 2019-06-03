namespace Senai_projeto
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TxtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TxtConfirmarSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnCadastrar = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.btnVoltarLog = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "E-mail";
            this.txtEmail.Location = new System.Drawing.Point(271, 231);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(251, 23);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(224, 222);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 114;
            this.pictureBox3.TabStop = false;
            // 
            // TxtNome
            // 
            this.TxtNome.Depth = 0;
            this.TxtNome.Hint = "Nome";
            this.TxtNome.Location = new System.Drawing.Point(271, 156);
            this.TxtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.PasswordChar = '\0';
            this.TxtNome.SelectedText = "";
            this.TxtNome.SelectionLength = 0;
            this.TxtNome.SelectionStart = 0;
            this.TxtNome.Size = new System.Drawing.Size(251, 23);
            this.TxtNome.TabIndex = 1;
            this.TxtNome.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(224, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 116;
            this.pictureBox1.TabStop = false;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Depth = 0;
            this.TxtSenha.Hint = "Senha";
            this.TxtSenha.Location = new System.Drawing.Point(271, 307);
            this.TxtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '\0';
            this.TxtSenha.SelectedText = "";
            this.TxtSenha.SelectionLength = 0;
            this.TxtSenha.SelectionStart = 0;
            this.TxtSenha.Size = new System.Drawing.Size(251, 23);
            this.TxtSenha.TabIndex = 3;
            this.TxtSenha.UseSystemPasswordChar = false;
            this.TxtSenha.Click += new System.EventHandler(this.TxtSenha_Click);
            this.TxtSenha.TextChanged += new System.EventHandler(this.TxtSenha_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(224, 298);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 118;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(224, 366);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 119;
            this.pictureBox4.TabStop = false;
            // 
            // TxtConfirmarSenha
            // 
            this.TxtConfirmarSenha.Depth = 0;
            this.TxtConfirmarSenha.Hint = "Comfirmar senha";
            this.TxtConfirmarSenha.Location = new System.Drawing.Point(271, 375);
            this.TxtConfirmarSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtConfirmarSenha.Name = "TxtConfirmarSenha";
            this.TxtConfirmarSenha.PasswordChar = '\0';
            this.TxtConfirmarSenha.SelectedText = "";
            this.TxtConfirmarSenha.SelectionLength = 0;
            this.TxtConfirmarSenha.SelectionStart = 0;
            this.TxtConfirmarSenha.Size = new System.Drawing.Size(251, 23);
            this.TxtConfirmarSenha.TabIndex = 4;
            this.TxtConfirmarSenha.UseSystemPasswordChar = false;
            this.TxtConfirmarSenha.Click += new System.EventHandler(this.TxtConfirmarSenha_Click);
            this.TxtConfirmarSenha.TextChanged += new System.EventHandler(this.TxtConfirmaSenha_TextChanged);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.AutoSize = true;
            this.BtnCadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCadastrar.BackColor = System.Drawing.Color.Red;
            this.BtnCadastrar.Depth = 0;
            this.BtnCadastrar.ForeColor = System.Drawing.Color.Red;
            this.BtnCadastrar.Location = new System.Drawing.Point(330, 492);
            this.BtnCadastrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Primary = false;
            this.BtnCadastrar.Size = new System.Drawing.Size(84, 36);
            this.BtnCadastrar.TabIndex = 6;
            this.BtnCadastrar.Text = "Registrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(295, 64);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(173, 77);
            this.pictureBox5.TabIndex = 122;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 124;
            this.label1.Text = "Tipo";
            // 
            // cbxTipoUsuario
            // 
            this.cbxTipoUsuario.FormattingEnabled = true;
            this.cbxTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Assistente"});
            this.cbxTipoUsuario.Location = new System.Drawing.Point(372, 428);
            this.cbxTipoUsuario.Name = "cbxTipoUsuario";
            this.cbxTipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoUsuario.TabIndex = 5;
            this.cbxTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cbxTipoUsuario_SelectedIndexChanged);
            // 
            // btnVoltarLog
            // 
            this.btnVoltarLog.AutoSize = true;
            this.btnVoltarLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVoltarLog.BackColor = System.Drawing.Color.Red;
            this.btnVoltarLog.Depth = 0;
            this.btnVoltarLog.ForeColor = System.Drawing.Color.Red;
            this.btnVoltarLog.Location = new System.Drawing.Point(498, 492);
            this.btnVoltarLog.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVoltarLog.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVoltarLog.Name = "btnVoltarLog";
            this.btnVoltarLog.Primary = false;
            this.btnVoltarLog.Size = new System.Drawing.Size(107, 36);
            this.btnVoltarLog.TabIndex = 127;
            this.btnVoltarLog.Text = "Voltar Login";
            this.btnVoltarLog.UseVisualStyleBackColor = false;
            this.btnVoltarLog.Click += new System.EventHandler(this.btnVoltarLog_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 586);
            this.Controls.Add(this.btnVoltarLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTipoUsuario);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.TxtConfirmarSenha);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtEmail);
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "       ";
            this.Text = "                                                                          Registr" +
    "ar";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSenha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtConfirmarSenha;
        private MaterialSkin.Controls.MaterialFlatButton BtnCadastrar;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTipoUsuario;
        private MaterialSkin.Controls.MaterialFlatButton btnVoltarLog;
    }
}