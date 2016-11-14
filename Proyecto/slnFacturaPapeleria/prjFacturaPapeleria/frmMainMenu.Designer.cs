namespace prjFacturaPapeleria
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.mnuPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsBtnFactura = new System.Windows.Forms.ToolStripButton();
            this.tsBtnProductos = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCategoria = new System.Windows.Forms.ToolStripButton();
            this.tsBtnUsuarios = new System.Windows.Forms.ToolStripButton();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.Color.Snow;
            this.mnuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mnuPrincipal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.mnuPrincipal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnFactura,
            this.tsBtnProductos,
            this.tsBtnCategoria,
            this.tsBtnUsuarios});
            this.mnuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Padding = new System.Windows.Forms.Padding(0);
            this.mnuPrincipal.Size = new System.Drawing.Size(400, 322);
            this.mnuPrincipal.TabIndex = 1;
            // 
            // tsBtnFactura
            // 
            this.tsBtnFactura.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFactura.Image")));
            this.tsBtnFactura.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsBtnFactura.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnFactura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFactura.Name = "tsBtnFactura";
            this.tsBtnFactura.Size = new System.Drawing.Size(399, 68);
            this.tsBtnFactura.Text = "Crear Factura";
            this.tsBtnFactura.Click += new System.EventHandler(this.tsBtnFactura_Click);
            // 
            // tsBtnProductos
            // 
            this.tsBtnProductos.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnProductos.Image")));
            this.tsBtnProductos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsBtnProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnProductos.Name = "tsBtnProductos";
            this.tsBtnProductos.Size = new System.Drawing.Size(399, 68);
            this.tsBtnProductos.Text = "Administrar Productos";
            this.tsBtnProductos.Click += new System.EventHandler(this.tsBtnProductos_Click);
            // 
            // tsBtnCategoria
            // 
            this.tsBtnCategoria.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCategoria.Image")));
            this.tsBtnCategoria.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsBtnCategoria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCategoria.Name = "tsBtnCategoria";
            this.tsBtnCategoria.Size = new System.Drawing.Size(399, 68);
            this.tsBtnCategoria.Text = "Administrar Categoría de Productos";
            this.tsBtnCategoria.Click += new System.EventHandler(this.tsBtnCategoria_Click);
            // 
            // tsBtnUsuarios
            // 
            this.tsBtnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnUsuarios.Image")));
            this.tsBtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsBtnUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnUsuarios.Name = "tsBtnUsuarios";
            this.tsBtnUsuarios.Size = new System.Drawing.Size(399, 68);
            this.tsBtnUsuarios.Text = "Administrar Usuarios";
            this.tsBtnUsuarios.Click += new System.EventHandler(this.tsBtnUsuarios_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(400, 322);
            this.Controls.Add(this.mnuPrincipal);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "frmMainMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripButton tsBtnFactura;
        private System.Windows.Forms.ToolStripButton tsBtnProductos;
        private System.Windows.Forms.ToolStripButton tsBtnCategoria;
        private System.Windows.Forms.ToolStripButton tsBtnUsuarios;
    }
}

