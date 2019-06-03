using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senai_projeto
{
    public partial class userAlocarAluno : UserControl
        
    {
        ClassEmpresa empresa = new ClassEmpresa();
        ClassAluno aluno = new ClassAluno();
        
        int codEmpresaClicada, codAlunoClicado = 0;
        public userAlocarAluno()
        {
            InitializeComponent();
            RetornarAlunoDgv();
            RetornarEmpresaDgv();

        }
        private void RetornarEmpresaDgv()
        {
           dgvEmpresa.DataSource = empresa.RetEmpresas();
        }
        private void RetornarAlunoDgv()
        {
            dgvAlunos.DataSource = aluno.retAlunos();
        }
        private bool VerificarDados()
        {
            if (String.IsNullOrEmpty(txtNomeAluno.Text) || String.IsNullOrEmpty(mskCpf.Text) || String.IsNullOrEmpty(txtNomeEmpresa.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void dgvAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se clicar em algum codigo no dgv
            if (dgvAlunos.Rows[e.RowIndex].Cells["codAluno"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codAlunoClicado = int.Parse(dgvAlunos.Rows[e.RowIndex].Cells["codAluno"].Value.ToString());
            }
            txtNomeAluno.Text = dgvAlunos.Rows[e.RowIndex].Cells["nomeAluno"].Value.ToString();
            mskCpf.Text = dgvAlunos.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            txtIdade.Text = dgvAlunos.Rows[e.RowIndex].Cells["idade"].Value.ToString();

        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            //Se clicar em algum codigo no dgv
            if (dgvAlunos.Rows[e.RowIndex].Cells["codAluno"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codAlunoClicado = int.Parse(dgvAlunos.Rows[e.RowIndex].Cells["codAluno"].Value.ToString());
            }
            txtNomeAluno.Text = dgvAlunos.Rows[e.RowIndex].Cells["nomeAluno"].Value.ToString();
            mskCpf.Text = dgvAlunos.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            txtIdade.Text = dgvAlunos.Rows[e.RowIndex].Cells["idade"].Value.ToString();


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            RetornarAlunoDgv();
            RetornarEmpresaDgv();

        }

        private void btnInserirAlunoEmpresa_Click(object sender, EventArgs e)
        {
            if (VerificarDados() == true)
            {
                empresa.aluno_codAluno = codAlunoClicado;
                empresa.nomeEmpresa = txtNomeEmpresa.Text;
                empresa.cnpj = mskCNPJ.Text;
                if (empresa.AlocarAlunoEmprego(codEmpresaClicada, txtNomeAluno.Text, mskCpf.Text, txtIdade.Text) == true)
                {
                    MessageBox.Show("Aluno alocado a empresa com sucesso");
                    dgvAlunosAlocados.DataSource = empresa.RetAlunosAlocados();
                }
            }

        }

        private void btnBuscarAluno_Click(object sender, EventArgs e)
        {
            if (txtBuscarAluno.Text.Length < 1 || txtBuscarAluno.Text == "Insira o código da Turma")
            {
               MessageBox.Show("Insira um valor no campo de filtro de \n             Turma ao lado da opção ''Filtrar por Turma''");
            }
            else
            {
                //Validação para o caso da tabela não tenha sido selecionada ainda
                if (dgvAlunos.Rows.Count == 0)
                {
                   MessageBox.Show("Por favor, selecione uma tabela antes de filtrar!");
                }
                else
                {
                    //Código para filtrar o datagridview, para colocar mais filtros juntos só adicionar AND/OR e a condição, 
                    // como faria no banco de dados 
                    (dgvAlunos.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("sexo LIKE '{0}%' OR idade LIKE '{0}%' OR nomeAluno LIKE '{0}%' OR cidade LIKE '{0}%' OR bairro LIKE '{0}%' ", txtBuscarAluno.Text);
                }
            }

        }

        private void btnBuscarEmpresa_Click(object sender, EventArgs e)
        {
            if (txtBuscarEmpresa.Text.Length < 1 || txtBuscarEmpresa.Text == "Insira o código da Turma")
            {
               if (txtBuscarEmpresa.Text.Length < 1 || txtBuscarEmpresa.Text == "Insira o código da Turma")
            {
                MessageBox.Show("Insira um valor no campo de filtro de \n             Turma ao lado da opção ''Filtrar por Turma''");
            }
            else
            {
                //Validação para o caso da tabela não tenha sido selecionada ainda
                if (dgvEmpresa.Rows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecione uma tabela antes de filtrar!");
                }
                else
                {
                    //Código para filtrar o datagridview, para colocar mais filtros juntos só adicionar AND/OR e a condição, 
                    // como faria no banco de dados 
                    (dgvEmpresa.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("nomeEmpresa LIKE '{0}%' OR cidade LIKE '{0}%'  ", txtBuscarEmpresa.Text);
                }
            }
            MessageBox.Show("Insira um valor no campo de filtro de \n             Turma ao lado da opção ''Filtrar por Turma''");
            }
            else
            {
                //Validação para o caso da tabela não tenha sido selecionada ainda
                if (dgvEmpresa.Rows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecione uma tabela antes de filtrar!");
                }
                else
                {
                    //Código para filtrar o datagridview, para colocar mais filtros juntos só adicionar AND/OR e a condição, 
                    // como faria no banco de dados 
                    (dgvEmpresa.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("nomeEmpresa LIKE '{0}%' OR cidade LIKE '{0}%'  ", txtBuscarEmpresa.Text);
                }
            }

        }
        private void userAlocarAluno_Load(object sender, EventArgs e)
        {

        }

        private void dgvAlunosAlocados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscarAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            //Se clicar em algum codigo no dgv
            if (dgvEmpresa.Rows[e.RowIndex].Cells["codEmpresa"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codEmpresaClicada = int.Parse(dgvEmpresa.Rows[e.RowIndex].Cells["codEmpresa"].Value.ToString());
            }
            txtNomeEmpresa.Text = dgvEmpresa.Rows[e.RowIndex].Cells["nomeEmpresa"].Value.ToString();
            mskCNPJ.Text = dgvEmpresa.Rows[e.RowIndex].Cells["cnpj"].Value.ToString();

        }
    }

}

    

