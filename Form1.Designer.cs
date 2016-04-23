namespace ApaganeiForm
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.rbApagar = new System.Windows.Forms.RadioButton();
            this.rbReiniciar = new System.Windows.Forms.RadioButton();
            this.rbCerrar = new System.Windows.Forms.RadioButton();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.labPulse = new System.Windows.Forms.Label();
            this.labConti = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serieCortaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serieMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serieLargaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliCortaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculaLargaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // rbApagar
            // 
            resources.ApplyResources(this.rbApagar, "rbApagar");
            this.rbApagar.Name = "rbApagar";
            this.rbApagar.TabStop = true;
            this.rbApagar.Tag = "a";
            this.rbApagar.UseVisualStyleBackColor = true;
            this.rbApagar.CheckedChanged += new System.EventHandler(this.rbApagar_CheckedChanged);
            // 
            // rbReiniciar
            // 
            resources.ApplyResources(this.rbReiniciar, "rbReiniciar");
            this.rbReiniciar.Name = "rbReiniciar";
            this.rbReiniciar.TabStop = true;
            this.rbReiniciar.Tag = "r";
            this.rbReiniciar.UseVisualStyleBackColor = true;
            this.rbReiniciar.CheckedChanged += new System.EventHandler(this.rbApagar_CheckedChanged);
            // 
            // rbCerrar
            // 
            resources.ApplyResources(this.rbCerrar, "rbCerrar");
            this.rbCerrar.Name = "rbCerrar";
            this.rbCerrar.TabStop = true;
            this.rbCerrar.Tag = "c";
            this.rbCerrar.UseVisualStyleBackColor = true;
            this.rbCerrar.CheckedChanged += new System.EventHandler(this.rbApagar_CheckedChanged);
            // 
            // btnContinuar
            // 
            resources.ApplyResources(this.btnContinuar, "btnContinuar");
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnSalir
            // 
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // labPulse
            // 
            resources.ApplyResources(this.labPulse, "labPulse");
            this.labPulse.Name = "labPulse";
            // 
            // labConti
            // 
            resources.ApplyResources(this.labConti, "labConti");
            this.labConti.Name = "labConti";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilesToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            resources.ApplyResources(this.archivoToolStripMenuItem, "archivoToolStripMenuItem");
            // 
            // perfilesToolStripMenuItem
            // 
            this.perfilesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.perfilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serieCortaToolStripMenuItem,
            this.serieMediaToolStripMenuItem,
            this.serieLargaToolStripMenuItem,
            this.peliCortaToolStripMenuItem,
            this.peliculaLargaToolStripMenuItem});
            this.perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            resources.ApplyResources(this.perfilesToolStripMenuItem, "perfilesToolStripMenuItem");
            // 
            // serieCortaToolStripMenuItem
            // 
            this.serieCortaToolStripMenuItem.Name = "serieCortaToolStripMenuItem";
            resources.ApplyResources(this.serieCortaToolStripMenuItem, "serieCortaToolStripMenuItem");
            this.serieCortaToolStripMenuItem.Click += new System.EventHandler(this.Perfil_Click);
            // 
            // serieMediaToolStripMenuItem
            // 
            this.serieMediaToolStripMenuItem.Name = "serieMediaToolStripMenuItem";
            resources.ApplyResources(this.serieMediaToolStripMenuItem, "serieMediaToolStripMenuItem");
            this.serieMediaToolStripMenuItem.Click += new System.EventHandler(this.Perfil_Click);
            // 
            // serieLargaToolStripMenuItem
            // 
            this.serieLargaToolStripMenuItem.Name = "serieLargaToolStripMenuItem";
            resources.ApplyResources(this.serieLargaToolStripMenuItem, "serieLargaToolStripMenuItem");
            this.serieLargaToolStripMenuItem.Click += new System.EventHandler(this.Perfil_Click);
            // 
            // peliCortaToolStripMenuItem
            // 
            this.peliCortaToolStripMenuItem.Name = "peliCortaToolStripMenuItem";
            resources.ApplyResources(this.peliCortaToolStripMenuItem, "peliCortaToolStripMenuItem");
            this.peliCortaToolStripMenuItem.Click += new System.EventHandler(this.Perfil_Click);
            // 
            // peliculaLargaToolStripMenuItem
            // 
            this.peliculaLargaToolStripMenuItem.Name = "peliculaLargaToolStripMenuItem";
            resources.ApplyResources(this.peliculaLargaToolStripMenuItem, "peliculaLargaToolStripMenuItem");
            this.peliculaLargaToolStripMenuItem.Click += new System.EventHandler(this.Perfil_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            resources.ApplyResources(this.ayudaToolStripMenuItem, "ayudaToolStripMenuItem");
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ApaganeiForm.Properties.Resources.cerrr;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ApaganeiForm.Properties.Resources.re;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApaganeiForm.Properties.Resources.apag;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ApaganeiForm.Properties.Resources.logotipo;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // FrmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labConti);
            this.Controls.Add(this.labPulse);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.rbCerrar);
            this.Controls.Add(this.rbReiniciar);
            this.Controls.Add(this.rbApagar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Load += new System.EventHandler(this.miFormulario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton rbApagar;
        private System.Windows.Forms.RadioButton rbReiniciar;
        private System.Windows.Forms.RadioButton rbCerrar;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label labPulse;
        private System.Windows.Forms.Label labConti;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serieMediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serieLargaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliCortaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculaLargaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serieCortaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}

