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
            totSalvar.SetToolTip(btnSalvar, "Salvar");
            totSair.SetToolTip(btnSair, "Sair");
            totCancelar.SetToolTip(btnCancelar, "Cancelar");
            totExcluir.SetToolTip(btnDelete, "Excluir");
            txtProp.Visible = false;

            lblID.Text = "-1";
            txtModelo.Focus();

            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.DataSource = bllCliente.Select();
        }

        public frmCadVeiculo(int id)
        {
            InitializeComponent();
            Camadas.MODEL.Veiculos veiculo = new Camadas.MODEL.Veiculos();
            Camadas.BLL.Veiculo bllVeic = new Camadas.BLL.Veiculo();
            Camadas.MODEL.Clientes cliente = new Camadas.MODEL.Clientes();
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            veiculo = bllVeic.SelectById(id)[0];
            cliente = bllCli.SelectByID(Convert.ToInt32(veiculo.idCliente.ToString()))[0];
            cmbCliente.Visible = false;
            txtProp.Visible = true;
            txtProp.Enabled = false;

            lblID.Text = veiculo.idVeiculo.ToString();
            txtModelo.Text = veiculo.modelo.ToString();
            txtMarca.Text = veiculo.marca.ToString();
            txtPlaca.Text = veiculo.placa.ToString();
            txtCliente.Text = veiculo.idCliente.ToString();
            txtProp.Text = cliente.nome.ToString();
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

            int id = Convert.ToInt32(lblID.Text);

            if(id == -1)
            {
                msg = "Deseja inserir Veiculo?";
                titulo = "Inserir";
            }
            else
            {
                msg = "Deseja alterar Veiculo?";
                titulo = "Alterar";
            }

            DialogResult resposta;
            resposta = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
            {
                if (id == -1)
                {
                    bllVeiculo.Insert(veiculo);
                } 
                else
                {
                    bllVeiculo.Update(veiculo);
                }
                
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.limparCampos();
            lblID.Text = "-1";
            txtModelo.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Veiculo bllVeiculo = new Camadas.BLL.Veiculo();

            if (lblID.Text != string.Empty)
            {
                DialogResult resposta;
                resposta = MessageBox.Show("Deseja remover este item?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (resposta == DialogResult.Yes)
                {
                    bllVeiculo.Delete(Convert.ToInt32(lblID.Text));
                }
            }
            else MessageBox.Show("Não há registros para remover!");

            this.limparCampos();
        }
    }
}
