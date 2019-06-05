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
    public partial class frmCadFuncionario : Form
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
        }
        private void FrmCadFuncionario_Load(object sender, EventArgs e)
        {
            lblID.Text = "-1";
            totSalvar.SetToolTip(btnSalvar, "Salvar");
            totAddUser.SetToolTip(btnAddUser, "Adicionar Usuário");
            totSair.SetToolTip(btnSair, "Sair");
            totCancelar.SetToolTip(btnCancelar, "Cancelar");
        }

        private void limparCampos()
        {
            lblID.Text = "";
            txtNome.Text = "";
            txtCpf.Text = "";
            txtCargo.Text = "";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            frmCadUsuario frmUser = new frmCadUsuario();
            this.Hide();
            frmUser.Show();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Funcionario bllFun = new Camadas.BLL.Funcionario();

            Camadas.MODEL.Funcionarios funcionario = new Camadas.MODEL.Funcionarios();
            funcionario.idFuncionario = Convert.ToInt32(lblID.Text);
            funcionario.nome = txtNome.Text;
            funcionario.cpf = txtCpf.Text;
            funcionario.cargo = txtCargo.Text;

            string msg;
            string titulo;

            msg = "Deseja inserir Funcionario?";
            titulo = "Inserir";

            DialogResult resposta;
            resposta = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
                if (funcionario.idFuncionario == -1)
                    bllFun.Insert(funcionario);
                else limparCampos();

            limparCampos();
        }

        
    }
}
