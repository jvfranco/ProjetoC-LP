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
            lblID.Text = "-1";
            txtLogin.Focus();
            inicializarTooltip();

            Camadas.BLL.Funcionario bllFunc = new Camadas.BLL.Funcionario();
            cmbFuncionario.DisplayMember = "nome";
            cmbFuncionario.ValueMember = "idFuncionario";
            cmbFuncionario.DataSource = bllFunc.Select();
            txtFunc.Visible = false;
        }

        public frmCadUsuario(int id)
        {
            InitializeComponent();
            this.limparCampos();
            inicializarTooltip();
            Camadas.MODEL.Usuarios usuario = new Camadas.MODEL.Usuarios();
            Camadas.BLL.Usuario bllUser = new Camadas.BLL.Usuario();
            Camadas.MODEL.Funcionarios funcionario = new Camadas.MODEL.Funcionarios();
            Camadas.BLL.Funcionario bllFunc = new Camadas.BLL.Funcionario();
            usuario = bllUser.SelectByIdFunc(id)[0];
            funcionario = bllFunc.SelectById(usuario.idFuncionario)[0];
            cmbFuncionario.Visible = false;
            txtFunc.Visible = true;
            txtFunc.Enabled = false;
            txtLogin.Enabled = false;
            lblID.Text = usuario.idFuncionario.ToString();
            txtLogin.Text = usuario.login.ToString();
            txtSenha.Text = usuario.senha.ToString();
            txtFunc.Text = funcionario.nome.ToString();
        }
        private void inicializarTooltip()
        {
            totSalvar.SetToolTip(btnSalvar, "Salvar");
            totSair.SetToolTip(btnSair, "Sair");
            totCancelar.SetToolTip(btnCancelar, "Cancelar");
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
            Camadas.MODEL.Usuarios usuario = new Camadas.MODEL.Usuarios();

            user.idUsuario = Convert.ToInt32(lblID.Text);
            user.idFuncionario = Convert.ToInt32(cmbFuncionario.SelectedValue);
            user.login = txtLogin.Text;
            user.senha = txtSenha.Text;

            string msg;
            string titulo;

            if(user.idUsuario == -1)
            {
                msg = "Deseja inserir Usuario?";
                titulo = "Inserir";
            } 
            else
            {
                msg = "Deseja atualizar Usuario?";
                titulo = "Inserir";
            }

            DialogResult resposta;
            resposta = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
            {
                usuario = bllUser.SelectByLogin(user.login);
                if (usuario.login != user.login && user.idUsuario == -1)
                {
                    bllUser.Insert(user);
                }
                else if (user.idUsuario > 0)
                {
                    bllUser.Update(user);
                }
                else
                {
                    MessageBox.Show("Usuário já existe!");
                    limparCampos();
                    txtLogin.Focus();
                    return;
                }
            }
            else
            {
                limparCampos();
                lblID.Text = "-1";
            }               

            limparCampos();
            lblID.Text = "-1";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.limparCampos();
            lblID.Text = "-1";
            txtLogin.Focus();
        }
    }
}
