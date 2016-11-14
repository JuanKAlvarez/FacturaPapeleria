using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using libUtilidades;

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
        clsUtilidades objUtilidades = new clsUtilidades();
        frmFactura    objFactura    = new frmFactura();
        frmProductos  objProducto   = new frmProductos();
        frmCategorias objCategoria  = new frmCategorias();
        frmUsuarios   objUsuario    = new frmUsuarios();
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
        private void tsBtnFactura_Click(object sender, EventArgs e)
        {
            objFactura.ShowDialog();
        }

        private void tsBtnProductos_Click(object sender, EventArgs e)
        {
            objProducto.ShowDialog();
        }

        private void tsBtnCategoria_Click(object sender, EventArgs e)
        {
            objCategoria.ShowDialog();
        }

        private void tsBtnUsuarios_Click(object sender, EventArgs e)
        {
            objUsuario.ShowDialog();
        }
        #endregion

        #region "Load"
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            // Carga de Iconos en el Menu Principal.
            string _strIconoFacturas  = objUtilidades.ObtenerParamConfig("prjFacturaPapeleria", "IconoFactura"   , "Escritorio");
            string _strIconoProductos = objUtilidades.ObtenerParamConfig("prjFacturaPapeleria", "IconoProductos" , "Escritorio");
            string _strIconoCategoria = objUtilidades.ObtenerParamConfig("prjFacturaPapeleria", "IconoCategoria" , "Escritorio");
            string _strIconoUsuarios  = objUtilidades.ObtenerParamConfig("prjFacturaPapeleria", "IconoUsuarios"  , "Escritorio");
           
            CargarImagen(tsBtnFactura,   _strIconoFacturas );
            CargarImagen(tsBtnProductos, _strIconoProductos);
            CargarImagen(tsBtnCategoria, _strIconoCategoria);
            CargarImagen(tsBtnUsuarios,  _strIconoUsuarios );



        }
        #endregion

    }
}
