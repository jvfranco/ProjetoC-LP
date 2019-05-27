namespace OficinaMecanica
{
    partial class frmCadFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadFuncionario));
            this.gpbFuncionarios = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbFuncionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFuncionarios
            // 
            this.gpbFuncionarios.Controls.Add(this.textBox2);
            this.gpbFuncionarios.Controls.Add(this.textBox1);
            this.gpbFuncionarios.Controls.Add(this.label4);
            this.gpbFuncionarios.Controls.Add(this.label3);
            this.gpbFuncionarios.Controls.Add(this.label2);
            this.gpbFuncionarios.Controls.Add(this.label1);
            this.gpbFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFuncionarios.Location = new System.Drawing.Point(2, 3);
            this.gpbFuncionarios.Name = "gpbFuncionarios";
            this.gpbFuncionarios.Size = new System.Drawing.Size(772, 168);
            this.gpbFuncionarios.TabIndex = 0;
            this.gpbFuncionarios.TabStop = false;
            this.gpbFuncionarios.Text = "Cadastro de Funcionários";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 29);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(683, 29);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(77, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 29);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(180, 177);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 100);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.Location = new System.Drawing.Point(286, 177);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(100, 100);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(392, 177);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 100);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(498, 177);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 100);
            this.btnSair.TabIndex = 4;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // frmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(778, 288);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gpbFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmCadFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionários - Oficina Mecânica";
            this.gpbFuncionarios.ResumeLayout(false);
            this.gpbFuncionarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFuncionarios;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
    }
}