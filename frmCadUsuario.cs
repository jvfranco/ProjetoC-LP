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
    public partial class frmCadUsuario : Form
    {
        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void FrmCadUsuario_Load(object sender, EventArgs e)
        {
            lblID.Text = "-1";
            txtLogin.Focus();
            totSalvar.SetToolTip(btnSalvar, "Salvar");
            totSair.SetToolTip(btnSair, "Sair");
            totCancelar.SetToolTip(btnCancelar, "Cancelar");

            Camadas.BLL.Funcionario bllFunc = new Camadas.BLL.Funcionario();
            cmbFuncionario.DisplayMember = "nome";
            cmbFuncionario.ValueMember = "idFuncionario";
            cmbFuncionario.DataSource = bllFunc.Select();
        }

        private void limparCampos()
        {
            lblID.Text = "-1";
            txtLogin.Text = "";
            txtSenha.Text = "";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Usuario bllUser = new Camadas.BLL.Usuario();

            Camadas.MODEL.Usuarios user = new Camadas.MODEL.Usuarios();
            user.idUsuario = Convert.ToInt32(lblID.Text);
            user.idFuncionario = Convert.ToInt32(cmbFuncionario.SelectedValue);
            user.login = txtLogin.Text;
            user.senha = txtSenha.Text;

            string msg;
            string titulo;

            msg = "Deseja inserir Usuario?";
            titulo = "Inserir";

            DialogResult resposta;
            resposta = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
                if (user.idUsuario == -1)
                    bllUser.Insert(user);
                else limparCampos();

            limparCampos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.limparCampos();
            lblID.Text = "-1";
            txtLogin.Focus();
        }
    }
}
