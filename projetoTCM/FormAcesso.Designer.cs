namespace projetoTCM
{
    partial class FormAcesso
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
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExcluirAcesso = new System.Windows.Forms.Button();
            this.btnCadastrarAcesso = new System.Windows.Forms.Button();
            this.btnEditarAcesso = new System.Windows.Forms.Button();
            this.cmbProfile = new System.Windows.Forms.ComboBox();
            this.dgAcesso = new System.Windows.Forms.DataGridView();
            this.userDomainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formAcessoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formAcessoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgAcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDomainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formAcessoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formAcessoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(472, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(265, 33);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "CADASTRO DE ACESSO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(123, 158);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(384, 37);
            this.txtName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "EMAIL";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(123, 237);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(384, 37);
            this.txtEmail.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(520, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "LOGIN";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(519, 158);
            this.txtLogin.MaxLength = 30;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(169, 37);
            this.txtLogin.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(514, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "SENHA";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(519, 237);
            this.txtPassword.MaxLength = 10;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(169, 37);
            this.txtPassword.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(699, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "ACESSO";
            // 
            // btnExcluirAcesso
            // 
            this.btnExcluirAcesso.BackColor = System.Drawing.Color.Silver;
            this.btnExcluirAcesso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluirAcesso.Location = new System.Drawing.Point(369, 548);
            this.btnExcluirAcesso.Name = "btnExcluirAcesso";
            this.btnExcluirAcesso.Size = new System.Drawing.Size(120, 34);
            this.btnExcluirAcesso.TabIndex = 8;
            this.btnExcluirAcesso.Text = "EXCLUIR";
            this.btnExcluirAcesso.UseVisualStyleBackColor = false;
            this.btnExcluirAcesso.Click += new System.EventHandler(this.btnExcluirAcesso_Click);
            // 
            // btnCadastrarAcesso
            // 
            this.btnCadastrarAcesso.BackColor = System.Drawing.Color.Silver;
            this.btnCadastrarAcesso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastrarAcesso.Location = new System.Drawing.Point(123, 548);
            this.btnCadastrarAcesso.Name = "btnCadastrarAcesso";
            this.btnCadastrarAcesso.Size = new System.Drawing.Size(120, 34);
            this.btnCadastrarAcesso.TabIndex = 6;
            this.btnCadastrarAcesso.Text = "CADASTRAR";
            this.btnCadastrarAcesso.UseVisualStyleBackColor = false;
            this.btnCadastrarAcesso.Click += new System.EventHandler(this.btnCadastrarAcesso_Click);
            // 
            // btnEditarAcesso
            // 
            this.btnEditarAcesso.BackColor = System.Drawing.Color.Silver;
            this.btnEditarAcesso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditarAcesso.Location = new System.Drawing.Point(246, 548);
            this.btnEditarAcesso.Name = "btnEditarAcesso";
            this.btnEditarAcesso.Size = new System.Drawing.Size(120, 34);
            this.btnEditarAcesso.TabIndex = 7;
            this.btnEditarAcesso.Text = "EDITAR";
            this.btnEditarAcesso.UseVisualStyleBackColor = false;
            this.btnEditarAcesso.Click += new System.EventHandler(this.btnEditarAcesso_Click);
            // 
            // cmbProfile
            // 
            this.cmbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfile.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfile.FormattingEnabled = true;
            this.cmbProfile.Items.AddRange(new object[] {
            "Administrador",
            "Caixa"});
            this.cmbProfile.Location = new System.Drawing.Point(704, 237);
            this.cmbProfile.Name = "cmbProfile";
            this.cmbProfile.Size = new System.Drawing.Size(193, 37);
            this.cmbProfile.TabIndex = 4;
            // 
            // dgAcesso
            // 
            this.dgAcesso.AllowUserToAddRows = false;
            this.dgAcesso.AllowUserToDeleteRows = false;
            this.dgAcesso.AllowUserToResizeColumns = false;
            this.dgAcesso.AllowUserToResizeRows = false;
            this.dgAcesso.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgAcesso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAcesso.Location = new System.Drawing.Point(123, 287);
            this.dgAcesso.Name = "dgAcesso";
            this.dgAcesso.ReadOnly = true;
            this.dgAcesso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAcesso.Size = new System.Drawing.Size(1023, 255);
            this.dgAcesso.TabIndex = 5;
            // 
            // userDomainBindingSource
            // 
            this.userDomainBindingSource.DataSource = typeof(ProjetoTCM.Domain.Security.UserDomain);
            // 
            // formAcessoBindingSource
            // 
            this.formAcessoBindingSource.DataSource = typeof(projetoTCM.FormAcesso);
            // 
            // formAcessoBindingSource1
            // 
            this.formAcessoBindingSource1.DataSource = typeof(projetoTCM.FormAcesso);
            // 
            // FormAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.dgAcesso);
            this.Controls.Add(this.cmbProfile);
            this.Controls.Add(this.btnExcluirAcesso);
            this.Controls.Add(this.btnCadastrarAcesso);
            this.Controls.Add(this.btnEditarAcesso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAcesso";
            this.Text = "FormAcesso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAcesso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDomainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formAcessoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formAcessoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExcluirAcesso;
        private System.Windows.Forms.Button btnCadastrarAcesso;
        private System.Windows.Forms.Button btnEditarAcesso;
        private System.Windows.Forms.ComboBox cmbProfile;
        private System.Windows.Forms.BindingSource userDomainBindingSource;
        private System.Windows.Forms.BindingSource formAcessoBindingSource;
        private System.Windows.Forms.BindingSource formAcessoBindingSource1;
        private System.Windows.Forms.DataGridView dgAcesso;
    }
}