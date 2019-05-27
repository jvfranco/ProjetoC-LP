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
    }
}
