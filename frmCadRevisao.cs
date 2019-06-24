using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaMecanica
{
    public partial class frmCadRevisao : Form
    {
        public frmCadRevisao()
        {
            InitializeComponent();
        }


        private void limparCampos()
        {
            lblID.Text = "-1";
            cmbCliente.Text = "";
            cmbFuncionario.Text = "";
            cmbVeiculo.Text = "";
            cmbServico.Text = "";
            cmbPecas.Text = "";
            txtKM.Text = "";
            txtObservações.Text = "";
            txtFormaPagto.Text = "";
            txtValServ.Text = "";
            txtDesconto.Text = "";
            txtValorTotal.Text = "";
            txtValorFinal.Text = "";
        }

        private void FrmRevisao_Load(object sender, EventArgs e)
        {
            lblID.Text = "-1";
            txtDesconto.Text = "0";
            totSalvar.SetToolTip(btnGravar, "Salvar");
            totSair.SetToolTip(btnSair, "Sair");
            totCancelar.SetToolTip(btnCancelar, "Cancelar");
            totCalcular.SetToolTip(btnCalcular, "Calcular Valor Total");

            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.DataSource = bllCli.Select();

            Camadas.BLL.Funcionario bllFunc = new Camadas.BLL.Funcionario();
            cmbFuncionario.DisplayMember = "nome";
            cmbFuncionario.ValueMember = "idFuncionario";
            cmbFuncionario.DataSource = bllFunc.Select();

            Camadas.BLL.Veiculo bllVei = new Camadas.BLL.Veiculo();
            cmbVeiculo.DisplayMember = "modelo";
            cmbVeiculo.ValueMember = "idVeiculo";
            cmbVeiculo.DataSource = bllVei.Select();

            Camadas.BLL.Servico bllServ = new Camadas.BLL.Servico();
            Camadas.MODEL.Servicos servico = new Camadas.MODEL.Servicos();

            cmbServico.DisplayMember = "descricao";
            cmbServico.ValueMember = "idServico";
            cmbServico.DataSource = bllServ.Select();
            servico = bllServ.SelectById(Convert.ToInt32(cmbServico.SelectedValue.ToString()))[0];
            txtValServ.Text = servico.valMaoObra.ToString();

            Camadas.BLL.Estoque bllProd = new Camadas.BLL.Estoque();
            cmbPecas.DisplayMember = "descricao";
            cmbPecas.ValueMember = "idProduto";
            cmbPecas.DataSource = bllProd.Select();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.limparCampos();
            cmbCliente.Focus();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddPecas_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbPecas.SelectedValue.ToString());
            Camadas.BLL.Estoque bllProd = new Camadas.BLL.Estoque();
            Camadas.MODEL.Estoque produto = new Camadas.MODEL.Estoque();

            produto = bllProd.SelectById(id)[0];
            float valorPeca = Convert.ToSingle(txtQuantidade.Text) * produto.valor;
            dgvVenda.Rows.Add(produto.idProduto.ToString(), produto.descricao.ToString(), txtQuantidade.Text, valorPeca.ToString());
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int idServ = Convert.ToInt32(cmbServico.SelectedValue.ToString());
            float valorTotal = 0;
            Camadas.BLL.Servico bllServ = new Camadas.BLL.Servico();
            Camadas.MODEL.Servicos servico = new Camadas.MODEL.Servicos();

            servico = bllServ.SelectById(idServ)[0];
            valorTotal = Convert.ToSingle(servico.valMaoObra);
            foreach (DataGridViewRow valor in dgvVenda.Rows)
            {
                valorTotal += Convert.ToSingle(valor.Cells["colValor"].Value);
            }

            txtValorTotal.Text = valorTotal.ToString();
            if (txtDesconto.Text != "0")
            {
                txtValorFinal.Text = (Convert.ToSingle(txtValorTotal.Text) - (Convert.ToSingle(txtValorTotal.Text) * (Convert.ToSingle(txtDesconto.Text) / 100))).ToString();
            }
            else
            {
                txtValorFinal.Text = txtValorTotal.Text;
            }
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Revisao venda = new Camadas.MODEL.Revisao();
            Camadas.BLL.Revisao bllVenda = new Camadas.BLL.Revisao();
            Camadas.MODEL.Revisao_Estoque prodVenda = new Camadas.MODEL.Revisao_Estoque();
            Camadas.BLL.Revisao_Estoque bllRevProd = new Camadas.BLL.Revisao_Estoque();

            venda.idCliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
            venda.idFuncionario = Convert.ToInt32(cmbFuncionario.SelectedValue.ToString());
            venda.idServico = Convert.ToInt32(cmbServico.SelectedValue.ToString());
            venda.kmAtual = Convert.ToInt32(txtKM.Text);
            venda.dataRevisao = Convert.ToDateTime(dtpData.Text);
            venda.observacao = txtObservações.Text;
            venda.valor_total = Convert.ToSingle(txtValorTotal.Text);
            venda.idVeiculo = Convert.ToInt32(cmbVeiculo.SelectedValue.ToString());
            venda.forma_pagto = txtFormaPagto.Text;
            venda.desconto = Convert.ToInt32(txtDesconto.Text);
            venda.valor_final = Convert.ToSingle(txtValorFinal.Text);
            bllVenda.Insert(venda);

            int id = bllVenda.SelectUltimoId();
            foreach(DataGridViewRow produto in dgvVenda.Rows)
            {
                prodVenda.idRevisao = id;
                prodVenda.idProduto = Convert.ToInt32(produto.Cells["colCodigo"].Value);
                prodVenda.quantidade = Convert.ToSingle(produto.Cells["colQuantidade"].Value);
                if (prodVenda.idProduto != 0)
                {
                    bllRevProd.Insert(prodVenda);
                }
            }
            this.limparCampos();
        }
    }
}
