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
            // TODO: esta linha de código carrega dados na tabela 'oFICINADataSet8.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter2.Fill(this.oFICINADataSet8.Clientes);
            totSair.SetToolTip(btnSair, "Sair");
            totEditar.SetToolTip(btnEditar, "Editar");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RdbID_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = true;
            txtPesquisa.Visible = true;
            lblPesquisa.Text = "Informe o ID:";
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void RdbNome_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = true;
            txtPesquisa.Visible = true;
            lblPesquisa.Text = "Informe o Nome:";
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void RdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            List<Camadas.MODEL.Clientes> lstClientes = new List<Camadas.MODEL.Clientes>();
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();

            if (rdbTodos.Checked)
            {
                lstClientes = bllCli.Select();
            }
            else if (rdbID.Checked)
            {
                lstClientes = bllCli.SelectByID(Convert.ToInt32(txtPesquisa.Text));
            }
            else if (rdbNome.Checked)
            {
                lstClientes = bllCli.SelectByNome(txtPesquisa.Text);
            }
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = lstClientes;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["id"].Value.ToString());
            frmCadCliente frmCli = new frmCadCliente(id);
            this.Hide();
            frmCli.Show();
        }
    }
}
