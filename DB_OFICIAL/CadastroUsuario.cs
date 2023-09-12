using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DB_OFICIAL
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=ALLAN; integrated security=SSPI;initial catalog=DB_OFICIAL");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cadastrar(object sender, EventArgs e)
        {
            if (txtNome.Txt)
            {

            }
        }
    }
}
