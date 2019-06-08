﻿using System;
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
    public partial class frmPsqEstoque : Form
    {
        public frmPsqEstoque()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPsqEstoque_Load(object sender, EventArgs e)
        {
            totSair.SetToolTip(btnSair, "Sair");
            totEditar.SetToolTip(btnEditar, "Editar");
        }

        private void RdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
        }

        private void RdbID_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = true;
            lblPesquisa.Text = "Informe o ID:";
            txtPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void RdbNome_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = true;
            lblPesquisa.Text = "Informe a Descrição:";
            txtPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Estoque bllEst = new Camadas.BLL.Estoque();
            List<Camadas.MODEL.Estoque> lstProdutos = new List<Camadas.MODEL.Estoque>();

            if (rdbTodos.Checked)
            {
                lstProdutos = bllEst.Select();
            }
            else if (rdbID.Checked)
            {
                int id = Convert.ToInt32(txtPesquisa.Text);
                lstProdutos = bllEst.SelectById(id);
            }
            else if (rdbNome.Checked)
            {
                string descricao = txtPesquisa.Text;
                lstProdutos = bllEst.SelectByDescricao(descricao);
            }
            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = lstProdutos;
        }
    }
}
