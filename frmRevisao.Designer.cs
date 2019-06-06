namespace OficinaMecanica
{
    partial class frmRevisao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRevisao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.btnAddPecas = new System.Windows.Forms.Button();
            this.cmbPecas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddSer = new System.Windows.Forms.Button();
            this.cmbServico = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVeiculo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtObservações = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFormaPagto = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.totSalvar = new System.Windows.Forms.ToolTip(this.components);
            this.totCancelar = new System.Windows.Forms.ToolTip(this.components);
            this.totSair = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValorFinal);
            this.groupBox1.Controls.Add(this.lblValorTotal);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtFormaPagto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtObservações);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.txtKM);
            this.groupBox1.Controls.Add(this.cmbVeiculo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dgvVenda);
            this.groupBox1.Controls.Add(this.btnAddPecas);
            this.groupBox1.Controls.Add(this.cmbPecas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAddSer);
            this.groupBox1.Controls.Add(this.cmbServico);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbFuncionario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 642);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordem de Serviço";
            // 
            // dgvVenda
            // 
            this.dgvVenda.BackgroundColor = System.Drawing.Color.White;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(6, 229);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.Size = new System.Drawing.Size(987, 221);
            this.dgvVenda.TabIndex = 10;
            // 
            // btnAddPecas
            // 
            this.btnAddPecas.Location = new System.Drawing.Point(960, 180);
            this.btnAddPecas.Name = "btnAddPecas";
            this.btnAddPecas.Size = new System.Drawing.Size(33, 32);
            this.btnAddPecas.TabIndex = 9;
            this.btnAddPecas.Text = "+";
            this.btnAddPecas.UseVisualStyleBackColor = true;
            // 
            // cmbPecas
            // 
            this.cmbPecas.FormattingEnabled = true;
            this.cmbPecas.Location = new System.Drawing.Point(11, 181);
            this.cmbPecas.Name = "cmbPecas";
            this.cmbPecas.Size = new System.Drawing.Size(943, 32);
            this.cmbPecas.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Peças:";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(860, 55);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(130, 29);
            this.dtpData.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(856, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data:";
            // 
            // btnAddSer
            // 
            this.btnAddSer.Location = new System.Drawing.Point(960, 116);
            this.btnAddSer.Name = "btnAddSer";
            this.btnAddSer.Size = new System.Drawing.Size(33, 32);
            this.btnAddSer.TabIndex = 7;
            this.btnAddSer.Text = "+";
            this.btnAddSer.UseVisualStyleBackColor = true;
            // 
            // cmbServico
            // 
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Location = new System.Drawing.Point(529, 117);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(425, 32);
            this.cmbServico.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(528, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Serviço:";
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(528, 55);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(326, 32);
            this.cmbFuncionario.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(528, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Funcionário:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(145, 55);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(377, 32);
            this.cmbCliente.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID.Location = new System.Drawing.Point(11, 55);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(127, 32);
            this.lblID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(141, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº da Revisão";
            // 
            // cmbVeiculo
            // 
            this.cmbVeiculo.FormattingEnabled = true;
            this.cmbVeiculo.Location = new System.Drawing.Point(11, 118);
            this.cmbVeiculo.Name = "cmbVeiculo";
            this.cmbVeiculo.Size = new System.Drawing.Size(326, 32);
            this.cmbVeiculo.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(11, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Veículo:";
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(347, 118);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(175, 29);
            this.txtKM.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(343, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "KM Atual:";
            // 
            // txtObservações
            // 
            this.txtObservações.Location = new System.Drawing.Point(6, 478);
            this.txtObservações.Multiline = true;
            this.txtObservações.Name = "txtObservações";
            this.txtObservações.Size = new System.Drawing.Size(983, 93);
            this.txtObservações.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(7, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 26);
            this.label9.TabIndex = 21;
            this.label9.Text = "Observações:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(4, 578);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 26);
            this.label10.TabIndex = 23;
            this.label10.Text = "Valor Total:";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(253, 578);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 26);
            this.label11.TabIndex = 25;
            this.label11.Text = "Desconto:";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(255, 604);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(240, 29);
            this.txtDesconto.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(501, 578);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 26);
            this.label12.TabIndex = 27;
            this.label12.Text = "Valor Final:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(749, 578);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(216, 26);
            this.label13.TabIndex = 29;
            this.label13.Text = "Forma de Pagamento:";
            // 
            // txtFormaPagto
            // 
            this.txtFormaPagto.Location = new System.Drawing.Point(751, 604);
            this.txtFormaPagto.Name = "txtFormaPagto";
            this.txtFormaPagto.Size = new System.Drawing.Size(240, 29);
            this.txtFormaPagto.TabIndex = 15;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.BackColor = System.Drawing.Color.White;
            this.lblValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorTotal.Location = new System.Drawing.Point(7, 604);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(240, 29);
            this.lblValorTotal.TabIndex = 12;
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.BackColor = System.Drawing.Color.White;
            this.lblValorFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorFinal.Location = new System.Drawing.Point(503, 604);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(240, 29);
            this.lblValorFinal.TabIndex = 14;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.Transparent;
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.Location = new System.Drawing.Point(834, 650);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(50, 50);
            this.btnGravar.TabIndex = 16;
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(890, 650);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(945, 650);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 50);
            this.btnSair.TabIndex = 18;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // frmRevisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1004, 704);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRevisao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Serviço - Oficina Mecânica";
            this.Load += new System.EventHandler(this.FrmRevisao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.Button btnAddPecas;
        private System.Windows.Forms.ComboBox cmbPecas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddSer;
        private System.Windows.Forms.ComboBox cmbServico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFormaPagto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtObservações;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.ComboBox cmbVeiculo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolTip totSalvar;
        private System.Windows.Forms.ToolTip totCancelar;
        private System.Windows.Forms.ToolTip totSair;
    }
}