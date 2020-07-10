namespace projetoTCM
{
    partial class FormSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSobre));
            this.lblDesenvolvedor = new System.Windows.Forms.Label();
            this.lblDesenvolvedor2 = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesenvolvedor
            // 
            this.lblDesenvolvedor.AutoSize = true;
            this.lblDesenvolvedor.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesenvolvedor.Location = new System.Drawing.Point(510, 49);
            this.lblDesenvolvedor.Name = "lblDesenvolvedor";
            this.lblDesenvolvedor.Size = new System.Drawing.Size(225, 36);
            this.lblDesenvolvedor.TabIndex = 1;
            this.lblDesenvolvedor.Text = "DESENVOLVEDOR";
            // 
            // lblDesenvolvedor2
            // 
            this.lblDesenvolvedor2.AutoSize = true;
            this.lblDesenvolvedor2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesenvolvedor2.Location = new System.Drawing.Point(375, 189);
            this.lblDesenvolvedor2.Name = "lblDesenvolvedor2";
            this.lblDesenvolvedor2.Size = new System.Drawing.Size(550, 174);
            this.lblDesenvolvedor2.TabIndex = 2;
            this.lblDesenvolvedor2.Text = resources.GetString("lblDesenvolvedor2.Text");
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.Location = new System.Drawing.Point(337, 537);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(618, 29);
            this.lblSite.TabIndex = 9;
            this.lblSite.Text = "Entre em contanto conosco pelo site: www.agilecompany.info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projetoTCM.Properties.Resources.logotipoPNG__1_;
            this.pictureBox1.Location = new System.Drawing.Point(445, 406);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 71);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDesenvolvedor2);
            this.Controls.Add(this.lblDesenvolvedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSobre";
            this.Text = "FormSobre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDesenvolvedor;
        private System.Windows.Forms.Label lblDesenvolvedor2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSite;
    }
}