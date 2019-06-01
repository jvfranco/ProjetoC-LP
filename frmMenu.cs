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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCliente cadCliente = new frmCadCliente();
            cadCliente.MdiParent = this;
            cadCliente.Show();
        }

        private void VeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadVeiculo cadVei = new frmCadVeiculo();
            cadVei.MdiParent = this;
            cadVei.Show();
        }

        private void ClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPsqCliente psqClientes = new frmPsqCliente();
            psqClientes.MdiParent = this;
            psqClientes.Show();
        }

        private void FuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFuncionario frmFunc = new frmCadFuncionario();
            frmFunc.MdiParent = this;
            frmFunc.Show();
        }

        private void ServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadServico frmSer = new frmCadServico();
            frmSer.MdiParent = this;
            frmSer.Show();
        }

        private void PeçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadEstoque frmEst = new frmCadEstoque();
            frmEst.MdiParent = this;
            frmEst.Show();
        }
    }
}
