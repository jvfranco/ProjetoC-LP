using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.DAL
{
    public class Veiculo_Cliente
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Veiculo_Cliente> Select()
        {
            List<MODEL.Veiculo_Cliente> listaVeiculo_Cliente = new List<MODEL.Veiculo_Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Veiculo_Cliente";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Veiculo_Cliente veiCli = new MODEL.Veiculo_Cliente();
                    veiCli.idCliente = Convert.ToInt32(dados["id_cliente"].ToString());
                    veiCli.idVeiculo = Convert.ToInt32(dados["id_veiculo"].ToString());
                    listaVeiculo_Cliente.Add(veiCli);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Veiculo_Cliente.");
            }
            finally
            {
                conexao.Close();
            }

            return listaVeiculo_Cliente;
        }

        public void Insert(Camadas.MODEL.Veiculo_Cliente veiCli)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Veiculo_Cliente values (@id_cliente, @id_veiculo);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_cliente", veiCli.idCliente);
            cmd.Parameters.AddWithValue("@id_veiculo", veiCli.idVeiculo);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de veiCli.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Camadas.MODEL.Veiculo_Cliente veiCli)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Veiculo_Cliente set idCliente=@id_cliente, idVeiculo=@id_veiculo, ";
            sql += "where idCliente=@id_cliente and idVeiculo=@id_veiculo; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_cliente", veiCli.idCliente);
            cmd.Parameters.AddWithValue("@id_veiculo", veiCli.idVeiculo);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de veiCli.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int idCliente, int idVeiculo)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Veiculo_Cliente where idCliente=@id_cliente and idVeiculo=@id_veiculo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_cliente", idCliente);
            cmd.Parameters.AddWithValue("@id_veiculo", idVeiculo);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na remoção de veiCli.");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
