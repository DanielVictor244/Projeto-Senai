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
    public partial class FrmLogin : MaterialSkin.Controls.MaterialForm
    {
        ClassUsuario usuario = new ClassUsuario();

        public FrmLogin()
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {



        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUsuario form = new FrmUsuario();
            form.ShowDialog();
        


        }

        private void txtSenhalogin_Click(object sender, EventArgs e)
        {
            txtSenhalogin.UseSystemPasswordChar = true;

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = usuario.VerificarLogin(txtEmailLogin.Text, txtSenhalogin.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("E-Mail ou Senha Incorretos ");
                txtEmailLogin.Text = "";
                txtSenhalogin.Text = "";
            }
            else
            {
                string tipo = dt.Rows[0]["tipo"].ToString();
                if(tipo == "1")
                {
                    this.Hide();
                    FrmAdministrador form = new FrmAdministrador();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Hide();
                    FrmSecretaria form = new FrmSecretaria();
                    form.ShowDialog();
                    this.Close();
                }
            }
              }

        private void btnRecuperarSenha_Click(object sender, EventArgs e)
        {
            //Ir para o formEsqueceuSenha e fechar o form que estiver aberto
            this.Hide();
           FrmEsqueceuSenha  form = new FrmEsqueceuSenha();
            form.ShowDialog();
            this.Close();
        }
    }
}

    


    



        
     
    

