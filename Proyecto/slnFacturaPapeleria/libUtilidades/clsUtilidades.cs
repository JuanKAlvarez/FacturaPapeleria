using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Web.Configuration;

namespace libUtilidades
{
    public class clsUtilidades
    {
        #region "Constructor"
        public clsUtilidades()
        { }
        #endregion

        #region "Atributos"

        #endregion

        #region "Métodos Privados"

        #endregion

        #region "Métodos Públicos"
        /*Llena un DataGridView a partir de una tabla que almacena el resultado de la consulta de la BD
         * PdgvGrid: DataGridView que se va a llenar
         * PdtTable: DataTable que tiene los datos
         */
        public void CargarGrid(DataGridView PdgvGrid, DataTable PdtTable)
        {
            try
            {
                PdgvGrid.DataSource = PdtTable;
                PdgvGrid.AutoSize = true;
                PdgvGrid.AllowUserToAddRows = false;
                PdgvGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                PdgvGrid.Visible = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*Llena un ComboBox a partir de una tabla que almacena el resultado de la consulta de la BD
         * PcmbCombo: Combo que se va a llenar
         * PdtTable: DataTable que tiene los datos
         * PstrValue: Nombre del Valumember
         * PstrDisplay: Nombre del DisplayMember
         */
        public void CargarCombo(ComboBox PcmbCombo, DataTable PdtTabla, string PstrValue, string PstrDisplay)
        {
            try
            {
                PcmbCombo.DataSource = PdtTabla;
                PcmbCombo.ValueMember = PstrValue;
                PcmbCombo.DisplayMember = PstrDisplay;
                PcmbCombo.DropDownWidth = 210;
                PcmbCombo.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*
         * Método que extrae una sección del archivo de configuración del proyecto. Esta sobrecarga retorna la sección como String
         * PstrProyecto: Nombre del proyecto donde está el archivo de configuración
         * PstrSeccion: Nombre de la sección a extraer      
         * PstrTipoProyecto: Parámetro que permite determinar si el archivo de configuración es de un proyecto web o de un proyecto WinForm
         */
        public string ObtenerParamConfig(string PstrProyecto, string PstrSeccion, string PstrTipoProyecto = "")
        {
            try
            {
                string _strRpta = string.Empty;
                if (PstrTipoProyecto == "Escritorio")
                {
                    //Configuration rootAppConfig = ConfigurationManager.OpenExeConfiguration(PstrProyecto);
                    _strRpta = ConfigurationManager.AppSettings[PstrSeccion];
                    return _strRpta;
                }

                Configuration rootWebConfig = WebConfigurationManager.OpenWebConfiguration(PstrProyecto);
                _strRpta = rootWebConfig.AppSettings.Settings[PstrSeccion].Value;

                return _strRpta;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion
    }
}
