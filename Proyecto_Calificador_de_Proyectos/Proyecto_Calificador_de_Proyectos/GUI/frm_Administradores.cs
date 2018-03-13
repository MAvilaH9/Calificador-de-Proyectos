using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Calificador_de_Proyectos.GUI
{
    public partial class frm_Administradores : UserControl
    {
        public frm_Administradores()
        {
            InitializeComponent();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            pnl_Menu.Visible = true;
            pnl_BtnMenu.Width = 40;
            pnl_Menu.Width = 40;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
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

        private void frm_Administrador_Load(object sender, EventArgs e)
        {

        }
    }
}
