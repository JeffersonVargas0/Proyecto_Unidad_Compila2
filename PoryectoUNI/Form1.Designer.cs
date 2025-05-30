namespace PoryectoUNI
{
    partial class Form1
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnRegistrarRuta = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblBuscarRuta = new System.Windows.Forms.Label();
            this.txtBuscarRuta = new System.Windows.Forms.TextBox();
            this.btnBuscarRuta = new System.Windows.Forms.Button();
            this.lblBuscarUbicacion = new System.Windows.Forms.Label();
            this.txtBuscarUbicacion = new System.Windows.Forms.TextBox();
            this.btnBuscarUbicacion = new System.Windows.Forms.Button();
            this.lstRutas = new System.Windows.Forms.ListBox();
            this.lblRutas = new System.Windows.Forms.Label();
            this.lstBuses = new System.Windows.Forms.ListBox();
            this.lblBuses = new System.Windows.Forms.Label();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.panelMapa = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelMapa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panelSidebar.Controls.Add(this.btnRegistrarRuta);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 60);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(180, 540);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnRegistrarRuta
            // 
            this.btnRegistrarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRegistrarRuta.FlatAppearance.BorderSize = 0;
            this.btnRegistrarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarRuta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarRuta.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarRuta.Location = new System.Drawing.Point(20, 30);
            this.btnRegistrarRuta.Name = "btnRegistrarRuta";
            this.btnRegistrarRuta.Size = new System.Drawing.Size(140, 40);
            this.btnRegistrarRuta.TabIndex = 0;
            this.btnRegistrarRuta.Text = "Registrar Ruta";
            this.btnRegistrarRuta.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1100, 60);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(350, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(382, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Rutas de Buses - UNI";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelMain.Controls.Add(this.lblBuscarRuta);
            this.panelMain.Controls.Add(this.txtBuscarRuta);
            this.panelMain.Controls.Add(this.btnBuscarRuta);
            this.panelMain.Controls.Add(this.lblBuscarUbicacion);
            this.panelMain.Controls.Add(this.txtBuscarUbicacion);
            this.panelMain.Controls.Add(this.btnBuscarUbicacion);
            this.panelMain.Controls.Add(this.panelMapa);
            this.panelMain.Controls.Add(this.lstRutas);
            this.panelMain.Controls.Add(this.lblRutas);
            this.panelMain.Controls.Add(this.lstBuses);
            this.panelMain.Controls.Add(this.lblBuses);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(180, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(920, 540);
            this.panelMain.TabIndex = 2;
            // 
            // lblBuscarRuta
            // 
            this.lblBuscarRuta.AutoSize = true;
            this.lblBuscarRuta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBuscarRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblBuscarRuta.Location = new System.Drawing.Point(20, 25);
            this.lblBuscarRuta.Name = "lblBuscarRuta";
            this.lblBuscarRuta.Size = new System.Drawing.Size(116, 19);
            this.lblBuscarRuta.TabIndex = 0;
            this.lblBuscarRuta.Text = "Buscar una ruta:";
            // 
            // txtBuscarRuta
            // 
            this.txtBuscarRuta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscarRuta.Location = new System.Drawing.Point(140, 22);
            this.txtBuscarRuta.Name = "txtBuscarRuta";
            this.txtBuscarRuta.Size = new System.Drawing.Size(230, 25);
            this.txtBuscarRuta.TabIndex = 1;
            // 
            // btnBuscarRuta
            // 
            this.btnBuscarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBuscarRuta.FlatAppearance.BorderSize = 0;
            this.btnBuscarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarRuta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscarRuta.ForeColor = System.Drawing.Color.White;
            this.btnBuscarRuta.Location = new System.Drawing.Point(380, 20);
            this.btnBuscarRuta.Name = "btnBuscarRuta";
            this.btnBuscarRuta.Size = new System.Drawing.Size(90, 28);
            this.btnBuscarRuta.TabIndex = 2;
            this.btnBuscarRuta.Text = "Buscar";
            this.btnBuscarRuta.UseVisualStyleBackColor = false;
            this.btnBuscarRuta.Click += new System.EventHandler(this.btnBuscarRuta_Click);
            // 
            // lblBuscarUbicacion
            // 
            this.lblBuscarUbicacion.AutoSize = true;
            this.lblBuscarUbicacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBuscarUbicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblBuscarUbicacion.Location = new System.Drawing.Point(490, 25);
            this.lblBuscarUbicacion.Name = "lblBuscarUbicacion";
            this.lblBuscarUbicacion.Size = new System.Drawing.Size(153, 19);
            this.lblBuscarUbicacion.TabIndex = 3;
            this.lblBuscarUbicacion.Text = "Buscar una ubicación:";
            // 
            // txtBuscarUbicacion
            // 
            this.txtBuscarUbicacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscarUbicacion.Location = new System.Drawing.Point(650, 22);
            this.txtBuscarUbicacion.Name = "txtBuscarUbicacion";
            this.txtBuscarUbicacion.Size = new System.Drawing.Size(180, 25);
            this.txtBuscarUbicacion.TabIndex = 4;
            // 
            // btnBuscarUbicacion
            // 
            this.btnBuscarUbicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBuscarUbicacion.FlatAppearance.BorderSize = 0;
            this.btnBuscarUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUbicacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscarUbicacion.ForeColor = System.Drawing.Color.White;
            this.btnBuscarUbicacion.Location = new System.Drawing.Point(840, 20);
            this.btnBuscarUbicacion.Name = "btnBuscarUbicacion";
            this.btnBuscarUbicacion.Size = new System.Drawing.Size(60, 28);
            this.btnBuscarUbicacion.TabIndex = 5;
            this.btnBuscarUbicacion.Text = "Buscar";
            this.btnBuscarUbicacion.UseVisualStyleBackColor = false;
            // 
            // lstRutas
            // 
            this.lstRutas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstRutas.FormattingEnabled = true;
            this.lstRutas.ItemHeight = 17;
            this.lstRutas.Location = new System.Drawing.Point(650, 100);
            this.lstRutas.Name = "lstRutas";
            this.lstRutas.Size = new System.Drawing.Size(250, 123);
            this.lstRutas.TabIndex = 7;
            // 
            // lblRutas
            // 
            this.lblRutas.AutoSize = true;
            this.lblRutas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRutas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblRutas.Location = new System.Drawing.Point(650, 78);
            this.lblRutas.Name = "lblRutas";
            this.lblRutas.Size = new System.Drawing.Size(101, 19);
            this.lblRutas.TabIndex = 8;
            this.lblRutas.Text = "Rutas Activas:";
            // 
            // lstBuses
            // 
            this.lstBuses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstBuses.FormattingEnabled = true;
            this.lstBuses.ItemHeight = 17;
            this.lstBuses.Location = new System.Drawing.Point(650, 260);
            this.lstBuses.Name = "lstBuses";
            this.lstBuses.Size = new System.Drawing.Size(250, 191);
            this.lstBuses.TabIndex = 9;
            // 
            // lblBuses
            // 
            this.lblBuses.AutoSize = true;
            this.lblBuses.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBuses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblBuses.Location = new System.Drawing.Point(650, 238);
            this.lblBuses.Name = "lblBuses";
            this.lblBuses.Size = new System.Drawing.Size(115, 19);
            this.lblBuses.TabIndex = 10;
            this.lblBuses.Text = "Buses Cercanos:";
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(-1, -1);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(600, 400);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            // 
            // panelMapa
            // 
            this.panelMapa.BackColor = System.Drawing.Color.White;
            this.panelMapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMapa.Controls.Add(this.gMapControl1);
            this.panelMapa.Location = new System.Drawing.Point(24, 60);
            this.panelMapa.Name = "panelMapa";
            this.panelMapa.Size = new System.Drawing.Size(600, 400);
            this.panelMapa.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Gestión de Rutas de Buses - UNI";
            this.panelSidebar.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelMapa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnRegistrarRuta;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblBuscarRuta;
        private System.Windows.Forms.TextBox txtBuscarRuta;
        private System.Windows.Forms.Button btnBuscarRuta;
        private System.Windows.Forms.Label lblBuscarUbicacion;
        private System.Windows.Forms.TextBox txtBuscarUbicacion;
        private System.Windows.Forms.Button btnBuscarUbicacion;
        private System.Windows.Forms.ListBox lstRutas;
        private System.Windows.Forms.Label lblRutas;
        private System.Windows.Forms.ListBox lstBuses;
        private System.Windows.Forms.Label lblBuses;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Panel panelMapa;
    }
}