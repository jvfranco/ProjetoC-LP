namespace OficinaMecanica
{
    partial class frmPsqCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPsqCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oFICINADataSet1 = new OficinaMecanica.OFICINADataSet1();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.btnSair = new System.Windows.Forms.Button();
            this.totSair = new System.Windows.Forms.ToolTip(this.components);
            this.btnEditar = new System.Windows.Forms.Button();
            this.totEditar = new System.Windows.Forms.ToolTip(this.components);
            this.oFICINADataSet = new OficinaMecanica.OFICINADataSet();
            this.oFICINADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new OficinaMecanica.OFICINADataSet1TableAdapters.ClientesTableAdapter();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFICINADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFICINADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFICINADataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.lblPesquisa);
            this.groupBox1.Controls.Add(this.dgvClientes);
            this.groupBox1.Controls.Add(this.rdbNome);
            this.groupBox1.Controls.Add(this.rdbID);
            this.groupBox1.Controls.Add(this.rdbTodos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1292, 540);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa de Clientes";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(1201, 62);
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
            this.txtPesquisa.Location = new System.Drawing.Point(796, 62);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(399, 29);
            this.txtPesquisa.TabIndex = 5;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Location = new System.Drawing.Point(792, 29);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(368, 28);
            this.lblPesquisa.TabIndex = 4;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNome,
            this.colEndereco,
            this.colNumero,
            this.colBairro,
            this.colCep,
            this.colCidade,
            this.colEstado,
            this.colTelefone,
            this.colEmail,
            this.colData,
            this.colCpf,
            this.colRg,
            this.ColTipo});
            this.dgvClientes.DataSource = this.clientesBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(6, 131);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(1280, 403);
            this.dgvClientes.TabIndex = 3;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.oFICINADataSet1;
            // 
            // oFICINADataSet1
            // 
            this.oFICINADataSet1.DataSetName = "OFICINADataSet1";
            this.oFICINADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(9, 97);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(176, 28);
            this.rdbNome.TabIndex = 2;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Buscar por Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.RdbNome_CheckedChanged);
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.Location = new System.Drawing.Point(10, 63);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(141, 28);
            this.rdbID.TabIndex = 1;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "Buscar por ID";
            this.rdbID.UseVisualStyleBackColor = true;
            this.rdbID.CheckedChanged += new System.EventHandler(this.RdbID_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(10, 29);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(145, 28);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Buscar Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.RdbTodos_CheckedChanged);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(1239, 549);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 50);
            this.btnSair.TabIndex = 2;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(1183, 549);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // oFICINADataSet
            // 
            this.oFICINADataSet.DataSetName = "OFICINADataSet";
            this.oFICINADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oFICINADataSetBindingSource
            // 
            this.oFICINADataSetBindingSource.DataSource = this.oFICINADataSet;
            this.oFICINADataSetBindingSource.Position = 0;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "id_cliente";
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 80;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "nome";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colEndereco
            // 
            this.colEndereco.DataPropertyName = "endereco";
            this.colEndereco.HeaderText = "Endereço";
            this.colEndereco.Name = "colEndereco";
            this.colEndereco.ReadOnly = true;
            // 
            // colNumero
            // 
            this.colNumero.DataPropertyName = "numero";
            this.colNumero.HeaderText = "Número";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            // 
            // colBairro
            // 
            this.colBairro.DataPropertyName = "bairro";
            this.colBairro.HeaderText = "Bairro";
            this.colBairro.Name = "colBairro";
            this.colBairro.ReadOnly = true;
            // 
            // colCep
            // 
            this.colCep.DataPropertyName = "cep";
            this.colCep.HeaderText = "CEP";
            this.colCep.Name = "colCep";
            this.colCep.ReadOnly = true;
            // 
            // colCidade
            // 
            this.colCidade.DataPropertyName = "cidade";
            this.colCidade.HeaderText = "Cidade";
            this.colCidade.Name = "colCidade";
            this.colCidade.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "estado";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // colTelefone
            // 
            this.colTelefone.DataPropertyName = "telefone";
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "email";
            this.colEmail.HeaderText = "E-Mail";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colData
            // 
            this.colData.DataPropertyName = "data_cadastro";
            this.colData.HeaderText = "Data de Cadastro";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            // 
            // colCpf
            // 
            this.colCpf.DataPropertyName = "cpf_cnpj";
            this.colCpf.HeaderText = "CPF/CNPJ";
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            // 
            // colRg
            // 
            this.colRg.DataPropertyName = "rg";
            this.colRg.HeaderText = "RG";
            this.colRg.Name = "colRg";
            this.colRg.ReadOnly = true;
            // 
            // ColTipo
            // 
            this.ColTipo.DataPropertyName = "tipo_pessoa";
            this.ColTipo.HeaderText = "Tipo";
            this.ColTipo.Name = "ColTipo";
            this.ColTipo.ReadOnly = true;
            // 
            // frmPsqCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1298, 604);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPsqCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Clientes - Oficina Mecânica";
            this.Load += new System.EventHandler(this.FrmPsqCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFICINADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFICINADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFICINADataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolTip totSair;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ToolTip totEditar;
        private System.Windows.Forms.BindingSource oFICINADataSetBindingSource;
        private OFICINADataSet oFICINADataSet;
        private OFICINADataSet1 oFICINADataSet1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private OFICINADataSet1TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipo;
    }
}