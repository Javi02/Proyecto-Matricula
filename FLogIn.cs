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

namespace Matricula
{
    public partial class FLogIn : Form
    {
        public FLogIn()
        {
            InitializeComponent();
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwrodTxt_TextChanged(object sender, EventArgs e)
        {

        }
        //
        private void logInBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-B6EFBEB\SQLEXPRESS;Initial Catalog=Matricula;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Login where nombre ='"+ usernameTxt.Text+"' and password='" + passwrordTxt.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                this.Hide();
                Menu main = new Menu();
                main.Show();


            }
            else
            {
                MessageBox.Show("Por favor ingresar la el usuario y la clave correcta", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
