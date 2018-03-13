using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Calificador_de_Proyectos.BO;

namespace Proyecto_Calificador_de_Proyectos.GUI
{
    public partial class frm_Profesores : UserControl
    {
        Validar_Datos_BO Validacion = new Validar_Datos_BO();
        public frm_Profesores()
        {
            InitializeComponent();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (pnl_Menu.Width == 40)
            {
                pnl_Menu.Visible = true;
                pnl_Menu.Width = 90;
                pnl_BtnMenu.Width = 90;
            }
            else
            {
                pnl_Menu.Visible = true;
                pnl_Menu.Width = 40;
                pnl_BtnMenu.Width = 40;
            }
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            pnl_Menu.Visible = true;
            pnl_BtnMenu.Width = 40;
            pnl_BtnMenu.Width = 40;
        }

        private void txt_Clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Numeros(e);
        }

        private void txt_ApellidoPat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Letras(e);
        }

        private void txt_ApellidoMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Letras(e);
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Letras(e);
        }
    }
}
