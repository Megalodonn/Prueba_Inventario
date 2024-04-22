$(document).ready(function () {

    $("#btnGuardar").click(function () {

        $.ajax({
            url: "FRM_Inventario.aspx/Insertar",
            data: '{"Tipo_Mov":"' + $("#txtTipo_Mov").val() +
                '","NRO_DOCUMENTO":"' + $("#txtNRO_DOCUMENTO").val() +
                '","CANTIDAD":"' + $("#txtCANTIDAD").val() +
                '","TIPO_DOCUMENTO":"' + $("#txtTIPO_DOCUMENTO").val() +
                '","COD_CIA":"' + $("#txtCOD_CIA").val() +
                '","COMPANIA_VENTA_3":"' + $("#txtCOMPANIA_VENTA_3").val() +
                '","COD_ITEM_2":"' + $("#txtCOD_ITEM_2").val() +
                '","ALMACEN_VENTA":"' + $("#txtALMACEN_VENTA").val() +
                '","COSTO_UNITARIO":"' + $("#txtCOSTO_UNITARIO").val() +
                '"}',
            dataType: "json",
            type: "POST",
            contentType: "application/json; charset=utf-8",
            success: function (jsondata) {
                //debugger
                //jQuery("#list").jqGrid('setGridParam', { page: 1 }).trigger("reloadGrid"); return false;
                alert(jsondata.d);
            },
            error: function (xhr, status, error) {
                trataErro(xhr);
            }
        });
    });

});