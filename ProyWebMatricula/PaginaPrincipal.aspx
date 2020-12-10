<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="ProyWebMatricula.PaginaPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
<link rel="stylesheet" type="text/css" href="style/fontawesome/css/all.css"/>
    <link href="#" rel="stylesheet" />
<title>Mantenimiento de Matriculas</title>

    <style type="text/css">
        .alert-primary {
            width: 123px;
            margin-left: 250px;
        }
        .table {
            width: 697px;
        }
        .auto-style1 {
            height: 36px;
        }
        .auto-style2 {
            height: 36px;
            width: 142px;
        }
        .auto-style3 {
            width: 142px;
            height: 29px;
        }
        .auto-style4 {
            height: 29px;
        }
    </style>

</head>

<body>

    <%--<table class="table" style="margin-left: 23%;">
        <thead>
            <tr>
                <th scope="col">#</th>
                <th scope="col">First</th>
                <th scope="col">Last</th>
                <th scope="col">Handle</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <th scope="row">1</th>
                <td>Mark</td>
                <td>Otto</td>
                <td>@mdo</td>
            </tr>
            <tr>
                <th scope="row">2</th>
                <td>Jacob</td>
                <td>Thornton</td>
                <td>@fat</td>
            </tr>
            <tr>
                <th scope="row">3</th>
                <td>Larry</td>
                <td>the Bird</td>
                <td>@twitter</td>
            </tr>
        </tbody>
    </table>
    
    <hr />--%>
   

    <form id="form1" runat="server">

          <h1 >Mantenimiento de Matriculas</h1>
          <br />
          <asp:Button ID="Button1" runat="server" Text="Nueva Matricula" />
            

          <hr />    

            <asp:GridView ID="gvMatriculas" runat="server"></asp:GridView>

            <br />
            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" />
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" />
            <asp:Button ID="btnEditar" runat="server" Text="Editar" />
            <asp:Button ID="Button4" runat="server" Text="Eliminar" />
          

    </form>


</body>
</html>
