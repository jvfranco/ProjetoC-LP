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
            txtData.Text = "";
        }
        public frmCadCliente()
        {
            InitializeComponent();
            limpaCampos();
            totSalvar.SetToolTip(btnSalvar, "Salvar");
            totSair.SetToolTip(btnSair, "Sair");
            totCancelar.SetToolTip(btnCancelar, "Cancelar");
            totCadVeiculo.SetToolTip(btnCadVeiculo, "Cadastrar Veículo");
            lblTipoDoc.Text = "CPF:";
            lblID.Text = "-1";
            txtNome.Focus();
            dtpCadastro.Visible = true;
            txtData.Visible = false;
        }

        public frmCadCliente(int id)
        {
            InitializeComponent();
            this.limpaCampos();
            Camadas.MODEL.Clientes cliente = new Camadas.MODEL.Clientes();
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            cliente = bllCli.SelectByID(id)[0];
            lblID.Text = cliente.idCliente.ToString();
            txtNome.Text = cliente.nome.ToString();
            txtRg.Text = cliente.rg.ToString();
            txtCpf.Text = cliente.cpf_cnpj.ToString();
            txtEndereco.Text = cliente.endereco.ToString();
            txtNumero.Text = cliente.numero.ToString();
            txtCidade.Text = cliente.cidade.ToString();
            txtBairro.Text = cliente.bairro.ToString();
            txtCep.Text = cliente.cep.ToString();
            txtEstado.Text = cliente.estado.ToString();
            txtTelefone.Text = cliente.telefone.ToString();
            txtEmail.Text = cliente.email.ToString();
            dtpCadastro.Visible = false;
            txtData.Visible = true;
            txtData.Text = cliente.dataCadastro.ToString();
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
            
            if (cliente.idCliente == -1)
            {
                msg = "Deseja inserir Cliente?";
                titulo = "Inserir";
                cliente.dataCadastro = Convert.ToDateTime(dtpCadastro.Text);
            }
            else
            {
                msg = "Deseja atualizar Cliente?";
                titulo = "Atualizar";
                cliente.dataCadastro = Convert.ToDateTime(txtData.Text);
            }
            DialogResult resposta;
            resposta = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);


            if (resposta == DialogResult.Yes) { 
                if (cliente.idCliente == -1)
                {
                    bllCli.Insert(cliente);
                }                   
                else
                {
                    bllCli.Update(cliente);
                }
            }
            else limpaCampos();

            limpaCampos();
        }
    }
}
