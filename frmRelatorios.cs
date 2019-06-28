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
        }

        private void BtnGerarRelatorio_Click(object sender, EventArgs e)
        {
            if (rdbSimplificado.Checked)
            {
                Relatorios.Relatorios.impRelatorioVendas();
            }
            if (rdbEstoque.Checked)
            {
                Relatorios.Relatorios.impRelatorioEstoque();
            }           

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
