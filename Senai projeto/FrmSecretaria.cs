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
    public partial class FrmSecretaria : MaterialSkin.Controls.MaterialForm
    {
        public FrmSecretaria()
        {
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

        private void BtnCadastrarEmpresa_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAlocarAluno_Click(object sender, EventArgs e)
        {
            
        }
    }
}