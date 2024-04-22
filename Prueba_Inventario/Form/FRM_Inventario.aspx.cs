using Prueba_Inventario.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba_Inventario.Form
{
    public partial class FRM_Inventario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static string Insertar(string Tipo_Mov, string txtNRO_DOCUMENTO, string CANTIDAD, string TIPO_DOCUMENTO, string  COD_CIA, string COMPANIA_VENTA_3, string COD_ITEM_2, string ALMACEN_VENTA, string COSTO_UNITARIO)
        {

            string result = "";
            try
            {

                BLInventario objProg = new BLInventario();
                result = objProg.Insertar( Tipo_Mov, txtNRO_DOCUMENTO, CANTIDAD, TIPO_DOCUMENTO,  COD_CIA, COMPANIA_VENTA_3, COD_ITEM_2, ALMACEN_VENTA, COSTO_UNITARIO );
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            finally
            {

            }
            return result;
        }
    }
}