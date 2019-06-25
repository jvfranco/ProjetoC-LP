using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.DAL
{
    public class Revisao_Estoque
    {
        private string strCon = Conexao.getConexao();

        public List<Camadas.MODEL.Revisao_Estoque> SelectByIdServico(int id)
        {
            List<Camadas.MODEL.Revisao_Estoque> lstProdutos = new List<MODEL.Revisao_Estoque>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert * from Revisao_Estoque where id_revisao=@id_revisao;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_revisao", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Revisao_Estoque produto = new MODEL.Revisao_Estoque();
                    produto.idRevisao = Convert.ToInt32(dados["id_revisao"].ToString());
                    produto.idProduto = Convert.ToInt32(dados["id_produto"].ToString());
                    produto.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    lstProdutos.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Produtos.");
            }
            finally
            {
                conexao.Close();
            }
            return lstProdutos;
        }

        public void Insert(Camadas.MODEL.Revisao_Estoque prodRev)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Revisao_Estoque values (@id_revisao, @id_produto, @quantidade);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_revisao", prodRev.idRevisao);
            cmd.Parameters.AddWithValue("@id_produto", prodRev.idProduto);
            cmd.Parameters.AddWithValue("@quantidade", prodRev.quantidade);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção dos produtos da venda.");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
