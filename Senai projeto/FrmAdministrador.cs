using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;



namespace Senai_projeto
{
    public partial class FrmAdministrador : MaterialSkin.Controls.MaterialForm
    {
        public FrmAdministrador()
        {
            InitializeComponent();
            

            InitializeComponent();

            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red600, Primary.Red600,
                Primary.Red500, Accent.Red400,
                TextShade.WHITE
                );

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void userTelaOpção1_Load(object sender, EventArgs e)
        {

        }

        private void btnVisualizarAluno_Click(object sender, EventArgs e)
        {
            userAlocarAluno1.BringToFront();
        }

        private void btnCadastrarEmpresa_Click(object sender, EventArgs e)
        {
           

        }

        private void userCadastrarEmpresa1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAlocarAluno_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDadosExcel_Click(object sender, EventArgs e)
        {
            userImportarDados1.BringToFront();
        }

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnVisualizarAlu_Click(object sender, EventArgs e)
        {
            userVisualizarAluno1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            userTelaOpção1.BringToFront();
        }

        private void btnCadastrarEmpresa_Click_1(object sender, EventArgs e)
        {
            userCadastrarEmpresa1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userEmpregos011.BringToFront();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            userStatus1.BringToFront();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            userHistorico1.BringToFront();
        }
    }
}
