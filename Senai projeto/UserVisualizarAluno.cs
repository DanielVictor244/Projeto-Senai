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
    public partial class UserVisualizarAluno : UserControl
    {
        ClassAluno aluno = new ClassAluno();
        public UserVisualizarAluno()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
                    }

        private void UserVisualizarAluno_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipo_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvVisualizarAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            dgvVisualizarAluno.DataSource = aluno.retAlunos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtBuscar.Text.Length < 1 || txtBuscar.Text == "Insira o código da Turma")
            {
                MessageBox.Show("Insira um valor no campo de filtro de \n             Turma ao lado da opção ''Filtrar por Turma''");
            }
            else
            {
                //Validação para o caso da tabela não tenha sido selecionada ainda
                if (dgvVisualizarAluno.Rows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecione uma tabela antes de filtrar!");
                }
                else
                {
                    //Código para filtrar o datagridview, para colocar mais filtros juntos só adicionar AND/OR e a condição, 
                    // como faria no banco de dados 
                    (dgvVisualizarAluno.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("sexo LIKE '{0}%' OR idade LIKE '{0}%' OR nomeAluno LIKE '{0}%' OR cidade LIKE '{0}%' OR bairro LIKE '{0}%' ", txtBuscar.Text);
                }
            }
        }
    }
}
