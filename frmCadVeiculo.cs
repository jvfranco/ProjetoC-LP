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
    public partial class frmCadVeiculo : Form
    {
        public frmCadVeiculo()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadVeiculo_Load(object sender, EventArgs e)
        {
            totSalvar.SetToolTip(btnSalvar, "Salvar");
            totSair.SetToolTip(btnSair, "Sair");
            totCancelar.SetToolTip(btnCancelar, "Cancelar");
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
