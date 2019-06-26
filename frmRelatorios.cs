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
    public partial class frmRelatorios : Form
    {
        public frmRelatorios()
        {
            InitializeComponent();
            lblID.Visible = false;
            txtID.Visible = false;
        }

        private void BtnGerarRelatorio_Click(object sender, EventArgs e)
        {
            if (rdbSimplificado.Checked)
            {
                Relatorios.relVendas.impRelatorioVendas();
            }
            if (rdbCompleto.Checked)
            {
                
            }           

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RdbCompleto_CheckedChanged(object sender, EventArgs e)
        {
            lblID.Visible = true;
            txtID.Visible = true;
        }

        private void RdbSimplificado_CheckedChanged(object sender, EventArgs e)
        {
            lblID.Visible = false;
            txtID.Visible = false;
        }
    }
}
