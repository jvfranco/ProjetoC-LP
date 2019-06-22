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
    public partial class frmPsqEstoque : Form
    {
        public frmPsqEstoque()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPsqEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'oFICINADataSet2.Estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueTableAdapter.Fill(this.oFICINADataSet9.Estoque);
            totSair.SetToolTip(btnSair, "Sair");
            totEditar.SetToolTip(btnEditar, "Editar");
        }

        private void RdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
        }

        private void RdbID_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = true;
            lblPesquisa.Text = "Informe o ID:";
            txtPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void RdbNome_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = true;
            lblPesquisa.Text = "Informe a Descrição:";
            txtPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Estoque bllEst = new Camadas.BLL.Estoque();
            List<Camadas.MODEL.Estoque> lstProdutos = new List<Camadas.MODEL.Estoque>();

            if (rdbTodos.Checked)
            {
                lstProdutos = bllEst.Select();
            }
            else if (rdbID.Checked)
            {
                lstProdutos = bllEst.SelectById(Convert.ToInt32(txtPesquisa.Text));
            }
            else if (rdbNome.Checked)
            { 
                lstProdutos = bllEst.SelectByDescricao(txtPesquisa.Text);
            }
            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = lstProdutos;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["idProduto"].Value.ToString());
            frmCadEstoque frmProd = new frmCadEstoque(id);
            this.Hide();
            frmProd.Show();
        }

        private void FrmPsqEstoque_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'oFICINADataSet9.Estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueTableAdapter.Fill(this.oFICINADataSet9.Estoque);

        }
    }
}
