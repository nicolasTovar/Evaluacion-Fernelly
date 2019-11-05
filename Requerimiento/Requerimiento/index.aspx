﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Requerimiento.index" %>

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
            <div class="col my-5">
        <div class="text-center">
            <div class="my-3">
                <asp:Button ID="btnUno" runat="server" Text="Primer formulario"  CssClass="btn btn-outline-primary" OnClick="btnUno_Click"/>
            </div>
            <div class="my-3">
                <asp:Button ID="btnDos" runat="server" Text="Segundo formulario" CssClass="btn btn-outline-danger" OnClick="btnDos_Click" />
            </div>
            <div class="my-3">
                <asp:Button ID="btnTres" runat="server" Text="Tercer formulario" CssClass="btn btn-outline-dark" OnClick="btnTres_Click" />
            </div>
            <div>
                <asp:Button ID="btnCuatro" runat="server" Text="Cuarto formulario" CssClass="btn btn-outline-success" OnClick="btnCuatro_Click" />
            </div>
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
