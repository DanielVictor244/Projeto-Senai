﻿using System;
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
    public partial class UserStatus : UserControl
    {
        ClassEmpresa empresa = new ClassEmpresa();
        ClassSolicitarContrato contrato = new ClassSolicitarContrato();
        ClassStatusEmprego status = new ClassStatusEmprego();
        int codAlunoStatusEmprego, codAlunoAlocadoClicado = 0;
        public UserStatus()
        {
            InitializeComponent();
            RetornarAlunosAlucadosDgv();
            RetornarStatusEmpregoDgv();
        }
        private bool ChecarTextos()
        {
            if (String.IsNullOrEmpty(txtNomeEmpresa.Text) || String.IsNullOrEmpty(txtNomeAluno.Text) || String.IsNullOrEmpty(txtStatus.Text) || String.IsNullOrEmpty(rchDescricao.Text) || String.IsNullOrEmpty(txtPeriodo.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void LimparDados()
        {
            txtNomeEmpresa.Text = "";
            txtNomeAluno.Text = "";
            txtPeriodo.Text = "";
            txtStatus.Text = "";
            rchDescricao.Text = "";
            mskDataInicio.Text = "";
            mskDataFim.Text = "";
        }
        private void RetornarAlunosAlucadosDgv()
        {
            dgvAlunosAlocados.DataSource = empresa.RetAlunosAlocados();
            //Dgv ajustar o tamanho para o conteúdo dentro, não o header
            dgvAlunosAlocados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void RetornarStatusEmpregoDgv()
        {
            dgvStatusAlunosAlocados.DataSource = empresa.RetStatusAlunosAlocados();
            //Dgv ajustar o tamanho para o conteúdo dentro, não o header
            dgvStatusAlunosAlocados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void dgvAlunosAlocados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            //Se clicar em algum codigo no dgv
            if (dgvAlunosAlocados.Rows[e.RowIndex].Cells["codEmprego"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codAlunoAlocadoClicado = int.Parse(dgvAlunosAlocados.Rows[e.RowIndex].Cells["codEmprego"].Value.ToString());
            }
            txtNomeEmpresa.Text = dgvAlunosAlocados.Rows[e.RowIndex].Cells["nomeEmpresa"].Value.ToString();
            txtNomeAluno.Text = dgvAlunosAlocados.Rows[e.RowIndex].Cells["nomeAluno"].Value.ToString();
        }

        private void dgvStatusAlunosAlocados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            //Se clicar em algum codigo no dgv
            if (dgvStatusAlunosAlocados.Rows[e.RowIndex].Cells["codStatus"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codAlunoStatusEmprego = int.Parse(dgvStatusAlunosAlocados.Rows[e.RowIndex].Cells["codStatus"].Value.ToString());
            }
            txtNomeEmpresa.Text = dgvStatusAlunosAlocados.Rows[e.RowIndex].Cells["nomeEmpresa"].Value.ToString();
            txtNomeAluno.Text = dgvStatusAlunosAlocados.Rows[e.RowIndex].Cells["nomeAluno"].Value.ToString();
            txtStatus.Text = dgvStatusAlunosAlocados.Rows[e.RowIndex].Cells["statusAluno"].Value.ToString();
            rchDescricao.Text = dgvStatusAlunosAlocados.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
            txtPeriodo.Text = dgvStatusAlunosAlocados.Rows[e.RowIndex].Cells["periodoContrato"].Value.ToString();
            mskDataInicio.Text = dgvStatusAlunosAlocados.Rows[e.RowIndex].Cells["dataInicio"].Value.ToString();
            mskDataFim.Text = dgvStatusAlunosAlocados.Rows[e.RowIndex].Cells["dataFim"].Value.ToString();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            RetornarAlunosAlucadosDgv();
            RetornarStatusEmpregoDgv();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(ChecarTextos() == true)
            {
                RetornarDados();
                if (status.Inserir() == true)
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Cadastro");
                    RetornarStatusEmpregoDgv();
                    LimparDados();
                }
            }else
            {
                MessageBox.Show("         Favor preencher os dados \n                 corretamente.", "Validação");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ChecarTextos() == true)
            {
                RetornarDados();
                if (status.Editar(codAlunoStatusEmprego) == true)
                {
                    MessageBox.Show("Editado com sucesso!", "Edição");
                    RetornarStatusEmpregoDgv();
                    LimparDados();
                }
            }
            else
            {
                MessageBox.Show("         Favor preencher os dados \n                 corretamente.", "Validação");
            }
        }

        private void RetornarDados()
        {
            status.nomeEmpresa = txtNomeEmpresa.Text;
            status.nomeAluno = txtNomeAluno.Text;
            status.statusAluno = txtStatus.Text;
            status.descricao = rchDescricao.Text;
            status.periodoContrato = txtPeriodo.Text;
            status.dataInicio = mskDataInicio.Text;
            status.dataFim = mskDataFim.Text;
        }
    }
}
