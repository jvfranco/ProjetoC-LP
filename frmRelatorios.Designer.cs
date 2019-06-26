namespace OficinaMecanica
{
    partial class frmRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorios));
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.rdbSimplificado = new System.Windows.Forms.RadioButton();
            this.rdbCompleto = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGerarRelatorio.BackgroundImage")));
            this.btnGerarRelatorio.FlatAppearance.BorderSize = 0;
            this.btnGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(279, 137);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(48, 48);
            this.btnGerarRelatorio.TabIndex = 0;
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.BtnGerarRelatorio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.rdbCompleto);
            this.groupBox1.Controls.Add(this.rdbSimplificado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relatórios";
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(333, 137);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(48, 48);
            this.btnSair.TabIndex = 2;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // rdbSimplificado
            // 
            this.rdbSimplificado.AutoSize = true;
            this.rdbSimplificado.Checked = true;
            this.rdbSimplificado.Location = new System.Drawing.Point(6, 28);
            this.rdbSimplificado.Name = "rdbSimplificado";
            this.rdbSimplificado.Size = new System.Drawing.Size(305, 28);
            this.rdbSimplificado.TabIndex = 0;
            this.rdbSimplificado.TabStop = true;
            this.rdbSimplificado.Text = "Relatório de Vendas Simplificado";
            this.rdbSimplificado.UseVisualStyleBackColor = true;
            this.rdbSimplificado.CheckedChanged += new System.EventHandler(this.RdbSimplificado_CheckedChanged);
            // 
            // rdbCompleto
            // 
            this.rdbCompleto.AutoSize = true;
            this.rdbCompleto.Location = new System.Drawing.Point(6, 62);
            this.rdbCompleto.Name = "rdbCompleto";
            this.rdbCompleto.Size = new System.Drawing.Size(369, 28);
            this.rdbCompleto.TabIndex = 1;
            this.rdbCompleto.Text = "Relatório de Vendas Completo Individual";
            this.rdbCompleto.UseVisualStyleBackColor = true;
            this.rdbCompleto.CheckedChanged += new System.EventHandler(this.RdbCompleto_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(236, 91);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(135, 29);
            this.txtID.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(30, 94);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(203, 24);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Informe o ID da Venda:";
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(391, 190);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGerarRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Vendas - Oficina Mecânica";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.RadioButton rdbCompleto;
        private System.Windows.Forms.RadioButton rdbSimplificado;
        private System.Windows.Forms.Button btnSair;
    }
}