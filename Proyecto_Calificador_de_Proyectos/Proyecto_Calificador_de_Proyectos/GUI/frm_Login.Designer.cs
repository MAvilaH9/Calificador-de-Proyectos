namespace Proyecto_Calificador_de_Proyectos
{
    partial class frm_Login
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.pnl_Superior = new System.Windows.Forms.Panel();
            this.pnl_Izquierdo = new System.Windows.Forms.Panel();
            this.pnl_Derecho = new System.Windows.Forms.Panel();
            this.pnl_Inferior = new System.Windows.Forms.Panel();
            this.Control_from = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.login = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_Usuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Contraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ptb_Contraseña = new System.Windows.Forms.PictureBox();
            this.ptb_Usuario = new System.Windows.Forms.PictureBox();
            this.btn_InicioCes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.btn_Minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnl_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Contraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Superior
            // 
            this.pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.pnl_Superior.Controls.Add(this.btn_Minimizar);
            this.pnl_Superior.Controls.Add(this.btn_Cerrar);
            this.pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_Superior.Name = "pnl_Superior";
            this.pnl_Superior.Size = new System.Drawing.Size(546, 30);
            this.pnl_Superior.TabIndex = 13;
            // 
            // pnl_Izquierdo
            // 
            this.pnl_Izquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.pnl_Izquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Izquierdo.Location = new System.Drawing.Point(0, 30);
            this.pnl_Izquierdo.Name = "pnl_Izquierdo";
            this.pnl_Izquierdo.Size = new System.Drawing.Size(10, 371);
            this.pnl_Izquierdo.TabIndex = 14;
            // 
            // pnl_Derecho
            // 
            this.pnl_Derecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.pnl_Derecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Derecho.Location = new System.Drawing.Point(536, 30);
            this.pnl_Derecho.Name = "pnl_Derecho";
            this.pnl_Derecho.Size = new System.Drawing.Size(10, 371);
            this.pnl_Derecho.TabIndex = 19;
            // 
            // pnl_Inferior
            // 
            this.pnl_Inferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.pnl_Inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Inferior.Location = new System.Drawing.Point(10, 391);
            this.pnl_Inferior.Name = "pnl_Inferior";
            this.pnl_Inferior.Size = new System.Drawing.Size(526, 10);
            this.pnl_Inferior.TabIndex = 20;
            // 
            // Control_from
            // 
            this.Control_from.Fixed = true;
            this.Control_from.Horizontal = true;
            this.Control_from.TargetControl = this.pnl_Superior;
            this.Control_from.Vertical = true;
            // 
            // login
            // 
            this.login.ElipseRadius = 50;
            this.login.TargetControl = this;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Usuario.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Usuario.HintText = "";
            this.txt_Usuario.isPassword = false;
            this.txt_Usuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.txt_Usuario.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.txt_Usuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.txt_Usuario.LineThickness = 3;
            this.txt_Usuario.Location = new System.Drawing.Point(306, 129);
            this.txt_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(184, 33);
            this.txt_Usuario.TabIndex = 36;
            this.txt_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Contraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Contraseña.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Contraseña.HintText = "";
            this.txt_Contraseña.isPassword = true;
            this.txt_Contraseña.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.txt_Contraseña.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.txt_Contraseña.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.txt_Contraseña.LineThickness = 3;
            this.txt_Contraseña.Location = new System.Drawing.Point(306, 256);
            this.txt_Contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(184, 33);
            this.txt_Contraseña.TabIndex = 37;
            this.txt_Contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ptb_Contraseña
            // 
            this.ptb_Contraseña.BackColor = System.Drawing.Color.White;
            this.ptb_Contraseña.Image = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Unlock_96px;
            this.ptb_Contraseña.Location = new System.Drawing.Point(306, 180);
            this.ptb_Contraseña.Name = "ptb_Contraseña";
            this.ptb_Contraseña.Size = new System.Drawing.Size(66, 67);
            this.ptb_Contraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Contraseña.TabIndex = 35;
            this.ptb_Contraseña.TabStop = false;
            // 
            // ptb_Usuario
            // 
            this.ptb_Usuario.BackColor = System.Drawing.Color.White;
            this.ptb_Usuario.Image = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.User_96px;
            this.ptb_Usuario.Location = new System.Drawing.Point(306, 55);
            this.ptb_Usuario.Name = "ptb_Usuario";
            this.ptb_Usuario.Size = new System.Drawing.Size(66, 67);
            this.ptb_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Usuario.TabIndex = 34;
            this.ptb_Usuario.TabStop = false;
            // 
            // btn_InicioCes
            // 
            this.btn_InicioCes.ActiveBorderThickness = 1;
            this.btn_InicioCes.ActiveCornerRadius = 20;
            this.btn_InicioCes.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_InicioCes.ActiveForecolor = System.Drawing.Color.White;
            this.btn_InicioCes.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_InicioCes.BackColor = System.Drawing.Color.White;
            this.btn_InicioCes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_InicioCes.BackgroundImage")));
            this.btn_InicioCes.ButtonText = "Iniciar Seción";
            this.btn_InicioCes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InicioCes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InicioCes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_InicioCes.IdleBorderThickness = 2;
            this.btn_InicioCes.IdleCornerRadius = 20;
            this.btn_InicioCes.IdleFillColor = System.Drawing.Color.White;
            this.btn_InicioCes.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_InicioCes.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_InicioCes.Location = new System.Drawing.Point(306, 314);
            this.btn_InicioCes.Margin = new System.Windows.Forms.Padding(5);
            this.btn_InicioCes.Name = "btn_InicioCes";
            this.btn_InicioCes.Size = new System.Drawing.Size(184, 41);
            this.btn_InicioCes.TabIndex = 33;
            this.btn_InicioCes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_InicioCes.Click += new System.EventHandler(this.btn_InicioCes_Click);
            // 
            // pic_Logo
            // 
            this.pic_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pic_Logo.Image = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.LogoUTM;
            this.pic_Logo.Location = new System.Drawing.Point(10, 131);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(275, 131);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Logo.TabIndex = 21;
            this.pic_Logo.TabStop = false;
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Minimizar.Image = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Minimize_Window_40px;
            this.btn_Minimizar.ImageActive = null;
            this.btn_Minimizar.Location = new System.Drawing.Point(465, 2);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(25, 25);
            this.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minimizar.TabIndex = 28;
            this.btn_Minimizar.TabStop = false;
            this.btn_Minimizar.Zoom = 10;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(128)))));
            this.btn_Cerrar.Image = global::Proyecto_Calificador_de_Proyectos.Properties.Resources.Delete_32px1;
            this.btn_Cerrar.ImageActive = null;
            this.btn_Cerrar.Location = new System.Drawing.Point(496, 2);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cerrar.TabIndex = 27;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Zoom = 10;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 401);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.ptb_Contraseña);
            this.Controls.Add(this.ptb_Usuario);
            this.Controls.Add(this.btn_InicioCes);
            this.Controls.Add(this.pic_Logo);
            this.Controls.Add(this.pnl_Inferior);
            this.Controls.Add(this.pnl_Derecho);
            this.Controls.Add(this.pnl_Izquierdo);
            this.Controls.Add(this.pnl_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.Text = "Login";
            this.pnl_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Contraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Superior;
        private System.Windows.Forms.Panel pnl_Izquierdo;
        private System.Windows.Forms.Panel pnl_Derecho;
        private System.Windows.Forms.Panel pnl_Inferior;
        private System.Windows.Forms.PictureBox pic_Logo;
        private Bunifu.Framework.UI.BunifuImageButton btn_Cerrar;
        private Bunifu.Framework.UI.BunifuImageButton btn_Minimizar;
        private Bunifu.Framework.UI.BunifuDragControl Control_from;
        private Bunifu.Framework.UI.BunifuElipse login;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Usuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Contraseña;
        private System.Windows.Forms.PictureBox ptb_Contraseña;
        private System.Windows.Forms.PictureBox ptb_Usuario;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_InicioCes;
    }
}

