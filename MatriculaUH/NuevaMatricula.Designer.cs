namespace MatriculaUH
{
    partial class NuevaMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaMatricula));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_idalumno = new System.Windows.Forms.TextBox();
            this.tx_idcarrera = new System.Windows.Forms.TextBox();
            this.tx_idmateria = new System.Windows.Forms.TextBox();
            this.tx_idmatricula = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bn_salir = new System.Windows.Forms.Button();
            this.bn_guardar = new System.Windows.Forms.Button();
            this.bn_eliminar = new System.Windows.Forms.Button();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Carrera:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Materia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID Matrícula:";
            // 
            // tx_idalumno
            // 
            this.tx_idalumno.Location = new System.Drawing.Point(115, 147);
            this.tx_idalumno.Name = "tx_idalumno";
            this.tx_idalumno.Size = new System.Drawing.Size(273, 20);
            this.tx_idalumno.TabIndex = 4;
            // 
            // tx_idcarrera
            // 
            this.tx_idcarrera.Location = new System.Drawing.Point(115, 188);
            this.tx_idcarrera.Name = "tx_idcarrera";
            this.tx_idcarrera.Size = new System.Drawing.Size(273, 20);
            this.tx_idcarrera.TabIndex = 5;
            // 
            // tx_idmateria
            // 
            this.tx_idmateria.Location = new System.Drawing.Point(115, 230);
            this.tx_idmateria.Name = "tx_idmateria";
            this.tx_idmateria.Size = new System.Drawing.Size(273, 20);
            this.tx_idmateria.TabIndex = 6;
            this.tx_idmateria.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tx_idmatricula
            // 
            this.tx_idmatricula.Location = new System.Drawing.Point(115, 280);
            this.tx_idmatricula.Name = "tx_idmatricula";
            this.tx_idmatricula.Size = new System.Drawing.Size(273, 20);
            this.tx_idmatricula.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 367);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(539, 215);
            this.dataGridView1.TabIndex = 8;
            // 
            // bn_salir
            // 
            this.bn_salir.BackColor = System.Drawing.Color.CadetBlue;
            this.bn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bn_salir.Image = ((System.Drawing.Image)(resources.GetObject("bn_salir.Image")));
            this.bn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bn_salir.Location = new System.Drawing.Point(469, 147);
            this.bn_salir.Name = "bn_salir";
            this.bn_salir.Size = new System.Drawing.Size(88, 33);
            this.bn_salir.TabIndex = 26;
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
            this.bn_guardar.Location = new System.Drawing.Point(469, 191);
            this.bn_guardar.Name = "bn_guardar";
            this.bn_guardar.Size = new System.Drawing.Size(88, 37);
            this.bn_guardar.TabIndex = 25;
            this.bn_guardar.Text = "Guardar";
            this.bn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bn_guardar.UseVisualStyleBackColor = false;
            this.bn_guardar.Click += new System.EventHandler(this.bn_guardar_Click);
            // 
            // bn_eliminar
            // 
            this.bn_eliminar.BackColor = System.Drawing.Color.CadetBlue;
            this.bn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("bn_eliminar.Image")));
            this.bn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bn_eliminar.Location = new System.Drawing.Point(469, 247);
            this.bn_eliminar.Name = "bn_eliminar";
            this.bn_eliminar.Size = new System.Drawing.Size(88, 35);
            this.bn_eliminar.TabIndex = 27;
            this.bn_eliminar.Text = "Eliminar";
            this.bn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bn_eliminar.UseVisualStyleBackColor = false;
            this.bn_eliminar.Click += new System.EventHandler(this.bn_eliminar_Click);
            // 
            // dt_fecha
            // 
            this.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha.Location = new System.Drawing.Point(115, 319);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(273, 20);
            this.dt_fecha.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fecha:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // NuevaMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(597, 606);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt_fecha);
            this.Controls.Add(this.bn_eliminar);
            this.Controls.Add(this.bn_salir);
            this.Controls.Add(this.bn_guardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tx_idmatricula);
            this.Controls.Add(this.tx_idmateria);
            this.Controls.Add(this.tx_idcarrera);
            this.Controls.Add(this.tx_idalumno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevaMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatriculaUH";
            this.Load += new System.EventHandler(this.NuevaMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_idalumno;
        private System.Windows.Forms.TextBox tx_idcarrera;
        private System.Windows.Forms.TextBox tx_idmateria;
        private System.Windows.Forms.TextBox tx_idmatricula;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bn_salir;
        private System.Windows.Forms.Button bn_guardar;
        private System.Windows.Forms.Button bn_eliminar;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}