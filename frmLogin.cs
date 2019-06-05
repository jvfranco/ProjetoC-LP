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

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
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

            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }

        private void PnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
