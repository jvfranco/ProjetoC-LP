﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.DAL
{
    public class Funcionarios
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Funcionarios> Select()
        {
            List<MODEL.Funcionarios> listaFuncionarios = new List<MODEL.Funcionarios>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Funcionario";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Funcionarios Funcionario = new MODEL.Funcionarios();
                    Funcionario.idFuncionario = Convert.ToInt32(dados["id_funcionario"].ToString());
                    Funcionario.nome = dados["nome"].ToString();
                    Funcionario.cpf = dados["cpf"].ToString();
                    Funcionario.cargo = dados["cargo"].ToString();
                    listaFuncionarios.Add(Funcionario);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Funcionarios.");
            }
            finally
            {
                conexao.Close();
            }

            return listaFuncionarios;
        }

        public List<MODEL.Funcionarios> SelectById(int id)
        {
            List<MODEL.Funcionarios> listaFuncionarios = new List<MODEL.Funcionarios>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Funcionario where id_funcionario=@id_funcionario";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_funcionario", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Funcionarios Funcionario = new MODEL.Funcionarios();
                    Funcionario.idFuncionario = Convert.ToInt32(dados["id_funcionario"].ToString());
                    Funcionario.nome = dados["nome"].ToString();
                    Funcionario.cpf = dados["cpf"].ToString();
                    Funcionario.cargo = dados["cargo"].ToString();
                    listaFuncionarios.Add(Funcionario);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Funcionarios.");
            }
            finally
            {
                conexao.Close();
            }

            return listaFuncionarios;
        }

        public List<MODEL.Funcionarios> SelectByNome(string nome)
        {
            List<MODEL.Funcionarios> listaFuncionarios = new List<MODEL.Funcionarios>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Funcionario where (nome like @nome)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Funcionarios Funcionario = new MODEL.Funcionarios();
                    Funcionario.idFuncionario = Convert.ToInt32(dados["id_funcionario"].ToString());
                    Funcionario.nome = dados["nome"].ToString();
                    Funcionario.cpf = dados["cpf"].ToString();
                    Funcionario.cargo = dados["cargo"].ToString();
                    listaFuncionarios.Add(Funcionario);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Funcionarios.");
            }
            finally
            {
                conexao.Close();
            }

            return listaFuncionarios;
        }

        public void Insert(Camadas.MODEL.Funcionarios Funcionario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Funcionario values (@nome, @cpf, @cargo);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", Funcionario.nome);
            cmd.Parameters.AddWithValue("@cpf", Funcionario.cpf);
            cmd.Parameters.AddWithValue("@cargo", Funcionario.cargo);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Funcionario.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Camadas.MODEL.Funcionarios Funcionario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Funcionario set nome=@nome, cpf=@cpf, cargo=@cargo ";
            sql += "where id_funcionario=@id_funcionario; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_funcionario", Funcionario.idFuncionario);
            cmd.Parameters.AddWithValue("@nome", Funcionario.nome);
            cmd.Parameters.AddWithValue("@cpf", Funcionario.cpf);
            cmd.Parameters.AddWithValue("@cargo", Funcionario.cargo);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de Funcionario.");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
