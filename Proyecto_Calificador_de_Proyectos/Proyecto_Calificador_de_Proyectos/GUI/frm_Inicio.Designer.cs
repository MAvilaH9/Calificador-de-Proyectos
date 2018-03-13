namespace Proyecto_Calificador_de_Proyectos.GUI
{
    partial class frm_Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_Superior = new System.Windows.Forms.Panel();
            this.btn_Maximizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Restaurar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pic_Maximizar = new System.Windows.Forms.PictureBox();
            this.pnl_Izquierdo = new System.Windows.Forms.Panel();
            this.pnl_Submenu = new System.Windows.Forms.Panel();
            this.btn_Retornar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Alumnos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Equipos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Proyectos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Profesores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Alumno = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Profesor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_Central = new System.Windows.Forms.Panel();
            this.Control_From = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.administradores = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.profesores = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.proyectos = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.equipos = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Inicio = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.alumnos = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.frm_Equipos1 = new Proyecto_Calificador_de_Proyectos.GUI.frm_Equipos();
            this.frm_Alumnos1 = new Proyecto_Calificador_de_Proyectos.GUI.frm_Alumnos();
            this.frm_Profesores1 = new Proyecto_Calificador_de_Proyectos.GUI.frm_Profesores();
            this.frm_Proyecto1 = new Proyecto_Calificador_de_Proyectos.GUI.frm_Proyecto();
            this.frm_Administradores1 = new Proyecto_Calificador_de_Proyectos.GUI.frm_Coordinadores();
            this.btn_Coordinador = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Coordinadores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Maximizar)).BeginInit();
            this.pnl_Izquierdo.SuspendLayout();
            this.pnl_Submenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Retornar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Central.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Superior
            // 
            this.pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.pnl_Superior.Controls.Add(this.btn_Maximizar);
            this.pnl_Superior.Controls.Add(this.btn_Restaurar);
            this.pnl_Superior.Controls.Add(this.btn_Minimizar);
            this.pnl_Superior.Controls.Add(this.btn_Cerrar);
            this.pnl_Superior.Controls.Add(this.pic_Maximizar);
            this.pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_Superior.Name = "pnl_Superior";
            this.pnl_Superior.Size = new System.Drawing.Size(950, 35);
            this.pnl_Superior.TabIndex = 2;
            // 
            // btn_Maximizar
            // 
            this.btn_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Maximizar.Image = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Maximize_Window_40px;
            this.btn_Maximizar.ImageActive = null;
            this.btn_Maximizar.Location = new System.Drawing.Point(866, 2);
            this.btn_Maximizar.Name = "btn_Maximizar";
            this.btn_Maximizar.Size = new System.Drawing.Size(30, 30);
            this.btn_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Maximizar.TabIndex = 3;
            this.btn_Maximizar.TabStop = false;
            this.btn_Maximizar.Zoom = 10;
            this.btn_Maximizar.Click += new System.EventHandler(this.btn_Maximizar_Click);
            // 
            // btn_Restaurar
            // 
            this.btn_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Restaurar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Restaurar.Image = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Restore_Window_40px;
            this.btn_Restaurar.ImageActive = null;
            this.btn_Restaurar.Location = new System.Drawing.Point(866, 3);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Size = new System.Drawing.Size(30, 30);
            this.btn_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Restaurar.TabIndex = 1;
            this.btn_Restaurar.TabStop = false;
            this.btn_Restaurar.Zoom = 10;
            this.btn_Restaurar.Click += new System.EventHandler(this.btn_Restaurar_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimizar.Image = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Minimize_Window_40px;
            this.btn_Minimizar.ImageActive = null;
            this.btn_Minimizar.Location = new System.Drawing.Point(830, 3);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minimizar.TabIndex = 2;
            this.btn_Minimizar.TabStop = false;
            this.btn_Minimizar.Zoom = 10;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cerrar.Image = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Delete_32px1;
            this.btn_Cerrar.ImageActive = null;
            this.btn_Cerrar.Location = new System.Drawing.Point(902, 3);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(30, 30);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Zoom = 10;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // pic_Maximizar
            // 
            this.pic_Maximizar.Location = new System.Drawing.Point(973, 2);
            this.pic_Maximizar.Name = "pic_Maximizar";
            this.pic_Maximizar.Size = new System.Drawing.Size(30, 30);
            this.pic_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Maximizar.TabIndex = 2;
            this.pic_Maximizar.TabStop = false;
            // 
            // pnl_Izquierdo
            // 
            this.pnl_Izquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.pnl_Izquierdo.Controls.Add(this.btn_Coordinador);
            this.pnl_Izquierdo.Controls.Add(this.pnl_Submenu);
            this.pnl_Izquierdo.Controls.Add(this.btn_Alumno);
            this.pnl_Izquierdo.Controls.Add(this.btn_Profesor);
            this.pnl_Izquierdo.Controls.Add(this.pictureBox1);
            this.pnl_Izquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Izquierdo.Location = new System.Drawing.Point(0, 35);
            this.pnl_Izquierdo.Name = "pnl_Izquierdo";
            this.pnl_Izquierdo.Size = new System.Drawing.Size(240, 511);
            this.pnl_Izquierdo.TabIndex = 11;
            // 
            // pnl_Submenu
            // 
            this.pnl_Submenu.Controls.Add(this.btn_Coordinadores);
            this.pnl_Submenu.Controls.Add(this.btn_Retornar);
            this.pnl_Submenu.Controls.Add(this.btn_Alumnos);
            this.pnl_Submenu.Controls.Add(this.btn_Equipos);
            this.pnl_Submenu.Controls.Add(this.btn_Proyectos);
            this.pnl_Submenu.Controls.Add(this.btn_Profesores);
            this.pnl_Submenu.Location = new System.Drawing.Point(40, 203);
            this.pnl_Submenu.Name = "pnl_Submenu";
            this.pnl_Submenu.Size = new System.Drawing.Size(200, 247);
            this.pnl_Submenu.TabIndex = 4;
            this.pnl_Submenu.Visible = false;
            // 
            // btn_Retornar
            // 
            this.btn_Retornar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Retornar.Image = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Reply_Arrow_64px;
            this.btn_Retornar.ImageActive = null;
            this.btn_Retornar.Location = new System.Drawing.Point(160, 222);
            this.btn_Retornar.Name = "btn_Retornar";
            this.btn_Retornar.Size = new System.Drawing.Size(40, 25);
            this.btn_Retornar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Retornar.TabIndex = 5;
            this.btn_Retornar.TabStop = false;
            this.btn_Retornar.Zoom = 10;
            this.btn_Retornar.Click += new System.EventHandler(this.btn_Retornar_Click);
            // 
            // btn_Alumnos
            // 
            this.btn_Alumnos.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Alumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.btn_Alumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Alumnos.BorderRadius = 0;
            this.btn_Alumnos.ButtonText = "               Alumnos";
            this.btn_Alumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Alumnos.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Alumnos.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Alumnos.Iconimage = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Student_Male_96px1;
            this.btn_Alumnos.Iconimage_right = null;
            this.btn_Alumnos.Iconimage_right_Selected = null;
            this.btn_Alumnos.Iconimage_Selected = null;
            this.btn_Alumnos.IconMarginLeft = 0;
            this.btn_Alumnos.IconMarginRight = 0;
            this.btn_Alumnos.IconRightVisible = true;
            this.btn_Alumnos.IconRightZoom = 0D;
            this.btn_Alumnos.IconVisible = true;
            this.btn_Alumnos.IconZoom = 70D;
            this.btn_Alumnos.IsTab = false;
            this.btn_Alumnos.Location = new System.Drawing.Point(3, 132);
            this.btn_Alumnos.Name = "btn_Alumnos";
            this.btn_Alumnos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.btn_Alumnos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Alumnos.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Alumnos.selected = false;
            this.btn_Alumnos.Size = new System.Drawing.Size(194, 37);
            this.btn_Alumnos.TabIndex = 6;
            this.btn_Alumnos.Text = "               Alumnos";
            this.btn_Alumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Alumnos.Textcolor = System.Drawing.Color.White;
            this.btn_Alumnos.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alumnos.Click += new System.EventHandler(this.btn_Alumnos_Click);
            // 
            // btn_Equipos
            // 
            this.btn_Equipos.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Equipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.btn_Equipos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Equipos.BorderRadius = 0;
            this.btn_Equipos.ButtonText = "               Equipos";
            this.btn_Equipos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Equipos.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Equipos.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Equipos.Iconimage = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.User_Groups_96px;
            this.btn_Equipos.Iconimage_right = null;
            this.btn_Equipos.Iconimage_right_Selected = null;
            this.btn_Equipos.Iconimage_Selected = null;
            this.btn_Equipos.IconMarginLeft = 0;
            this.btn_Equipos.IconMarginRight = 0;
            this.btn_Equipos.IconRightVisible = true;
            this.btn_Equipos.IconRightZoom = 0D;
            this.btn_Equipos.IconVisible = true;
            this.btn_Equipos.IconZoom = 70D;
            this.btn_Equipos.IsTab = false;
            this.btn_Equipos.Location = new System.Drawing.Point(3, 175);
            this.btn_Equipos.Name = "btn_Equipos";
            this.btn_Equipos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.btn_Equipos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Equipos.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Equipos.selected = false;
            this.btn_Equipos.Size = new System.Drawing.Size(194, 37);
            this.btn_Equipos.TabIndex = 5;
            this.btn_Equipos.Text = "               Equipos";
            this.btn_Equipos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Equipos.Textcolor = System.Drawing.Color.White;
            this.btn_Equipos.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Equipos.Click += new System.EventHandler(this.btn_Equipos_Click);
            // 
            // btn_Proyectos
            // 
            this.btn_Proyectos.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Proyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.btn_Proyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Proyectos.BorderRadius = 0;
            this.btn_Proyectos.ButtonText = "               Proyectos";
            this.btn_Proyectos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Proyectos.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Proyectos.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Proyectos.Iconimage = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Reading_96px1;
            this.btn_Proyectos.Iconimage_right = null;
            this.btn_Proyectos.Iconimage_right_Selected = null;
            this.btn_Proyectos.Iconimage_Selected = null;
            this.btn_Proyectos.IconMarginLeft = 0;
            this.btn_Proyectos.IconMarginRight = 0;
            this.btn_Proyectos.IconRightVisible = true;
            this.btn_Proyectos.IconRightZoom = 0D;
            this.btn_Proyectos.IconVisible = true;
            this.btn_Proyectos.IconZoom = 70D;
            this.btn_Proyectos.IsTab = false;
            this.btn_Proyectos.Location = new System.Drawing.Point(3, 89);
            this.btn_Proyectos.Name = "btn_Proyectos";
            this.btn_Proyectos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.btn_Proyectos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Proyectos.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Proyectos.selected = false;
            this.btn_Proyectos.Size = new System.Drawing.Size(194, 37);
            this.btn_Proyectos.TabIndex = 4;
            this.btn_Proyectos.Text = "               Proyectos";
            this.btn_Proyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Proyectos.Textcolor = System.Drawing.Color.White;
            this.btn_Proyectos.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Proyectos.Click += new System.EventHandler(this.btn_Proyectos_Click);
            // 
            // btn_Profesores
            // 
            this.btn_Profesores.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Profesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.btn_Profesores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Profesores.BorderRadius = 0;
            this.btn_Profesores.ButtonText = "               Profesores";
            this.btn_Profesores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Profesores.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Profesores.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Profesores.Iconimage = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Management_96px1;
            this.btn_Profesores.Iconimage_right = null;
            this.btn_Profesores.Iconimage_right_Selected = null;
            this.btn_Profesores.Iconimage_Selected = null;
            this.btn_Profesores.IconMarginLeft = 0;
            this.btn_Profesores.IconMarginRight = 0;
            this.btn_Profesores.IconRightVisible = true;
            this.btn_Profesores.IconRightZoom = 0D;
            this.btn_Profesores.IconVisible = true;
            this.btn_Profesores.IconZoom = 70D;
            this.btn_Profesores.IsTab = false;
            this.btn_Profesores.Location = new System.Drawing.Point(3, 46);
            this.btn_Profesores.Name = "btn_Profesores";
            this.btn_Profesores.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.btn_Profesores.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Profesores.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Profesores.selected = false;
            this.btn_Profesores.Size = new System.Drawing.Size(194, 37);
            this.btn_Profesores.TabIndex = 3;
            this.btn_Profesores.Text = "               Profesores";
            this.btn_Profesores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profesores.Textcolor = System.Drawing.Color.White;
            this.btn_Profesores.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profesores.Click += new System.EventHandler(this.btn_Pofesores_Click);
            // 
            // btn_Alumno
            // 
            this.btn_Alumno.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Alumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.btn_Alumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Alumno.BorderRadius = 0;
            this.btn_Alumno.ButtonText = "   Alumno";
            this.btn_Alumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Alumno.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Alumno.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Alumno.Iconimage = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Student_Male_96px1;
            this.btn_Alumno.Iconimage_right = null;
            this.btn_Alumno.Iconimage_right_Selected = null;
            this.btn_Alumno.Iconimage_Selected = null;
            this.btn_Alumno.IconMarginLeft = 0;
            this.btn_Alumno.IconMarginRight = 0;
            this.btn_Alumno.IconRightVisible = true;
            this.btn_Alumno.IconRightZoom = 0D;
            this.btn_Alumno.IconVisible = true;
            this.btn_Alumno.IconZoom = 90D;
            this.btn_Alumno.IsTab = false;
            this.btn_Alumno.Location = new System.Drawing.Point(0, 328);
            this.btn_Alumno.Name = "btn_Alumno";
            this.btn_Alumno.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.btn_Alumno.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Alumno.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Alumno.selected = false;
            this.btn_Alumno.Size = new System.Drawing.Size(240, 52);
            this.btn_Alumno.TabIndex = 3;
            this.btn_Alumno.Text = "   Alumno";
            this.btn_Alumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Alumno.Textcolor = System.Drawing.Color.White;
            this.btn_Alumno.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Profesor
            // 
            this.btn_Profesor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Profesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.btn_Profesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Profesor.BorderRadius = 0;
            this.btn_Profesor.ButtonText = "   Profesor";
            this.btn_Profesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Profesor.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Profesor.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Profesor.Iconimage = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Management_96px1;
            this.btn_Profesor.Iconimage_right = null;
            this.btn_Profesor.Iconimage_right_Selected = null;
            this.btn_Profesor.Iconimage_Selected = null;
            this.btn_Profesor.IconMarginLeft = 0;
            this.btn_Profesor.IconMarginRight = 0;
            this.btn_Profesor.IconRightVisible = true;
            this.btn_Profesor.IconRightZoom = 0D;
            this.btn_Profesor.IconVisible = true;
            this.btn_Profesor.IconZoom = 90D;
            this.btn_Profesor.IsTab = false;
            this.btn_Profesor.Location = new System.Drawing.Point(0, 238);
            this.btn_Profesor.Name = "btn_Profesor";
            this.btn_Profesor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.btn_Profesor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Profesor.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Profesor.selected = false;
            this.btn_Profesor.Size = new System.Drawing.Size(240, 52);
            this.btn_Profesor.TabIndex = 2;
            this.btn_Profesor.Text = "   Profesor";
            this.btn_Profesor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profesor.Textcolor = System.Drawing.Color.White;
            this.btn_Profesor.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.LogoUTM;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_Central
            // 
            this.pnl_Central.Controls.Add(this.frm_Equipos1);
            this.pnl_Central.Controls.Add(this.frm_Alumnos1);
            this.pnl_Central.Controls.Add(this.frm_Profesores1);
            this.pnl_Central.Controls.Add(this.frm_Proyecto1);
            this.pnl_Central.Controls.Add(this.frm_Administradores1);
            this.pnl_Central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Central.Location = new System.Drawing.Point(240, 35);
            this.pnl_Central.Name = "pnl_Central";
            this.pnl_Central.Size = new System.Drawing.Size(710, 511);
            this.pnl_Central.TabIndex = 12;
            // 
            // Control_From
            // 
            this.Control_From.Fixed = true;
            this.Control_From.Horizontal = true;
            this.Control_From.TargetControl = this.pnl_Superior;
            this.Control_From.Vertical = true;
            // 
            // administradores
            // 
            this.administradores.ElipseRadius = 5;
            // 
            // profesores
            // 
            this.profesores.ElipseRadius = 5;
            this.profesores.TargetControl = this.btn_Profesores;
            // 
            // proyectos
            // 
            this.proyectos.ElipseRadius = 5;
            this.proyectos.TargetControl = this.btn_Proyectos;
            // 
            // equipos
            // 
            this.equipos.ElipseRadius = 5;
            this.equipos.TargetControl = this.btn_Equipos;
            // 
            // Inicio
            // 
            this.Inicio.ElipseRadius = 30;
            this.Inicio.TargetControl = this;
            // 
            // alumnos
            // 
            this.alumnos.ElipseRadius = 5;
            this.alumnos.TargetControl = this.btn_Alumnos;
            // 
            // frm_Equipos1
            // 
            this.frm_Equipos1.BackColor = System.Drawing.Color.White;
            this.frm_Equipos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_Equipos1.Location = new System.Drawing.Point(0, 0);
            this.frm_Equipos1.Name = "frm_Equipos1";
            this.frm_Equipos1.Size = new System.Drawing.Size(710, 511);
            this.frm_Equipos1.TabIndex = 4;
            this.frm_Equipos1.Visible = false;
            // 
            // frm_Alumnos1
            // 
            this.frm_Alumnos1.BackColor = System.Drawing.Color.White;
            this.frm_Alumnos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_Alumnos1.Location = new System.Drawing.Point(0, 0);
            this.frm_Alumnos1.Name = "frm_Alumnos1";
            this.frm_Alumnos1.Size = new System.Drawing.Size(710, 511);
            this.frm_Alumnos1.TabIndex = 3;
            this.frm_Alumnos1.Visible = false;
            // 
            // frm_Profesores1
            // 
            this.frm_Profesores1.BackColor = System.Drawing.Color.White;
            this.frm_Profesores1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_Profesores1.Location = new System.Drawing.Point(0, 0);
            this.frm_Profesores1.Name = "frm_Profesores1";
            this.frm_Profesores1.Size = new System.Drawing.Size(710, 511);
            this.frm_Profesores1.TabIndex = 2;
            this.frm_Profesores1.Visible = false;
            // 
            // frm_Proyecto1
            // 
            this.frm_Proyecto1.BackColor = System.Drawing.Color.White;
            this.frm_Proyecto1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_Proyecto1.Location = new System.Drawing.Point(0, 0);
            this.frm_Proyecto1.Name = "frm_Proyecto1";
            this.frm_Proyecto1.Size = new System.Drawing.Size(710, 511);
            this.frm_Proyecto1.TabIndex = 1;
            this.frm_Proyecto1.Visible = false;
            // 
            // frm_Administradores1
            // 
            this.frm_Administradores1.BackColor = System.Drawing.Color.White;
            this.frm_Administradores1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_Administradores1.Location = new System.Drawing.Point(0, 0);
            this.frm_Administradores1.Name = "frm_Administradores1";
            this.frm_Administradores1.Size = new System.Drawing.Size(710, 511);
            this.frm_Administradores1.TabIndex = 0;
            this.frm_Administradores1.Visible = false;
            // 
            // btn_Coordinador
            // 
            this.btn_Coordinador.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Coordinador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.btn_Coordinador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Coordinador.BorderRadius = 0;
            this.btn_Coordinador.ButtonText = "   Coordinador";
            this.btn_Coordinador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Coordinador.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Coordinador.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Coordinador.Iconimage = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Management_96px1;
            this.btn_Coordinador.Iconimage_right = null;
            this.btn_Coordinador.Iconimage_right_Selected = null;
            this.btn_Coordinador.Iconimage_Selected = null;
            this.btn_Coordinador.IconMarginLeft = 0;
            this.btn_Coordinador.IconMarginRight = 0;
            this.btn_Coordinador.IconRightVisible = true;
            this.btn_Coordinador.IconRightZoom = 0D;
            this.btn_Coordinador.IconVisible = true;
            this.btn_Coordinador.IconZoom = 90D;
            this.btn_Coordinador.IsTab = false;
            this.btn_Coordinador.Location = new System.Drawing.Point(0, 148);
            this.btn_Coordinador.Name = "btn_Coordinador";
            this.btn_Coordinador.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.btn_Coordinador.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Coordinador.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Coordinador.selected = false;
            this.btn_Coordinador.Size = new System.Drawing.Size(240, 52);
            this.btn_Coordinador.TabIndex = 5;
            this.btn_Coordinador.Text = "   Coordinador";
            this.btn_Coordinador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Coordinador.Textcolor = System.Drawing.Color.White;
            this.btn_Coordinador.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Coordinador.Click += new System.EventHandler(this.btn_Coordinador_Click);
            // 
            // btn_Coordinadores
            // 
            this.btn_Coordinadores.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Coordinadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.btn_Coordinadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Coordinadores.BorderRadius = 0;
            this.btn_Coordinadores.ButtonText = "               Coordinadores";
            this.btn_Coordinadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Coordinadores.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Coordinadores.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Coordinadores.Iconimage = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Management_96px1;
            this.btn_Coordinadores.Iconimage_right = null;
            this.btn_Coordinadores.Iconimage_right_Selected = null;
            this.btn_Coordinadores.Iconimage_Selected = null;
            this.btn_Coordinadores.IconMarginLeft = 0;
            this.btn_Coordinadores.IconMarginRight = 0;
            this.btn_Coordinadores.IconRightVisible = true;
            this.btn_Coordinadores.IconRightZoom = 0D;
            this.btn_Coordinadores.IconVisible = true;
            this.btn_Coordinadores.IconZoom = 70D;
            this.btn_Coordinadores.IsTab = false;
            this.btn_Coordinadores.Location = new System.Drawing.Point(3, 3);
            this.btn_Coordinadores.Name = "btn_Coordinadores";
            this.btn_Coordinadores.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.btn_Coordinadores.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Coordinadores.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Coordinadores.selected = false;
            this.btn_Coordinadores.Size = new System.Drawing.Size(194, 37);
            this.btn_Coordinadores.TabIndex = 7;
            this.btn_Coordinadores.Text = "               Coordinadores";
            this.btn_Coordinadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Coordinadores.Textcolor = System.Drawing.Color.White;
            this.btn_Coordinadores.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Coordinadores.Click += new System.EventHandler(this.btn_Coordinadores_Click);
            // 
            // frm_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 546);
            this.Controls.Add(this.pnl_Central);
            this.Controls.Add(this.pnl_Izquierdo);
            this.Controls.Add(this.pnl_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Inicio";
            this.Text = "frm_Inicio";
            this.pnl_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Maximizar)).EndInit();
            this.pnl_Izquierdo.ResumeLayout(false);
            this.pnl_Submenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Retornar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Central.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Superior;
        private Bunifu.Framework.UI.BunifuImageButton btn_Maximizar;
        private Bunifu.Framework.UI.BunifuImageButton btn_Restaurar;
        private Bunifu.Framework.UI.BunifuImageButton btn_Minimizar;
        private Bunifu.Framework.UI.BunifuImageButton btn_Cerrar;
        private System.Windows.Forms.PictureBox pic_Maximizar;
        private System.Windows.Forms.Panel pnl_Izquierdo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Alumno;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Profesor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_Central;
        private Bunifu.Framework.UI.BunifuDragControl Control_From;
        private System.Windows.Forms.Panel pnl_Submenu;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Equipos;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Proyectos;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Profesores;
        private Bunifu.Framework.UI.BunifuElipse administradores;
        private Bunifu.Framework.UI.BunifuElipse profesores;
        private Bunifu.Framework.UI.BunifuElipse proyectos;
        private Bunifu.Framework.UI.BunifuElipse equipos;
        private Bunifu.Framework.UI.BunifuElipse Inicio;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Alumnos;
        private frm_Coordinadores frm_Administradores1;
        private frm_Proyecto frm_Proyecto1;
        private frm_Profesores frm_Profesores1;
        private frm_Alumnos frm_Alumnos1;
        private frm_Equipos frm_Equipos1;
        private Bunifu.Framework.UI.BunifuElipse alumnos;
        private Bunifu.Framework.UI.BunifuImageButton btn_Retornar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Coordinador;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Coordinadores;
    }
}