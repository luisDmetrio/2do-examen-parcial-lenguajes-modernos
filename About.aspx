<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="testAssp.About" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
  
    <link rel="stylesheet" href="css/estilos.css">

    <body>  
   

          <div align="center" class="form-header">
                        <h1 class="form-title">R<span>egistrar Usuarios</span></h1>
                    </div>


    <div align="center">
        <%--<form action="" class="form">
            </form>--%>
     
                
        <%--<form action="" class="form">--%>
                
              

                <%--<form action="" class="form">--%>
                    <br></br>
                <label for="nombre" class="form-label">Nombre</label>
                <asp:TextBox ID="txtNombre" runat="server"   placeholder="Escriba su nombre" Width="400px"/> </asp:TextBox>
                 
                <br></br>
                <label for="apellidoPateno" class="form-label">Apellido Paterno</label>
                <asp:TextBox ID="txtapellidoPaterno" runat="server"   placeholder="Escriba su apellido paterno" Width="400px"/>
                
                <br></br>
                <label for="apellidoMaterno" class="form-label">Apellido Materno</label>
                <asp:TextBox ID="txtapellidoMaterno" runat="server"   placeholder="Escriba su apellido materno" Width="400px" ></asp:TextBox>
               
                    <br></br>
                 <label for="colona" class="form-label">Clave colonia</label>
                 <asp:TextBox ID="txtColonia" runat="server" placeholder="Escriba el ID de su colonia" ></asp:TextBox>
                  
                    <br></br>
                 <label for="ciudd" class="form-label">Clave Ciudad</label>
                 <asp:TextBox ID="txtCiudad" runat="server" placeholder="Escriba el ID de su ciudad"></asp:TextBox>
                    
                    <br></br>
                 <label for="reyago" class="form-label">Clave de Rey Mago</label>
                 <asp:TextBox ID="txtRey" runat="server" placeholder="Escriba su ID de rey mago"></asp:TextBox>
                    
                    <br></br>
                 <label for="grpo" class="form-label">ID del grupo de vecinos</label>
                 <asp:TextBox ID="txtGrupo" runat="server"  placeholder="Escriba el ID de su grupo"></asp:TextBox>
                    
                   <br></br>
                 <asp:Button ID="btnRegistrar" OnClick="btnRegistrar_Click" runat="server" Text="Registrar"   Width="200px" Height="50px" />
    
                 <%--</form>   --%>

             <%--</form>--%>

          </div>
        </body>


    
    


</asp:Content>
