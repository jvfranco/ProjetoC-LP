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
            lblID.Text = "-1";
            inicializarTooltip();
        }

        public frmCadServico(int id)
        {
            InitializeComponent();
            this.limparCampos();
            inicializarTooltip();
            Camadas.MODEL.Servicos servico = new Camadas.MODEL.Servicos();
            Camadas.BLL.Servico bllServ = new Camadas.BLL.Servico();
            servico = bllServ.SelectById(id)[0];
            lblID.Text = servico.idServico.ToString();
            txtDescricao.Text = servico.descricao.ToString();
            txtValor.Text = servico.valMaoObra.ToString();            
        }

        private void FrmCadServico_Load(object sender, EventArgs e)
        {
            
        }

        private void inicializarTooltip()
        {
            totSalvar.SetToolTip(btnSalvar, "Salvar");
            totSair.SetToolTip(btnSair, "Sair");
            totCancelar.SetToolTip(btnCancelar, "Cancelar");
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

            if (servico.idServico == -1)
            {
                msg = "Deseja inserir Serviço?";
                titulo = "Inserir";
            }
            else
            {
                msg = "Deseja atualizar Serviço?";
                titulo = "Alterar";
            }

            DialogResult resposta;
            resposta = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
                if (servico.idServico == -1)
                {
                    bllServ.Insert(servico);
                }
                else if (servico.idServico > 0)
                {
                    bllServ.Update(servico);
                }
                else
                {
                    limparCampos();
                    lblID.Text = "-1";
                }
            limparCampos();
            lblID.Text = "-1";
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.limparCampos();
            lblID.Text = "-1";
            txtDescricao.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
