<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="P1_Web_Marc.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Botiga Online</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="css/estils.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header>
                <img class="logo" src="img/logo.png" alt="imatge del logo de la botiga Online">
                <h1 class="titol_capçalera"> Funko_DAM</h1>
                <a href="Carrito.aspx" <i class="fa fa-shopping-basket"></i></a>
            </header>

            <main>
                <h1>Benvolgut/da a la botiga Funko_DAM</h1>
                <h2>Productes en Estoc:</h2>
                <asp:Label ID="labelSInProd" runat="server" class="msgNoProductes"></asp:Label>
                <div class="productes">
                    <asp:Label ID="label_prod1" runat="server" ></asp:Label>
                    <asp:Label ID="label_prod2" runat="server" ></asp:Label>
                    <asp:Label ID="label_prod3" runat="server" ></asp:Label>
                    <asp:Label ID="label_prod4" runat="server" ></asp:Label>
                    
                </div>
                <div class="quantitatProductes">
                    <p id="quantitatVisible" runat="server" Visible ="false">Quantitat: </p><asp:TextBox id="quantitat1" runat="server" type="number"  class='quantitatInd'/>
                    <p id="quantitatVisible2" runat="server" Visible ="false">Quantitat: </p><asp:TextBox id="quantitat2" runat="server" type="number" class='quantitatInd'/>
                    <p id="quantitatVisible3" runat="server" Visible ="false">Quantitat: </p><asp:TextBox id="quantitat3" runat="server" type="number" class='quantitatInd'/>
                    <p id="quantitatVisible4" runat="server" Visible ="false">Quantitat: </p><asp:TextBox id="quantitat4" runat="server" type="number" class='quantitatInd'/>
                </div>
                <div class="botonsComprar">
                    <asp:Button ID="Button1" runat="server" Text="Afegeix al Carrito" class='botoComprar' OnClick="Button1_Click"/>
                    <asp:Button ID="Button2" runat="server" Text="Afegeix al Carrito" class='botoComprar' OnClick="Button2_Click"/>
                    <asp:Button ID="Button3" runat="server" Text="Afegeix al Carrito" class='botoComprar' OnClick="Button3_Click"/>
                    <asp:Button ID="Button4" runat="server" Text="Afegeix al Carrito" class='botoComprar' OnClick="Button4_Click"/>
                </div>
            </main>
        </div>
    </form>
</body>
</html>
