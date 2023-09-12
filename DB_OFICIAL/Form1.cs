using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DB_OFICIAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=ALLAN; integrated security=SSPI;initial catalog=DB_OFICIAL");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;


        private bool AutenticarUsuario(string email, string senha)
        {
            string conexaoString = "Data Source=DESKTOP-4D8LF92;Initial Catalog=BuscaTec;Integrated Security=True";
            using (SqlConnection conexaoDB = new SqlConnection(conexaoString))
            {
                string sql = "SELECT COUNT(*) FROM Usuarios WHERE email = @email AND senha = @senha";
                SqlCommand cmd = new SqlCommand(sql, conexaoDB);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                conexaoDB.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {




        }

        private void lbnEsqueceu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string email = txtLogin.Text;
            string senha = txtSenha.Text;

            if (AutenticarUsuario(email, senha))
            {

                MessageBox.Show("Login bem-sucedido!");

            }
            else
            {

                MessageBox.Show("Login falhou. Verifique suas credenciais.");
            }
        }
    }
}
