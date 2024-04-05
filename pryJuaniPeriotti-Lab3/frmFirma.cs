using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryJuaniPeriotti_Lab3
{
    public partial class frmFirma : Form
    {
        public Bitmap archivoImagen;
        public frmFirma()
        {
            InitializeComponent();
            archivoImagen = new Bitmap(pbFirmar.Width, pbFirmar.Height);
        }
        private void pbFirmar_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.Location.ToString();
            if (e.Button == MouseButtons.Left)
            {
                lblEjeX.Text = e.X.ToString();
                lblEjeY.Text = e.Y.ToString();
                using (Graphics g = Graphics.FromImage(archivoImagen))
                {
                    g.FillEllipse(Brushes.Black, e.X, e.Y, 5, 5);
                }
                pbFirmar.Invalidate();
            }
        }

        private void pbFirmar_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(archivoImagen, Point.Empty);
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            archivoImagen.Save("Firma.jpg");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            pbFirmar
        }
    }
}
