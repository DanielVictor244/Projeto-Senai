namespace Senai_projeto
{
    partial class UserEmpregos01
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscarEmpresa = new System.Windows.Forms.Label();
            this.dgvSolicitarEmprego = new System.Windows.Forms.DataGridView();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.BtnRemoverContrato = new System.Windows.Forms.Button();
            this.btnEditarContrato = new System.Windows.Forms.Button();
            this.btnCadastrarContrato = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoContrato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitarEmprego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(353, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(242, 307);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 23);
            this.btnBuscar.TabIndex = 50;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(107, 307);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(129, 20);
            this.txtBuscar.TabIndex = 49;
            // 
            // lblBuscarEmpresa
            // 
            this.lblBuscarEmpresa.AutoSize = true;
            this.lblBuscarEmpresa.Location = new System.Drawing.Point(17, 307);
            this.lblBuscarEmpresa.Name = "lblBuscarEmpresa";
            this.lblBuscarEmpresa.Size = new System.Drawing.Size(84, 13);
            this.lblBuscarEmpresa.TabIndex = 48;
            this.lblBuscarEmpresa.Text = "Buscar Empresa";
            // 
            // dgvSolicitarEmprego
            // 
            this.dgvSolicitarEmprego.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitarEmprego.Location = new System.Drawing.Point(481, 344);
            this.dgvSolicitarEmprego.Name = "dgvSolicitarEmprego";
            this.dgvSolicitarEmprego.Size = new System.Drawing.Size(307, 197);
            this.dgvSolicitarEmprego.TabIndex = 47;
            this.dgvSolicitarEmprego.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitarEmprego_CellContentClick);
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Location = new System.Drawing.Point(30, 344);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.Size = new System.Drawing.Size(305, 197);
            this.dgvEmpresa.TabIndex = 46;
            this.dgvEmpresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresa_CellContentClick);
            // 
            // BtnRemoverContrato
            // 
            this.BtnRemoverContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.BtnRemoverContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoverContrato.Location = new System.Drawing.Point(593, 187);
            this.BtnRemoverContrato.Name = "BtnRemoverContrato";
            this.BtnRemoverContrato.Size = new System.Drawing.Size(160, 32);
            this.BtnRemoverContrato.TabIndex = 45;
            this.BtnRemoverContrato.Text = "REMOVER CONTRATO";
            this.BtnRemoverContrato.UseVisualStyleBackColor = false;
            this.BtnRemoverContrato.Click += new System.EventHandler(this.btnRemoverContrato_Click);
            // 
            // btnEditarContrato
            // 
            this.btnEditarContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.btnEditarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarContrato.Location = new System.Drawing.Point(290, 187);
            this.btnEditarContrato.Name = "btnEditarContrato";
            this.btnEditarContrato.Size = new System.Drawing.Size(160, 29);
            this.btnEditarContrato.TabIndex = 44;
            this.btnEditarContrato.Text = "EDITAR CONTRATO";
            this.btnEditarContrato.UseVisualStyleBackColor = false;
            this.btnEditarContrato.Click += new System.EventHandler(this.btnEditarContrato_Click);
            // 
            // btnCadastrarContrato
            // 
            this.btnCadastrarContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.btnCadastrarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarContrato.Location = new System.Drawing.Point(49, 183);
            this.btnCadastrarContrato.Name = "btnCadastrarContrato";
            this.btnCadastrarContrato.Size = new System.Drawing.Size(160, 33);
            this.btnCadastrarContrato.TabIndex = 43;
            this.btnCadastrarContrato.Text = "SOLICITAR CONTRATO";
            this.btnCadastrarContrato.UseVisualStyleBackColor = false;
            this.btnCadastrarContrato.Click += new System.EventHandler(this.btnCadastrarContrato_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Tipo de contrato:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboTipoContrato
            // 
            this.cboTipoContrato.FormattingEnabled = true;
            this.cboTipoContrato.Items.AddRange(new object[] {
            "Fase Escolar ",
            "Pratica sequêncial",
            "Concomitante ",
            "Sequêncial",
            "Dual"});
            this.cboTipoContrato.Location = new System.Drawing.Point(160, 94);
            this.cboTipoContrato.Name = "cboTipoContrato";
            this.cboTipoContrato.Size = new System.Drawing.Size(156, 21);
            this.cboTipoContrato.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nome Da Empresa:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(160, 48);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(156, 20);
            this.txtNomeEmpresa.TabIndex = 39;
            // 
            // UserEmpregos01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscarEmpresa);
            this.Controls.Add(this.dgvSolicitarEmprego);
            this.Controls.Add(this.dgvEmpresa);
            this.Controls.Add(this.BtnRemoverContrato);
            this.Controls.Add(this.btnEditarContrato);
            this.Controls.Add(this.btnCadastrarContrato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTipoContrato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Name = "UserEmpregos01";
            this.Size = new System.Drawing.Size(805, 589);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitarEmprego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscarEmpresa;
        private System.Windows.Forms.DataGridView dgvSolicitarEmprego;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.Button BtnRemoverContrato;
        private System.Windows.Forms.Button btnEditarContrato;
        private System.Windows.Forms.Button btnCadastrarContrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipoContrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
    }
}
