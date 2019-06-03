using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Senai_projeto 
{
    class ClassLogin
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        ClassConexaoDB bd = new ClassConexaoDB();


        public int loginAdm()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE email = '{0}' AND senha = '{1}'", Email, Senha));
            bd.Desconectar();
            int linha = (dt.Rows.Count > 0) ? 1 : 0;
            return linha;
        }
        public int loginSecretaria()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE email = '{0}' AND senha = '{1}'", Email, Senha));
            bd.Desconectar();
            int linha = (dt.Rows.Count > 0) ? 1 : 0;
            return linha;
        }
      
    }
}

