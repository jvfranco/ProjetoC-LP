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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private Camadas.MODEL.Usuarios User = new Camadas.MODEL.Usuarios();
        
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Usuario bllUser = new Camadas.BLL.Usuario();
            User = bllUser.SelectByLogin(txtLogin.Text);

            if (txtLogin.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Preencha usuário e senha");
                txtLogin.Focus();
                return;
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Preencha a senha");
                txtSenha.Focus();
                return;
            }
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Preencha o usuário");
                txtLogin.Focus();
                return;
            }
            else if (txtLogin.Text != User.login || txtSenha.Text != User.senha)
            {
                MessageBox.Show("Usuário ou senha inválidos!");
                txtLogin.Focus();
                return;
            }
            else if (txtLogin.Text == User.login || txtSenha.Text == User.senha)
            {
                frmMenu menu = new frmMenu();
                this.Hide();
                menu.Show();
            }
            
        }
    }
}
