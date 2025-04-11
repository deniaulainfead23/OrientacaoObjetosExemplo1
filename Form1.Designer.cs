
namespace RetanguloForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.Button btnDesenhar;
        private System.Windows.Forms.Panel panelDesenho;

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
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.btnDesenhar = new System.Windows.Forms.Button();
            this.panelDesenho = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(12, 12);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 0;
            // 
            // txtLargura
            // 
            this.txtLargura.Location = new System.Drawing.Point(12, 38);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(100, 20);
            this.txtLargura.TabIndex = 1;
            // 
            // btnDesenhar
            // 
            this.btnDesenhar.Location = new System.Drawing.Point(12, 64);
            this.btnDesenhar.Name = "btnDesenhar";
            this.btnDesenhar.Size = new System.Drawing.Size(100, 23);
            this.btnDesenhar.TabIndex = 2;
            this.btnDesenhar.Text = "Desenhar Retângulo";
            this.btnDesenhar.UseVisualStyleBackColor = true;
            this.btnDesenhar.Click += new System.EventHandler(this.btnDesenhar_Click);
            // 
            // panelDesenho
            // 
            this.panelDesenho.BackColor = System.Drawing.Color.White;
            this.panelDesenho.Location = new System.Drawing.Point(130, 12);
            this.panelDesenho.Name = "panelDesenho";
            this.panelDesenho.Size = new System.Drawing.Size(300, 300);
            this.panelDesenho.TabIndex = 3;
            this.panelDesenho.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesenho_Paint);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(450, 330);
            this.Controls.Add(this.panelDesenho);
            this.Controls.Add(this.btnDesenhar);
            this.Controls.Add(this.txtLargura);
            this.Controls.Add(this.txtAltura);
            this.Name = "Form1";
            this.Text = "Desenhando Retângulo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
