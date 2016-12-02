namespace MatriculaUH
{
    partial class Materias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materias));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tx_cupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_materia = new System.Windows.Forms.TextBox();
            this.tx_codigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tx_escribir_materia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bn_salir = new System.Windows.Forms.Button();
            this.bn_guardar = new System.Windows.Forms.Button();
            this.bn_eliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tx_cupo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tx_materia);
            this.groupBox1.Controls.Add(this.tx_codigo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 130);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materias";
            // 
            // tx_cupo
            // 
            this.tx_cupo.Location = new System.Drawing.Point(86, 96);
            this.tx_cupo.Name = "tx_cupo";
            this.tx_cupo.Size = new System.Drawing.Size(300, 21);
            this.tx_cupo.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cupo:";
            // 
            // tx_materia
            // 
            this.tx_materia.Location = new System.Drawing.Point(86, 60);
            this.tx_materia.Name = "tx_materia";
            this.tx_materia.Size = new System.Drawing.Size(300, 21);
            this.tx_materia.TabIndex = 1;
            // 
            // tx_codigo
            // 
            this.tx_codigo.Location = new System.Drawing.Point(86, 26);
            this.tx_codigo.Name = "tx_codigo";
            this.tx_codigo.Size = new System.Drawing.Size(300, 21);
            this.tx_codigo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cod Materia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Materia:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(89, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(410, 177);
            this.dataGridView1.TabIndex = 30;
            // 
            // tx_escribir_materia
            // 
            this.tx_escribir_materia.Location = new System.Drawing.Point(211, 263);
            this.tx_escribir_materia.Name = "tx_escribir_materia";
            this.tx_escribir_materia.Size = new System.Drawing.Size(181, 20);
            this.tx_escribir_materia.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Escriba la carrera a buscar:";
            // 
            // bn_salir
            // 
            this.bn_salir.BackColor = System.Drawing.Color.CadetBlue;
            this.bn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bn_salir.Image = ((System.Drawing.Image)(resources.GetObject("bn_salir.Image")));
            this.bn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bn_salir.Location = new System.Drawing.Point(463, 124);
            this.bn_salir.Name = "bn_salir";
            this.bn_salir.Size = new System.Drawing.Size(92, 37);
            this.bn_salir.TabIndex = 34;
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
            this.bn_guardar.Location = new System.Drawing.Point(463, 167);
            this.bn_guardar.Name = "bn_guardar";
            this.bn_guardar.Size = new System.Drawing.Size(92, 39);
            this.bn_guardar.TabIndex = 33;
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
            this.bn_eliminar.Location = new System.Drawing.Point(407, 241);
            this.bn_eliminar.Name = "bn_eliminar";
            this.bn_eliminar.Size = new System.Drawing.Size(92, 48);
            this.bn_eliminar.TabIndex = 47;
            this.bn_eliminar.Text = "Eliminar";
            this.bn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bn_eliminar.UseVisualStyleBackColor = false;
            this.bn_eliminar.Click += new System.EventHandler(this.bn_eliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(569, 485);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bn_eliminar);
            this.Controls.Add(this.bn_salir);
            this.Controls.Add(this.bn_guardar);
            this.Controls.Add(this.tx_escribir_materia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Materias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.Materias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tx_cupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_materia;
        private System.Windows.Forms.TextBox tx_codigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tx_escribir_materia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bn_salir;
        private System.Windows.Forms.Button bn_guardar;
        private System.Windows.Forms.Button bn_eliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}