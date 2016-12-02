namespace MatriculaUH
{
    partial class NuevoAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoAlumno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tx_apellido = new System.Windows.Forms.TextBox();
            this.tx_cedula = new System.Windows.Forms.TextBox();
            this.tx_nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bn_salir = new System.Windows.Forms.Button();
            this.bn_guardar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tx_escribir_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tx_apellido);
            this.groupBox1.Controls.Add(this.tx_cedula);
            this.groupBox1.Controls.Add(this.tx_nombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Alumno";
            // 
            // tx_apellido
            // 
            this.tx_apellido.Location = new System.Drawing.Point(99, 49);
            this.tx_apellido.Name = "tx_apellido";
            this.tx_apellido.Size = new System.Drawing.Size(300, 22);
            this.tx_apellido.TabIndex = 20;
            // 
            // tx_cedula
            // 
            this.tx_cedula.Location = new System.Drawing.Point(99, 76);
            this.tx_cedula.Name = "tx_cedula";
            this.tx_cedula.Size = new System.Drawing.Size(300, 22);
            this.tx_cedula.TabIndex = 22;
            // 
            // tx_nombre
            // 
            this.tx_nombre.Location = new System.Drawing.Point(99, 19);
            this.tx_nombre.Name = "tx_nombre";
            this.tx_nombre.Size = new System.Drawing.Size(300, 22);
            this.tx_nombre.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cedula";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Apellido:";
            // 
            // bn_salir
            // 
            this.bn_salir.BackColor = System.Drawing.Color.CadetBlue;
            this.bn_salir.Cursor = System.Windows.Forms.Cursors.Default;
            this.bn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bn_salir.Image = ((System.Drawing.Image)(resources.GetObject("bn_salir.Image")));
            this.bn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bn_salir.Location = new System.Drawing.Point(476, 134);
            this.bn_salir.Name = "bn_salir";
            this.bn_salir.Size = new System.Drawing.Size(96, 33);
            this.bn_salir.TabIndex = 28;
            this.bn_salir.Text = "Salir";
            this.bn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bn_salir.UseVisualStyleBackColor = false;
            this.bn_salir.Click += new System.EventHandler(this.bn_salir_Click);
            // 
            // bn_guardar
            // 
            this.bn_guardar.BackColor = System.Drawing.Color.CadetBlue;
            this.bn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("bn_guardar.Image")));
            this.bn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bn_guardar.Location = new System.Drawing.Point(476, 191);
            this.bn_guardar.Name = "bn_guardar";
            this.bn_guardar.Size = new System.Drawing.Size(96, 35);
            this.bn_guardar.TabIndex = 27;
            this.bn_guardar.Text = "Guardar";
            this.bn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bn_guardar.UseVisualStyleBackColor = false;
            this.bn_guardar.Click += new System.EventHandler(this.bn_guardar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(109, 296);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(351, 160);
            this.dataGridView.TabIndex = 31;
            // 
            // tx_escribir_nombre
            // 
            this.tx_escribir_nombre.Location = new System.Drawing.Point(210, 254);
            this.tx_escribir_nombre.Name = "tx_escribir_nombre";
            this.tx_escribir_nombre.Size = new System.Drawing.Size(298, 20);
            this.tx_escribir_nombre.TabIndex = 30;
            this.tx_escribir_nombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tx_escribir_nombre_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Escriba el Nombre del Alumno:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // NuevoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(575, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.tx_escribir_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bn_salir);
            this.Controls.Add(this.bn_guardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "NuevoAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatriculaUH";
            this.Load += new System.EventHandler(this.NuevoAlumno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tx_cedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_apellido;
        private System.Windows.Forms.TextBox tx_nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bn_salir;
        private System.Windows.Forms.Button bn_guardar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox tx_escribir_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}