using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Forms;

namespace InfoGestOficial
{
    internal class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=;database=infogest");
        public String mensagem;

        public bool insereEmpresa(empresa em)
        {
            MySqlCommand cmd = new MySqlCommand("cad_empresa", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nome_empresa", em.Nome_Empresa);
            cmd.Parameters.AddWithValue("cnpj_empresa", em.Cnpj_Empresa);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim insereEmpresa

        public bool cad_func(funcionarios f)
        {
            MySqlCommand cmd = new MySqlCommand("cad_func", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nom_func", f.Nome);
            cmd.Parameters.AddWithValue("cpf_func", f.Cpf);
            cmd.Parameters.AddWithValue("login_func", f.Login);
            cmd.Parameters.AddWithValue("senha_func", f.Senha);
            cmd.Parameters.AddWithValue("tel_func", f.Tel);
            cmd.Parameters.AddWithValue("end_func", f.End);
            cmd.Parameters.AddWithValue("salario_func", f.Salario);
            cmd.Parameters.AddWithValue("funcao_func", f.Cargo);
            cmd.Parameters.AddWithValue("adm", f.Adm);


            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim cadastro funcionario
        public bool testeConection()
        {
            try
            {
                conexao.Open();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
        }
        public DataTable listaFuncionarios(string cmdSql)
        {
            MySqlCommand cmd = new MySqlCommand("lista_func", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_func

        public DataTable valida(string cmdSql)
        {
            MySqlCommand cmd = new MySqlCommand("valida_user", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

            public bool insereFornecedor(fornecedores forn)
            {
                MySqlCommand cmd = new MySqlCommand("insere_fornecedor", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nome", forn.Nome);
                cmd.Parameters.AddWithValue("cnpj", forn.Cnpj);
                cmd.Parameters.AddWithValue("endereco", forn.Endereco);

                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery(); // executa o comando
                    return true;
                }
                catch (MySqlException e)
                {
                    mensagem = "Erro:" + e.Message;
                    return false;
                }
                finally
                {
                    conexao.Close();
                }
            }// fim insereBanda
        }
    }
}     
