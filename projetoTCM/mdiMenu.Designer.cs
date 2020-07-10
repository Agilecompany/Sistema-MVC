namespace projetoTCM
{
    partial class mdiMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiMenu));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuVertical = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENDEDORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCESSOAOSISTEMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENDAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTAVENDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGURAÇÕESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAZERLOGOFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLTERARTEMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cALENDÁRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnsair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnslide = new System.Windows.Forms.PictureBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblData = new System.Windows.Forms.Label();
            this.menuVertical.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.White;
            this.menuVertical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuVertical.Controls.Add(this.menuStrip2);
            this.menuVertical.Controls.Add(this.btnsair);
            this.menuVertical.Controls.Add(this.pictureBox1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.menuVertical.Size = new System.Drawing.Size(195, 749);
            this.menuVertical.TabIndex = 4;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROToolStripMenuItem,
            this.vENDAToolStripMenuItem,
            this.sOBREToolStripMenuItem,
            this.cONFIGURAÇÕESToolStripMenuItem});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip2.Location = new System.Drawing.Point(0, 50);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(182, 697);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cADASTROToolStripMenuItem
            // 
            this.cADASTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTEToolStripMenuItem,
            this.vENDEDORToolStripMenuItem,
            this.pRODUTOToolStripMenuItem,
            this.aCESSOAOSISTEMAToolStripMenuItem});
            this.cADASTROToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cADASTROToolStripMenuItem.Image = global::projetoTCM.Properties.Resources.cadastro;
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(136, 30);
            this.cADASTROToolStripMenuItem.Text = "CADASTRO";
            // 
            // cLIENTEToolStripMenuItem
            // 
            this.cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.cLIENTEToolStripMenuItem.Text = "CLIENTE";
            this.cLIENTEToolStripMenuItem.Click += new System.EventHandler(this.cLIENTEToolStripMenuItem_Click);
            // 
            // vENDEDORToolStripMenuItem
            // 
            this.vENDEDORToolStripMenuItem.Name = "vENDEDORToolStripMenuItem";
            this.vENDEDORToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.vENDEDORToolStripMenuItem.Text = "VENDEDOR";
            this.vENDEDORToolStripMenuItem.Click += new System.EventHandler(this.vENDEDORToolStripMenuItem_Click);
            // 
            // pRODUTOToolStripMenuItem
            // 
            this.pRODUTOToolStripMenuItem.Name = "pRODUTOToolStripMenuItem";
            this.pRODUTOToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.pRODUTOToolStripMenuItem.Text = "PRODUTO";
            this.pRODUTOToolStripMenuItem.Click += new System.EventHandler(this.pRODUTOToolStripMenuItem_Click);
            // 
            // aCESSOAOSISTEMAToolStripMenuItem
            // 
            this.aCESSOAOSISTEMAToolStripMenuItem.Name = "aCESSOAOSISTEMAToolStripMenuItem";
            this.aCESSOAOSISTEMAToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.aCESSOAOSISTEMAToolStripMenuItem.Text = "ACESSO AO SISTEMA";
            this.aCESSOAOSISTEMAToolStripMenuItem.Click += new System.EventHandler(this.aCESSOAOSISTEMAToolStripMenuItem_Click);
            // 
            // vENDAToolStripMenuItem
            // 
            this.vENDAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vENDAToolStripMenuItem1,
            this.cONSULTAVENDAToolStripMenuItem});
            this.vENDAToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vENDAToolStripMenuItem.Image = global::projetoTCM.Properties.Resources.carrinho;
            this.vENDAToolStripMenuItem.Name = "vENDAToolStripMenuItem";
            this.vENDAToolStripMenuItem.Size = new System.Drawing.Size(102, 30);
            this.vENDAToolStripMenuItem.Text = "VENDA";
            // 
            // vENDAToolStripMenuItem1
            // 
            this.vENDAToolStripMenuItem1.Name = "vENDAToolStripMenuItem1";
            this.vENDAToolStripMenuItem1.Size = new System.Drawing.Size(242, 30);
            this.vENDAToolStripMenuItem1.Text = "REALIZAR VENDA";
            this.vENDAToolStripMenuItem1.Click += new System.EventHandler(this.vENDAToolStripMenuItem1_Click);
            // 
            // cONSULTAVENDAToolStripMenuItem
            // 
            this.cONSULTAVENDAToolStripMenuItem.Name = "cONSULTAVENDAToolStripMenuItem";
            this.cONSULTAVENDAToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.cONSULTAVENDAToolStripMenuItem.Text = "CONSULTA VENDA";
            this.cONSULTAVENDAToolStripMenuItem.Click += new System.EventHandler(this.cONSULTAVENDAToolStripMenuItem_Click);
            // 
            // sOBREToolStripMenuItem
            // 
            this.sOBREToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sOBREToolStripMenuItem.Image = global::projetoTCM.Properties.Resources.interrogação;
            this.sOBREToolStripMenuItem.Name = "sOBREToolStripMenuItem";
            this.sOBREToolStripMenuItem.Size = new System.Drawing.Size(98, 30);
            this.sOBREToolStripMenuItem.Text = "SOBRE";
            this.sOBREToolStripMenuItem.Click += new System.EventHandler(this.sOBREToolStripMenuItem_Click);
            // 
            // cONFIGURAÇÕESToolStripMenuItem
            // 
            this.cONFIGURAÇÕESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAZERLOGOFFToolStripMenuItem,
            this.aLTERARTEMAToolStripMenuItem,
            this.cALENDÁRIOToolStripMenuItem});
            this.cONFIGURAÇÕESToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cONFIGURAÇÕESToolStripMenuItem.Name = "cONFIGURAÇÕESToolStripMenuItem";
            this.cONFIGURAÇÕESToolStripMenuItem.Size = new System.Drawing.Size(176, 30);
            this.cONFIGURAÇÕESToolStripMenuItem.Text = "CONFIGURAÇÕES";
            // 
            // fAZERLOGOFFToolStripMenuItem
            // 
            this.fAZERLOGOFFToolStripMenuItem.Name = "fAZERLOGOFFToolStripMenuItem";
            this.fAZERLOGOFFToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.fAZERLOGOFFToolStripMenuItem.Text = "FAZER LOGOFF";
            this.fAZERLOGOFFToolStripMenuItem.Click += new System.EventHandler(this.fAZERLOGOFFToolStripMenuItem_Click);
            // 
            // aLTERARTEMAToolStripMenuItem
            // 
            this.aLTERARTEMAToolStripMenuItem.Name = "aLTERARTEMAToolStripMenuItem";
            this.aLTERARTEMAToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.aLTERARTEMAToolStripMenuItem.Text = "ALTERAR TEMA";
            this.aLTERARTEMAToolStripMenuItem.Click += new System.EventHandler(this.aLTERARTEMAToolStripMenuItem_Click);
            // 
            // cALENDÁRIOToolStripMenuItem
            // 
            this.cALENDÁRIOToolStripMenuItem.Name = "cALENDÁRIOToolStripMenuItem";
            this.cALENDÁRIOToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.cALENDÁRIOToolStripMenuItem.Text = "CALENDÁRIO";
            this.cALENDÁRIOToolStripMenuItem.Click += new System.EventHandler(this.cALENDÁRIOToolStripMenuItem_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsair.Image = global::projetoTCM.Properties.Resources.Webp2;
            this.btnsair.Location = new System.Drawing.Point(11, 688);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(40, 43);
            this.btnsair.TabIndex = 8;
            this.btnsair.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.AliceBlue;
            this.barraTitulo.Controls.Add(this.btnslide);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(195, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1175, 44);
            this.barraTitulo.TabIndex = 5;
            // 
            // btnslide
            // 
            this.btnslide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnslide.Image = global::projetoTCM.Properties.Resources.botao_de_menu_de_tres_linhas_horizontais;
            this.btnslide.Location = new System.Drawing.Point(6, 9);
            this.btnslide.Name = "btnslide";
            this.btnslide.Size = new System.Drawing.Size(28, 26);
            this.btnslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnslide.TabIndex = 0;
            this.btnslide.TabStop = false;
            this.btnslide.Click += new System.EventHandler(this.btnslide_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(195, 730);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 19);
            this.lblData.TabIndex = 11;
            // 
            // mdiMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.menuVertical);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "mdiMenu";
            this.RightToLeftLayout = true;
            this.Text = "SISTEMA DE GERENCIAMENTO DE LOJA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mdiMenu_Load);
            this.menuVertical.ResumeLayout(false);
            this.menuVertical.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox btnslide;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENDEDORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCESSOAOSISTEMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOBREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONFIGURAÇÕESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAZERLOGOFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLTERARTEMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cALENDÁRIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENDAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cONSULTAVENDAToolStripMenuItem;
    }
}



