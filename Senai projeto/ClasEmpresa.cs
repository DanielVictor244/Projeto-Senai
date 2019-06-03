using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Senai_projeto
{
    class ClassEmpresa
    {
        ClassConexaoDB bd = new ClassConexaoDB();

        public int codEmpresa { get; set; }
        public string nomeEmpresa { get; set; }
        public string telefone { get; set; }
        public string emailContato { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string bairro { get; set; }
        public string rua { get; set; }
        public string complemento { get; set; }
        public string numeroCasa { get; set; }
        public string cep { get; set; }
        public string Aluno_codAluno { get; set; }

        public bool Inserir()
        {

            try
            {
                // Conecta no banco
                bd.Conectar();

                // Executa o insert
                bd.ExecutarComandosSql(string.Format("INSERT INTO Empresa ( nomeEmpresa,telefone,emailContato,cidade,estado,bairro,rua,complemento,numeroCasa,cep" +
                    " endereco) VALUES ()", nomeEmpresa, telefone, emailContato, cidade, estado, bairro, rua, complemento, nomeEmpresa, cep));


                // Desconecta no banco

                bd.Desconectar();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " Erro ao inserir Empresa! ");
            }
        }

        public DataTable RetTodosEmpresa()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(string.Format("SELECT * FROM Empresa"));


            bd.Desconectar();

            return dt;
        }

        public bool Editar(int codEmpresaClicado)
        {
            try
            {
                // Conecta no banco
                bd.Conectar();

                // Executa o insert
                bd.ExecutarComandosSql(String.Format("UPDATE Empresa SET   nomeEmpresa = '{0}', telefone = '{1}', cidade = '{2}',estado = '{3}',bairro = '{4}',rua = '{5}',complemento = '{6}',numeroCasa = '{7}',cep = '{8}' "
                + " WHERE " +
                " Aluno_codAluno = {9}, codEmpresa LIKE {10}" // arg 0
                , nomeEmpresa // arg  1
                , telefone // arg  2
                , cidade // arg  3
                , estado
                , bairro
                , rua
                , complemento
                , numeroCasa
                , cep
                , codEmpresa
                , Aluno_codAluno
                // arg 4             
                ));



                // Desconecta no banco

                bd.Desconectar();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " Erro ao editar Empresa! ");
            }
        }



        public DataTable RetEmpresaNome(string busca)
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Empresa WHERE nomeEmpresa like '%{0}%'", busca));

            bd.Desconectar();

            return dt;
        }
        public bool Excluir(string codEmpresaClicado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM curso WHERE codEmpresa LIKE {0}", codEmpresaClicado));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)                  
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados da Empresa. ");
            }
        }
    }


    }


