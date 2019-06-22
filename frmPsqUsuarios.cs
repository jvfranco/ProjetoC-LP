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
    public partial class frmPsqUsuarios : Form
    {
        public frmPsqUsuarios()
        {
            InitializeComponent();
        }

        private void RdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
        }

        private void RdbIDFunc_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = true;
            txtPesquisa.Visible = true;
            lblPesquisa.Text = "Informe o ID do Funcionário:";
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            List<Camadas.MODEL.Usuarios> lstUser = new List<Camadas.MODEL.Usuarios>();
            Camadas.BLL.Usuario bllUser = new Camadas.BLL.Usuario();

            if (rdbTodos.Checked)
            {
                lstUser = bllUser.Select();
            }
            else if (rdbIDFunc.Checked)
            {
                int id = txtPesquisa.Text != "" ? Convert.ToInt32(txtPesquisa.Text) : 0;
                lstUser = bllUser.SelectByIdFunc(id);
            }

            dgvUsuarios.DataSource = "";
            dgvUsuarios.DataSource = lstUser;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPsqUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'oFICINADataSet5.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.oFICINADataSet5.Usuarios);
            totSair.SetToolTip(btnSair, "Sair");
            totEditar.SetToolTip(btnEditar, "Editar");
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["idfuncionarioDataGridViewTextBoxColumn"].Value.ToString());
            frmCadUsuario frmUser = new frmCadUsuario(id);
            this.Hide();
            frmUser.Show();
        }
    }
}
