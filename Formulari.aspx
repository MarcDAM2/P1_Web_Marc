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
                <img class="logo" src="img/logo.png" alt="imatge del logo de la botiga Online">
                <h1 class="titol_capçalera"> Funko_DAM</h1>
            </header>

            <main>
                <h1> Formulari per confirmar la Comanda: </h1>
                <div class="dadesClient">
                    <div class="tipusDades">
                        <p>Introdueix el DNI/NIF: </p>
                        <input type="text" name="clientDNI" class="clientDNI" placeholder="Escriu el teu DNI">
                    </div>
                    <div class="tipusDades">
                        <p>Introdueix el teu nom: </p>
                        <input type="text" name="clientNom" class="clientNom" placeholder="Escriu el teu Nom">
                    </div>
                    <div class="tipusDades">
                        <p>Introdueix el teu número de telèfon: </p>
                        <input type="text" name="clientTelefon" class="clientTelefon" placeholder="Escriu el teu telèfon">
                    </div>
                </div>
                <form></form>
                <form action ="Confirmacio.aspx" class="boton">
                    <asp:Button class="boto" runat="server" Text="Confirma Comanda" />
                </form>
            </main>
        </div>
    </form>
</body>
</html>
