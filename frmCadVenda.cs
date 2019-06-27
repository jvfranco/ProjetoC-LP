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
    public partial class frmCadVenda : Form
    {
        public frmCadVenda()
        {
            InitializeComponent();
            lblID.Text = "-1";
            txtDesconto.Text = "0";
            inicializarTooltip();

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

        public frmCadVenda(int id)
        {
            InitializeComponent();
            inicializarTooltip();
            Camadas.MODEL.Revisao venda = new Camadas.MODEL.Revisao();
            List<Camadas.MODEL.Revisao_Estoque> lstProdutos = new List<Camadas.MODEL.Revisao_Estoque>();
            Camadas.BLL.Revisao bllRev = new Camadas.BLL.Revisao();
            Camadas.BLL.Revisao_Estoque bllEst = new Camadas.BLL.Revisao_Estoque();

            venda = bllRev.SelectById(id)[0];
            lstProdutos = bllEst.SelectByIdVenda(venda.idRevisao);

            this.limparCampos();
            this.desabilitarCampos();
            btnGravar.Visible = false;
            btnCalcular.Visible = false;
            btnCancelar.Visible = false;
            btnAddPecas.Enabled = false;

            lblID.Text = venda.idRevisao.ToString();
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.DataSource = bllCli.SelectByID(Convert.ToInt32(venda.idCliente));

            Camadas.BLL.Funcionario bllFunc = new Camadas.BLL.Funcionario();
            cmbFuncionario.DisplayMember = "nome";
            cmbFuncionario.ValueMember = "idFuncionario";
            cmbFuncionario.DataSource = bllFunc.SelectById(venda.idFuncionario);

            Camadas.BLL.Veiculo bllVei = new Camadas.BLL.Veiculo();
            cmbVeiculo.DisplayMember = "modelo";
            cmbVeiculo.ValueMember = "idVeiculo";
            cmbVeiculo.DataSource = bllVei.SelectById(venda.idVeiculo);

            Camadas.BLL.Servico bllServ = new Camadas.BLL.Servico();
            Camadas.MODEL.Servicos servicoM = new Camadas.MODEL.Servicos();
            cmbServico.DisplayMember = "descricao";
            cmbServico.ValueMember = "idServico";
            cmbServico.DataSource = bllServ.SelectById(venda.idServico);
            servicoM = bllServ.SelectById(Convert.ToInt32(cmbServico.SelectedValue.ToString()))[0];
            txtValServ.Text = "";
            txtValServ.Text = servicoM.valMaoObra.ToString();

            dgvVenda.DataSource = "";
            dgvVenda.DataSource = lstProdutos;

            dtpData.Text = venda.dataRevisao.ToString();
            txtKM.Text = venda.kmAtual.ToString();
            txtObservações.Text = venda.observacao.ToString();
            txtValorTotal.Text = venda.valor_total.ToString();
            txtDesconto.Text = venda.desconto.ToString();
            txtValorFinal.Text = venda.valor_final.ToString();
            txtFormaPagto.Text = venda.forma_pagto.ToString();
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
            txtQuantidade.Text = "";
            dgvVenda.DataSource = "";
        }

        private void inicializarTooltip()
        {
            totSalvar.SetToolTip(btnGravar, "Salvar");
            totSair.SetToolTip(btnSair, "Sair");
            totCancelar.SetToolTip(btnCancelar, "Cancelar");
            totCalcular.SetToolTip(btnCalcular, "Calcular Valor Total");
        }

        private void desabilitarCampos()
        {
            lblID.Enabled = false;
            cmbCliente.Enabled = false;
            cmbFuncionario.Enabled = false;
            cmbVeiculo.Enabled = false;
            cmbServico.Enabled = false;
            cmbPecas.Enabled = false;
            txtKM.Enabled = false;
            txtObservações.Enabled = false;
            txtFormaPagto.Enabled = false;
            txtValServ.Enabled = false;
            txtDesconto.Enabled = false;
            txtValorTotal.Enabled = false;
            txtValorFinal.Enabled = false;
            txtQuantidade.Enabled = false;
            dtpData.Enabled = false;
        }

        private void FrmRevisao_Load(object sender, EventArgs e)
        {
            
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
            if (Convert.ToInt32(txtQuantidade.Text) > produto.quantidade)
            {
                MessageBox.Show("Quantidade superior ao encontrado no estoque! Há " + produto.quantidade + " peças no estoque!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQuantidade.Text = "";
                txtQuantidade.Focus();
                return;
            }
            else
            {
                float valorPeca = Convert.ToSingle(txtQuantidade.Text) * produto.valor;
                dgvVenda.Rows.Add(produto.idProduto.ToString(), produto.descricao.ToString(), txtQuantidade.Text, valorPeca.ToString());
            }            
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
            foreach (DataGridViewRow produto in dgvVenda.Rows)
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
            lblID.Text = "-1";
        }
    }
}
