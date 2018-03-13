namespace Proyecto_Calificador_de_Proyectos.GUI
{
    partial class frm_Profesores
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Superior = new System.Windows.Forms.Panel();
            this.pnl_BtnMenu = new System.Windows.Forms.Panel();
            this.btn_Menu = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_Buscar = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_Inicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Editar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Guardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Eliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmb_Carrera = new MetroFramework.Controls.MetroComboBox();
            this.cmb_Division = new MetroFramework.Controls.MetroComboBox();
            this.dgv_Administrador = new System.Windows.Forms.DataGridView();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.division = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Nombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_ApellidoMat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_ApellidoPat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Clave = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_Nombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_Apellido2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_Carrera = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_Division = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_Apellido1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_Clave = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnl_Superior.SuspendLayout();
            this.pnl_BtnMenu.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Administrador)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Superior
            // 
            this.pnl_Superior.Controls.Add(this.pnl_BtnMenu);
            this.pnl_Superior.Controls.Add(this.bunifuMaterialTextbox4);
            this.pnl_Superior.Controls.Add(this.bunifuCustomLabel1);
            this.pnl_Superior.Controls.Add(this.btn_Buscar);
            this.pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_Superior.Name = "pnl_Superior";
            this.pnl_Superior.Size = new System.Drawing.Size(710, 70);
            this.pnl_Superior.TabIndex = 39;
            // 
            // pnl_BtnMenu
            // 
            this.pnl_BtnMenu.BackColor = System.Drawing.Color.White;
            this.pnl_BtnMenu.Controls.Add(this.btn_Menu);
            this.pnl_BtnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnl_BtnMenu.Name = "pnl_BtnMenu";
            this.pnl_BtnMenu.Size = new System.Drawing.Size(40, 70);
            this.pnl_BtnMenu.TabIndex = 43;
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_Menu.color = System.Drawing.Color.Transparent;
            this.btn_Menu.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Menu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Menu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Menu.Image = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Menu_64px;
            this.btn_Menu.ImagePosition = 6;
            this.btn_Menu.ImageZoom = 70;
            this.btn_Menu.LabelPosition = 0;
            this.btn_Menu.LabelText = "";
            this.btn_Menu.Location = new System.Drawing.Point(0, 33);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(40, 37);
            this.btn_Menu.TabIndex = 44;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // bunifuMaterialTextbox4
            // 
            this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox4.HintText = "";
            this.bunifuMaterialTextbox4.isPassword = false;
            this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox4.LineThickness = 3;
            this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(187, 33);
            this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(168, 33);
            this.bunifuMaterialTextbox4.TabIndex = 42;
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(184, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(161, 16);
            this.bunifuCustomLabel1.TabIndex = 41;
            this.bunifuCustomLabel1.Text = "POR APELLIDO PATERNO";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.White;
            this.btn_Buscar.color = System.Drawing.Color.White;
            this.btn_Buscar.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Buscar.Image = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Search_32px;
            this.btn_Buscar.ImagePosition = 8;
            this.btn_Buscar.ImageZoom = 50;
            this.btn_Buscar.LabelPosition = 24;
            this.btn_Buscar.LabelText = "Buscar";
            this.btn_Buscar.Location = new System.Drawing.Point(109, 0);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(67, 70);
            this.btn_Buscar.TabIndex = 0;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.White;
            this.pnl_Menu.Controls.Add(this.btn_Inicio);
            this.pnl_Menu.Controls.Add(this.btn_Editar);
            this.pnl_Menu.Controls.Add(this.btn_Guardar);
            this.pnl_Menu.Controls.Add(this.btn_Eliminar);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 70);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(40, 441);
            this.pnl_Menu.TabIndex = 40;
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Inicio.BackColor = System.Drawing.Color.Transparent;
            this.btn_Inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Inicio.BorderRadius = 0;
            this.btn_Inicio.ButtonText = "Inicio";
            this.btn_Inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Inicio.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Inicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Inicio.Iconimage = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Home_64px1;
            this.btn_Inicio.Iconimage_right = null;
            this.btn_Inicio.Iconimage_right_Selected = null;
            this.btn_Inicio.Iconimage_Selected = null;
            this.btn_Inicio.IconMarginLeft = 0;
            this.btn_Inicio.IconMarginRight = 0;
            this.btn_Inicio.IconRightVisible = true;
            this.btn_Inicio.IconRightZoom = 0D;
            this.btn_Inicio.IconVisible = true;
            this.btn_Inicio.IconZoom = 70D;
            this.btn_Inicio.IsTab = false;
            this.btn_Inicio.Location = new System.Drawing.Point(0, 399);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Inicio.OnHovercolor = System.Drawing.Color.Silver;
            this.btn_Inicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Inicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Inicio.selected = false;
            this.btn_Inicio.Size = new System.Drawing.Size(90, 42);
            this.btn_Inicio.TabIndex = 43;
            this.btn_Inicio.Text = "Inicio";
            this.btn_Inicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inicio.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Inicio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inicio.Click += new System.EventHandler(this.btn_Inicio_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Editar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Editar.BorderRadius = 0;
            this.btn_Editar.ButtonText = "Editar";
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Editar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Editar.Iconimage = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Edit_64px1;
            this.btn_Editar.Iconimage_right = null;
            this.btn_Editar.Iconimage_right_Selected = null;
            this.btn_Editar.Iconimage_Selected = null;
            this.btn_Editar.IconMarginLeft = 0;
            this.btn_Editar.IconMarginRight = 0;
            this.btn_Editar.IconRightVisible = true;
            this.btn_Editar.IconRightZoom = 0D;
            this.btn_Editar.IconVisible = true;
            this.btn_Editar.IconZoom = 70D;
            this.btn_Editar.IsTab = false;
            this.btn_Editar.Location = new System.Drawing.Point(0, 91);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Editar.OnHovercolor = System.Drawing.Color.Silver;
            this.btn_Editar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Editar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Editar.selected = false;
            this.btn_Editar.Size = new System.Drawing.Size(90, 42);
            this.btn_Editar.TabIndex = 41;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Editar.Textcolor = System.Drawing.Color.Green;
            this.btn_Editar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Guardar.BorderRadius = 0;
            this.btn_Guardar.ButtonText = "Guardar";
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Guardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Guardar.Iconimage = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Save_64px1;
            this.btn_Guardar.Iconimage_right = null;
            this.btn_Guardar.Iconimage_right_Selected = null;
            this.btn_Guardar.Iconimage_Selected = null;
            this.btn_Guardar.IconMarginLeft = 0;
            this.btn_Guardar.IconMarginRight = 0;
            this.btn_Guardar.IconRightVisible = true;
            this.btn_Guardar.IconRightZoom = 0D;
            this.btn_Guardar.IconVisible = true;
            this.btn_Guardar.IconZoom = 70D;
            this.btn_Guardar.IsTab = false;
            this.btn_Guardar.Location = new System.Drawing.Point(0, 26);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Guardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Guardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Guardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Guardar.selected = false;
            this.btn_Guardar.Size = new System.Drawing.Size(90, 42);
            this.btn_Guardar.TabIndex = 40;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Textcolor = System.Drawing.Color.Green;
            this.btn_Guardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Eliminar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar.BorderRadius = 0;
            this.btn_Eliminar.ButtonText = "Eliminar";
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Eliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.Iconimage = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Trash_64px;
            this.btn_Eliminar.Iconimage_right = null;
            this.btn_Eliminar.Iconimage_right_Selected = null;
            this.btn_Eliminar.Iconimage_Selected = null;
            this.btn_Eliminar.IconMarginLeft = 0;
            this.btn_Eliminar.IconMarginRight = 0;
            this.btn_Eliminar.IconRightVisible = true;
            this.btn_Eliminar.IconRightZoom = 0D;
            this.btn_Eliminar.IconVisible = true;
            this.btn_Eliminar.IconZoom = 70D;
            this.btn_Eliminar.IsTab = false;
            this.btn_Eliminar.Location = new System.Drawing.Point(0, 159);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.OnHovercolor = System.Drawing.Color.Silver;
            this.btn_Eliminar.OnHoverTextColor = System.Drawing.Color.Red;
            this.btn_Eliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Eliminar.selected = false;
            this.btn_Eliminar.Size = new System.Drawing.Size(90, 42);
            this.btn_Eliminar.TabIndex = 42;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.Textcolor = System.Drawing.Color.White;
            this.btn_Eliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cmb_Carrera
            // 
            this.cmb_Carrera.FormattingEnabled = true;
            this.cmb_Carrera.ItemHeight = 23;
            this.cmb_Carrera.Location = new System.Drawing.Point(518, 108);
            this.cmb_Carrera.Name = "cmb_Carrera";
            this.cmb_Carrera.Size = new System.Drawing.Size(168, 29);
            this.cmb_Carrera.TabIndex = 56;
            this.cmb_Carrera.UseSelectable = true;
            // 
            // cmb_Division
            // 
            this.cmb_Division.FormattingEnabled = true;
            this.cmb_Division.ItemHeight = 23;
            this.cmb_Division.Items.AddRange(new object[] {
            "Tecnología de la Información y Comunicación",
            "Administración",
            "Turismo",
            "Gastronomía",
            "Desarrollo de Negocios",
            "Diseño Digital",
            "Mantenimiento",
            "Mecatronica",
            "Prosesos Industriales",
            "Energías Renovables"});
            this.cmb_Division.Location = new System.Drawing.Point(308, 109);
            this.cmb_Division.Name = "cmb_Division";
            this.cmb_Division.Size = new System.Drawing.Size(168, 29);
            this.cmb_Division.TabIndex = 55;
            this.cmb_Division.UseSelectable = true;
            // 
            // dgv_Administrador
            // 
            this.dgv_Administrador.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Administrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Administrador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clave,
            this.apellidoPat,
            this.apellidoMat,
            this.nombre,
            this.carrera,
            this.division});
            this.dgv_Administrador.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.dgv_Administrador.Location = new System.Drawing.Point(108, 330);
            this.dgv_Administrador.Name = "dgv_Administrador";
            this.dgv_Administrador.Size = new System.Drawing.Size(578, 152);
            this.dgv_Administrador.TabIndex = 54;
            // 
            // clave
            // 
            this.clave.HeaderText = "CLAVE";
            this.clave.Name = "clave";
            // 
            // apellidoPat
            // 
            this.apellidoPat.HeaderText = "APELLIDO PATERNO";
            this.apellidoPat.Name = "apellidoPat";
            // 
            // apellidoMat
            // 
            this.apellidoMat.HeaderText = "APELLIDO MATERNO";
            this.apellidoMat.Name = "apellidoMat";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "NOMBRE (S)";
            this.nombre.Name = "nombre";
            // 
            // carrera
            // 
            this.carrera.HeaderText = "CARRERA";
            this.carrera.Name = "carrera";
            // 
            // division
            // 
            this.division.HeaderText = "DIVISIÓN";
            this.division.Name = "division";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Nombre.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Nombre.HintText = "";
            this.txt_Nombre.isPassword = false;
            this.txt_Nombre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.txt_Nombre.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.txt_Nombre.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txt_Nombre.LineThickness = 3;
            this.txt_Nombre.Location = new System.Drawing.Point(518, 176);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(168, 33);
            this.txt_Nombre.TabIndex = 53;
            this.txt_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // txt_ApellidoMat
            // 
            this.txt_ApellidoMat.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_ApellidoMat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ApellidoMat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ApellidoMat.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ApellidoMat.HintText = "";
            this.txt_ApellidoMat.isPassword = false;
            this.txt_ApellidoMat.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.txt_ApellidoMat.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.txt_ApellidoMat.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txt_ApellidoMat.LineThickness = 3;
            this.txt_ApellidoMat.Location = new System.Drawing.Point(308, 176);
            this.txt_ApellidoMat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ApellidoMat.Name = "txt_ApellidoMat";
            this.txt_ApellidoMat.Size = new System.Drawing.Size(168, 33);
            this.txt_ApellidoMat.TabIndex = 52;
            this.txt_ApellidoMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ApellidoMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ApellidoMat_KeyPress);
            // 
            // txt_ApellidoPat
            // 
            this.txt_ApellidoPat.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_ApellidoPat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ApellidoPat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ApellidoPat.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ApellidoPat.HintText = "";
            this.txt_ApellidoPat.isPassword = false;
            this.txt_ApellidoPat.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.txt_ApellidoPat.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.txt_ApellidoPat.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txt_ApellidoPat.LineThickness = 3;
            this.txt_ApellidoPat.Location = new System.Drawing.Point(108, 176);
            this.txt_ApellidoPat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ApellidoPat.Name = "txt_ApellidoPat";
            this.txt_ApellidoPat.Size = new System.Drawing.Size(168, 33);
            this.txt_ApellidoPat.TabIndex = 51;
            this.txt_ApellidoPat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ApellidoPat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ApellidoPat_KeyPress);
            // 
            // txt_Clave
            // 
            this.txt_Clave.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txt_Clave.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Clave.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Clave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Clave.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Clave.HintText = "";
            this.txt_Clave.isPassword = false;
            this.txt_Clave.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.txt_Clave.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.txt_Clave.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txt_Clave.LineThickness = 3;
            this.txt_Clave.Location = new System.Drawing.Point(108, 109);
            this.txt_Clave.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(147, 35);
            this.txt_Clave.TabIndex = 50;
            this.txt_Clave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Clave_KeyPress);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.lbl_Nombre.Location = new System.Drawing.Point(515, 156);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(85, 16);
            this.lbl_Nombre.TabIndex = 49;
            this.lbl_Nombre.Text = "NOMBRE (S)";
            // 
            // lbl_Apellido2
            // 
            this.lbl_Apellido2.AutoSize = true;
            this.lbl_Apellido2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.lbl_Apellido2.Location = new System.Drawing.Point(305, 156);
            this.lbl_Apellido2.Name = "lbl_Apellido2";
            this.lbl_Apellido2.Size = new System.Drawing.Size(136, 16);
            this.lbl_Apellido2.TabIndex = 48;
            this.lbl_Apellido2.Text = "APELLIDO MATERNO";
            // 
            // lbl_Carrera
            // 
            this.lbl_Carrera.AutoSize = true;
            this.lbl_Carrera.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Carrera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.lbl_Carrera.Location = new System.Drawing.Point(515, 89);
            this.lbl_Carrera.Name = "lbl_Carrera";
            this.lbl_Carrera.Size = new System.Drawing.Size(69, 16);
            this.lbl_Carrera.TabIndex = 47;
            this.lbl_Carrera.Text = "CARRERA";
            // 
            // lbl_Division
            // 
            this.lbl_Division.AutoSize = true;
            this.lbl_Division.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Division.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.lbl_Division.Location = new System.Drawing.Point(305, 89);
            this.lbl_Division.Name = "lbl_Division";
            this.lbl_Division.Size = new System.Drawing.Size(66, 16);
            this.lbl_Division.TabIndex = 46;
            this.lbl_Division.Text = "DIVISIÓN";
            // 
            // lbl_Apellido1
            // 
            this.lbl_Apellido1.AutoSize = true;
            this.lbl_Apellido1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.lbl_Apellido1.Location = new System.Drawing.Point(105, 156);
            this.lbl_Apellido1.Name = "lbl_Apellido1";
            this.lbl_Apellido1.Size = new System.Drawing.Size(131, 16);
            this.lbl_Apellido1.TabIndex = 45;
            this.lbl_Apellido1.Text = "APELLIDO PATERNO";
            // 
            // lbl_Clave
            // 
            this.lbl_Clave.AutoSize = true;
            this.lbl_Clave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.lbl_Clave.Location = new System.Drawing.Point(105, 89);
            this.lbl_Clave.Name = "lbl_Clave";
            this.lbl_Clave.Size = new System.Drawing.Size(50, 16);
            this.lbl_Clave.TabIndex = 44;
            this.lbl_Clave.Text = "CLAVE";
            // 
            // frm_Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmb_Carrera);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.cmb_Division);
            this.Controls.Add(this.dgv_Administrador);
            this.Controls.Add(this.pnl_Superior);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Clave);
            this.Controls.Add(this.txt_ApellidoMat);
            this.Controls.Add(this.lbl_Apellido1);
            this.Controls.Add(this.txt_ApellidoPat);
            this.Controls.Add(this.lbl_Division);
            this.Controls.Add(this.txt_Clave);
            this.Controls.Add(this.lbl_Carrera);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Apellido2);
            this.Name = "frm_Profesores";
            this.Size = new System.Drawing.Size(710, 511);
            this.pnl_Superior.ResumeLayout(false);
            this.pnl_Superior.PerformLayout();
            this.pnl_BtnMenu.ResumeLayout(false);
            this.pnl_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Administrador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Superior;
        private System.Windows.Forms.Panel pnl_BtnMenu;
        private Bunifu.Framework.UI.BunifuTileButton btn_Menu;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTileButton btn_Buscar;
        private System.Windows.Forms.Panel pnl_Menu;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Inicio;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Editar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Guardar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Eliminar;
        private MetroFramework.Controls.MetroComboBox cmb_Carrera;
        private MetroFramework.Controls.MetroComboBox cmb_Division;
        private System.Windows.Forms.DataGridView dgv_Administrador;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPat;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn division;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Nombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ApellidoMat;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ApellidoPat;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Clave;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Nombre;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Apellido2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Carrera;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Division;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Apellido1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Clave;
    }
}
