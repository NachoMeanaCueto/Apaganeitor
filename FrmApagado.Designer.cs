namespace ApaganeiForm
{
    partial class FrmApagado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApagado));
            this.labTexto = new System.Windows.Forms.Label();
            this.labTiempo = new System.Windows.Forms.Label();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PcbLogo = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.NtiIcono = new System.Windows.Forms.NotifyIcon(this.components);
            this.CmsIcono = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmTitulo = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmTiempo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsmParar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmMaximizar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnParar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).BeginInit();
            this.CmsIcono.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTexto
            // 
            this.labTexto.AutoSize = true;
            this.labTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTexto.Location = new System.Drawing.Point(43, 151);
            this.labTexto.Name = "labTexto";
            this.labTexto.Size = new System.Drawing.Size(216, 20);
            this.labTexto.TabIndex = 0;
            this.labTexto.Text = "Su ordenador se apagará en:";
            // 
            // labTiempo
            // 
            this.labTiempo.AutoSize = true;
            this.labTiempo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labTiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTiempo.ForeColor = System.Drawing.Color.Black;
            this.labTiempo.Location = new System.Drawing.Point(94, 185);
            this.labTiempo.Name = "labTiempo";
            this.labTiempo.Size = new System.Drawing.Size(122, 33);
            this.labTiempo.TabIndex = 1;
            this.labTiempo.Text = "00:00:00";
            // 
            // BtnAtras
            // 
            this.BtnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(17, 282);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(125, 38);
            this.BtnAtras.TabIndex = 3;
            this.BtnAtras.Text = "&Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(169, 282);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(125, 38);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_click);
            // 
            // PcbLogo
            // 
            this.PcbLogo.Image = global::ApaganeiForm.Properties.Resources.logotipo;
            this.PcbLogo.Location = new System.Drawing.Point(11, 11);
            this.PcbLogo.Name = "PcbLogo";
            this.PcbLogo.Size = new System.Drawing.Size(299, 120);
            this.PcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogo.TabIndex = 3;
            this.PcbLogo.TabStop = false;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimizar.Location = new System.Drawing.Point(169, 238);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(125, 38);
            this.BtnMinimizar.TabIndex = 2;
            this.BtnMinimizar.Text = "&Minimizar";
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // NtiIcono
            // 
            this.NtiIcono.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NtiIcono.BalloonTipText = "Pulse con el boton derecho sobre el icono \r\npara cambiar la configuración";
            this.NtiIcono.ContextMenuStrip = this.CmsIcono;
            this.NtiIcono.Icon = ((System.Drawing.Icon)(resources.GetObject("NtiIcono.Icon")));
            this.NtiIcono.Text = "Apaganeitor 200";
            this.NtiIcono.DoubleClick += new System.EventHandler(this.NtiIcono_DoubleClick);
            // 
            // CmsIcono
            // 
            this.CmsIcono.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmTitulo,
            this.TsmTiempo,
            this.toolStripSeparator1,
            this.TsmParar,
            this.TsmMaximizar,
            this.TsmSalir});
            this.CmsIcono.Name = "CmsIcono";
            this.CmsIcono.Size = new System.Drawing.Size(139, 120);
            // 
            // TsmTitulo
            // 
            this.TsmTitulo.Enabled = false;
            this.TsmTitulo.Name = "TsmTitulo";
            this.TsmTitulo.Size = new System.Drawing.Size(138, 22);
            this.TsmTitulo.Text = "TsmTitulo";
            // 
            // TsmTiempo
            // 
            this.TsmTiempo.Enabled = false;
            this.TsmTiempo.Name = "TsmTiempo";
            this.TsmTiempo.Size = new System.Drawing.Size(138, 22);
            this.TsmTiempo.Text = "TsmTiempo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // TsmParar
            // 
            this.TsmParar.Name = "TsmParar";
            this.TsmParar.Size = new System.Drawing.Size(138, 22);
            this.TsmParar.Text = "&Pausar";
            this.TsmParar.Click += new System.EventHandler(this.TsmParar_Click);
            this.TsmParar.Paint += new System.Windows.Forms.PaintEventHandler(this.TsmParar_Paint);
            // 
            // TsmMaximizar
            // 
            this.TsmMaximizar.Name = "TsmMaximizar";
            this.TsmMaximizar.Size = new System.Drawing.Size(138, 22);
            this.TsmMaximizar.Text = "&Maximizar";
            this.TsmMaximizar.Click += new System.EventHandler(this.TsmMaximizar_Click);
            // 
            // TsmSalir
            // 
            this.TsmSalir.Name = "TsmSalir";
            this.TsmSalir.Size = new System.Drawing.Size(138, 22);
            this.TsmSalir.Text = "&Salir";
            this.TsmSalir.Click += new System.EventHandler(this.TsmSalir_Click);
            // 
            // BtnParar
            // 
            this.BtnParar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnParar.Location = new System.Drawing.Point(17, 238);
            this.BtnParar.Name = "BtnParar";
            this.BtnParar.Size = new System.Drawing.Size(125, 38);
            this.BtnParar.TabIndex = 1;
            this.BtnParar.Text = "&Pausar";
            this.BtnParar.UseVisualStyleBackColor = true;
            this.BtnParar.Click += new System.EventHandler(this.BtnParar_Click);
            this.BtnParar.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnParar_Paint);
            // 
            // FrmApagado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 332);
            this.ControlBox = false;
            this.Controls.Add(this.BtnParar);
            this.Controls.Add(this.BtnMinimizar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.PcbLogo);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.labTiempo);
            this.Controls.Add(this.labTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmApagado";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apaganeitor 2000 (versión Beta 2.1)";
            this.Load += new System.EventHandler(this.FrmApagado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).EndInit();
            this.CmsIcono.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTexto;
        private System.Windows.Forms.Label labTiempo;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.PictureBox PcbLogo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.NotifyIcon NtiIcono;
        private System.Windows.Forms.ContextMenuStrip CmsIcono;
        private System.Windows.Forms.ToolStripMenuItem TsmMaximizar;
        private System.Windows.Forms.ToolStripMenuItem TsmSalir;
        private System.Windows.Forms.ToolStripMenuItem TsmTiempo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button BtnParar;
        private System.Windows.Forms.ToolStripMenuItem TsmParar;
        private System.Windows.Forms.ToolStripMenuItem TsmTitulo;

    }
}