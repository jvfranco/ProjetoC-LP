using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Relatorios
{
    public class relVendas
    {
        public static void impRelatorioVendas()
        {
            Camadas.BLL.Revisao bllVenda = new Camadas.BLL.Revisao();
            Camadas.BLL.Revisao_Estoque bllProdVenda = new Camadas.BLL.Revisao_Estoque();
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            Camadas.BLL.Funcionario bllFuncionario = new Camadas.BLL.Funcionario();
            Camadas.BLL.Veiculo bllVeiculo = new Camadas.BLL.Veiculo();
            Camadas.BLL.Servico bllServico = new Camadas.BLL.Servico();

            List<Camadas.MODEL.Revisao> lstVendas = new List<Camadas.MODEL.Revisao>();
            List<Camadas.MODEL.Revisao_Estoque> lstProdutosVenda = new List<Camadas.MODEL.Revisao_Estoque>();

            Camadas.MODEL.Clientes cliente = new Camadas.MODEL.Clientes();
            Camadas.MODEL.Funcionarios funcionario = new Camadas.MODEL.Funcionarios();
            Camadas.MODEL.Servicos servico = new Camadas.MODEL.Servicos();
            Camadas.MODEL.Veiculos veiculo = new Camadas.MODEL.Veiculos();

            int totalVendas = 0;
            float valorTotalVendas = 0;

            lstVendas = bllVenda.Select();

            foreach (Camadas.MODEL.Revisao venda in lstVendas)
            {
                totalVendas++;
                valorTotalVendas += venda.valor_final;
            }

            string folder = Funcoes.diretorioPasta();
            string arquivo = folder + @"\RelatorioVendas.html";
            StreamWriter sw = new StreamWriter(arquivo);

            using (sw)
            {
                sw.WriteLine("<!DOCTYPE html>");
                sw.WriteLine("<html lang='pt-br'>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta charset='UTF-8'/>");
                sw.WriteLine("<title>Relatório de Vendas</title>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css' integrity='sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO' crossorigin='anonymous'/>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<div class='container'>");
                sw.WriteLine("<div class='row'>");
                sw.WriteLine("<div class='col-sm-12 col-md-12'>");
                sw.WriteLine("<br>");
                sw.WriteLine("<h1 class='text-center'>Relatório de Vendas</h1>");
                sw.WriteLine("</div>");
                sw.WriteLine("<br>");

                sw.WriteLine("<div class='card text-white bg-primary mb-3 col-sm-12 col-md-6'>");
                sw.WriteLine("<div class='card-header text-center'>NÚMERO DE VENDAS</div>");
                sw.WriteLine("<div class='card-body'>");
                sw.WriteLine("<h2 class='card-text text-center'> " +  totalVendas + " </h2>");
                sw.WriteLine("</div>");
                sw.WriteLine("</div>");

                sw.WriteLine("<div class='card text-white bg-danger mb-3 col-sm-12 col-md-6'>");
                sw.WriteLine("<div class='card-header text-center'>VALOR TOTAL DAS VENDAS</div>");
                sw.WriteLine("<div class='card-body'>");
                sw.WriteLine("<h2 class='card-text text-center'> " + string.Format("{0:C2}", valorTotalVendas) + " </h2>");
                sw.WriteLine("</div>");
                sw.WriteLine("</div>");
                sw.WriteLine("</div>");

                sw.WriteLine("<div class='row'>");
                sw.WriteLine("<div class='col-sm-12 col-md-12'>");
                sw.WriteLine("<table class='table table-hover table-bordered'>");
                sw.WriteLine("<thead class='thead-dark'>");
                sw.WriteLine("<tr>");
                sw.WriteLine("<th scope='col'>Código</th>");
                sw.WriteLine("<th scope='col'>Cliente</th>");
                sw.WriteLine("<th scope='col'>Funcionário</th>");
                sw.WriteLine("<th scope='col'>Veiculo</th>");
                sw.WriteLine("<th scope='col'>Placa</th>");
                sw.WriteLine("<th scope='col'>Serviço</th>");
                sw.WriteLine("<th scope='col'>Valor Sem Desconto</th>");
                sw.WriteLine("<th scope='col'>Desconto</th>");
                sw.WriteLine("<th scope='col'>Valor Final</th>");
                sw.WriteLine("</tr>");
                sw.WriteLine("</thead>");
                sw.WriteLine("<tbody>");

                foreach(Camadas.MODEL.Revisao venda in lstVendas)
                {
                    cliente = bllCliente.SelectByID(Convert.ToInt32(venda.idCliente))[0];
                    funcionario = bllFuncionario.SelectById(Convert.ToInt32(venda.idFuncionario))[0];
                    veiculo = bllVeiculo.SelectById(Convert.ToInt32(venda.idVeiculo))[0];
                    servico = bllServico.SelectById(Convert.ToInt32(venda.idServico))[0];

                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td>" + venda.idRevisao + "</td>");
                    sw.WriteLine("<td>" + cliente.nome + "</td>");
                    sw.WriteLine("<td>" + funcionario.nome + "</td>");
                    sw.WriteLine("<td>" + veiculo.modelo + "</td>");
                    sw.WriteLine("<td>" + veiculo.placa + "</td>");
                    sw.WriteLine("<td>" + servico.descricao + "</td>");
                    sw.WriteLine("<td>" + string.Format("{0:C2}", venda.valor_total) + "</td>");
                    sw.WriteLine("<td>" + venda.desconto + "%</td>");
                    sw.WriteLine("<td>" + string.Format("{0:C2}", venda.valor_final) + "</td>");
                    sw.WriteLine("</tr>");
                }

                sw.WriteLine("</tbody>");
                sw.WriteLine("</table>");
                sw.WriteLine("</div>");
                sw.WriteLine("</div>");
                sw.WriteLine("</div>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }
    }
}
