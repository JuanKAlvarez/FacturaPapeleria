using System;
using System.Drawing;
using System.Windows.Forms;
using libUtilidades;
using System.IO;
using System.Data;
using libCategoriaRN;

namespace prjFacturaPapeleria
{
    public partial class frmCategorias : Form
    {

        #region "Constructor"
        public frmCategorias()
        {
            InitializeComponent();
        }
        #endregion

        #region "Variables"
        string strError;
        string strNombre;
        int    intPosicion;
        string strDescripcion;
        int intId;
        clsUtilidades objUtilidades;
        clsCategoriaRN objCategoriaRN;
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
                MessageBox.Show(ex.Message, "Papeleria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar(bool PboolDelete)
        {
            if (!PboolDelete)
            {
                if (txtNomCategoria.Text.Trim() == string.Empty)
                {
                    strError = "Ingrese el Nombre de la categoria";
                    return false;
                }
                if (txtDescripCategoria.Text.Trim() == string.Empty)
                {
                    strError = "Ingrese la decripcion de la categoria";
                    return false;
                }
            }
            else
            {
                if (Convert.ToInt32(lblIdCategoria.Text.ToString().Trim()) == 0)
                {
                    strError = "no Se ha Seleccionado ningun registro";
                    return false;
                }
            }
            
            return true;
            
            
        }

        private void CapturarDatos()
        {
            if (!Validar(false))
            {
                MessageBox.Show(strError,"PAPELERIA", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            strNombre = txtNomCategoria.Text.Trim();
            strDescripcion = txtDescripCategoria.Text.Trim();

            if (lblIdCategoria.Text.ToString().Trim() != "000")
            {
                intId = Convert.ToInt32(lblIdCategoria.Text.ToString().Trim());
            }



        }

        private void Limpiar()
        {
            txtDescripCategoria.Text = string.Empty;
            txtNomCategoria.Text = string.Empty;
            lblIdCategoria.Text = "000";

            tsBtnAgregar.Enabled = true;
            tsBtnEliminar.Enabled = false;
            tsBtnModificar.Enabled = false;

        }

        private void LlenarGid(DataTable PdtDatos, DataGridView PdgvTabla)
        {
            try
            {
                objUtilidades = new clsUtilidades();
                objUtilidades.CargarGrid(PdgvTabla, PdtDatos);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PAPELERIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private DataTable ConsultarCategoria()
        {
            DataTable _dtTbl;
            DataSet _dsTablas;

            objCategoriaRN = new clsCategoriaRN();
            _dsTablas = objCategoriaRN.ConsultarCategorias();
            _dtTbl = _dsTablas.Tables[0];

            return _dtTbl;
        }

        private void InsetCategoria()
        {
            try
            {
                if (!Validar(false))
                {
                    MessageBox.Show(strError, "PAPELERIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataSet _dsTablas;
                DataTable _dtTabla;
                DataTable _dtTbl;
                string _strMsg;

                CapturarDatos();

                objCategoriaRN = new clsCategoriaRN();
                _dsTablas = objCategoriaRN.InsertCategoria(strNombre , strDescripcion);
                _dtTabla = _dsTablas.Tables[0];
                _strMsg = _dtTabla.Rows[0]["Mensaje"].ToString();

                Limpiar();

                _dtTbl = ConsultarCategoria();
                LlenarGid(_dtTbl, dgvTabla);
                txtNomCategoria.Select();
                MessageBox.Show(_strMsg, "PAPELERIA", MessageBoxButtons.OK);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PAPELERIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateCategoria()
        {
            try
            {
                if (!Validar(false))
                {
                    MessageBox.Show(strError, "PAPELERIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataSet _dsTablas;
                DataTable _dtTabla;
                DataTable _dtTbl;
                string _strMsg;

                CapturarDatos();

                objCategoriaRN = new clsCategoriaRN();
                _dsTablas = objCategoriaRN.UpdateCategoria(intId, strNombre, strDescripcion);
                _dtTabla = _dsTablas.Tables[0];
                _strMsg = _dtTabla.Rows[0]["Mensaje"].ToString();

                Limpiar();

                _dtTbl = ConsultarCategoria();
                LlenarGid(_dtTbl, dgvTabla);
                txtNomCategoria.Select();
                MessageBox.Show(_strMsg, "PAPELERIA", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PAPELERIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteCategoria()
        {
            try
            {
                if (!Validar(true))
                {
                    MessageBox.Show(strError, "PAPELERIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if(MessageBox.Show("Seguro que dese Eliminar el Registro?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataSet _dsTablas;
                    DataTable _dtTabla;
                    DataTable _dtTbl;
                    string _strMsg;

                    CapturarDatos();

                    objCategoriaRN = new clsCategoriaRN();
                    _dsTablas = objCategoriaRN.DeleteCategoria(intId);
                    _dtTabla = _dsTablas.Tables[0];
                    _strMsg = _dtTabla.Rows[0]["Mensaje"].ToString();

                    Limpiar();

                    _dtTbl = ConsultarCategoria();
                    LlenarGid(_dtTbl, dgvTabla);
                    txtNomCategoria.Select();
                }

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PAPELERIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region "Metodos Publicos"

        #endregion

        #region "Botones"
        private void tsBtnAgregar_Click(object sender, EventArgs e)
        {
            InsetCategoria();
        }

        private void tsBtnModificar_Click(object sender, EventArgs e)
        {
            UpdateCategoria();
        }

        private void tsBtnEliminar_Click(object sender, EventArgs e)
        {
            DeleteCategoria();
        }

        private void tsBtnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        #endregion

        #region "Load"

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            objUtilidades = new clsUtilidades();
            string _strIconoAgregar   = objUtilidades.ObtenerParamConfig("prjFacturaPapeleria", "IconoAgregar", "Escritorio");
            string _strIconoModificar = objUtilidades.ObtenerParamConfig("prjFacturaPapeleria", "IconoModificar", "Escritorio");
            string _strIconoEliminar  = objUtilidades.ObtenerParamConfig("prjFacturaPapeleria", "IconoEliminar", "Escritorio");
            string _strIconoNuevo     = objUtilidades.ObtenerParamConfig("prjFacturaPapeleria", "IconoNuevo", "Escritorio");
            
DataTable _dtTbl;
            CargarImagen(tsBtnAgregar,   _strIconoAgregar);
            CargarImagen(tsBtnModificar, _strIconoModificar);
            CargarImagen(tsBtnEliminar,  _strIconoEliminar);
            CargarImagen(tsBtnNuevo,     _strIconoNuevo);

            tsBtnEliminar.Enabled = false;
            tsBtnModificar.Enabled = false;
            tsBtnNuevo.Text = "Limpiar";

            _dtTbl = ConsultarCategoria();
            LlenarGid(_dtTbl, dgvTabla);
        }


        #endregion

        #region "Eventos"
        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            intPosicion = dgvTabla.CurrentRow.Index;
            lblIdCategoria.Text = dgvTabla[0, intPosicion].Value.ToString().Trim();
            txtNomCategoria.Text = dgvTabla[1, intPosicion].Value.ToString().Trim();
            txtDescripCategoria.Text = dgvTabla[2, intPosicion].Value.ToString().Trim();

            tsBtnAgregar.Enabled = false;
            tsBtnEliminar.Enabled = true;
            tsBtnModificar.Enabled = true;

        }

        private void txtNomCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tsBtnAgregar.Enabled == true)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    InsetCategoria();
                }
            }
        }

        private void txtDescripCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tsBtnAgregar.Enabled == true)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    InsetCategoria();
                }
            }
        }
        #endregion


    }
}
