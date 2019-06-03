namespace Senai_projeto
{
    partial class FrmEsqueceuSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEsqueceuSenha));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnEnviarSenha = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmailRecuperaçao = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDeuCerto = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 221);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // btnEnviarSenha
            // 
            this.btnEnviarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.btnEnviarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarSenha.ForeColor = System.Drawing.Color.Transparent;
            this.btnEnviarSenha.Location = new System.Drawing.Point(102, 341);
            this.btnEnviarSenha.Name = "btnEnviarSenha";
            this.btnEnviarSenha.Size = new System.Drawing.Size(114, 45);
            this.btnEnviarSenha.TabIndex = 29;
            this.btnEnviarSenha.Text = "Enviar";
            this.btnEnviarSenha.UseVisualStyleBackColor = true;
            this.btnEnviarSenha.Click += new System.EventHandler(this.btnEnviarSenha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 77);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmailRecuperaçao
            // 
            this.txtEmailRecuperaçao.Depth = 0;
            this.txtEmailRecuperaçao.Hint = "E-mail";
            this.txtEmailRecuperaçao.Location = new System.Drawing.Point(60, 230);
            this.txtEmailRecuperaçao.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmailRecuperaçao.Name = "txtEmailRecuperaçao";
            this.txtEmailRecuperaçao.PasswordChar = '\0';
            this.txtEmailRecuperaçao.SelectedText = "";
            this.txtEmailRecuperaçao.SelectionLength = 0;
            this.txtEmailRecuperaçao.SelectionStart = 0;
            this.txtEmailRecuperaçao.Size = new System.Drawing.Size(218, 23);
            this.txtEmailRecuperaçao.TabIndex = 27;
            this.txtEmailRecuperaçao.UseSystemPasswordChar = false;
            // 
            // lblDeuCerto
            // 
            this.lblDeuCerto.AutoSize = true;
            this.lblDeuCerto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeuCerto.Location = new System.Drawing.Point(57, 277);
            this.lblDeuCerto.Name = "lblDeuCerto";
            this.lblDeuCerto.Size = new System.Drawing.Size(0, 14);
            this.lblDeuCerto.TabIndex = 31;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.Location = new System.Drawing.Point(57, 303);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 14);
            this.lblErro.TabIndex = 32;
            // 
            // FrmEsqueceuSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(335, 431);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lblDeuCerto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEnviarSenha);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtEmailRecuperaçao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEsqueceuSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperação de senha";
            this.Load += new System.EventHandler(this.FrmEsqueceuSenha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnEnviarSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmailRecuperaçao;
        private System.Windows.Forms.Label lblDeuCerto;
        private System.Windows.Forms.Label lblErro;
    }
}