using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.DAL
{
    public class Veiculos
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Veiculos> Select()
        {
            List<MODEL.Veiculos> listaVeiculos = new List<MODEL.Veiculos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Veiculos";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Veiculos Veiculo = new MODEL.Veiculos();
                    Veiculo.idVeiculo = Convert.ToInt32(dados["id_veiculo"].ToString());
                    Veiculo.modelo = dados["modelo"].ToString();
                    Veiculo.marca = dados["marca"].ToString();
                    Veiculo.placa = dados["numero"].ToString();
                    listaVeiculos.Add(Veiculo);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Veiculos.");
            }
            finally
            {
                conexao.Close();
            }

            return listaVeiculos;
        }

        public void Insert(Camadas.MODEL.Veiculos Veiculo)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Veiculos values (@modelo, @marca, @placa);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@modelo", Veiculo.modelo);
            cmd.Parameters.AddWithValue("@marca", Veiculo.marca);
            cmd.Parameters.AddWithValue("@placa", Veiculo.placa);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Veiculo.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Camadas.MODEL.Veiculos Veiculo)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Veiculos set modelo=@modelo, marca=@marca, ";
            sql += "placa=@placa where idVeiculo=@id_veiculo; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_veiculo", Veiculo.idVeiculo);
            cmd.Parameters.AddWithValue("@modelo", Veiculo.modelo);
            cmd.Parameters.AddWithValue("@marca", Veiculo.marca);
            cmd.Parameters.AddWithValue("@placa", Veiculo.placa);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de Veiculo.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int idVeiculo)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Veiculos where idVeiculo=@id_veiculo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_veiculo", idVeiculo);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na remoção de Veiculo.");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
