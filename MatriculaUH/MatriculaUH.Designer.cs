namespace MatriculaUH
{
    partial class MatriculaUH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatriculaUH));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaMatrículaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.listaCarrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCarrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCarrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(900, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaMatrículaToolStripMenuItem,
            this.consultaMatriculaToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(69, 20);
            this.fileMenu.Text = "&Matricula";
            // 
            // nuevaMatrículaToolStripMenuItem
            // 
            this.nuevaMatrículaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevaMatrículaToolStripMenuItem.Image")));
            this.nuevaMatrículaToolStripMenuItem.Name = "nuevaMatrículaToolStripMenuItem";
            this.nuevaMatrículaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevaMatrículaToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.nuevaMatrículaToolStripMenuItem.Text = "&Nueva Matricula";
            this.nuevaMatrículaToolStripMenuItem.Click += new System.EventHandler(this.nuevaMatrículaToolStripMenuItem_Click);
            // 
            // consultaMatriculaToolStripMenuItem
            // 
            this.consultaMatriculaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaMatriculaToolStripMenuItem.Image")));
            this.consultaMatriculaToolStripMenuItem.Name = "consultaMatriculaToolStripMenuItem";
            this.consultaMatriculaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.consultaMatriculaToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.consultaMatriculaToolStripMenuItem.Text = "&Consulta Matricula";
            this.consultaMatriculaToolStripMenuItem.Click += new System.EventHandler(this.consultaMatriculaToolStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaCarrerasToolStripMenuItem,
            this.agregarCarrerasToolStripMenuItem,
            this.eliminarCarrerasToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(57, 20);
            this.editMenu.Text = "&Carrera";
            // 
            // listaCarrerasToolStripMenuItem
            // 
            this.listaCarrerasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listaCarrerasToolStripMenuItem.Image")));
            this.listaCarrerasToolStripMenuItem.Name = "listaCarrerasToolStripMenuItem";
            this.listaCarrerasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.listaCarrerasToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.listaCarrerasToolStripMenuItem.Text = "&Lista Carreras";
            this.listaCarrerasToolStripMenuItem.Click += new System.EventHandler(this.listaCarrerasToolStripMenuItem_Click);
            // 
            // agregarCarrerasToolStripMenuItem
            // 
            this.agregarCarrerasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarCarrerasToolStripMenuItem.Image")));
            this.agregarCarrerasToolStripMenuItem.Name = "agregarCarrerasToolStripMenuItem";
            this.agregarCarrerasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.agregarCarrerasToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.agregarCarrerasToolStripMenuItem.Text = "&Agregar Carreras";
            this.agregarCarrerasToolStripMenuItem.Click += new System.EventHandler(this.agregarCarrerasToolStripMenuItem_Click);
            // 
            // eliminarCarrerasToolStripMenuItem
            // 
            this.eliminarCarrerasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarCarrerasToolStripMenuItem.Image")));
            this.eliminarCarrerasToolStripMenuItem.Name = "eliminarCarrerasToolStripMenuItem";
            this.eliminarCarrerasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.eliminarCarrerasToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.eliminarCarrerasToolStripMenuItem.Text = "&Eliminar Carreras";
            this.eliminarCarrerasToolStripMenuItem.Click += new System.EventHandler(this.eliminarCarrerasToolStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(62, 20);
            this.viewMenu.Text = "&Alumno";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actualizarToolStripMenuItem.Image")));
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.actualizarToolStripMenuItem.Text = "&Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // MatriculaUH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MatriculaUH";
            this.Text = "MatriculaUH";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem nuevaMatrículaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaMatriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaCarrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCarrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCarrerasToolStripMenuItem;
    }
}



