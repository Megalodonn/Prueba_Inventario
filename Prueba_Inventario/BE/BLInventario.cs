using Prueba_Inventario.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba_Inventario.BE
{
    public class BLInventario
    {
        public string Insertar(string Tipo_Mov, string txtNRO_DOCUMENTO, string CANTIDAD, string TIPO_DOCUMENTO, string COD_CIA, string COMPANIA_VENTA_3, string COD_ITEM_2, string ALMACEN_VENTA, string COSTO_UNITARIO)
        {
            return Insertar(Tipo_Mov, txtNRO_DOCUMENTO, CANTIDAD, TIPO_DOCUMENTO, COD_CIA, COMPANIA_VENTA_3, COD_ITEM_2, ALMACEN_VENTA, COSTO_UNITARIO);
        }

    }
}