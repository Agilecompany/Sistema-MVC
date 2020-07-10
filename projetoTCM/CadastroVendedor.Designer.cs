namespace projetoTCM
{
    partial class CadastroVendedor
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
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dgVendedor = new System.Windows.Forms.DataGridView();
            this.btnExcluirVendedor = new System.Windows.Forms.Button();
            this.btnCadastrarVendedor = new System.Windows.Forms.Button();
            this.btnEditarVendedor = new System.Windows.Forms.Button();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // mskPhone
            // 
            this.mskPhone.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPhone.Location = new System.Drawing.Point(688, 234);
            this.mskPhone.Mask = "(99) 00000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(173, 33);
            this.mskPhone.TabIndex = 5;
            // 
            // mskCpf
            // 
            this.mskCpf.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpf.Location = new System.Drawing.Point(501, 234);
            this.mskCpf.Mask = "000.000.000.-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(160, 33);
            this.mskCpf.TabIndex = 4;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(683, 205);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(99, 26);
            this.lblTelefone.TabIndex = 33;
            this.lblTelefone.Text = "TELEFONE";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(90, 205);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 26);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "E-MAIL";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(496, 205);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(44, 26);
            this.lblCPF.TabIndex = 31;
            this.lblCPF.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(90, 126);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(68, 26);
            this.lblNome.TabIndex = 30;
            this.lblNome.Text = "NOME";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(95, 234);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(384, 33);
            this.txtEmail.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(95, 158);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(384, 33);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(890, 205);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(57, 26);
            this.lblSexo.TabIndex = 39;
            this.lblSexo.Text = "SEXO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 33);
            this.label1.TabIndex = 43;
            this.label1.Text = "CADASTRO DE VENDEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(496, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 44;
            this.label2.Text = "ENDEREÇO";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(501, 157);
            this.txtAddress.MaxLength = 100;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(560, 33);
            this.txtAddress.TabIndex = 2;
            // 
            // dgVendedor
            // 
            this.dgVendedor.BackgroundColor = System.Drawing.Color.White;
            this.dgVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendedor.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgVendedor.Location = new System.Drawing.Point(94, 287);
            this.dgVendedor.Name = "dgVendedor";
            this.dgVendedor.Size = new System.Drawing.Size(1023, 107);
            this.dgVendedor.TabIndex = 46;
            // 
            // btnExcluirVendedor
            // 
            this.btnExcluirVendedor.BackColor = System.Drawing.Color.Silver;
            this.btnExcluirVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluirVendedor.Location = new System.Drawing.Point(341, 400);
            this.btnExcluirVendedor.Name = "btnExcluirVendedor";
            this.btnExcluirVendedor.Size = new System.Drawing.Size(120, 34);
            this.btnExcluirVendedor.TabIndex = 49;
            this.btnExcluirVendedor.Text = "EXCLUIR";
            this.btnExcluirVendedor.UseVisualStyleBackColor = false;
            this.btnExcluirVendedor.Click += new System.EventHandler(this.btnExcluirVendedor_Click);
            // 
            // btnCadastrarVendedor
            // 
            this.btnCadastrarVendedor.BackColor = System.Drawing.Color.Silver;
            this.btnCadastrarVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastrarVendedor.Location = new System.Drawing.Point(95, 400);
            this.btnCadastrarVendedor.Name = "btnCadastrarVendedor";
            this.btnCadastrarVendedor.Size = new System.Drawing.Size(120, 34);
            this.btnCadastrarVendedor.TabIndex = 47;
            this.btnCadastrarVendedor.Text = "CADASTRAR";
            this.btnCadastrarVendedor.UseVisualStyleBackColor = false;
            this.btnCadastrarVendedor.Click += new System.EventHandler(this.btnCadastrarVendedor_Click);
            // 
            // btnEditarVendedor
            // 
            this.btnEditarVendedor.BackColor = System.Drawing.Color.Silver;
            this.btnEditarVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditarVendedor.Location = new System.Drawing.Point(218, 400);
            this.btnEditarVendedor.Name = "btnEditarVendedor";
            this.btnEditarVendedor.Size = new System.Drawing.Size(120, 34);
            this.btnEditarVendedor.TabIndex = 48;
            this.btnEditarVendedor.Text = "EDITAR";
            this.btnEditarVendedor.UseVisualStyleBackColor = false;
            this.btnEditarVendedor.Click += new System.EventHandler(this.btnEditarVendedor_Click);
            // 
            // cmbSexo
            // 
            this.cmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "OUTROS",
            "MASCULINO",
            "FEMININO"});
            this.cmbSexo.Location = new System.Drawing.Point(895, 234);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(166, 33);
            this.cmbSexo.TabIndex = 6;
            // 
            // CadastroVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.btnExcluirVendedor);
            this.Controls.Add(this.btnCadastrarVendedor);
            this.Controls.Add(this.btnEditarVendedor);
            this.Controls.Add(this.dgVendedor);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.mskPhone);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroVendedor";
            this.Text = "CadastroFornecedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastroVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridView dgVendedor;
        private System.Windows.Forms.Button btnExcluirVendedor;
        private System.Windows.Forms.Button btnCadastrarVendedor;
        private System.Windows.Forms.Button btnEditarVendedor;
        private System.Windows.Forms.ComboBox cmbSexo;
    }
}