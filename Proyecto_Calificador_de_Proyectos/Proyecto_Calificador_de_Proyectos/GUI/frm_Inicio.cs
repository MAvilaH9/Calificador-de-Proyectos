using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Calificador_de_Proyectos.GUI
{
    public partial class frm_Inicio : Form
    {
        public frm_Inicio()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_Maximizar.Visible = false;
            btn_Restaurar.Visible = true;
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_Restaurar.Visible = false;
            btn_Maximizar.Visible = true;
        }

        private void btn_Pofesores_Click(object sender, EventArgs e)
        {
            frm_Profesores1.Visible = true;
            pnl_Submenu.Visible = false;
            btn_Profesor.Visible = true;
            btn_Alumno.Visible = true;
        }

        private void btn_Proyectos_Click(object sender, EventArgs e)
        {
            frm_Proyecto1.Visible = true;
            pnl_Submenu.Visible = false;
            btn_Profesor.Visible = true;
            btn_Alumno.Visible = true;
        }

        private void btn_Equipos_Click(object sender, EventArgs e)
        {
            frm_Equipos1.Visible = true;
            pnl_Submenu.Visible = false;
            btn_Profesor.Visible = true;
            btn_Alumno.Visible = true;
        }

        private void btn_Alumnos_Click(object sender, EventArgs e)
        {
            frm_Alumnos1.Visible = true;
            pnl_Submenu.Visible = false;
            btn_Profesor.Visible = true;
            btn_Alumno.Visible = true;
        }

        private void btn_Retornar_Click(object sender, EventArgs e)
        {
            pnl_Submenu.Visible = false;
            btn_Coordinador.Visible = true;
            btn_Profesor.Visible = true;
           btn_Alumno.Visible=true;
        }

        private void btn_Coordinador_Click(object sender, EventArgs e)
        {
            pnl_Submenu.Visible = true;
            btn_Profesor.Visible = false;
            btn_Alumno.Visible = false;
        }

        private void btn_Coordinadores_Click(object sender, EventArgs e)
        {
            frm_Administradores1.Visible = true;
            pnl_Submenu.Visible = false;
            btn_Profesor.Visible = true;
            btn_Alumno.Visible = true;
        }
    }
}
