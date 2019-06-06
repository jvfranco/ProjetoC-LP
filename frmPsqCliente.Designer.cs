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
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.btnSair = new System.Windows.Forms.Button();
            this.totSair = new System.Windows.Forms.ToolTip(this.components);
            this.btnEditar = new System.Windows.Forms.Button();
            this.totEditar = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
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
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(6, 131);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(1280, 403);
            this.dgvClientes.TabIndex = 3;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellContentClick);
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
    }
}