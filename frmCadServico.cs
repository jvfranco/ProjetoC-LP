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
    public partial class frmCadServico : Form
    {
        public frmCadServico()
        {
            InitializeComponent();
        }

        private void FrmCadServico_Load(object sender, EventArgs e)
        {
            lblID.Text = "-1";
        }

        private void limparCampos()
        {
            lblID.Text = "-1";
            txtDescricao.Text = "";
            txtValor.Text = "";
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Servico bllServ = new Camadas.BLL.Servico();

            Camadas.MODEL.Servicos servico = new Camadas.MODEL.Servicos();
            servico.idServico = Convert.ToInt32(lblID.Text);
            servico.descricao = txtDescricao.Text;
            servico.valMaoObra = Convert.ToSingle(txtValor.Text);

            string msg;
            string titulo;

            msg = "Deseja inserir Serviço?";
            titulo = "Inserir";

            DialogResult resposta;
            resposta = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
                if (servico.idServico == -1)
                    bllServ.Insert(servico);
                else limparCampos();

            limparCampos();
        }
    }
}
