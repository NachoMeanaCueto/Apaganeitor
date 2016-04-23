namespace ApaganeiForm
{
    partial class FrmTiempo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTiempo));
            this.labTitulo = new System.Windows.Forms.Label();
            this.labtext = new System.Windows.Forms.Label();
            this.labHoras = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NudHoras = new System.Windows.Forms.NumericUpDown();
            this.NudMin = new System.Windows.Forms.NumericUpDown();
            this.NudSeg = new System.Windows.Forms.NumericUpDown();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pcbIcono = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.Location = new System.Drawing.Point(82, 164);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(201, 25);
            this.labTitulo.TabIndex = 2;
            this.labTitulo.Text = "Menú de apagado";
            // 
            // labtext
            // 
            this.labtext.AutoSize = true;
            this.labtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtext.Location = new System.Drawing.Point(94, 202);
            this.labtext.Name = "labtext";
            this.labtext.Size = new System.Drawing.Size(267, 48);
            this.labtext.TabIndex = 3;
            this.labtext.Text = "Introduzca el tiempo que desea que pase\r\nhasta que se apague su ordenador y pulse" +
    " \r\ncontinuar.";
            // 
            // labHoras
            // 
            this.labHoras.AutoSize = true;
            this.labHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHoras.Location = new System.Drawing.Point(213, 278);
            this.labHoras.Name = "labHoras";
            this.labHoras.Size = new System.Drawing.Size(45, 16);
            this.labHoras.TabIndex = 8;
            this.labHoras.Text = "Horas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Minutos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Segundos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(25, 399);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 49);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "&Atras";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(198, 399);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(142, 49);
            this.btnContinuar.TabIndex = 5;
            this.btnContinuar.Text = "&Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ApaganeiForm.Properties.Resources.logotipo;
            this.pictureBox2.Location = new System.Drawing.Point(25, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(340, 149);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // NudHoras
            // 
            this.NudHoras.Location = new System.Drawing.Point(127, 278);
            this.NudHoras.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NudHoras.Name = "NudHoras";
            this.NudHoras.Size = new System.Drawing.Size(80, 20);
            this.NudHoras.TabIndex = 1;
            this.NudHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudHoras_KeyPress);
            // 
            // NudMin
            // 
            this.NudMin.Location = new System.Drawing.Point(127, 315);
            this.NudMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NudMin.Name = "NudMin";
            this.NudMin.Size = new System.Drawing.Size(80, 20);
            this.NudMin.TabIndex = 2;
            this.NudMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudHoras_KeyPress);
            // 
            // NudSeg
            // 
            this.NudSeg.Location = new System.Drawing.Point(127, 352);
            this.NudSeg.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NudSeg.Name = "NudSeg";
            this.NudSeg.Size = new System.Drawing.Size(80, 20);
            this.NudSeg.TabIndex = 3;
            this.NudSeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudSeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudHoras_KeyPress);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "apagar.png");
            this.imageList1.Images.SetKeyName(1, "reiniciar.png");
            this.imageList1.Images.SetKeyName(2, "cerrar.png");
            // 
            // pcbIcono
            // 
            this.pcbIcono.Location = new System.Drawing.Point(34, 202);
            this.pcbIcono.Name = "pcbIcono";
            this.pcbIcono.Size = new System.Drawing.Size(54, 58);
            this.pcbIcono.TabIndex = 11;
            this.pcbIcono.TabStop = false;
            // 
            // FrmTiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 459);
            this.ControlBox = false;
            this.Controls.Add(this.pcbIcono);
            this.Controls.Add(this.NudSeg);
            this.Controls.Add(this.NudMin);
            this.Controls.Add(this.NudHoras);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labHoras);
            this.Controls.Add(this.labtext);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTiempo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apaganeitor 2000 (versión Beta 2.1)";
            this.Load += new System.EventHandler(this.FrmTiempo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Label labtext;
        private System.Windows.Forms.Label labHoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.NumericUpDown NudHoras;
        private System.Windows.Forms.NumericUpDown NudMin;
        private System.Windows.Forms.NumericUpDown NudSeg;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pcbIcono;
    }
}