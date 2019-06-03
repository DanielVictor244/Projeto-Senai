using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Senai_projeto
{
   
        class ClassUsuario
        {
            ClassConexaoDB bd = new ClassConexaoDB();

            public int codUsuario { get; set; }
            public string emailUsuario { get; set; }
            public string senha { get; set; }
            public string tipo { get; set; }
            


            public bool Inserir()
            {
                try
                {
                    // Conecta no banco
                    bd.Conectar();

                    // Executa o insert
                    bd.ExecutarComandosSql(string.Format("INSERT INTO Usuario ( emailUsuario,  senha, tipo, "+
                        ") VALUES ('{0}','{1}','{2}')", emailUsuario,
                         senha, tipo));


                    // Desconecta no banco

                    bd.Desconectar();

                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message + " Erro ao inserir Usuario! ");
                }
            }
            public bool Valida(string cpf)

            {

                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                string tempCpf;

                string digito;

                int soma;

                int resto;

                cpf = cpf.Trim();

                cpf = cpf.Replace(".", "").Replace("-", "");

                if (cpf.Length != 11)

                    return false;

                tempCpf = cpf.Substring(0, 9);

                soma = 0;

                for (int i = 0; i < 9; i++)

                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

                resto = soma % 11;

                if (resto < 2)

                    resto = 0;

                else

                    resto = 11 - resto;

                digito = resto.ToString();

                tempCpf = tempCpf + digito;

                soma = 0;

                for (int i = 0; i < 10; i++)

                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

                resto = soma % 11;

                if (resto < 2)

                    resto = 0;

                else

                    resto = 11 - resto;

                digito = digito + resto.ToString();

                return cpf.EndsWith(digito);

            }

            public static bool ValidarEmail(string email)
            {
                bool validEmail = false;
                int indexArr = email.IndexOf('@');
                if (indexArr > 0)
                {
                    int indexDot = email.IndexOf('.', indexArr);
                    if (indexDot - 1 > indexArr)
                    {
                        if (indexDot + 1 < email.Length)
                        {
                            string indexDot2 = email.Substring(indexDot + 1, 1);
                            if (indexDot2 != ".")
                            {
                                validEmail = true;
                            }
                        }
                    }
                }
                return validEmail;
            }



        }
    }


