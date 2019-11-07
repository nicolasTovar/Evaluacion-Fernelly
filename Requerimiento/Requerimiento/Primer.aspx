<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Primer.aspx.cs" Inherits="Requerimiento.Primer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row my-5">
                <div class="col my-5 text-center">
                       <h1>Carga de datos del XML y generar el JSON</h1>
          <div class="my-3">

            <asp:DropDownList ID="ddlCategoria" runat="server"></asp:DropDownList>
        </div>
        <div class="my-3">
         
            <asp:GridView ID="gvProducto" runat="server" CssClass="m-auto" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
        </div>
        <div class="my-3">
        <asp:Button ID="btnMostrar" runat="server" Text="Mostrar" OnClick="btnMostrar_Click" CssClass="btn btn-outline-primary" />
        </div>
        <div class="my-3">
        <asp:Button ID="btnRegresar" runat="server" Text="Regresar" OnClick="btnRegresar_Click" CssClass="btn btn-outline-danger" />
        </div>
       <div class="my-3">
        <asp:Button ID="btnGenerarJsonCategoria" runat="server" Text="Generar archivo JSON categoria" OnClick="btnCategoria_Click" CssClass="btn btn-outline-secondary" />
        </div>
        <div class="my-3">
        <asp:Button ID="btnGenerarJsonProducto" runat="server" Text="Generar archivo JSON producto" OnClick="btnProducto_Click" CssClass="btn btn-outline-warning" />
        </div>
                </div>
            </div>
        </div>

      
    </form>
<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

</body>
</html>
