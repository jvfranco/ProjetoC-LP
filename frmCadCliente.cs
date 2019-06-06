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

        private void limpaCampos()
        {
            lblID.Text = "";
            txtNome.Clear();
            txtEndereco.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            dtpCadastro.Text = "";
        }
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            limpaCampos();
            totSalvar.SetToolTip(btnSalvar, "Salvar");
            totSair.SetToolTip(btnSair, "Sair");
            totCancelar.SetToolTip(btnCancelar, "Cancelar");
            totCadVeiculo.SetToolTip(btnCadVeiculo, "Cadastrar Veículo");
            lblTipoDoc.Text = "CPF:";
            lblID.Text = "-1";
            txtNome.Focus();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.limpaCampos();
            lblID.Text = "-1";
            txtNome.Focus();       
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();

            //instancia e preenche com dados o objeto produto
            Camadas.MODEL.Clientes cliente = new Camadas.MODEL.Clientes();
            cliente.idCliente = Convert.ToInt32(lblID.Text);
            cliente.nome = txtNome.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.numero = Convert.ToInt32(txtNumero.Text);
            cliente.bairro = txtBairro.Text;
            cliente.cep = txtCep.Text;
            cliente.cidade = txtCidade.Text ;
            cliente.estado = txtEstado.Text;
            cliente.telefone = txtTelefone.Text;
            cliente.email = txtEmail.Text;
            cliente.dataCadastro = Convert.ToDateTime(dtpCadastro.Text);
            cliente.cpf_cnpj = txtCpf.Text;
            cliente.rg = txtRg.Text;
            if (rdbFisica.Checked)
            {
                cliente.tipoPessoa = "Fisica";
            }
            else
            {
                cliente.tipoPessoa = "Juridica";
            }
            
            string msg;
            string titulo;
            
                msg = "Deseja inserir Cliente?";
                titulo = "Inserir";
            
            DialogResult resposta;
            resposta = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
                if (cliente.idCliente == -1)
                    bllCli.Insert(cliente);
                else limpaCampos();

            limpaCampos();
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
