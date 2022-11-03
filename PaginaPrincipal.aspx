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
                <div class="productes">
                    <div class="producte">
                        <img src="img/logo.png" alt=" Imatge del producte1">
                        <p class="nomProducte"> Nom del producte</p>
                        <p> 15,99 €</p>
                        <p class="descripcio"> Figureta de una serie.</p>
                        <div class="quantitat">
                            <p> Quantitat: </p>
                            <input type="number" class="quantitatInd" name="quantitatIndividual" min="0" max="100">
                        </div>
                        <asp:Button class="botoComprar" runat="server" Text="Afegeix al Carrito" />
                    </div>
                    <div class="producte">
                        <img src="img/logo.png" alt=" Imatge del producte1">
                        <p class="nomProducte"> Nom del producte</p>
                        <p> 15,99 €</p>
                        <p class="descripcio"> Figureta de una serie.</p>
                        <div class="quantitat">
                            <p> Quantitat: </p>
                            <input type="number" class="quantitatInd" name="quantitatIndividual" min="0" max="100">
                        </div>
                        <asp:Button class="botoComprar" runat="server" Text="Afegeix al Carrito" />
                    </div>
                    <div class="producte">
                        <img src="img/logo.png" alt=" Imatge del producte1">
                        <p class="nomProducte"> Nom del producte</p>
                        <p> 15,99 €</p>
                        <p class="descripcio"> Figureta de una serie.</p>
                        <div class="quantitat">
                            <p> Quantitat: </p>
                            <input type="number" class="quantitatInd" name="quantitatIndividual" min="0" max="100">
                        </div>
                        <asp:Button class="botoComprar" runat="server" Text="Afegeix al Carrito" />
                    </div>
                    <div class="producte">
                        <img src="img/logo.png" alt=" Imatge del producte1">
                        <p class="nomProducte"> Nom del producte</p>
                        <p> 15,99 €</p>
                        <p class="descripcio"> Figureta de una serie hola que tal com estas sdjanjidnajis dsanodojan</p>
                        <div class="quantitat">
                            <p> Quantitat: </p>
                            <input type="number" class="quantitatInd" name="quantitatIndividual" min="0" max="100">
                        </div>
                        <asp:Button class="botoComprar" runat="server" Text="Afegeix al Carrito" />
                    </div>
                </div>
            </main>
        </div>
    </form>
</body>
</html>
