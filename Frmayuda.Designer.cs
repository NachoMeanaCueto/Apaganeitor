namespace ApaganeiForm
{
    partial class Frmayuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmayuda));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labAyuda = new System.Windows.Forms.Label();
            this.btnAyudaAtras = new System.Windows.Forms.Button();
            this.labPregunta = new System.Windows.Forms.Label();
            this.labDesactivar = new System.Windows.Forms.Label();
            this.labBug = new System.Windows.Forms.Label();
            this.labCorreo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApaganeiForm.Properties.Resources.logotipo;
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labAyuda
            // 
            this.labAyuda.AutoSize = true;
            this.labAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAyuda.Location = new System.Drawing.Point(12, 156);
            this.labAyuda.Name = "labAyuda";
            this.labAyuda.Size = new System.Drawing.Size(353, 75);
            this.labAyuda.TabIndex = 1;
            this.labAyuda.Text = resources.GetString("labAyuda.Text");
            // 
            // btnAyudaAtras
            // 
            this.btnAyudaAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyudaAtras.Location = new System.Drawing.Point(111, 430);
            this.btnAyudaAtras.Name = "btnAyudaAtras";
            this.btnAyudaAtras.Size = new System.Drawing.Size(147, 49);
            this.btnAyudaAtras.TabIndex = 2;
            this.btnAyudaAtras.Text = "&Atras";
            this.btnAyudaAtras.UseVisualStyleBackColor = true;
            this.btnAyudaAtras.Click += new System.EventHandler(this.btnAyudaAtras_Click);
            // 
            // labPregunta
            // 
            this.labPregunta.AutoSize = true;
            this.labPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPregunta.Location = new System.Drawing.Point(42, 231);
            this.labPregunta.Name = "labPregunta";
            this.labPregunta.Size = new System.Drawing.Size(279, 16);
            this.labPregunta.TabIndex = 3;
            this.labPregunta.Text = "¿Como desactivo el modo suspensión?\r\n";
            // 
            // labDesactivar
            // 
            this.labDesactivar.AutoSize = true;
            this.labDesactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDesactivar.Location = new System.Drawing.Point(12, 260);
            this.labDesactivar.Name = "labDesactivar";
            this.labDesactivar.Size = new System.Drawing.Size(339, 75);
            this.labDesactivar.TabIndex = 4;
            this.labDesactivar.Text = resources.GetString("labDesactivar.Text");
            // 
            // labBug
            // 
            this.labBug.AutoSize = true;
            this.labBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBug.Location = new System.Drawing.Point(12, 351);
            this.labBug.Name = "labBug";
            this.labBug.Size = new System.Drawing.Size(327, 30);
            this.labBug.TabIndex = 5;
            this.labBug.Text = "Para cualquier problema que le surja póngase en contacto\r\ncon nosotros a través d" +
    "el correo electrónico:\r\n";
            // 
            // labCorreo
            // 
            this.labCorreo.AutoSize = true;
            this.labCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCorreo.Location = new System.Drawing.Point(92, 393);
            this.labCorreo.Name = "labCorreo";
            this.labCorreo.Size = new System.Drawing.Size(176, 15);
            this.labCorreo.TabIndex = 6;
            this.labCorreo.Text = "nachomeanacueto@gmail.con";
            // 
            // Frmayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 491);
            this.Controls.Add(this.labCorreo);
            this.Controls.Add(this.labBug);
            this.Controls.Add(this.labDesactivar);
            this.Controls.Add(this.labPregunta);
            this.Controls.Add(this.btnAyudaAtras);
            this.Controls.Add(this.labAyuda);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmayuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apaganeitor 2000 (versión Beta 2.0)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labAyuda;
        private System.Windows.Forms.Button btnAyudaAtras;
        private System.Windows.Forms.Label labPregunta;
        private System.Windows.Forms.Label labDesactivar;
        private System.Windows.Forms.Label labBug;
        private System.Windows.Forms.Label labCorreo;
    }
}