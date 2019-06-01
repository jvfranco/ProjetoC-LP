using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.DAL
{
    public class Funcionarios
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Funcionarios> Select()
        {
            List<MODEL.Funcionarios> listaFuncionarios = new List<MODEL.Funcionarios>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Funcionario";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Funcionarios Funcionario = new MODEL.Funcionarios();
                    Funcionario.idFuncionario = Convert.ToInt32(dados["id_funcionario"].ToString());
                    Funcionario.nome = dados["nome"].ToString();
                    Funcionario.cpf = dados["cpf"].ToString();
                    listaFuncionarios.Add(Funcionario);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Funcionarios.");
            }
            finally
            {
                conexao.Close();
            }

            return listaFuncionarios;
        }

        public void Insert(Camadas.MODEL.Funcionarios Funcionario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Funcionario values (@nome, @cpf);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", Funcionario.nome);
            cmd.Parameters.AddWithValue("@cpf", Funcionario.cpf);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Funcionario.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Camadas.MODEL.Funcionarios Funcionario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Funcionario set nome=@nome, cpf=@cpf, ";
            sql += "where idFuncionario=@id_funcionario; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_funcionario", Funcionario.idFuncionario);
            cmd.Parameters.AddWithValue("@nome", Funcionario.nome);
            cmd.Parameters.AddWithValue("@cpf", Funcionario.cpf);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de Funcionario.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int idFuncionario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Funcionario where idFuncionario=@id_funcionario;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_funcionario", idFuncionario);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na remoção de Funcionario.");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
