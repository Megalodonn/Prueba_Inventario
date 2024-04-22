using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Prueba_Inventario.BD
{
    public class BDInventario
    {
        public string Insertar(string Tipo_Mov, string NRO_DOCUMENTO, string CANTIDAD, string TIPO_DOCUMENTO, string COD_CIA, string COMPANIA_VENTA_3, string COD_ITEM_2, string ALMACEN_VENTA, string COSTO_UNITARIO)
        {
            string result = "";
            string connString = ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;
            using (SqlConnection db = new SqlConnection(connString))
            {

                try
                {
                    db.Open();
                    SqlCommand sql_cmnd = new SqlCommand("SP_Insertar", db);
                    sql_cmnd.Parameters.AddWithValue("@pTipo_Mov", SqlDbType.VarChar).Value = Tipo_Mov;
                    sql_cmnd.Parameters.AddWithValue("@pNRO_DOCUMENTO", SqlDbType.VarChar).Value = NRO_DOCUMENTO;
                    sql_cmnd.Parameters.AddWithValue("@pCANTIDAD", SqlDbType.VarChar).Value = CANTIDAD;
                    sql_cmnd.Parameters.AddWithValue("@pTIPO_DOCUMENTO", SqlDbType.VarChar).Value = TIPO_DOCUMENTO;
                    sql_cmnd.Parameters.AddWithValue("@pCOD_CIA", SqlDbType.VarChar).Value = COD_CIA;
                    sql_cmnd.Parameters.AddWithValue("@pCOMPANIA_VENTA_3", SqlDbType.VarChar).Value = COMPANIA_VENTA_3;
                    sql_cmnd.Parameters.AddWithValue("@pCOD_ITEM_2", SqlDbType.VarChar).Value = COD_ITEM_2;
                    sql_cmnd.Parameters.AddWithValue("@pALMACEN_VENTA", SqlDbType.VarChar).Value = ALMACEN_VENTA;
                    sql_cmnd.Parameters.AddWithValue("@pCOSTO_UNITARIO", SqlDbType.VarChar).Value = COSTO_UNITARIO;
                    sql_cmnd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader dr = sql_cmnd.ExecuteReader())
                    { 
                    
                    }
                    result = "EXITO";
                }
                catch (Exception ex)
                {
                    //throw new Exception("Error: " + ex.Message);
                    result = ex.Message;
                }
                finally
                {
                    db.Close();
                }


            }

            return result;
        }
    }
}