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
            Camadas.MODEL.Clientes cliente = new Camadas.MODEL.Clientes();
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();

            if (rdbTodos.Checked)
            {
                lstClientes = bllCli.Select();
                dgvClientes.DataSource = "";
                dgvClientes.DataSource = lstClientes;
            }
            else if (rdbID.Checked)
            {
                int idCliente = Convert.ToInt32(txtPesquisa.Text);
                cliente = bllCli.SelectByID(idCliente);
                dgvClientes.DataSource = "";
                dgvClientes.DataSource = cliente;
            }
            else if (rdbNome.Checked)
            {
                lstClientes = bllCli.SelectByNome(txtPesquisa.Text);
                dgvClientes.DataSource = "";
                dgvClientes.DataSource = lstClientes;
            }
            
        }
    }
}
