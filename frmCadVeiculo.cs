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

        private void limparCampos()
        {
            lblID.Text = "";
            txtModelo.Text = "";
            txtMarca.Text = "";
            txtPlaca.Text = "";
        }

        private void FrmCadVeiculo_Load(object sender, EventArgs e)
        {
            totSalvar.SetToolTip(btnSalvar, "Salvar");
            totSair.SetToolTip(btnSair, "Sair");
            totCancelar.SetToolTip(btnCancelar, "Cancelar");

            lblID.Text = "-1";
            txtModelo.Focus();

            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.DataSource = bllCliente.Select();

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Veiculo bllVeiculo = new Camadas.BLL.Veiculo();
            Camadas.MODEL.Veiculos veiculo = new Camadas.MODEL.Veiculos();
            
            veiculo.idVeiculo = Convert.ToInt32(lblID.Text);
            veiculo.idCliente = Convert.ToInt32(txtCliente.Text);
            veiculo.modelo = txtModelo.Text;
            veiculo.marca = txtMarca.Text;
            veiculo.placa = txtPlaca.Text;

            string msg;
            string titulo;

            msg = "Deseja inserir Veiculo?";
            titulo = "Inserir";

            DialogResult resposta;
            resposta = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
            {
                bllVeiculo.Insert(veiculo);
            }
            else
            {
                limparCampos();
            }
            limparCampos();  
        }

        private void TxtCliente_Leave(object sender, EventArgs e)
        {
        }

        private void CmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCliente.Text = cmbCliente.SelectedValue.ToString();
        }
    }
}
