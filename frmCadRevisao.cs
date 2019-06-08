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
            txtDesconto.Text = "";
        }

        private void FrmRevisao_Load(object sender, EventArgs e)
        {
            lblID.Text = "-1";
            totSalvar.SetToolTip(btnGravar, "Salvar");
            totSair.SetToolTip(btnSair, "Sair");
            totCancelar.SetToolTip(btnCancelar, "Cancelar");

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
            cmbServico.DisplayMember = "descricao";
            cmbServico.ValueMember = "idServico";
            cmbServico.DataSource = bllServ.Select();

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

        private void BtnAddSer_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddPecas_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbPecas.SelectedValue.ToString());
            Camadas.BLL.Estoque bllProd = new Camadas.BLL.Estoque();
            Camadas.MODEL.Estoque produto = new Camadas.MODEL.Estoque();

            produto = bllProd.SelectById(id);
            float valorPeca = Convert.ToSingle(txtQuantidade.Text) * produto.valor;

            dgvVenda.Rows.Add(produto.idProduto.ToString(), produto.descricao.ToString(), txtQuantidade.Text, valorPeca.ToString());          
        }
    }
}
