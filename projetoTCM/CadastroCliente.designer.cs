namespace projetoTCM
{
    partial class frmCadastroCliente
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mkdCpf = new System.Windows.Forms.MaskedTextBox();
            this.mkdPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.lblcelular = new System.Windows.Forms.Label();
            this.mkdCellPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.BtnEditarCliente = new System.Windows.Forms.Button();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(97, 149);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(395, 33);
            this.txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(97, 236);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(395, 33);
            this.txtEmail.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(92, 113);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(68, 26);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "NOME";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(507, 116);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(44, 26);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(92, 203);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 26);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-MAIL";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(681, 116);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(99, 26);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "TELEFONE";
            // 
            // mkdCpf
            // 
            this.mkdCpf.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdCpf.Location = new System.Drawing.Point(512, 149);
            this.mkdCpf.Mask = "000.000.000.-00";
            this.mkdCpf.Name = "mkdCpf";
            this.mkdCpf.Size = new System.Drawing.Size(155, 33);
            this.mkdCpf.TabIndex = 2;
            // 
            // mkdPhone
            // 
            this.mkdPhone.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdPhone.Location = new System.Drawing.Point(696, 149);
            this.mkdPhone.Mask = "(99) 00000-0000";
            this.mkdPhone.Name = "mkdPhone";
            this.mkdPhone.Size = new System.Drawing.Size(166, 33);
            this.mkdPhone.TabIndex = 3;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(691, 203);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(57, 26);
            this.lblSexo.TabIndex = 14;
            this.lblSexo.Text = "SEXO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "CADASTRO DE CLIENTE";
            // 
            // dtgCliente
            // 
            this.dtgCliente.BackgroundColor = System.Drawing.Color.White;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Location = new System.Drawing.Point(94, 287);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.Size = new System.Drawing.Size(1023, 199);
            this.dtgCliente.TabIndex = 19;
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcelular.Location = new System.Drawing.Point(507, 193);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(89, 26);
            this.lblcelular.TabIndex = 20;
            this.lblcelular.Text = "CELULAR";
            // 
            // mkdCellPhone
            // 
            this.mkdCellPhone.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdCellPhone.Location = new System.Drawing.Point(512, 236);
            this.mkdCellPhone.Mask = "(99) 00000-0000";
            this.mkdCellPhone.Name = "mkdCellPhone";
            this.mkdCellPhone.Size = new System.Drawing.Size(155, 33);
            this.mkdCellPhone.TabIndex = 5;
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.BackColor = System.Drawing.Color.Silver;
            this.btnExcluirCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluirCliente.Location = new System.Drawing.Point(336, 492);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(120, 34);
            this.btnExcluirCliente.TabIndex = 52;
            this.btnExcluirCliente.Text = "EXCLUIR";
            this.btnExcluirCliente.UseVisualStyleBackColor = false;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.BackColor = System.Drawing.Color.Silver;
            this.btnCadastrarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(90, 492);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(120, 34);
            this.btnCadastrarCliente.TabIndex = 50;
            this.btnCadastrarCliente.Text = "CADASTRAR";
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // BtnEditarCliente
            // 
            this.BtnEditarCliente.BackColor = System.Drawing.Color.Silver;
            this.BtnEditarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnEditarCliente.Location = new System.Drawing.Point(213, 492);
            this.BtnEditarCliente.Name = "BtnEditarCliente";
            this.BtnEditarCliente.Size = new System.Drawing.Size(120, 34);
            this.BtnEditarCliente.TabIndex = 51;
            this.BtnEditarCliente.Text = "EDITAR";
            this.BtnEditarCliente.UseVisualStyleBackColor = false;
            this.BtnEditarCliente.Click += new System.EventHandler(this.BtnEditarCliente_Click);
            // 
            // cmbSex
            // 
            this.cmbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "OUTROS",
            "MASCULINO",
            "FEMININO"});
            this.cmbSex.Location = new System.Drawing.Point(696, 236);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(166, 33);
            this.cmbSex.TabIndex = 6;
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1145, 521);
            this.ControlBox = false;
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.btnExcluirCliente);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.BtnEditarCliente);
            this.Controls.Add(this.mkdCellPhone);
            this.Controls.Add(this.lblcelular);
            this.Controls.Add(this.dtgCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.mkdPhone);
            this.Controls.Add(this.mkdCpf);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mkdCpf;
        private System.Windows.Forms.MaskedTextBox mkdPhone;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.MaskedTextBox mkdCellPhone;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button BtnEditarCliente;
        protected internal System.Windows.Forms.ComboBox cmbSex;
    }
}

