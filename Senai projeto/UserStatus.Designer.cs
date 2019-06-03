namespace Senai_projeto
{
    partial class UserStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStatusAlunosAlocados = new System.Windows.Forms.DataGridView();
            this.mskDataFim = new System.Windows.Forms.MaskedTextBox();
            this.mskDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.lblDataF = new System.Windows.Forms.Label();
            this.lblDataI = new System.Windows.Forms.Label();
            this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCadastrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.rchDescricao = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dgvAlunosAlocados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusAlunosAlocados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosAlocados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStatusAlunosAlocados
            // 
            this.dgvStatusAlunosAlocados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStatusAlunosAlocados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatusAlunosAlocados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvStatusAlunosAlocados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatusAlunosAlocados.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvStatusAlunosAlocados.EnableHeadersVisualStyles = false;
            this.dgvStatusAlunosAlocados.Location = new System.Drawing.Point(333, 357);
            this.dgvStatusAlunosAlocados.Name = "dgvStatusAlunosAlocados";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatusAlunosAlocados.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.dgvStatusAlunosAlocados.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvStatusAlunosAlocados.Size = new System.Drawing.Size(231, 134);
            this.dgvStatusAlunosAlocados.TabIndex = 89;
            this.dgvStatusAlunosAlocados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStatusAlunosAlocados_CellContentClick);
            // 
            // mskDataFim
            // 
            this.mskDataFim.Location = new System.Drawing.Point(270, 196);
            this.mskDataFim.Mask = "00/00/0000";
            this.mskDataFim.Name = "mskDataFim";
            this.mskDataFim.Size = new System.Drawing.Size(72, 20);
            this.mskDataFim.TabIndex = 88;
            this.mskDataFim.ValidatingType = typeof(System.DateTime);
            // 
            // mskDataInicio
            // 
            this.mskDataInicio.Location = new System.Drawing.Point(111, 196);
            this.mskDataInicio.Mask = "00/00/0000";
            this.mskDataInicio.Name = "mskDataInicio";
            this.mskDataInicio.Size = new System.Drawing.Size(72, 20);
            this.mskDataInicio.TabIndex = 87;
            this.mskDataInicio.ValidatingType = typeof(System.DateTime);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(21, 163);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(132, 20);
            this.lblPeriodo.TabIndex = 86;
            this.lblPeriodo.Text = "Periodo do contrato:";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(167, 162);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(230, 20);
            this.txtPeriodo.TabIndex = 85;
            // 
            // lblDataF
            // 
            this.lblDataF.AutoSize = true;
            this.lblDataF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataF.Location = new System.Drawing.Point(189, 197);
            this.lblDataF.Name = "lblDataF";
            this.lblDataF.Size = new System.Drawing.Size(60, 20);
            this.lblDataF.TabIndex = 84;
            this.lblDataF.Text = "Data fim:";
            // 
            // lblDataI
            // 
            this.lblDataI.AutoSize = true;
            this.lblDataI.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataI.Location = new System.Drawing.Point(28, 197);
            this.lblDataI.Name = "lblDataI";
            this.lblDataI.Size = new System.Drawing.Size(74, 20);
            this.lblDataI.TabIndex = 83;
            this.lblDataI.Text = "Data início:";
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(381, 234);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(141, 43);
            this.btnEditar.TabIndex = 81;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Depth = 0;
            this.btnCadastrar.Location = new System.Drawing.Point(27, 234);
            this.btnCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Primary = true;
            this.btnCadastrar.Size = new System.Drawing.Size(141, 43);
            this.btnCadastrar.TabIndex = 80;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(82, 101);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(73, 20);
            this.lblMotivo.TabIndex = 79;
            this.lblMotivo.Text = "Descrição:";
            // 
            // rchDescricao
            // 
            this.rchDescricao.Location = new System.Drawing.Point(164, 90);
            this.rchDescricao.Name = "rchDescricao";
            this.rchDescricao.Size = new System.Drawing.Size(230, 66);
            this.rchDescricao.TabIndex = 78;
            this.rchDescricao.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(108, 67);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 77;
            this.lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(164, 64);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(230, 20);
            this.txtStatus.TabIndex = 76;
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAluno.Location = new System.Drawing.Point(43, 39);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(105, 20);
            this.lblNomeAluno.TabIndex = 75;
            this.lblNomeAluno.Text = "Nome do aluno:";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(164, 39);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(230, 20);
            this.txtNomeAluno.TabIndex = 74;
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresa.Location = new System.Drawing.Point(24, 14);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(125, 20);
            this.lblNomeEmpresa.TabIndex = 73;
            this.lblNomeEmpresa.Text = "Nome da empresa:";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(164, 13);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(230, 20);
            this.txtNomeEmpresa.TabIndex = 72;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(271, 449);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(56, 42);
            this.btnAtualizar.TabIndex = 71;
            this.btnAtualizar.Text = "Mostrar Todos";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dgvAlunosAlocados
            // 
            this.dgvAlunosAlocados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAlunosAlocados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlunosAlocados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvAlunosAlocados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlunosAlocados.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvAlunosAlocados.EnableHeadersVisualStyles = false;
            this.dgvAlunosAlocados.Location = new System.Drawing.Point(24, 357);
            this.dgvAlunosAlocados.Name = "dgvAlunosAlocados";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlunosAlocados.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            this.dgvAlunosAlocados.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvAlunosAlocados.Size = new System.Drawing.Size(242, 134);
            this.dgvAlunosAlocados.TabIndex = 70;
            this.dgvAlunosAlocados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunosAlocados_CellContentClick);
            // 
            // UserStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvStatusAlunosAlocados);
            this.Controls.Add(this.mskDataFim);
            this.Controls.Add(this.mskDataInicio);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.lblDataF);
            this.Controls.Add(this.lblDataI);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.rchDescricao);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblNomeAluno);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.lblNomeEmpresa);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvAlunosAlocados);
            this.Name = "UserStatus";
            this.Size = new System.Drawing.Size(805, 589);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusAlunosAlocados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosAlocados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStatusAlunosAlocados;
        private System.Windows.Forms.MaskedTextBox mskDataFim;
        private System.Windows.Forms.MaskedTextBox mskDataInicio;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label lblDataF;
        private System.Windows.Forms.Label lblDataI;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCadastrar;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.RichTextBox rchDescricao;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dgvAlunosAlocados;
    }
}
