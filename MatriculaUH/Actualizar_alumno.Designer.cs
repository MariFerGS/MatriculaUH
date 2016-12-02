namespace MatriculaUH
{
    partial class Actualizar_alumno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar_alumno));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tx_escribir_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bn_salir = new System.Windows.Forms.Button();
            this.bn_guardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tx_apellido = new System.Windows.Forms.TextBox();
            this.tx_cedula = new System.Windows.Forms.TextBox();
            this.tx_nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bn_actualizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView.Location = new System.Drawing.Point(117, 309);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(361, 160);
            this.dataGridView.TabIndex = 37;
            // 
            // tx_escribir_nombre
            // 
            this.tx_escribir_nombre.Location = new System.Drawing.Point(218, 270);
            this.tx_escribir_nombre.Name = "tx_escribir_nombre";
            this.tx_escribir_nombre.Size = new System.Drawing.Size(232, 20);
            this.tx_escribir_nombre.TabIndex = 36;
            this.tx_escribir_nombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tx_escribir_nombre_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Escriba el Nombre del Alumno:";
            // 
            // bn_salir
            // 
            this.bn_salir.BackColor = System.Drawing.Color.CadetBlue;
            this.bn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bn_salir.Image = ((System.Drawing.Image)(resources.GetObject("bn_salir.Image")));
            this.bn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bn_salir.Location = new System.Drawing.Point(495, 129);
            this.bn_salir.Name = "bn_salir";
            this.bn_salir.Size = new System.Drawing.Size(97, 46);
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
            this.bn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bn_guardar.Location = new System.Drawing.Point(495, 181);
            this.bn_guardar.Name = "bn_guardar";
            this.bn_guardar.Size = new System.Drawing.Size(97, 50);
            this.bn_guardar.TabIndex = 33;
            this.bn_guardar.Text = "Guardar";
            this.bn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bn_guardar.UseVisualStyleBackColor = false;
            this.bn_guardar.Click += new System.EventHandler(this.bn_guardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tx_apellido);
            this.groupBox1.Controls.Add(this.tx_cedula);
            this.groupBox1.Controls.Add(this.tx_nombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 121);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Alumno";
            // 
            // tx_apellido
            // 
            this.tx_apellido.Location = new System.Drawing.Point(97, 56);
            this.tx_apellido.Name = "tx_apellido";
            this.tx_apellido.Size = new System.Drawing.Size(300, 25);
            this.tx_apellido.TabIndex = 20;
            // 
            // tx_cedula
            // 
            this.tx_cedula.Location = new System.Drawing.Point(97, 83);
            this.tx_cedula.Name = "tx_cedula";
            this.tx_cedula.Size = new System.Drawing.Size(300, 25);
            this.tx_cedula.TabIndex = 22;
            // 
            // tx_nombre
            // 
            this.tx_nombre.Location = new System.Drawing.Point(97, 26);
            this.tx_nombre.Name = "tx_nombre";
            this.tx_nombre.Size = new System.Drawing.Size(300, 25);
            this.tx_nombre.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cedula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Apellido:";
            // 
            // bn_actualizar
            // 
            this.bn_actualizar.BackColor = System.Drawing.Color.CadetBlue;
            this.bn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("bn_actualizar.Image")));
            this.bn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bn_actualizar.Location = new System.Drawing.Point(456, 261);
            this.bn_actualizar.Name = "bn_actualizar";
            this.bn_actualizar.Size = new System.Drawing.Size(101, 36);
            this.bn_actualizar.TabIndex = 38;
            this.bn_actualizar.Text = "Actualizar";
            this.bn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bn_actualizar.UseVisualStyleBackColor = false;
            this.bn_actualizar.Click += new System.EventHandler(this.bn_actualizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // Actualizar_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(606, 485);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bn_actualizar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.tx_escribir_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bn_salir);
            this.Controls.Add(this.bn_guardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Actualizar_alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatriculaUH";
            this.Load += new System.EventHandler(this.Actualizar_alumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox tx_escribir_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bn_salir;
        private System.Windows.Forms.Button bn_guardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tx_apellido;
        private System.Windows.Forms.TextBox tx_cedula;
        private System.Windows.Forms.TextBox tx_nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bn_actualizar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}