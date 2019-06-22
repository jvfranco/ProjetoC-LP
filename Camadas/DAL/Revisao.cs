using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.DAL
{
    public class Revisao
    {
        private string strCon = Camadas.DAL.Conexao.getConexao();

        public List<MODEL.Revisao> Select()
        {
            List<MODEL.Revisao> lstRevisao = new List<MODEL.Revisao>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Revisao";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Revisao revisao = new MODEL.Revisao();
                    revisao.idRevisao = Convert.ToInt32(dados["id_revisao"].ToString());
                    revisao.idCliente = Convert.ToInt32(dados["id_cliente"].ToString());
                    revisao.idFuncionario = Convert.ToInt32(dados["id_funcionario"].ToString());
                    revisao.idServico = Convert.ToInt32(dados["id_servico"].ToString());
                    revisao.kmAtual = Convert.ToInt32(dados["km_atual"].ToString());
                    revisao.dataRevisao = Convert.ToDateTime(dados["data_revisao"].ToString());
                    revisao.observacao = dados["observacao"].ToString();
                    revisao.valor_total = Convert.ToSingle(dados["valor_total"].ToString());
                    revisao.idVeiculo = Convert.ToInt32(dados["id_veiculo"].ToString());
                    revisao.forma_pagto = dados["forma_pagto"].ToString();
                    revisao.desconto = Convert.ToSingle(dados["desconto"].ToString());
                    revisao.valor_final = Convert.ToSingle(dados["valor_final"].ToString());

                    lstRevisao.Add(revisao);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta da revisao.");
            }
            finally
            {
                conexao.Close();
            }

            return lstRevisao;
        }

        public void Insert(Camadas.MODEL.Revisao revisao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Revisao values (@id_cliente, @id_funcionario, @id_servico, @km_atual, @data_revisao, @observacao, @valor_total, @id_veiculo, @forma_pagto, @desconto, @valor_final)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_cliente", revisao.idCliente);
            cmd.Parameters.AddWithValue("@id_funcionario", revisao.idFuncionario);
            cmd.Parameters.AddWithValue("@id_servico", revisao.idServico);
            cmd.Parameters.AddWithValue("@km_atual", revisao.kmAtual);
            cmd.Parameters.AddWithValue("@data_revisao", revisao.kmAtual);
            cmd.Parameters.AddWithValue("@observacao", revisao.kmAtual);
            cmd.Parameters.AddWithValue("@valor_total", revisao.kmAtual);
            cmd.Parameters.AddWithValue("@id_veiculo", revisao.kmAtual);
            cmd.Parameters.AddWithValue("@forma_pagto", revisao.kmAtual);
            cmd.Parameters.AddWithValue("@desconto", revisao.kmAtual);
            cmd.Parameters.AddWithValue("@valor_final", revisao.kmAtual);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();          
            }
            catch
            {
                Console.WriteLine("Deu erro na Inserção da Venda.");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
