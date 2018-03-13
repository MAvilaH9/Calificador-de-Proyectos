using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Calificador_de_Proyectos.GUI;

namespace Proyecto_Calificador_de_Proyectos
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_InicioCes_Click(object sender, EventArgs e)
        {
            frm_Inicio objI = new frm_Inicio();
            objI.Show();
            this.Hide();
        }
    }
}
