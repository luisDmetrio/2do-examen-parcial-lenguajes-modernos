<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Actualizacion.aspx.cs" Inherits="testAssp.Actualizacion" %>

<!DOCTYPE html>
<html lang= "es">


    <link rel="stylesheet" href="css/estilos.css">

   

    <body>


         <div class="contenedor">
             <form id="form1" class="form" runat="server">
        <div class="contenedor" align="center" >
            </div>
                <div class="form-header">
                    <h1 class="form-title"> A<span>ctualizar Informacion</span></h1>
                </div>

                 <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID_Vecino" DataSourceID="SqlDataSource1">
                     <Columns>
                         <asp:BoundField DataField="ID_Vecino" HeaderText="ID_Vecino" InsertVisible="False" ReadOnly="True" SortExpression="ID_Vecino" />
                         <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                         <asp:BoundField DataField="apellidoPaterno" HeaderText="apellidoPaterno" SortExpression="apellidoPaterno" />
                         <asp:BoundField DataField="apellidoMaterno" HeaderText="apellidoMaterno" SortExpression="apellidoMaterno" />
                         <asp:BoundField DataField="Clave_ReyMago" HeaderText="Clave_ReyMago" SortExpression="Clave_ReyMago" />
                         <asp:BoundField DataField="Clave_Ciudad" HeaderText="Clave_Ciudad" SortExpression="Clave_Ciudad" />
                     </Columns>
                 </asp:GridView>


                 <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ReyesMagosConnectionString %>" SelectCommand="SELECT [ID_Vecino], [nombre], [apellidoPaterno], [apellidoMaterno], [Clave_ReyMago], [Clave_Ciudad] FROM [Vecinos]"></asp:SqlDataSource>


                 <br></br>
        <label for="Eliminar" class="form-label">Inserte el ID del Usuario que desea Modificar<asp:TextBox ID="txtIDmod" runat="server" Width="37px"></asp:TextBox>
                 <asp:Button ID="btnModificar" runat="server" Height="21px" OnClick="btnModificar_Click" Text="OK" Width="37px" />
                 </label>


                 <label for="nombre" class="form-label">Nombre</label>
                <asp:TextBox ID="txtNombre" runat="server"   placeholder="Escriba su nombre" Width="400px"/> </asp:TextBox>
                 
                <br></br>
                <label for="apellidoPateno" class="form-label">Apellido Paterno</label>
                <asp:TextBox ID="txtapellidoPaterno" runat="server"   placeholder="Escriba su apellido paterno" Width="400px"/>
                
                <br></br>
                <label for="apellidoMaterno" class="form-label">Apellido Materno</label>
                <asp:TextBox ID="txtapellidoMaterno" runat="server"   placeholder="Escriba su apellido materno" Width="400px" ></asp:TextBox>
               
                  
                 <%--   <br></br>
                 <label for="ciudd" class="form-label">Clave Ciudad</label>
                 <asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox>
                    
                    <br></br>
                 <label for="reyago" class="form-label">Clave de Rey Mago</label>
                    
                


        &nbsp;<asp:TextBox ID="txtRey" runat="server"></asp:TextBox>--%>
         </div>
        
    </form>

        <a href="https://localhost:44350/Default"  style='color: #00FF00'>HOME</a>
    </body>


</html>