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
    public partial class frmPsqVendas : Form
    {
        public frmPsqVendas()
        {
            InitializeComponent();
        }

        private void FrmPsqOS_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'oFICINADataSet10.Revisao'. Você pode movê-la ou removê-la conforme necessário.
            this.revisaoTableAdapter.Fill(this.oFICINADataSet10.Revisao);
            totSair.SetToolTip(btnSair, "Sair");
            totDetalhes.SetToolTip(btnDetalhes, "Detalhes");
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            List<Camadas.MODEL.Revisao> lstVendas = new List<Camadas.MODEL.Revisao>();
            Camadas.BLL.Revisao bllVenda = new Camadas.BLL.Revisao();

            if (rdbTodos.Checked)
            {
                lstVendas = bllVenda.Select();
            }
            if (rdbID.Checked)
            {
                lstVendas = bllVenda.SelectById(Convert.ToInt32(txtPesquisa.Text));
            }
            if (rdbData.Checked)
            {
                lstVendas = bllVenda.SelectByData(Convert.ToDateTime(txtPesquisa.Text));
            }

            dgvOS.DataSource = "";
            dgvOS.DataSource = lstVendas;
        }

        private void BtnDetalhes_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvOS.SelectedRows[0].Cells["idServico"].Value.ToString());
            frmCadVenda frmServ = new frmCadVenda(id);
            this.Hide();
            frmServ.Show();
        }
    }
}
