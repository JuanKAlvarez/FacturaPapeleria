namespace prjFacturaPapeleria
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.grbFormulario = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnModificar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNuevo = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            this.dgvTabla.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTabla.Location = new System.Drawing.Point(0, 188);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(484, 274);
            this.dgvTabla.TabIndex = 8;
            // 
            // grbFormulario
            // 
            this.grbFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbFormulario.Location = new System.Drawing.Point(0, 41);
            this.grbFormulario.Name = "grbFormulario";
            this.grbFormulario.Size = new System.Drawing.Size(484, 147);
            this.grbFormulario.TabIndex = 7;
            this.grbFormulario.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(34, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnAgregar,
            this.toolStripSeparator1,
            this.tsBtnModificar,
            this.tsBtnEliminar,
            this.tsBtnNuevo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(484, 41);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnAgregar
            // 
            this.tsBtnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAgregar.Image")));
            this.tsBtnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAgregar.Name = "tsBtnAgregar";
            this.tsBtnAgregar.Size = new System.Drawing.Size(38, 38);
            this.tsBtnAgregar.Text = "Agregar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // tsBtnModificar
            // 
            this.tsBtnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnModificar.Image")));
            this.tsBtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnModificar.Name = "tsBtnModificar";
            this.tsBtnModificar.Size = new System.Drawing.Size(38, 38);
            this.tsBtnModificar.Text = "Modificar";
            // 
            // tsBtnEliminar
            // 
            this.tsBtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEliminar.Image")));
            this.tsBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEliminar.Name = "tsBtnEliminar";
            this.tsBtnEliminar.Size = new System.Drawing.Size(38, 38);
            this.tsBtnEliminar.Text = "Eliminar";
            // 
            // tsBtnNuevo
            // 
            this.tsBtnNuevo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNuevo.Image")));
            this.tsBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNuevo.Name = "tsBtnNuevo";
            this.tsBtnNuevo.Size = new System.Drawing.Size(38, 38);
            this.tsBtnNuevo.Text = "Nuevo";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.grbFormulario);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.GroupBox grbFormulario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnModificar;
        private System.Windows.Forms.ToolStripButton tsBtnEliminar;
        private System.Windows.Forms.ToolStripButton tsBtnNuevo;
    }
}