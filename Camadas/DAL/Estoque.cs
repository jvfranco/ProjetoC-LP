using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.DAL
{
    public class Estoque
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Estoque> Select()
        {
            List<MODEL.Estoque> listaEstoque = new List<MODEL.Estoque>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Estoque";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Estoque Estoque = new MODEL.Estoque();
                    Estoque.idProduto = Convert.ToInt32(dados["id_produto"].ToString());
                    Estoque.descricao = dados["descricao"].ToString();
                    Estoque.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    Estoque.valor = Convert.ToSingle(dados["valor"].ToString());
                    listaEstoque.Add(Estoque);
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

            return listaEstoque;
        }

        public List<MODEL.Estoque> SelectById(int id)
        {
            List<MODEL.Estoque> lstProdutos = new List<MODEL.Estoque>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Estoque where id_produto=@id_produto";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_produto", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Estoque produto = new MODEL.Estoque();
                    produto.idProduto = Convert.ToInt32(dados["id_produto"].ToString());
                    produto.descricao = dados["descricao"].ToString();
                    produto.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    produto.valor = Convert.ToSingle(dados["valor"].ToString());
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

        public List<MODEL.Estoque> SelectByDescricao(string descricao)
        {
            List<MODEL.Estoque> listaEstoque = new List<MODEL.Estoque>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Estoque where (descricao like @descricao)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", "%" + descricao + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Estoque produto = new MODEL.Estoque();
                    produto.idProduto = Convert.ToInt32(dados["id_produto"].ToString());
                    produto.descricao = dados["descricao"].ToString();
                    produto.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    produto.valor = Convert.ToSingle(dados["valor"].ToString());
                    listaEstoque.Add(produto);
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
            return listaEstoque;
        }

        public void Insert(Camadas.MODEL.Estoque Estoque)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Estoque values (@descricao, @quantidade, @valor);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", Estoque.descricao);
            cmd.Parameters.AddWithValue("@quantidade", Estoque.quantidade);
            cmd.Parameters.AddWithValue("@valor", Estoque.valor);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Produto.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Camadas.MODEL.Estoque Estoque)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Estoque set descricao=@descricao, quantidade=@quantidade, ";
            sql += "valor=@valor where id_produto=@id_produto; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_produto", Estoque.idProduto);
            cmd.Parameters.AddWithValue("@descricao", Estoque.descricao);
            cmd.Parameters.AddWithValue("@quantidade", Estoque.quantidade);
            cmd.Parameters.AddWithValue("@valor", Estoque.valor);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de Produto.");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
