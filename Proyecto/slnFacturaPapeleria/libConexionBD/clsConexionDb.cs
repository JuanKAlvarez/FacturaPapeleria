using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace libConexionBD
{
    public class clsConexionDb
    {
        #region "Constructor"
        public clsConexionDb()
        { 
        }
        #endregion

        #region "Métodos Públicos"

        public DataSet TraerDataSet(SqlConnection PobjConexion, string PStoredProcedure)
        {
            try
            {

                SqlCommand objCommand = new SqlCommand(PStoredProcedure, PobjConexion);
                SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
                DataSet dsGeneral = new DataSet();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandTimeout = 300;
                objAdapter.Fill(dsGeneral);
                PobjConexion.Close();
                return dsGeneral;
            }
            catch (SqlException ErrorSQL)
            {
                throw ErrorSQL;
            }
            catch (Exception Error)
            {
                throw Error;
            }
            finally
            {
                PobjConexion.Close();
            }
        }

        public DataSet TraerDataSet(SqlConnection PobjConexion, string PstrStoredProcedure, SqlParameter[] PobjParameters)
        {
            try
            {
                SqlCommand objCommand = new SqlCommand(PstrStoredProcedure, PobjConexion);
                SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
                DataSet dsGeneral = new DataSet();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandTimeout = 300;
                foreach (SqlParameter Parameters in PobjParameters)
                {
                    objAdapter.SelectCommand.Parameters.AddWithValue(Parameters.ParameterName, Parameters.Value);
                }
                objAdapter.Fill(dsGeneral);
                PobjConexion.Close();
                return dsGeneral;
            }
            catch (SqlException ErrorSQL)
            {
                throw ErrorSQL;
            }
            catch (Exception Error)
            {
                throw Error;
            }
            finally
            {
                PobjConexion.Close();
            }
        }

        public DataTable TraerDataTable(SqlConnection PobjConexion, string PstrStoredProcedure)
        {
            try
            {
                SqlCommand objCommand = new SqlCommand(PstrStoredProcedure, PobjConexion);
                SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
                DataTable dtGeneral = new DataTable("tblGnal");
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandTimeout = 300;
                objAdapter.Fill(dtGeneral);
                PobjConexion.Close();
                return dtGeneral;
            }
            catch (SqlException ErrorSQL)
            {
                throw ErrorSQL;
            }
            catch (Exception Error)
            {
                throw Error;
            }
            finally
            {
                PobjConexion.Close();
            }
        }

        public DataTable TraerDataTable(SqlConnection PobjConexion, string PstrStoredProcedure, SqlParameter[]PobjParameters)
        {
            try
            {
                SqlCommand objCommand = new SqlCommand(PstrStoredProcedure, PobjConexion);
                SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
                DataTable dtGeneral = new DataTable("Generico");
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandTimeout = 300;
                foreach (SqlParameter Parameters in PobjParameters)
                {
                    objAdapter.SelectCommand.Parameters.AddWithValue(Parameters.ParameterName, Parameters.Value);
                }
                objAdapter.Fill(dtGeneral);
                PobjConexion.Close();
                return dtGeneral;
            }
            catch (SqlException ErrorSQL)
            {
                throw ErrorSQL;
            }
            catch (Exception Error)
            {
                throw Error;
            }
            finally
            {
                PobjConexion.Close();
            }
        }

        public SqlDataReader TraerDataReader(SqlConnection PobjConexion, string PstrStoredProcedure)
        {
            try
            {
                SqlCommand objCommand = new SqlCommand(PstrStoredProcedure, PobjConexion);
                SqlDataReader drGeneral;
                objCommand.CommandType = CommandType.StoredProcedure;
                drGeneral = objCommand.ExecuteReader();
                return drGeneral;
            }
            catch (SqlException ErrorSQL)
            {
                throw ErrorSQL;
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }

        public SqlDataReader TraerDataReader(SqlConnection PobjConexion, string PstrStoredProcedure, SqlParameter[] PobjParameters)
        {
            try
            {
                SqlCommand objCommand = new SqlCommand(PstrStoredProcedure, PobjConexion);
                SqlDataReader drGeneral;
                objCommand.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter Parameters in PobjParameters)
                {
                    objCommand.Parameters.AddWithValue(Parameters.ParameterName, Parameters.Value);
                }
                drGeneral = objCommand.ExecuteReader();
                return drGeneral;
            }
            catch (SqlException ErrorSQL)
            {
                throw ErrorSQL;
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }

        public SqlConnection ObtenerConexion(string PstrNombreConexion)
        {
            try
            {

                SqlConnection objConexion = new SqlConnection();
                objConexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings[PstrNombreConexion].ToString();
                objConexion.Open();
                return objConexion;
            }
            catch (SqlException ErrorSQL)
            {
                throw ErrorSQL;
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }

        public int EjecutarQuery(SqlConnection PobjConexion, string PstrStoredProcedure, SqlParameter[] PobjParameters)
        {
            try
            {
                SqlCommand objCommand = new SqlCommand(PstrStoredProcedure, PobjConexion);
                objCommand.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter Parameters in PobjParameters)
                {
                    objCommand.Parameters.AddWithValue(Parameters.ParameterName, Parameters.Value);
                }
                return objCommand.ExecuteNonQuery();
            }
            catch (SqlException ErrorSQL)
            {
                throw ErrorSQL;
            }
            catch (Exception Error)
            {
                throw Error;
            }
            finally
            {
                PobjConexion.Close();
            }
        }

        public int EjecutarQuery(SqlConnection PobjConexion, string PstrStoredProcedure)
        {
            try
            {
                SqlCommand objCommand = new SqlCommand(PstrStoredProcedure, PobjConexion);
                objCommand.CommandType = CommandType.StoredProcedure;
                return objCommand.ExecuteNonQuery();
            }
            catch (SqlException ErrorSQL)
            {
                throw ErrorSQL;
            }
            catch (Exception Error)
            {
                throw Error;
            }
            finally
            {
                PobjConexion.Close();
            }
        }

        public bool EjecutarQuerys(SqlConnection PobjConexion, string PstrStoredProcedure)
        {
            try
            {
                SqlCommand objCommand = new SqlCommand(PstrStoredProcedure, PobjConexion);
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ErrorSQL)
            {
                throw ErrorSQL;
            }
            catch (Exception Error)
            {
                throw Error;
            }
            finally
            {
                PobjConexion.Close();
            }
        }

        public bool EjecutarQuerys(SqlConnection PobjConexion, string PstrStoredProcedure, SqlParameter[] PobjParameters)
        {
            try
            {
                SqlCommand objCommand = new SqlCommand(PstrStoredProcedure, PobjConexion);
                objCommand.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter Parameters in PobjParameters)
                {
                    if (Parameters.Direction == ParameterDirection.Output)
                    {
                        objCommand.Parameters.AddWithValue(Parameters.ParameterName, Parameters.Value);
                        objCommand.Parameters[Parameters.ParameterName].Direction = ParameterDirection.Output;
                    }
                    else
                    {
                        objCommand.Parameters.AddWithValue(Parameters.ParameterName, Parameters.Value);
                    }
                }
                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ErrorSQL)
            {
                throw ErrorSQL;
            }
            catch (Exception Error)
            {
                throw Error;
            }
            finally
            {
                PobjConexion.Close();
            }
        }

        public string EjecutarQuerysDirecccion(SqlConnection PobjConexion, string PstrStoredProcedure, SqlParameter[] PobjParameters)
        {
            try
            {
                SqlCommand objCommand = new SqlCommand(PstrStoredProcedure, PobjConexion);
                objCommand.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter Parameters in PobjParameters)
                {
                    if (Parameters.Direction == ParameterDirection.Output)
                    {
                        objCommand.Parameters.AddWithValue(Parameters.ParameterName, Parameters.Value);
                        objCommand.Parameters[Parameters.ParameterName].Direction = ParameterDirection.Output;
                    }
                    else if (Parameters.Direction == ParameterDirection.InputOutput)
                    {
                        objCommand.Parameters.AddWithValue(Parameters.ParameterName, Parameters.Value);
                        objCommand.Parameters[Parameters.ParameterName].Direction = ParameterDirection.InputOutput;
                    }
                    else
                    {
                        objCommand.Parameters.AddWithValue(Parameters.ParameterName, Parameters.Value);
                    }
                }
                objCommand.ExecuteNonQuery();
                return objCommand.Parameters[PobjParameters.Length - 1].Value.ToString();
            }
            catch (SqlException ErrorSQL)
            {
                throw ErrorSQL;
            }
            catch (Exception Error)
            {
                throw Error;
            }
            finally
            {
                PobjConexion.Close();
            }
        }
        #endregion
        
    }
}
