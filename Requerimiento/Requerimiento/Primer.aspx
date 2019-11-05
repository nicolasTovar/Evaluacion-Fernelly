<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Primer.aspx.cs" Inherits="Requerimiento.Primer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlCategoria" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:GridView ID="gvProducto" runat="server"></asp:GridView>
        </div>
        <div>
        <asp:Button ID="btnMostrar" runat="server" Text="Mostrar" OnClick="btnMostrar_Click" />
        </div>
      
    </form>
</body>
</html>
