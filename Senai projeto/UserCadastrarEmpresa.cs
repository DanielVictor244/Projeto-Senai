 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;


namespace Senai_projeto
{
    public partial class UserCadastrarEmpresa : UserControl
    {
        ClassEmpresa empresa = new ClassEmpresa();
       int codEmpresaClicado= 0;
        public UserCadastrarEmpresa()
        {
            InitializeComponent();
            
        }
        private void MostrarCEP()
        {
            if (mskCep.Text != "")
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + mskCep.Text + "/json/");
                request.AllowAutoRedirect = false;
                HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

                if (ChecaServidor.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show("Servidor indisponível");
                    return; // Sai da rotina
                }

                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            response = Regex.Replace(response, "[{},]", string.Empty);
                            response = response.Replace("\"", "");

                            String[] substrings = response.Split('\n');

                            int cont = 0;
                            foreach (var substring in substrings)
                            {
                                if (cont == 1)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    if (valor[0] == "  erro")
                                    {
                                        MessageBox.Show("  O CEP inserido não foi localizado. ");
                                        mskCep.Focus();
                                        return;
                                    }
                                }

                                //Logradouro
                                if (cont == 2)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txtRuaEmpresa.Text = valor[1];
                                }

                                //Complemento
                                if (cont == 3)
                                {
                                    //string[] valor = substring.Split(":".ToCharArray());
                                    //txtComplementoEmpresa.Text = valor[1];
                                }

                                //Bairro
                                if (cont == 4)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txtBairroEmpresa.Text = valor[1];
                                }

                                //Localidade (Cidade)
                                if (cont == 5)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txtCidadeEmpresa.Text = valor[1];
                                }

                                //Estado (UF)
                                if (cont == 6)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txtEstadoEmpresa.Text = valor[1];
                                }

                                cont++;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(" Favor inserir o CEP para o preenchi ");
            }


        }


        private void UserCadastrarEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgvCadastrarEmpresa.DataSource = empresa.RetEmpresas();
        }

        private void dgvCadastrarEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCepEmpresa_Leave(object sender, EventArgs e)
        {
            MostrarCEP();
        }
        private void PegarDados()
        {
            //Pegar as informações para a inserção
            empresa.nomeEmpresa = txtNome.Text;
            empresa.cnpj = mskCNPJ.Text;
            empresa.razaoSocial = txtRazaoEmpresa.Text;
            empresa.telefone = mskTelefone.Text;
            empresa.emailContato = txtEmailEmpresa.Text;
            empresa.cidade = txtCidadeEmpresa.Text;
            empresa.estado = txtEstadoEmpresa.Text;
            empresa.bairro = txtBairroEmpresa.Text;
            empresa.rua = txtRuaEmpresa.Text;
            empresa.complemento = txtComplementoEmpresa.Text;
            empresa.numero = txtNumeroEmpresa.Text;
            empresa.cep = mskCep.Text;
            empresa.responsavelContrato = txtResponsavel.Text;
            empresa.telefoneResponsavel = mskTelefone.Text;

        }


        private void btnInserirEmpresa_Click(object sender, EventArgs e)
        {
            if (ChecarTextos() == true)
            {

                PegarDados();
                if (empresa.Inserir() == true)
                {
                    MessageBox.Show("     A empresa foi cadastrada com sucesso!");
                    
                   dgvCadastrarEmpresa.DataSource = empresa.RetEmpresas();
                }
            }
            else
            {
                MessageBox.Show("  Preencha corretamente todos oscampos");
            }

        }
        private void RetornarEmpresaDgv()
        {
            dgvCadastrarEmpresa.DataSource = empresa.RetEmpresas();
        }
        private bool ChecarTextos()
        {
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(mskTelefone.Text) || String.IsNullOrEmpty(txtEmailEmpresa.Text) || String.IsNullOrEmpty(txtEstadoEmpresa.Text) || String.IsNullOrEmpty(txtCidadeEmpresa.Text) || String.IsNullOrEmpty(txtBairroEmpresa.Text) ||
String.IsNullOrEmpty(txtNumeroEmpresa.Text) || String.IsNullOrEmpty(txtComplementoEmpresa.Text) || String.IsNullOrEmpty(txtRuaEmpresa.Text) || String.IsNullOrEmpty(mskCep.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void btnEditarEmpresa_Click(object sender, EventArgs e)
        {
            if (ChecarTextos() == true)
            {
                PegarDados();
                empresa.aluno_codAluno = 0;

                if (empresa.Editar(codEmpresaClicado) == true)
                {
                    MessageBox.Show(" A edição da empresa foi realizada com sucesso!");
                  
                    RetornarEmpresaDgv();
                }
            }
            else
            {
                MessageBox.Show("  Preencha corretamente todos os  campos!");
            }


        }

        private void dgvCadastrarEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            //Se clicar em algum codigo no dgv
            if (dgvCadastrarEmpresa.Rows[e.RowIndex].Cells["codEmpresa"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
               codEmpresaClicado = int.Parse(dgvCadastrarEmpresa.Rows[e.RowIndex].Cells["codEmpresa"].Value.ToString());
            }
            txtNome.Text = dgvCadastrarEmpresa.Rows[e.RowIndex].Cells["nomeEmpresa"].Value.ToString();
            mskCNPJ.Text = dgvCadastrarEmpresa.Rows[e.RowIndex].Cells["cnpj"].Value.ToString();
            txtRazaoEmpresa.Text = dgvCadastrarEmpresa.Rows[e.RowIndex].Cells["razaoSocial"].Value.ToString();
            mskTelefone.Text = dgvCadastrarEmpresa.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            txtResponsavel.Text = dgvCadastrarEmpresa.Rows[e.RowIndex].Cells["emailContato"].Value.ToString();
            mskCep.Text = dgvCadastrarEmpresa.Rows[e.RowIndex].Cells["cep"].Value.ToString();
            txtEstadoEmpresa.Text = dgvCadastrarEmpresa.Rows[e.RowIndex].Cells["estado"].Value.ToString();
            txtCidadeEmpresa.Text = dgvCadastrarEmpresa.Rows[e.RowIndex].Cells["cidade"].Value.ToString();
            txtBairroEmpresa.Text = dgvCadastrarEmpresa.Rows[e.RowIndex].Cells["bairro"].Value.ToString();
            txtRuaEmpresa.Text = dgvCadastrarEmpresa.Rows[e.RowIndex].Cells["rua"].Value.ToString();
            txtComplementoEmpresa.Text = dgvCadastrarEmpresa.Rows[e.RowIndex].Cells["complemento"].Value.ToString();
            txtNumeroEmpresa.Text = dgvCadastrarEmpresa.Rows[e.RowIndex].Cells["numeroCasa"].Value.ToString();
            txtResponsavel.Text = dgvCadastrarEmpresa.Rows[e.RowIndex].Cells["responsavelContrato"].Value.ToString();
            mskTelefone.Text = dgvCadastrarEmpresa.Rows[e.RowIndex].Cells["telefoneResponsavel"].Value.ToString();

        }

        private void txtTelefoneEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mskCep_Leave(object sender, EventArgs e)
        {
            MostrarCEP();
        }
    }

}
    

