namespace Calculadora
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIntegrantes = new System.Windows.Forms.Label();
            this.txtIntegrantes = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.linkGit = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(14, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(326, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Projeto Calculadora Semi-Científica";
            // 
            // lblIntegrantes
            // 
            this.lblIntegrantes.AutoSize = true;
            this.lblIntegrantes.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrantes.Location = new System.Drawing.Point(15, 57);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.Size = new System.Drawing.Size(86, 20);
            this.lblIntegrantes.TabIndex = 1;
            this.lblIntegrantes.Text = "Integrantes";
            // 
            // txtIntegrantes
            // 
            this.txtIntegrantes.AutoSize = true;
            this.txtIntegrantes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntegrantes.Location = new System.Drawing.Point(17, 87);
            this.txtIntegrantes.Name = "txtIntegrantes";
            this.txtIntegrantes.Size = new System.Drawing.Size(246, 45);
            this.txtIntegrantes.TabIndex = 4;
            this.txtIntegrantes.Text = "• Vinicius Rodrigues de Oliveira — RM 559611\r\n• Nathalia Mantovani — RM 99904\r\n• " +
    "Alexis Rondo — RM 560384";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(15, 159);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(203, 20);
            this.lblLink.TabIndex = 5;
            this.lblLink.Text = "Link para repositório GitHub";
            // 
            // linkGit
            // 
            this.linkGit.AutoSize = true;
            this.linkGit.Location = new System.Drawing.Point(17, 189);
            this.linkGit.Name = "linkGit";
            this.linkGit.Size = new System.Drawing.Size(55, 13);
            this.linkGit.TabIndex = 6;
            this.linkGit.TabStop = true;
            this.linkGit.Text = "https://github.com/naah-m/Calculadora-Semi-Cientifica";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 259);
            this.Controls.Add(this.linkGit);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.txtIntegrantes);
            this.Controls.Add(this.lblIntegrantes);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sobre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIntegrantes;
        private System.Windows.Forms.Label txtIntegrantes;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.LinkLabel linkGit;
    }
}
