namespace MatriculaUH
{
    partial class EliminarCarrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarCarrera));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tx_escribir_carrera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bn_eliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(64, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(320, 150);
            this.dataGridView1.TabIndex = 36;
            // 
            // tx_escribir_carrera
            // 
            this.tx_escribir_carrera.Location = new System.Drawing.Point(167, 131);
            this.tx_escribir_carrera.Name = "tx_escribir_carrera";
            this.tx_escribir_carrera.Size = new System.Drawing.Size(169, 20);
            this.tx_escribir_carrera.TabIndex = 35;
            this.tx_escribir_carrera.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tx_escribir_carrera_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Escriba la carrera a buscar:";
            // 
            // bn_eliminar
            // 
            this.bn_eliminar.BackColor = System.Drawing.Color.CadetBlue;
            this.bn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("bn_eliminar.Image")));
            this.bn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bn_eliminar.Location = new System.Drawing.Point(342, 119);
            this.bn_eliminar.Name = "bn_eliminar";
            this.bn_eliminar.Size = new System.Drawing.Size(87, 43);
            this.bn_eliminar.TabIndex = 46;
            this.bn_eliminar.Text = "Eliminar";
            this.bn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bn_eliminar.UseVisualStyleBackColor = false;
            this.bn_eliminar.Click += new System.EventHandler(this.bn_eliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // EliminarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(435, 335);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bn_eliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tx_escribir_carrera);
            this.Controls.Add(this.label1);
            this.Name = "EliminarCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarCarrera";
            this.Load += new System.EventHandler(this.EliminarCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tx_escribir_carrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bn_eliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}