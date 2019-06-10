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
    public partial class frmPsqServicos : Form
    {
        public frmPsqServicos()
        {
            InitializeComponent();
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
            Camadas.BLL.Servico bllServ = new Camadas.BLL.Servico();
            List<Camadas.MODEL.Servicos> lstServicos = new List<Camadas.MODEL.Servicos>();

            if (rdbTodos.Checked)
            {
                lstServicos = bllServ.Select();
            }
            else if (rdbID.Checked)
            {
                int id = Convert.ToInt32(txtPesquisa.Text);
                //lstServicos = bllServ.SelectById(id);
            }
            else if (rdbNome.Checked)
            {
                string descricao = txtPesquisa.Text;
               // lstServicos = bllServ.SelectByDescricao(descricao);
            }

            dgvServicos.DataSource = "";
            dgvServicos.DataSource = lstServicos;
        }

        private void FrmPsqServicos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'oFICINADataSet4.Servicos'. Você pode movê-la ou removê-la conforme necessário.
            this.servicosTableAdapter.Fill(this.oFICINADataSet4.Servicos);
            totSair.SetToolTip(btnSair, "Sair");
            totEditar.SetToolTip(btnEditar, "Editar");
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
