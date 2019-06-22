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
    public partial class frmPsqFuncionario : Form
    {
        public frmPsqFuncionario()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPsqFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'oFICINADataSet3.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.oFICINADataSet3.Funcionario);
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
            lblPesquisa.Text = "Informe o nome:";
            txtPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Funcionario bllFunc = new Camadas.BLL.Funcionario();
            List<Camadas.MODEL.Funcionarios> lstFuncionarios = new List<Camadas.MODEL.Funcionarios>();

            if (rdbTodos.Checked)
            {
                lstFuncionarios = bllFunc.Select();
            }
            else if (rdbID.Checked)
            {
                int id = Convert.ToInt32(txtPesquisa.Text);
                lstFuncionarios = bllFunc.SelectById(id);
            }
            else if (rdbNome.Checked)
            {
                string nome = txtPesquisa.Text;
                lstFuncionarios = bllFunc.SelectByNome(nome);
            }
            dgvFuncionarios.DataSource = "";
            dgvFuncionarios.DataSource = lstFuncionarios;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvFuncionarios.SelectedRows[0].Cells["idFuncionario"].Value.ToString());
            frmCadFuncionario frmFunc = new frmCadFuncionario(id);
            this.Hide();
            frmFunc.Show();
        }
    }
}
