
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RetanguloForms
{
    public partial class Form1 : Form
    {
        float altura = 0;
        float largura = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDesenhar_Click(object sender, EventArgs e)
        {
            try
            {
                altura = float.Parse(txtAltura.Text);
                largura = float.Parse(txtLargura.Text);
                panelDesenho.Invalidate();
            }
            catch
            {
                MessageBox.Show("Digite valores válidos.");
            }
        }

        private void panelDesenho_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            float escala = 5.0f;
            float h = altura * escala;
            float w = largura * escala;

            if (h > panelDesenho.Height) h = panelDesenho.Height - 10;
            if (w > panelDesenho.Width) w = panelDesenho.Width - 10;

            Pen caneta = new Pen(Color.Blue, 2);
            g.DrawRectangle(caneta, 10, 10, w, h);
        }
    }
}
