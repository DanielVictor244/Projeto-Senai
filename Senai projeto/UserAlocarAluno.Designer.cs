namespace Senai_projeto
{
    partial class userAlocarAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userAlocarAluno));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.btnInserirAlunoEmpresa = new System.Windows.Forms.Button();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lbldade = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarEmpresa = new System.Windows.Forms.Button();
            this.btnBuscarAluno = new System.Windows.Forms.Button();
            this.txtBuscarAluno = new System.Windows.Forms.TextBox();
            this.txtBuscarEmpresa = new System.Windows.Forms.TextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.dgvAlunosAlocados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosAlocados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome aluno :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "cpf :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome empresa :";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(195, 56);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(233, 20);
            this.txtNomeAluno.TabIndex = 4;
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(224, 181);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(233, 20);
            this.txtNomeEmpresa.TabIndex = 6;
            // 
            // btnInserirAlunoEmpresa
            // 
            this.btnInserirAlunoEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirAlunoEmpresa.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirAlunoEmpresa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnInserirAlunoEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirAlunoEmpresa.Image")));
            this.btnInserirAlunoEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirAlunoEmpresa.Location = new System.Drawing.Point(283, 297);
            this.btnInserirAlunoEmpresa.Name = "btnInserirAlunoEmpresa";
            this.btnInserirAlunoEmpresa.Size = new System.Drawing.Size(241, 42);
            this.btnInserirAlunoEmpresa.TabIndex = 111;
            this.btnInserirAlunoEmpresa.Text = "           Alocar aluno na empresa";
            this.btnInserirAlunoEmpresa.UseVisualStyleBackColor = true;
            this.btnInserirAlunoEmpresa.Click += new System.EventHandler(this.btnInserirAlunoEmpresa_Click);
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.dgvAlunos.Location = new System.Drawing.Point(59, 360);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(240, 150);
            this.dgvAlunos.TabIndex = 112;
            this.dgvAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellContentClick);
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.dgvEmpresa.Location = new System.Drawing.Point(492, 360);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.Size = new System.Drawing.Size(240, 150);
            this.dgvEmpresa.TabIndex = 113;
            this.dgvEmpresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresa_CellContentClick);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(132, 143);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 114;
            // 
            // lbldade
            // 
            this.lbldade.AutoSize = true;
            this.lbldade.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldade.Location = new System.Drawing.Point(55, 139);
            this.lbldade.Name = "lbldade";
            this.lbldade.Size = new System.Drawing.Size(71, 23);
            this.lbldade.TabIndex = 115;
            this.lbldade.Text = "Idade :";
            // 
            // btnMostrar
            // 
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnMostrar.Location = new System.Drawing.Point(333, 344);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(139, 36);
            this.btnMostrar.TabIndex = 116;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 118;
            this.label4.Text = "CNPJ :";
            // 
            // btnBuscarEmpresa
            // 
            this.btnBuscarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpresa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmpresa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBuscarEmpresa.Location = new System.Drawing.Point(562, 287);
            this.btnBuscarEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarEmpresa.Name = "btnBuscarEmpresa";
            this.btnBuscarEmpresa.Size = new System.Drawing.Size(139, 36);
            this.btnBuscarEmpresa.TabIndex = 119;
            this.btnBuscarEmpresa.Text = "Buscar Empresa";
            this.btnBuscarEmpresa.UseVisualStyleBackColor = true;
            this.btnBuscarEmpresa.Click += new System.EventHandler(this.btnBuscarEmpresa_Click);
            // 
            // btnBuscarAluno
            // 
            this.btnBuscarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAluno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAluno.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBuscarAluno.Location = new System.Drawing.Point(93, 287);
            this.btnBuscarAluno.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarAluno.Name = "btnBuscarAluno";
            this.btnBuscarAluno.Size = new System.Drawing.Size(139, 36);
            this.btnBuscarAluno.TabIndex = 120;
            this.btnBuscarAluno.Text = "Buscar Aluno";
            this.btnBuscarAluno.UseVisualStyleBackColor = true;
            this.btnBuscarAluno.Click += new System.EventHandler(this.btnBuscarAluno_Click);
            // 
            // txtBuscarAluno
            // 
            this.txtBuscarAluno.Location = new System.Drawing.Point(111, 334);
            this.txtBuscarAluno.Name = "txtBuscarAluno";
            this.txtBuscarAluno.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarAluno.TabIndex = 121;
            this.txtBuscarAluno.TextChanged += new System.EventHandler(this.txtBuscarAluno_TextChanged);
            // 
            // txtBuscarEmpresa
            // 
            this.txtBuscarEmpresa.Location = new System.Drawing.Point(584, 334);
            this.txtBuscarEmpresa.Name = "txtBuscarEmpresa";
            this.txtBuscarEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarEmpresa.TabIndex = 122;
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(121, 94);
            this.mskCpf.Mask = "000.000.000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(79, 20);
            this.mskCpf.TabIndex = 162;
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Location = new System.Drawing.Point(134, 220);
            this.mskCNPJ.Mask = "99.999.999/9999-99";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(111, 20);
            this.mskCNPJ.TabIndex = 163;
            // 
            // dgvAlunosAlocados
            // 
            this.dgvAlunosAlocados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAlunosAlocados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunosAlocados.Location = new System.Drawing.Point(529, 94);
            this.dgvAlunosAlocados.Name = "dgvAlunosAlocados";
            this.dgvAlunosAlocados.Size = new System.Drawing.Size(240, 150);
            this.dgvAlunosAlocados.TabIndex = 164;
            this.dgvAlunosAlocados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunosAlocados_CellContentClick);
            // 
            // userAlocarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAlunosAlocados);
            this.Controls.Add(this.mskCNPJ);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.txtBuscarEmpresa);
            this.Controls.Add(this.txtBuscarAluno);
            this.Controls.Add(this.btnBuscarAluno);
            this.Controls.Add(this.btnBuscarEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lbldade);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.dgvEmpresa);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.btnInserirAlunoEmpresa);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "userAlocarAluno";
            this.Size = new System.Drawing.Size(805, 589);
            this.Load += new System.EventHandler(this.userAlocarAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosAlocados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Button btnInserirAlunoEmpresa;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lbldade;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarEmpresa;
        private System.Windows.Forms.Button btnBuscarAluno;
        private System.Windows.Forms.TextBox txtBuscarAluno;
        private System.Windows.Forms.TextBox txtBuscarEmpresa;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.DataGridView dgvAlunosAlocados;
    }
}
