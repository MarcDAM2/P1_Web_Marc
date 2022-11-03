<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="P1_Web_Marc.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Carret de la Compra</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="css/carrito.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header>
                <img class="logo" src="img/logo.png" alt="imatge del logo de la botiga Online">
                <h1 class="titol_capçalera"> Funko_DAM</h1>
            </header>

            <main>
                <h1>Carret de la Compra: </h1>

                <div class="productes_carrito">
                    <div class="producte">
                        <img src="img/logo.png" alt="">
                        <p>Nom del producte</p>
                        <p>Quantitat: </p>
                        <input type="number" class="quantitatInd" name="quantitatIndividual" min="0" max="100">
                        <asp:Button class="eliminarProd" runat="server" Text="x" />
                    </div>
                    <div class="producte">
                        <img src="img/logo.png" alt="">
                        <p>Nom del producte</p>
                        <p>Quantitat: </p>
                        <input type="number" class="quantitatInd" name="quantitatIndividual" min="0" max="100">
                        <asp:Button class="eliminarProd" runat="server" Text="x" />
                    </div>
                    <div class="botons">
                        <!-- Fico un nou form buit ja que el WebForm es una versió vella i el primer form action no funciona-->
                        <form></form>
                        <form action ="PaginaPrincipal.aspx">
                            <asp:Button class="boto" runat="server" Text="Continuar Comprant" />
                        </form>
                        <form action ="Formulari.aspx">
                            <asp:Button class="boto" runat="server" Text="Realitzar Compra" />
                        </form>
                    </div>
                </div>
            </main>
        </div>
    </form>
</body>
</html>
