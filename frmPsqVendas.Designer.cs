namespace OficinaMecanica
{
    partial class frmPsqVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPsqVendas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.dgvOS = new System.Windows.Forms.DataGridView();
            this.rdbData = new System.Windows.Forms.RadioButton();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.totSair = new System.Windows.Forms.ToolTip(this.components);
            this.totDetalhes = new System.Windows.Forms.ToolTip(this.components);
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.oFICINADataSet10 = new OficinaMecanica.OFICINADataSet10();
            this.revisaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.revisaoTableAdapter = new OficinaMecanica.OFICINADataSet10TableAdapters.RevisaoTableAdapter();
            this.idServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idservicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idveiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmatualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formapagtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valortotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorfinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFICINADataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revisaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.lblPesquisa);
            this.groupBox1.Controls.Add(this.dgvOS);
            this.groupBox1.Controls.Add(this.rdbData);
            this.groupBox1.Controls.Add(this.rdbID);
            this.groupBox1.Controls.Add(this.rdbTodos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 391);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa de Ordens de Serviço";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(965, 62);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(85, 29);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(560, 62);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(399, 29);
            this.txtPesquisa.TabIndex = 5;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Location = new System.Drawing.Point(340, 30);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(368, 28);
            this.lblPesquisa.TabIndex = 4;
            // 
            // dgvOS
            // 
            this.dgvOS.AutoGenerateColumns = false;
            this.dgvOS.BackgroundColor = System.Drawing.Color.White;
            this.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServico,
            this.idclienteDataGridViewTextBoxColumn,
            this.idfuncionarioDataGridViewTextBoxColumn,
            this.idservicoDataGridViewTextBoxColumn,
            this.idveiculoDataGridViewTextBoxColumn,
            this.DataServico,
            this.kmatualDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.formapagtoDataGridViewTextBoxColumn,
            this.valortotalDataGridViewTextBoxColumn,
            this.descontoDataGridViewTextBoxColumn,
            this.valorfinalDataGridViewTextBoxColumn});
            this.dgvOS.DataSource = this.revisaoBindingSource;
            this.dgvOS.Location = new System.Drawing.Point(6, 130);
            this.dgvOS.Name = "dgvOS";
            this.dgvOS.Size = new System.Drawing.Size(1044, 253);
            this.dgvOS.TabIndex = 3;
            // 
            // rdbData
            // 
            this.rdbData.AutoSize = true;
            this.rdbData.Location = new System.Drawing.Point(7, 96);
            this.rdbData.Name = "rdbData";
            this.rdbData.Size = new System.Drawing.Size(161, 28);
            this.rdbData.TabIndex = 2;
            this.rdbData.TabStop = true;
            this.rdbData.Text = "Buscar por Data";
            this.rdbData.UseVisualStyleBackColor = true;
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.Location = new System.Drawing.Point(8, 62);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(141, 28);
            this.rdbID.TabIndex = 1;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "Buscar por ID";
            this.rdbID.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(8, 28);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(145, 28);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Buscar Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetalhes.BackgroundImage")));
            this.btnDetalhes.FlatAppearance.BorderSize = 0;
            this.btnDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalhes.Location = new System.Drawing.Point(952, 400);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(48, 48);
            this.btnDetalhes.TabIndex = 7;
            this.btnDetalhes.UseVisualStyleBackColor = true;
            this.btnDetalhes.Click += new System.EventHandler(this.BtnDetalhes_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(1008, 400);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 50);
            this.btnSair.TabIndex = 8;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // oFICINADataSet10
            // 
            this.oFICINADataSet10.DataSetName = "OFICINADataSet10";
            this.oFICINADataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // revisaoBindingSource
            // 
            this.revisaoBindingSource.DataMember = "Revisao";
            this.revisaoBindingSource.DataSource = this.oFICINADataSet10;
            // 
            // revisaoTableAdapter
            // 
            this.revisaoTableAdapter.ClearBeforeFill = true;
            // 
            // idServico
            // 
            this.idServico.DataPropertyName = "id_revisao";
            this.idServico.HeaderText = "Código";
            this.idServico.Name = "idServico";
            this.idServico.ReadOnly = true;
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "Cód. Cliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            // 
            // idfuncionarioDataGridViewTextBoxColumn
            // 
            this.idfuncionarioDataGridViewTextBoxColumn.DataPropertyName = "id_funcionario";
            this.idfuncionarioDataGridViewTextBoxColumn.HeaderText = "Cód. Funcionário";
            this.idfuncionarioDataGridViewTextBoxColumn.Name = "idfuncionarioDataGridViewTextBoxColumn";
            // 
            // idservicoDataGridViewTextBoxColumn
            // 
            this.idservicoDataGridViewTextBoxColumn.DataPropertyName = "id_servico";
            this.idservicoDataGridViewTextBoxColumn.HeaderText = "Cód. Serviço";
            this.idservicoDataGridViewTextBoxColumn.Name = "idservicoDataGridViewTextBoxColumn";
            // 
            // idveiculoDataGridViewTextBoxColumn
            // 
            this.idveiculoDataGridViewTextBoxColumn.DataPropertyName = "id_veiculo";
            this.idveiculoDataGridViewTextBoxColumn.HeaderText = "Cód. Veiculo";
            this.idveiculoDataGridViewTextBoxColumn.Name = "idveiculoDataGridViewTextBoxColumn";
            // 
            // DataServico
            // 
            this.DataServico.DataPropertyName = "data_revisao";
            this.DataServico.HeaderText = "Data Serviço";
            this.DataServico.Name = "DataServico";
            // 
            // kmatualDataGridViewTextBoxColumn
            // 
            this.kmatualDataGridViewTextBoxColumn.DataPropertyName = "km_atual";
            this.kmatualDataGridViewTextBoxColumn.HeaderText = "km";
            this.kmatualDataGridViewTextBoxColumn.Name = "kmatualDataGridViewTextBoxColumn";
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            // 
            // formapagtoDataGridViewTextBoxColumn
            // 
            this.formapagtoDataGridViewTextBoxColumn.DataPropertyName = "forma_pagto";
            this.formapagtoDataGridViewTextBoxColumn.HeaderText = "Forma de Pagamento";
            this.formapagtoDataGridViewTextBoxColumn.Name = "formapagtoDataGridViewTextBoxColumn";
            // 
            // valortotalDataGridViewTextBoxColumn
            // 
            this.valortotalDataGridViewTextBoxColumn.DataPropertyName = "valor_total";
            this.valortotalDataGridViewTextBoxColumn.HeaderText = "Valor Total";
            this.valortotalDataGridViewTextBoxColumn.Name = "valortotalDataGridViewTextBoxColumn";
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            this.descontoDataGridViewTextBoxColumn.DataPropertyName = "desconto";
            this.descontoDataGridViewTextBoxColumn.HeaderText = "Desconto";
            this.descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            // 
            // valorfinalDataGridViewTextBoxColumn
            // 
            this.valorfinalDataGridViewTextBoxColumn.DataPropertyName = "valor_final";
            this.valorfinalDataGridViewTextBoxColumn.HeaderText = "Valor Final";
            this.valorfinalDataGridViewTextBoxColumn.Name = "valorfinalDataGridViewTextBoxColumn";
            // 
            // frmPsqOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1064, 454);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDetalhes);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPsqOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Ordens de Serviço - Oficina Mecânica";
            this.Load += new System.EventHandler(this.FrmPsqOS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFICINADataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revisaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.DataGridView dgvOS;
        private System.Windows.Forms.RadioButton rdbData;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolTip totSair;
        private System.Windows.Forms.ToolTip totDetalhes;
        private OFICINADataSet10 oFICINADataSet10;
        private System.Windows.Forms.BindingSource revisaoBindingSource;
        private OFICINADataSet10TableAdapters.RevisaoTableAdapter revisaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idservicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idveiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmatualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formapagtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valortotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorfinalDataGridViewTextBoxColumn;
    }
}