<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="U1_W3_D1_Esercizio.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Multicinema</title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
<div class="container">

    <div><h1>Cinema Multisala</h1></div>

    <div class="box-form">
        <form id="form1" runat="server">
            <div>
                <p>Nome: <asp:TextBox ID="txtNome" runat="server"></asp:TextBox></p>
                <p>Cognome: <asp:TextBox ID="txtCognome" runat="server"></asp:TextBox></p>
                <p>Sala:
                    <asp:DropDownList ID="ddilTipoSala" runat="server">
>           
                    </asp:DropDownList>
                <asp:CheckBox CssClass="d-inline" ID="CK_BBigliettoRidotto" Text="Biglietto Ridotto" runat="server" />
               </p>
           
                <asp:Button CssClass="d-inline" Text="Prenota" ID="Prenota" runat="server" OnClick="Prenota_Click" />
            </div>
        </form>

        <div>
            <div>
                <h2>Informazioni Supplementari</h2>
                <div>
                    <p ID="txtSalaNord" runat="server">Biglietti venduti SALA NORD: , di cui ridotti:</p>
                    <p ID="txtSalaEst" runat="server">Biglietti venduti SALA EST: , di cui ridotti:</p>
                    <p id="txtSalaSud" runat="server">Biglietti venduti SALA SUD: , di cui ridotti:</p>
                </div>
            </div>
        </div>
    </div>
</div>
   
</body>
</html>
