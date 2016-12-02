namespace MatriculaUH
{
    partial class AgregarCarrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCarrera));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bn_salir = new System.Windows.Forms.Button();
            this.bn_guardar = new System.Windows.Forms.Button();
            this.bn_actualizar = new System.Windows.Forms.Button();
            this.tx_escribir_carrera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tx_carrera = new System.Windows.Forms.TextBox();
            this.tx_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(142, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(287, 150);
            this.dataGridView1.TabIndex = 33;
            // 
            // bn_salir
            // 
            this.bn_salir.BackColor = System.Drawing.Color.CadetBlue;
            this.bn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bn_salir.Image = ((System.Drawing.Image)(resources.GetObject("bn_salir.Image")));
            this.bn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bn_salir.Location = new System.Drawing.Point(455, 125);
            this.bn_salir.Name = "bn_salir";
            this.bn_salir.Size = new System.Drawing.Size(97, 34);
            this.bn_salir.TabIndex = 32;
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
            this.bn_guardar.Location = new System.Drawing.Point(455, 168);
            this.bn_guardar.Name = "bn_guardar";
            this.bn_guardar.Size = new System.Drawing.Size(97, 39);
            this.bn_guardar.TabIndex = 31;
            this.bn_guardar.Text = "Guardar";
            this.bn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bn_guardar.UseVisualStyleBackColor = false;
            this.bn_guardar.Click += new System.EventHandler(this.bn_guardar_Click);
            // 
            // bn_actualizar
            // 
            this.bn_actualizar.BackColor = System.Drawing.Color.CadetBlue;
            this.bn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("bn_actualizar.Image")));
            this.bn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bn_actualizar.Location = new System.Drawing.Point(356, 267);
            this.bn_actualizar.Name = "bn_actualizar";
            this.bn_actualizar.Size = new System.Drawing.Size(105, 23);
            this.bn_actualizar.TabIndex = 30;
            this.bn_actualizar.Text = "Actualizar";
            this.bn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bn_actualizar.UseVisualStyleBackColor = false;
            this.bn_actualizar.Click += new System.EventHandler(this.bn_actualizar_Click);
            // 
            // tx_escribir_carrera
            // 
            this.tx_escribir_carrera.Location = new System.Drawing.Point(184, 267);
            this.tx_escribir_carrera.Name = "tx_escribir_carrera";
            this.tx_escribir_carrera.Size = new System.Drawing.Size(166, 20);
            this.tx_escribir_carrera.TabIndex = 27;
            this.tx_escribir_carrera.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tx_escribir_carrera_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Escriba la carrera a buscar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tx_carrera);
            this.groupBox1.Controls.Add(this.tx_id);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 101);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carreras";
            // 
            // tx_carrera
            // 
            this.tx_carrera.Location = new System.Drawing.Point(86, 60);
            this.tx_carrera.Name = "tx_carrera";
            this.tx_carrera.Size = new System.Drawing.Size(300, 25);
            this.tx_carrera.TabIndex = 1;
            // 
            // tx_id
            // 
            this.tx_id.Location = new System.Drawing.Point(86, 26);
            this.tx_id.Name = "tx_id";
            this.tx_id.Size = new System.Drawing.Size(300, 25);
            this.tx_id.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "ID Carrera:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(457, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 45);
            this.button1.TabIndex = 40;
            this.button1.Text = "Agregar Materias";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // AgregarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(564, 457);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bn_salir);
            this.Controls.Add(this.bn_guardar);
            this.Controls.Add(this.bn_actualizar);
            this.Controls.Add(this.tx_escribir_carrera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgregarCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Carrera";
            this.Load += new System.EventHandler(this.AgregarCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bn_salir;
        private System.Windows.Forms.Button bn_guardar;
        private System.Windows.Forms.Button bn_actualizar;
        private System.Windows.Forms.TextBox tx_escribir_carrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tx_carrera;
        private System.Windows.Forms.TextBox tx_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}