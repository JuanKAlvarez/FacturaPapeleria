using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libCategoriaRN;
using libConexionBD;
using System.Data.SqlClient;
using System.Data;

namespace libCategoriaRN
{
    public class clsCategoriaRN
    {
        #region "Constructor"
        public clsCategoriaRN()
        { }
        #endregion

        #region "Atributos"
        clsConexionDb objProcesarBD;
        SqlParameter[] objParametros;
        SqlConnection objSqlConexion;
        DataSet dsResultado;
        string strError;
        #endregion

        #region "Propiedades"
        public string Error
        {
            get { return strError; }
            set { strError = value; }
        }
        #endregion

        #region "Metodos Privados"
        private bool Validar(string PstrNombre, string PstrDescripcion)
        {
            try
            {
                if (PstrNombre == string.Empty)
                {
                    strError = "Ingrese el Nombre de la categoria";
                    return false;
                }
                if (PstrDescripcion == string.Empty)
                {
                    strError = "Ingrese la decripcion de la categoria";
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region "Metodos Publicos"
        public DataSet ConsultarCategorias()
        {
            try
            {
                objProcesarBD  = new clsConexionDb();
                objSqlConexion = new SqlConnection();
                dsResultado    = new DataSet();
                
                objSqlConexion = objProcesarBD.ObtenerConexion("CnxUniversidad");

                dsResultado = objProcesarBD.TraerDataSet(objSqlConexion, "SP_ConsultarCategoria");

                return dsResultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataSet InsertCategoria(string PstrNombre, string PstrDescripcion)
        {
            if (!Validar(PstrNombre, PstrDescripcion))
            {
                return null;
            }
            objProcesarBD = new clsConexionDb();
            objSqlConexion = new SqlConnection();
            dsResultado = new DataSet();
            objParametros = new SqlParameter[2];

            objParametros[0] = new SqlParameter("@Nombre", PstrNombre);
            objParametros[1] = new SqlParameter("@Descripcion", PstrDescripcion);
            
            objSqlConexion = objProcesarBD.ObtenerConexion("CnxUniversidad");

            dsResultado = objProcesarBD.TraerDataSet(objSqlConexion, "SP_InsertCategoria", objParametros);

            return dsResultado;


        }

        public DataSet UpdateCategoria(int PintId, string PstrNombre, string PstrDescripcion)
        {
            if (!Validar(PstrNombre, PstrDescripcion))
            {
                return null;
            }
            objProcesarBD = new clsConexionDb();
            objSqlConexion = new SqlConnection();
            dsResultado = new DataSet();
            objParametros = new SqlParameter[3];

            objParametros[0] = new SqlParameter("@Id", PintId);
            objParametros[1] = new SqlParameter("@Nombre", PstrNombre);
            objParametros[2] = new SqlParameter("@Descripcion", PstrDescripcion);

            objSqlConexion = objProcesarBD.ObtenerConexion("CnxUniversidad");
                
            dsResultado = objProcesarBD.TraerDataSet(objSqlConexion, "SP_UpdateCategoria", objParametros);

            return dsResultado;


        }

        public DataSet DeleteCategoria(int PintId)
        {
            
            objProcesarBD = new clsConexionDb();
            objSqlConexion = new SqlConnection();
            dsResultado = new DataSet();
            objParametros = new SqlParameter[1];

            objParametros[0] = new SqlParameter("@Id", PintId);
            
            objSqlConexion = objProcesarBD.ObtenerConexion("CnxUniversidad");

            dsResultado = objProcesarBD.TraerDataSet(objSqlConexion, "SP_DeleteCategoria", objParametros);

            return dsResultado;


        }

        #endregion
    }


}
