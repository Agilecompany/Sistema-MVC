namespace projetoTCM
{
    partial class TelaConfiguraçoes
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
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnAlterarUsuario = new System.Windows.Forms.Button();
            this.lblConfiguracoes = new System.Windows.Forms.Label();
            this.btnAlterarTema = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalendario
            // 
            this.btnCalendario.BackColor = System.Drawing.Color.Silver;
            this.btnCalendario.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.Location = new System.Drawing.Point(510, 174);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(225, 44);
            this.btnCalendario.TabIndex = 0;
            this.btnCalendario.Text = "CALENDÁRIO";
            this.btnCalendario.UseVisualStyleBackColor = false;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // btnAlterarUsuario
            // 
            this.btnAlterarUsuario.BackColor = System.Drawing.Color.Silver;
            this.btnAlterarUsuario.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarUsuario.Location = new System.Drawing.Point(510, 251);
            this.btnAlterarUsuario.Name = "btnAlterarUsuario";
            this.btnAlterarUsuario.Size = new System.Drawing.Size(225, 44);
            this.btnAlterarUsuario.TabIndex = 2;
            this.btnAlterarUsuario.Text = "ALTERAR USUÁRIO";
            this.btnAlterarUsuario.UseVisualStyleBackColor = false;
            // 
            // lblConfiguracoes
            // 
            this.lblConfiguracoes.AutoSize = true;
            this.lblConfiguracoes.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracoes.Location = new System.Drawing.Point(517, 49);
            this.lblConfiguracoes.Name = "lblConfiguracoes";
            this.lblConfiguracoes.Size = new System.Drawing.Size(208, 33);
            this.lblConfiguracoes.TabIndex = 3;
            this.lblConfiguracoes.Text = "CONFIGURAÇÕES";
            // 
            // btnAlterarTema
            // 
            this.btnAlterarTema.BackColor = System.Drawing.Color.Silver;
            this.btnAlterarTema.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarTema.Location = new System.Drawing.Point(510, 328);
            this.btnAlterarTema.Name = "btnAlterarTema";
            this.btnAlterarTema.Size = new System.Drawing.Size(225, 60);
            this.btnAlterarTema.TabIndex = 4;
            this.btnAlterarTema.Text = "ALTERAR TEMA: ESCURO";
            this.btnAlterarTema.UseVisualStyleBackColor = false;
            // 
            // TelaConfiguraçoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.btnAlterarTema);
            this.Controls.Add(this.lblConfiguracoes);
            this.Controls.Add(this.btnAlterarUsuario);
            this.Controls.Add(this.btnCalendario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaConfiguraçoes";
            this.Text = "TelaConfigurações";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaConfiguraçoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Button btnAlterarUsuario;
        private System.Windows.Forms.Label lblConfiguracoes;
        private System.Windows.Forms.Button btnAlterarTema;
    }
}