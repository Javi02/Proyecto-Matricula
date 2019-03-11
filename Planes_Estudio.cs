using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula
{
    public partial class Planes_Estudio : Form
    {
        public Planes_Estudio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Industrial
            Industrial industrial = new Industrial();
            industrial.ShowDialog();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            //Quimica
            Quimica Q = new Quimica();
            Q.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelAdmin_Click(object sender, EventArgs e)
        {
            Administracion admin = new Administracion();
            admin.ShowDialog();
        }

        private void labelDerecho_Click(object sender, EventArgs e)
        {
            Derecho derecho = new Derecho();
            derecho.ShowDialog();

        }

        private void labelInfo_Click(object sender, EventArgs e)
        {
            Informatica info = new Informatica();
            info.ShowDialog();
        }

        private void labelOdonto_Click(object sender, EventArgs e)
        {
            Odonto odontoPlan = new Odonto();
            odontoPlan.ShowDialog();

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Menu menuPrincipal = new Menu();
            Planes_Estudio plan = new Planes_Estudio();
            this.Hide();
            menuPrincipal.ShowDialog();
        }
    }
}
