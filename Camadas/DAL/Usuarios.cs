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

        public void Insert(Camadas.MODEL.Usuarios Usuario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Usuarios values (@login, @senha);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
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
            string sql = "Update Usuarios set login=@login, senha=@senha, ";
            sql += "where idUsuario=@id_usuario; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_usuario", Usuario.idUsuario);
            cmd.Parameters.AddWithValue("@login", Usuario.login);
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

        public void Delete(int idUsuario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Usuarios where idUsuario=@id_usuario;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na remoção de Usuario.");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
