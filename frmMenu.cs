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

        private void FinalizarServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadRevisao frmRev = new frmCadRevisao();
            frmRev.MdiParent = this;
            frmRev.Show();
        }

        private void FuncionáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPsqFuncionario frmFunc = new frmPsqFuncionario();
            frmFunc.MdiParent = this;
            frmFunc.Show();
        }

        private void EstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPsqEstoque frmEst = new frmPsqEstoque();
            frmEst.MdiParent = this;
            frmEst.Show();
        }

        private void ServiçosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPsqServicos frmServ = new frmPsqServicos();
            frmServ.MdiParent = this;
            frmServ.Show();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPsqUsuarios frmUser = new frmPsqUsuarios();
            frmUser.MdiParent = this;
            frmUser.Show();
        }

        private void RevisõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPsqOS frmOS = new frmPsqOS();
            frmOS.MdiParent = this;
            frmOS.Show();
        }

        private void VeículosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPsqVeiculos frmVeic = new frmPsqVeiculos();
            frmVeic.MdiParent = this;
            frmVeic.Show();
        }
    }
}
