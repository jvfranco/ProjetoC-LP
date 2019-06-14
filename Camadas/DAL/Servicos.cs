using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.DAL
{
    public class Servicos
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Servicos> Select()
        {
            List<MODEL.Servicos> listaServicos = new List<MODEL.Servicos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Servicos";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Servicos Servico = new MODEL.Servicos();
                    Servico.idServico = Convert.ToInt32(dados["id_servico"].ToString());
                    Servico.descricao = dados["descricao"].ToString();
                    Servico.valMaoObra = Convert.ToSingle(dados["val_mao_obra"].ToString());
                    listaServicos.Add(Servico);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Servicos.");
            }
            finally
            {
                conexao.Close();
            }

            return listaServicos;
        }
        public List<MODEL.Servicos> SelectByIdList(int id)
        {
            List<MODEL.Servicos> listaServicos = new List<MODEL.Servicos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Servicos where id_servico=@id_servico";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_servico", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Servicos servico = new MODEL.Servicos();
                    servico.idServico = Convert.ToInt32(dados["id_servico"].ToString());
                    servico.descricao = dados["descricao"].ToString();
                    servico.valMaoObra = Convert.ToSingle(dados["val_mao_obra"].ToString());
                    listaServicos.Add(servico);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Servicos.");
            }
            finally
            {
                conexao.Close();
            }

            return listaServicos;
        }

        public MODEL.Servicos SelectById(int id)
        {
            MODEL.Servicos servico = new MODEL.Servicos();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Servicos where id_servico=@id_servico";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_servico", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {                    
                    servico.idServico = Convert.ToInt32(dados["id_servico"].ToString());
                    servico.descricao = dados["descricao"].ToString();
                    servico.valMaoObra = Convert.ToSingle(dados["val_mao_obra"].ToString());
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Servicos.");
            }
            finally
            {
                conexao.Close();
            }

            return servico;
        }
        public List<MODEL.Servicos> SelectByDescricao(string descricao)
        {
            List<MODEL.Servicos> listaServicos = new List<MODEL.Servicos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Servicos where (descricao like @descricao)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", "%" + descricao + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Servicos servico = new MODEL.Servicos();
                    servico.idServico = Convert.ToInt32(dados["id_servico"].ToString());
                    servico.descricao = dados["descricao"].ToString();
                    servico.valMaoObra = Convert.ToSingle(dados["val_mao_obra"].ToString());
                    listaServicos.Add(servico);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Servicos.");
            }
            finally
            {
                conexao.Close();
            }
            return listaServicos;
        }
        public void Insert(Camadas.MODEL.Servicos Servico)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Servicos values (@descricao, @val_mao_obra);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", Servico.descricao);
            cmd.Parameters.AddWithValue("@val_mao_obra", Servico.valMaoObra);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Servico.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Camadas.MODEL.Servicos Servico)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Servicos set descricao=@descricao, val_mao_obra=@val_mao_obra, ";
            sql += "where idServico=@id_servico; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_servico", Servico.idServico);
            cmd.Parameters.AddWithValue("@descricao", Servico.descricao);
            cmd.Parameters.AddWithValue("@valor_mao_obra", Servico.valMaoObra);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de Servico.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int idServico)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Servicos where idServico=@id_servico;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_servico", idServico);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na remoção de Servico.");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
