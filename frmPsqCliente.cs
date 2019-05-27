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
    public partial class frmPsqCliente : Form
    {
        public frmPsqCliente()
        {
            InitializeComponent();
        }

        private void FrmPsqCliente_Load(object sender, EventArgs e)
        {
            totSair.SetToolTip(btnSair, "Sair");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RdbID_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = true;
            txtPesqusia.Visible = true;
            lblPesquisa.Text = "Informe o ID:";
            txtPesqusia.Text = "";
            txtPesqusia.Focus();
        }

        private void RdbNome_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = true;
            txtPesqusia.Visible = true;
            lblPesquisa.Text = "Informe o Nome:";
            txtPesqusia.Text = "";
            txtPesqusia.Focus();
        }

        private void RdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesqusia.Visible = false;
            dgvClientes.DataSource = "";
            //terminar
        }
    }
}
