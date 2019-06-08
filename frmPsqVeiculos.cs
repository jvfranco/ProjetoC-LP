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
            lblPesquisa.Text = "Informe o ID do Cliente:";
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
                lstVeiculos = bllVei.SelectByIdCliente(Convert.ToInt32(txtPesquisa.Text));
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
    }
}
