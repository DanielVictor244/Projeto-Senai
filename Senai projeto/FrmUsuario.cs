using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Material design
using MaterialSkin;
using MaterialSkin.Controls;

namespace Senai_projeto


{
    public partial class FrmUsuario : MaterialForm
    {
        ClassUsuario usuario = new ClassUsuario();

        public FrmUsuario()
        {
            InitializeComponent();

            MaterialSkinManager materialSkin = MaterialSkinManager.Instance;
            materialSkin.AddFormToManage(this);
            materialSkin.Theme = MaterialSkinManager.Themes.LIGHT;

            //Cores do form
            materialSkin.ColorScheme = new ColorScheme(
                Primary.Red500, Primary.Red500,
                Primary.Red400, Accent.Red400,
                TextShade.WHITE
            );

        }

       

        

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            //Se for diferente então irá apagar e mandar msgBox
            if (TxtSenha.Text != TxtConfirmarSenha.Text)
            {
                MessageBox.Show(" Favor informar a senha novamente","Senhas não conferem ");
                TxtSenha.Text = "";
                TxtConfirmarSenha.Text = "";
                TxtSenha.Focus();

            //Verificar email
            }else if(usuario.validarEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("   Email o email inserido é inválido, \n             tente novamente!");
                txtEmail.Text = "";
                txtEmail.Focus();
            }else
            {
                
                usuario.Email = txtEmail.Text;
                usuario.Senha = TxtSenha.Text;
                usuario.Nome = TxtNome.Text;
                //Se for igual irá inserir no banco
                cbxTipoUsuario.Text = (cbxTipoUsuario.Text == "Administrador") ? "1" : "2";
                usuario.Tipo = int.Parse(cbxTipoUsuario.Text);

                if (usuario.InserirUsuario() == true)
                {
                    MessageBox.Show("  Usuário  cadastrado com sucesso!");
           
                }
            }
        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {
            //Tampar senha
          
        }

        private void TxtConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
            //Tampar senha
            
        }
        

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnImportarDados_MouseEnter(object sender, EventArgs e)
        {
           BtnCadastrar.BackColor = Color.FromArgb(245, 62, 56);
        }

        private void btnImportarDados_MouseHover(object sender, EventArgs e)
        {
            BtnCadastrar.BackColor = Color.FromArgb(245, 62, 56);
        }

        private void btnVoltarLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin form = new FrmLogin();
            form.ShowDialog();
            form.Close();
        }

        private void cbxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void TxtSenha_Click(object sender, EventArgs e)
        {
            TxtSenha.UseSystemPasswordChar = true;

        }

        private void TxtConfirmarSenha_Click(object sender, EventArgs e)
        {
            TxtConfirmarSenha.UseSystemPasswordChar = true;

        }
    }
}
