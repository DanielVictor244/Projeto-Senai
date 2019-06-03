namespace Senai_projeto
{
    partial class FrmAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCadastrarEmpresa = new System.Windows.Forms.Button();
            this.btnDadosExcel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVisualizarAluno = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.userHistorico1 = new Senai_projeto.UserHistorico();
            this.userStatus1 = new Senai_projeto.UserStatus();
            this.userEmpregos011 = new Senai_projeto.UserEmpregos01();
            this.userTelaOpção1 = new Senai_projeto.UserTelaOpção();
            this.userVisualizarAluno1 = new Senai_projeto.UserVisualizarAluno();
            this.userImportarDados1 = new Senai_projeto.userImportarDados();
            this.userAlocarAluno1 = new Senai_projeto.userAlocarAluno();
            this.userCadastrarEmpresa1 = new Senai_projeto.UserCadastrarEmpresa();
            this.userTelaOpção2 = new Senai_projeto.UserTelaOpção();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.btnHistorico);
            this.panel1.Controls.Add(this.btnStatus);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnCadastrarEmpresa);
            this.panel1.Controls.Add(this.btnDadosExcel);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnVisualizarAluno);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 651);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 67);
            this.button1.TabIndex = 25;
            this.button1.Text = "Solicitar Contratos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastrarEmpresa
            // 
            this.btnCadastrarEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.btnCadastrarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarEmpresa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEmpresa.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarEmpresa.Location = new System.Drawing.Point(12, 134);
            this.btnCadastrarEmpresa.Name = "btnCadastrarEmpresa";
            this.btnCadastrarEmpresa.Size = new System.Drawing.Size(146, 67);
            this.btnCadastrarEmpresa.TabIndex = 23;
            this.btnCadastrarEmpresa.Text = "Cadastrar Empresa";
            this.btnCadastrarEmpresa.UseVisualStyleBackColor = true;
            this.btnCadastrarEmpresa.Click += new System.EventHandler(this.btnCadastrarEmpresa_Click_1);
            // 
            // btnDadosExcel
            // 
            this.btnDadosExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.btnDadosExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDadosExcel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDadosExcel.ForeColor = System.Drawing.Color.Transparent;
            this.btnDadosExcel.Location = new System.Drawing.Point(12, 313);
            this.btnDadosExcel.Name = "btnDadosExcel";
            this.btnDadosExcel.Size = new System.Drawing.Size(146, 67);
            this.btnDadosExcel.TabIndex = 21;
            this.btnDadosExcel.Text = "Importar dados do Excel";
            this.btnDadosExcel.UseVisualStyleBackColor = true;
            this.btnDadosExcel.Click += new System.EventHandler(this.btnDadosExcel_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.panel4.Location = new System.Drawing.Point(4, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(174, 20);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Administrador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 71);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnVisualizarAluno
            // 
            this.btnVisualizarAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.btnVisualizarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarAluno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarAluno.ForeColor = System.Drawing.Color.Transparent;
            this.btnVisualizarAluno.Location = new System.Drawing.Point(12, 223);
            this.btnVisualizarAluno.Name = "btnVisualizarAluno";
            this.btnVisualizarAluno.Size = new System.Drawing.Size(146, 67);
            this.btnVisualizarAluno.TabIndex = 2;
            this.btnVisualizarAluno.Text = "Alocar Aluno";
            this.btnVisualizarAluno.UseVisualStyleBackColor = true;
            this.btnVisualizarAluno.Click += new System.EventHandler(this.btnVisualizarAluno_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(182, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 63);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(5, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(805, 589);
            this.panel5.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.panel3.Location = new System.Drawing.Point(4, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 17);
            this.panel3.TabIndex = 2;
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.ForeColor = System.Drawing.Color.Transparent;
            this.btnStatus.Location = new System.Drawing.Point(12, 495);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(146, 67);
            this.btnStatus.TabIndex = 26;
            this.btnStatus.Text = "Status Encamiamento";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.Color.Transparent;
            this.btnHistorico.Location = new System.Drawing.Point(12, 571);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(146, 67);
            this.btnHistorico.TabIndex = 27;
            this.btnHistorico.Text = "Historico do Aluno";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // userHistorico1
            // 
            this.userHistorico1.Location = new System.Drawing.Point(182, 126);
            this.userHistorico1.Name = "userHistorico1";
            this.userHistorico1.Size = new System.Drawing.Size(805, 589);
            this.userHistorico1.TabIndex = 10;
            // 
            // userStatus1
            // 
            this.userStatus1.Location = new System.Drawing.Point(184, 126);
            this.userStatus1.Name = "userStatus1";
            this.userStatus1.Size = new System.Drawing.Size(805, 589);
            this.userStatus1.TabIndex = 9;
            // 
            // userEmpregos011
            // 
            this.userEmpregos011.Location = new System.Drawing.Point(182, 123);
            this.userEmpregos011.Name = "userEmpregos011";
            this.userEmpregos011.Size = new System.Drawing.Size(810, 592);
            this.userEmpregos011.TabIndex = 8;
            // 
            // userTelaOpção1
            // 
            this.userTelaOpção1.BackColor = System.Drawing.Color.White;
            this.userTelaOpção1.ForeColor = System.Drawing.Color.White;
            this.userTelaOpção1.Location = new System.Drawing.Point(182, 126);
            this.userTelaOpção1.Name = "userTelaOpção1";
            this.userTelaOpção1.Size = new System.Drawing.Size(805, 589);
            this.userTelaOpção1.TabIndex = 7;
            // 
            // userVisualizarAluno1
            // 
            this.userVisualizarAluno1.Location = new System.Drawing.Point(182, 126);
            this.userVisualizarAluno1.Name = "userVisualizarAluno1";
            this.userVisualizarAluno1.Size = new System.Drawing.Size(805, 589);
            this.userVisualizarAluno1.TabIndex = 6;
            // 
            // userImportarDados1
            // 
            this.userImportarDados1.Location = new System.Drawing.Point(182, 126);
            this.userImportarDados1.Name = "userImportarDados1";
            this.userImportarDados1.Size = new System.Drawing.Size(805, 589);
            this.userImportarDados1.TabIndex = 5;
            // 
            // userAlocarAluno1
            // 
            this.userAlocarAluno1.Location = new System.Drawing.Point(184, 126);
            this.userAlocarAluno1.Name = "userAlocarAluno1";
            this.userAlocarAluno1.Size = new System.Drawing.Size(805, 589);
            this.userAlocarAluno1.TabIndex = 4;
            // 
            // userCadastrarEmpresa1
            // 
            this.userCadastrarEmpresa1.Location = new System.Drawing.Point(184, 126);
            this.userCadastrarEmpresa1.Name = "userCadastrarEmpresa1";
            this.userCadastrarEmpresa1.Size = new System.Drawing.Size(805, 589);
            this.userCadastrarEmpresa1.TabIndex = 3;
            // 
            // userTelaOpção2
            // 
            this.userTelaOpção2.BackColor = System.Drawing.Color.White;
            this.userTelaOpção2.ForeColor = System.Drawing.Color.White;
            this.userTelaOpção2.Location = new System.Drawing.Point(182, 126);
            this.userTelaOpção2.Name = "userTelaOpção2";
            this.userTelaOpção2.Size = new System.Drawing.Size(805, 589);
            this.userTelaOpção2.TabIndex = 11;
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 714);
            this.Controls.Add(this.userTelaOpção2);
            this.Controls.Add(this.userHistorico1);
            this.Controls.Add(this.userStatus1);
            this.Controls.Add(this.userEmpregos011);
            this.Controls.Add(this.userTelaOpção1);
            this.Controls.Add(this.userVisualizarAluno1);
            this.Controls.Add(this.userImportarDados1);
            this.Controls.Add(this.userAlocarAluno1);
            this.Controls.Add(this.userCadastrarEmpresa1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "          SENAI - FACULDADE DE TECNOLOGIA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnDadosExcel;
        private System.Windows.Forms.Button btnCadastrarEmpresa;
        private System.Windows.Forms.Button btnVisualizarAluno;
        private System.Windows.Forms.Button button1;
        private UserCadastrarEmpresa userCadastrarEmpresa1;
        private userAlocarAluno userAlocarAluno1;
        private userImportarDados userImportarDados1;
        private UserVisualizarAluno userVisualizarAluno1;
        private UserTelaOpção userTelaOpção1;
        private UserEmpregos01 userEmpregos011;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnStatus;
        private UserStatus userStatus1;
        private UserHistorico userHistorico1;
        private UserTelaOpção userTelaOpção2;
    }
}