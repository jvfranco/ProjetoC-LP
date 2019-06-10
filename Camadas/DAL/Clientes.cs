using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.DAL
{
    public class Clientes
    {
        private string strCon = Conexao.getConexao();


        public List<MODEL.Clientes> Select()
        { 
            List<MODEL.Clientes> listaClientes = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Clientes";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Clientes cliente = new MODEL.Clientes();
                    cliente.idCliente = Convert.ToInt32(dados["id_cliente"].ToString());
                    cliente.nome = dados["nome"].ToString();
                    cliente.endereco = dados["endereco"].ToString();
                    cliente.numero = Convert.ToInt32(dados["numero"].ToString());
                    cliente.bairro = dados["bairro"].ToString();
                    cliente.cep = dados["cep"].ToString();
                    cliente.cidade = dados["cidade"].ToString();
                    cliente.estado = dados["estado"].ToString();
                    cliente.telefone = dados["telefone"].ToString();
                    cliente.email = dados["email"].ToString();
                    cliente.dataCadastro = Convert.ToDateTime(dados["data_cadastro"].ToString());
                    cliente.cpf_cnpj = dados["cpf_cnpj"].ToString();
                    cliente.rg = dados["rg"].ToString();
                    cliente.tipoPessoa = dados["tipo_pessoa"].ToString();

                    listaClientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de clientes.");
            }
            finally
            {
                conexao.Close();
            }

            return listaClientes;
        }

        public MODEL.Clientes SelectByID(int id_cliente)
        {
            MODEL.Clientes cliente = new MODEL.Clientes();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Clientes where id_cliente=@id_cliente";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {                    
                    cliente.idCliente = Convert.ToInt32(dados["id_cliente"].ToString());
                    cliente.nome = dados["nome"].ToString();
                    cliente.endereco = dados["endereco"].ToString();
                    cliente.numero = Convert.ToInt32(dados["numero"].ToString());
                    cliente.bairro = dados["bairro"].ToString();
                    cliente.cep = dados["cep"].ToString();
                    cliente.cidade = dados["cidade"].ToString();
                    cliente.estado = dados["estado"].ToString();
                    cliente.telefone = dados["telefone"].ToString();
                    cliente.email = dados["email"].ToString();
                    cliente.dataCadastro = Convert.ToDateTime(dados["data_cadastro"].ToString());
                    cliente.cpf_cnpj = dados["cpf_cnpj"].ToString();
                    cliente.rg = dados["rg"].ToString();
                    cliente.tipoPessoa = dados["tipo_pessoa"].ToString();
                    
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de clientes por ID.");
            }
            finally
            {
                conexao.Close();
            }
            return cliente;

        }

        public List<MODEL.Clientes> SelectByNome(string nome)
        {
            List<MODEL.Clientes> listaClientes = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Clientes where (nome like @nome)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Clientes cliente = new MODEL.Clientes();
                    cliente.idCliente = Convert.ToInt32(dados["id_cliente"].ToString());
                    cliente.nome = dados["nome"].ToString();
                    cliente.endereco = dados["endereco"].ToString();
                    cliente.numero = Convert.ToInt32(dados["numero"].ToString());
                    cliente.bairro = dados["bairro"].ToString();
                    cliente.cep = dados["cep"].ToString();
                    cliente.cidade = dados["cidade"].ToString();
                    cliente.estado = dados["estado"].ToString();
                    cliente.telefone = dados["telefone"].ToString();
                    cliente.email = dados["email"].ToString();
                    cliente.dataCadastro = Convert.ToDateTime(dados["data_cadastro"].ToString());
                    cliente.cpf_cnpj = dados["cpf_cnpj"].ToString();
                    cliente.rg = dados["rg"].ToString();
                    cliente.tipoPessoa = dados["tipo_pessoa"].ToString();

                    listaClientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de clientes por Nome.");
            }
            finally
            {
                conexao.Close();
            }

            return listaClientes;
        }

        public void Insert(Camadas.MODEL.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Clientes values (@nome, @endereco, @numero, @bairro, @cep, @cidade, @estado, @telefone, @email, @data_cadastro, @cpf_cnpj, @rg, @tipo_pessoa);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@numero", cliente.numero);
            cmd.Parameters.AddWithValue("@bairro", cliente.bairro);
            cmd.Parameters.AddWithValue("@cep", cliente.cep);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@estado", cliente.estado);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@email", cliente.email);
            cmd.Parameters.AddWithValue("@data_cadastro", cliente.dataCadastro);
            cmd.Parameters.AddWithValue("@cpf_cnpj", cliente.cpf_cnpj);
            cmd.Parameters.AddWithValue("@rg", cliente.rg);
            cmd.Parameters.AddWithValue("@tipo_pessoa", cliente.tipoPessoa);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de cliente.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Camadas.MODEL.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Clientes set nome=@nome, endereco=@endereco, ";
            sql += "numero=@numero, bairro=@bairro, cep=@cep, ";
            sql += "cidade=@cidade, estado=@estado, telefone=@telefone, ";
            sql += "email=@email, dataCadastro=@data_cadastro, cpf_cnpj=@cpf_cnpj, ";
            sql += "rg=@rg tipoPessoa=@tipo_pessoa where idCliente=@id_cliente; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_cliente", cliente.idCliente);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@numero", cliente.numero);
            cmd.Parameters.AddWithValue("@bairro", cliente.bairro);
            cmd.Parameters.AddWithValue("@cep", cliente.cep);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@estado", cliente.estado);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@email", cliente.email);
            cmd.Parameters.AddWithValue("@data_cadastro", cliente.dataCadastro);
            cmd.Parameters.AddWithValue("@cpf_cnpj", cliente.cpf_cnpj);
            cmd.Parameters.AddWithValue("@rg", cliente.rg);
            cmd.Parameters.AddWithValue("@tipo_pessoa", cliente.tipoPessoa);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de cliente.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int idCliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Clientes where idCliente=@id_cliente;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_cliente", idCliente);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na remoção de cliente.");
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
