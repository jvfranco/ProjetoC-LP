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
                    MODEL.Veiculos veiculo = new MODEL.Veiculos();
                    veiculo.idVeiculo = Convert.ToInt32(dados["id_veiculo"].ToString());
                    veiculo.idCliente = Convert.ToInt32(dados["id_cliente"].ToString());
                    veiculo.modelo = dados["modelo"].ToString();
                    veiculo.marca = dados["marca"].ToString();
                    veiculo.placa = dados["placa"].ToString();
                    
                    listaVeiculos.Add(veiculo);
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

        public List<MODEL.Veiculos> SelectById(int id)
        {
            List<MODEL.Veiculos> listaVeiculos = new List<MODEL.Veiculos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Veiculos where id_veiculo=@id_veiculo";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_veiculo", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Veiculos veiculo = new MODEL.Veiculos();
                    veiculo.idVeiculo = Convert.ToInt32(dados["id_veiculo"].ToString());
                    veiculo.idCliente = Convert.ToInt32(dados["id_cliente"].ToString());
                    veiculo.modelo = dados["modelo"].ToString();
                    veiculo.marca = dados["marca"].ToString();
                    veiculo.placa = dados["placa"].ToString();

                    listaVeiculos.Add(veiculo);
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

        public List<MODEL.Veiculos> SelectByModelo(string modelo)
        {
            List<MODEL.Veiculos> listaVeiculos = new List<MODEL.Veiculos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Veiculos where (modelo like @modelo)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@modelo", "%" + modelo + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Veiculos veiculo = new MODEL.Veiculos();
                    veiculo.idVeiculo = Convert.ToInt32(dados["id_veiculo"].ToString());
                    veiculo.idCliente = Convert.ToInt32(dados["id_cliente"].ToString());
                    veiculo.modelo = dados["modelo"].ToString();
                    veiculo.marca = dados["marca"].ToString();
                    veiculo.placa = dados["placa"].ToString();

                    listaVeiculos.Add(veiculo);
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

        public void Insert(Camadas.MODEL.Veiculos veiculo)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Veiculos values (@id_cliente, @modelo, @marca, @placa);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_cliente", veiculo.idCliente);
            cmd.Parameters.AddWithValue("@modelo", veiculo.modelo);
            cmd.Parameters.AddWithValue("@marca", veiculo.marca);
            cmd.Parameters.AddWithValue("@placa", veiculo.placa);
            
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

        public void Update(Camadas.MODEL.Veiculos veiculo)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Veiculos set modelo=@modelo, marca=@marca, ";
            sql += "placa=@placa, id_cliente=@id_cliente where id_veiculo=@id_veiculo; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_veiculo", veiculo.idVeiculo);
            cmd.Parameters.AddWithValue("@modelo", veiculo.modelo);
            cmd.Parameters.AddWithValue("@marca", veiculo.marca);
            cmd.Parameters.AddWithValue("@placa", veiculo.placa);
            cmd.Parameters.AddWithValue("@id_cliente", veiculo.idCliente);
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
    }
}
