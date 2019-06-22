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
    public partial class frmCadEstoque : Form
    {
        public frmCadEstoque()
        {
            InitializeComponent();
            lblID.Text = "-1";
            totSalvar.SetToolTip(btnSalvar, "Salvar");
            totSair.SetToolTip(btnSair, "Sair");
            totCancelar.SetToolTip(btnCancelar, "Cancelar");
        }

        public frmCadEstoque(int id)
        {
            InitializeComponent();
            this.limparCampos();
            Camadas.MODEL.Estoque produto = new Camadas.MODEL.Estoque();
            Camadas.BLL.Estoque bllProd = new Camadas.BLL.Estoque();
            produto = bllProd.SelectById(id)[0];
            lblID.Text = produto.idProduto.ToString();
            txtDescricao.Text = produto.descricao.ToString();
            txtQuantidade.Text = produto.quantidade.ToString();
            txtValor.Text = produto.valor.ToString();
        }

        private void FrmCadEstoque_Load(object sender, EventArgs e)
        {
            
        }

        private void limparCampos()
        {
            lblID.Text = "-1";
            txtDescricao.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            lblID.Text = "-1";
            txtDescricao.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Estoque bllEst = new Camadas.BLL.Estoque();

            Camadas.MODEL.Estoque produto = new Camadas.MODEL.Estoque();
            produto.idProduto = Convert.ToInt32(lblID.Text);
            produto.descricao = txtDescricao.Text;
            produto.quantidade = Convert.ToSingle(txtQuantidade.Text);
            produto.valor = Convert.ToSingle(txtValor.Text);

            string msg;
            string titulo;

            msg = "Deseja inserir Produto?";
            titulo = "Inserir";

            DialogResult resposta;
            resposta = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
                if (produto.idProduto == -1)
                    bllEst.Insert(produto);
                else limparCampos();

            limparCampos();
        }
    }
}
