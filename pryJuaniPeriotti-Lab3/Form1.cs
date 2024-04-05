using Microsoft.VisualBasic;

namespace pryJuaniPeriotti_Lab3
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string psswrd = txtPassword.Text;
            if (user == "" || psswrd == "")
            {
                MessageBox.Show("Por favor ingrese su usuario y contraseña");
            }
            else
            {
                frmFirma firma = new frmFirma();
                firma.Show();
            }
        }
    }
}