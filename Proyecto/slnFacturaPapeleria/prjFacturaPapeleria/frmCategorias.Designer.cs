namespace prjFacturaPapeleria
{
    partial class frmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.grbFormulario = new System.Windows.Forms.GroupBox();
            this.txtDescripCategoria = new System.Windows.Forms.TextBox();
            this.txtNomCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdCategoria = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnModificar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.grbFormulario.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            this.dgvTabla.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTabla.Location = new System.Drawing.Point(3, 16);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.Size = new System.Drawing.Size(478, 245);
            this.dgvTabla.TabIndex = 8;
            this.dgvTabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabla_CellClick);
            // 
            // grbFormulario
            // 
            this.grbFormulario.Controls.Add(this.txtDescripCategoria);
            this.grbFormulario.Controls.Add(this.txtNomCategoria);
            this.grbFormulario.Controls.Add(this.label2);
            this.grbFormulario.Controls.Add(this.label1);
            this.grbFormulario.Controls.Add(this.lblIdCategoria);
            this.grbFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbFormulario.Location = new System.Drawing.Point(0, 41);
            this.grbFormulario.Name = "grbFormulario";
            this.grbFormulario.Size = new System.Drawing.Size(484, 157);
            this.grbFormulario.TabIndex = 7;
            this.grbFormulario.TabStop = false;
            // 
            // txtDescripCategoria
            // 
            this.txtDescripCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripCategoria.Location = new System.Drawing.Point(16, 95);
            this.txtDescripCategoria.Multiline = true;
            this.txtDescripCategoria.Name = "txtDescripCategoria";
            this.txtDescripCategoria.Size = new System.Drawing.Size(410, 46);
            this.txtDescripCategoria.TabIndex = 2;
            this.txtDescripCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripCategoria_KeyPress);
            // 
            // txtNomCategoria
            // 
            this.txtNomCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomCategoria.Location = new System.Drawing.Point(16, 49);
            this.txtNomCategoria.Name = "txtNomCategoria";
            this.txtNomCategoria.Size = new System.Drawing.Size(410, 24);
            this.txtNomCategoria.TabIndex = 1;
            this.txtNomCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomCategoria_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblIdCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCategoria.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIdCategoria.Location = new System.Drawing.Point(441, 16);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(40, 24);
            this.lblIdCategoria.TabIndex = 0;
            this.lblIdCategoria.Text = "000";
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
            this.tsBtnAgregar.Click += new System.EventHandler(this.tsBtnAgregar_Click);
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
            this.tsBtnModificar.Click += new System.EventHandler(this.tsBtnModificar_Click);
            // 
            // tsBtnEliminar
            // 
            this.tsBtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEliminar.Image")));
            this.tsBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEliminar.Name = "tsBtnEliminar";
            this.tsBtnEliminar.Size = new System.Drawing.Size(38, 38);
            this.tsBtnEliminar.Text = "Eliminar";
            this.tsBtnEliminar.Click += new System.EventHandler(this.tsBtnEliminar_Click);
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
            this.tsBtnNuevo.Click += new System.EventHandler(this.tsBtnNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTabla);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 264);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 35);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "De click para editar o eliminar un registro  ";
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbFormulario);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCategorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.grbFormulario.ResumeLayout(false);
            this.grbFormulario.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.TextBox txtDescripCategoria;
        private System.Windows.Forms.TextBox txtNomCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
    }
}