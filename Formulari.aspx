<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulari.aspx.cs" Inherits="P1_Web_Marc.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Formulari Comanda</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="css/formulari.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header>
                <a href="Carrito.aspx" <i class="fa fa-mail-reply-all"></i></a>
                <img class="logo" src="img/logo.png" alt="imatge del logo de la botiga Online">
                <h1 class="titol_capçalera"> Funko_DAM</h1>
            </header>

            <main>
                <h1> Formulari per confirmar la Comanda: </h1>
                <div class="dadesClient">
                    <div class="tipusDades">
                        <p>Introdueix el DNI/NIF: </p>
                        <input id="clientDNI" type="text" name="client_dni" class="clientDNI" placeholder="Escriu el teu DNI" runat="server">
                    </div>
                    <div class="tipusDades">
                        <p>Introdueix el teu nom: </p>
                        <input id="clientNom" type="text" name="clientNom" class="client_nom" placeholder="Escriu el teu Nom" runat="server">
                    </div>
                    <div class="tipusDades">
                        <p>Introdueix el teu número de telèfon: </p>
                        <input id="clientTel" type="text" name="clientTelefon" class="client_telefon" placeholder="Escriu el teu telèfon" runat="server">
                    </div>
                </div>
                <div class="boton">
                    <asp:Button class="boto" runat="server" Text="Confirma Comanda" OnClick="BotoConfirmarComanda" />
                </div>
            </main>
        </div>
    </form>
</body>
</html>
