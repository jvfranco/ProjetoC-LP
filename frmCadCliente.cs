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
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            totSalvar.SetToolTip(btnSalvar, "Salvar");
            totSair.SetToolTip(btnSair, "Sair");
            totCancelar.SetToolTip(btnCancelar, "Cancelar");
            totCadVeiculo.SetToolTip(btnCadVeiculo, "Cadastrar Veículo");
            lblTipoDoc.Text = "CPF:";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TotSalvar_Popup(object sender, PopupEventArgs e)
        {

        }

        private void BtnCadVeiculo_Click(object sender, EventArgs e)
        {
            frmCadVeiculo cadVei = new frmCadVeiculo();
            this.Hide();
            cadVei.Show();
        }

        private void RdbFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblTipoDoc.Text = "CPF:";
        }

        private void RdbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblTipoDoc.Text = "CNPJ:";
        }
    }
}
