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
    public partial class frmPsqVeiculos : Form
    {
        public frmPsqVeiculos()
        {
            InitializeComponent();
        }

        private void FrmPsqVeiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'oFICINADataSet6.Veiculos'. Você pode movê-la ou removê-la conforme necessário.
            this.veiculosTableAdapter.Fill(this.oFICINADataSet6.Veiculos);
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

        private void RdbModelo_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = true;
            lblPesquisa.Text = "Informe o Modelo:";
            txtPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Veiculo bllVei = new Camadas.BLL.Veiculo();
            List<Camadas.MODEL.Veiculos> lstVeiculos = new List<Camadas.MODEL.Veiculos>();

            if (rdbTodos.Checked)
            {
                lstVeiculos = bllVei.Select();
            }
            else if (rdbID.Checked)
            { 
                lstVeiculos = bllVei.SelectById(Convert.ToInt32(txtPesquisa.Text));
            }
            else if (rdbModelo.Checked)
            {
                lstVeiculos = bllVei.SelectByModelo(txtPesquisa.Text);
            }

            dgvVeiculos.DataSource = "";
            dgvVeiculos.DataSource = lstVeiculos;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvVeiculos.SelectedRows[0].Cells["idVeiculo"].Value.ToString());
            frmCadVeiculo frmVeic = new frmCadVeiculo(id);
            this.Hide();
            frmVeic.Show();
        }
    }
}
