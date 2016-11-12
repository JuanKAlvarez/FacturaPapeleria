using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace prjFacturaPapeleria
{
    public partial class frmMainMenu : Form
    {
        

        
        #region "Constructor"
        public frmMainMenu()
        {
            InitializeComponent();
        }
        #endregion

        #region "Variables"

        #endregion

        #region "Metodos Privados"
        private void CargarImagen(ToolStripButton PtsImagen, string PstrRutaImagen)
        {
            try
            {
                PtsImagen.Image = Image.FromFile(Directory.GetCurrentDirectory() +
                                  "\\Imagenes\\" + PstrRutaImagen);   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Papeleria", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }              
        }
        #endregion

        #region "Metodos Publicos"

        #endregion

        #region "Botones"

        #endregion

        #region "Load"
        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
