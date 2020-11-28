<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarUsuario.aspx.cs" Inherits="testAssp.EliminarUsuario" %>


  <link rel="stylesheet" href="css/estilos.css">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

    <div class="contenedor">
    <form id="form1" class="form" runat="server">
        <div class="contenedor" align="center" >
            </div>
                <div class="form-header">
                    <h1 class="form-title"> E<span>liminar Usuarios</span></h1>
                </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID_Vecino" DataSourceID="ReyesMagos" Height="143px" Width="351px">
            <Columns>
                <asp:BoundField DataField="ID_Vecino" HeaderText="ID_Vecino" InsertVisible="False" ReadOnly="True" SortExpression="ID_Vecino" />
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                <asp:BoundField DataField="apellidoPaterno" HeaderText="apellidoPaterno" SortExpression="apellidoPaterno" />
                <asp:BoundField DataField="apellidoMaterno" HeaderText="apellidoMaterno" SortExpression="apellidoMaterno" />
                <asp:BoundField DataField="Clave_Ciudad" HeaderText="Clave_Ciudad" SortExpression="Clave_Ciudad" />
                <asp:BoundField DataField="Clave_ReyMago" HeaderText="Clave_ReyMago" SortExpression="Clave_ReyMago" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="ReyesMagos" runat="server" ConnectionString="<%$ ConnectionStrings:ReyesMagosConnectionString %>" SelectCommand="SELECT * FROM [Vecinos]"></asp:SqlDataSource>
    
        
        
        <br></br>
        <label for="Eliminar" class="form-label">Inserte el ID del Usuario a Eliminar</label>
        <asp:TextBox ID="txtEliminar" runat="server"></asp:TextBox>
        <asp:Button ID="btnEliminar" runat="server" Height="18px" OnClick="btnEliminar_Click" Text="Eliminar" />


        </div>
        
    </form>
       
        
    <br></br>

      <%--  <label for="Eliminar" class="form-label">Inserte el ID del Usuario a Eliminar</label>
        <asp:TextBox ID="txtEliminar" runat="server"></asp:TextBox>


        <asp:Button ID="btnEliminar" runat="server" Height="18px" OnClick="btnEliminar_Click" Text="Eliminar" />--%>


    

     <a href="https://localhost:44350/Default" style='color: #00FF00'>HOME</a>
     
   

</body>
</html>

