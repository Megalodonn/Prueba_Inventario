<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FRM_Inventario.aspx.cs" Inherits="Prueba_Inventario.Form.FRM_Inventario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-group">
            <label for="email">Fecha Inicio:</label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <label for="email">Fecha Fin:</label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <label for="email">Tipo Movimiento:</label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <label for="email">Nro. Documento:</label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <input type="button" value="Buscar" id="btnBuscar" />
        </div>
                <table>
                    <tr>
                        <td align="right"> Tipo Movimiento:
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtTipo_Mov" runat="server" Width="100px" />
                            <input type="button" value="Insertar" id="btnInsertar" />
                            <input type="button" value="Modificar" id="btnModificar" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">N° Documento :
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtNRO_DOCUMENTO" runat="server" Enabled="false" Width="300px" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">TIPO DOCUMENTO :
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtTIPO_DOCUMENTO" runat="server" Enabled="false" Width="300px" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">Cantidad :
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtCANTIDAD" runat="server" MaxLength="11" Width="50px" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">COD CIA :
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtCOD_CIA" runat="server" MaxLength="11" Width="50px" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">COMPANIA_VENTA_3 :
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtCOMPANIA_VENTA_3" runat="server" MaxLength="11" Width="50px" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">COD_ITEM_2 :
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtCOD_ITEM_2" runat="server" MaxLength="11" Width="50px" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">ALMACEN_VENTA :
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtALMACEN_VENTA" runat="server" MaxLength="11" Width="50px" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">COSTO UNITARIO :
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtCOSTO_UNITARIO" runat="server" MaxLength="11" Width="50px" />
                        </td>
                    </tr>
                </table>
    </form>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-3.4.1.js"></script>

</body>
</html>
