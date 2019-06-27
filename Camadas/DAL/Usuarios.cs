using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.DAL
{
    public class Usuarios
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Usuarios> Select()
        {
            List<MODEL.Usuarios> listaUsuarios = new List<MODEL.Usuarios>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Usuarios";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Usuarios Usuario = new MODEL.Usuarios();
                    Usuario.idUsuario = Convert.ToInt32(dados["id_usuario"].ToString());
                    Usuario.idFuncionario = Convert.ToInt32(dados["id_funcionario"].ToString());
                    Usuario.login = dados["login"].ToString();
                    Usuario.senha = dados["senha"].ToString();
                    listaUsuarios.Add(Usuario);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Usuarios.");
            }
            finally
            {
                conexao.Close();
            }

            return listaUsuarios;
        }

        public List<MODEL.Usuarios> SelectByIdFunc(int id)
        {
            List<MODEL.Usuarios> listaUsuarios = new List<MODEL.Usuarios>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Usuarios where id_funcionario=@id_funcionario";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_funcionario", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Usuarios Usuario = new MODEL.Usuarios();
                    Usuario.idUsuario = Convert.ToInt32(dados["id_usuario"].ToString());
                    Usuario.idFuncionario = Convert.ToInt32(dados["id_funcionario"].ToString());
                    Usuario.login = dados["login"].ToString();
                    Usuario.senha = dados["senha"].ToString();
                    listaUsuarios.Add(Usuario);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Usuarios.");
            }
            finally
            {
                conexao.Close();
            }

            return listaUsuarios;
        }

        public MODEL.Usuarios SelectByLogin(string login)
        {
            MODEL.Usuarios usuario = new MODEL.Usuarios();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Usuarios where (login like @login)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@login", login);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    usuario.idUsuario = Convert.ToInt32(dados["id_usuario"].ToString());
                    usuario.idFuncionario = Convert.ToInt32(dados["id_funcionario"].ToString());
                    usuario.login = dados["login"].ToString();
                    usuario.senha = dados["senha"].ToString();
                    
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Usuarios.");
            }
            finally
            {
                conexao.Close();
            }

            return usuario;
        }

        public void Insert(Camadas.MODEL.Usuarios Usuario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Usuarios values (@id_funcionario, @login, @senha);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_funcionario", Usuario.idFuncionario);
            cmd.Parameters.AddWithValue("@login", Usuario.login);
            cmd.Parameters.AddWithValue("@senha", Usuario.senha);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Usuario.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Camadas.MODEL.Usuarios Usuario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Usuarios set senha=@senha where id_usuario=@id_usuario;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_usuario", Usuario.idUsuario);
            cmd.Parameters.AddWithValue("@senha", Usuario.senha);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de Usuario.");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
