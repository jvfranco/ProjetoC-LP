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
