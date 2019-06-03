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
using System.Net;
using System.Net.Mail;

namespace Senai_projeto
{
    public partial class FrmEsqueceuSenha : MaterialSkin.Controls.MaterialForm
    {
        public FrmEsqueceuSenha()
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

        private void FrmEsqueceuSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviarSenha_Click(object sender, EventArgs e)
        {
            ClassRecuperarEmail recuperar = new ClassRecuperarEmail();

            lblDeuCerto.Text = "";
            lblErro.Text = "";
            recuperar.EmailEsquecido = txtEmailRecuperaçao.Text;
            lblDeuCerto.Text = "Tentando enviar email...";
            if (recuperar.EsqueceuSenha() == false)
            {
                lblDeuCerto.Text = "";
                lblErro.Text = "Email não foi encontrado! Por favor, tente novamente.";
            }
            else
            {
                lblDeuCerto.Text = "Email enviado com sucesso! Tente logar novamente.";
                btnEnviarSenha.Hide();
            }
        }
        public void SemInternet()
        {
            lblErro.Text = "Não foi possível encontrar conexão com a internet!";
        }


    }
}
