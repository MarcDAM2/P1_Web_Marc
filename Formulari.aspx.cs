using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P1_Web_Marc
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BotoConfirmarComanda(object sender, EventArgs e)
        {
            //Response.Redirect("Confirmacio.aspx");

            String path = Server.MapPath(".") + "/Comandes/";
            String[] fitxersComandes = Directory.GetFiles(path, "Comanda*.txt", SearchOption.AllDirectories);
            int numComandes = fitxersComandes.Length;
            numComandes++;

            if ((clientDNI.Value == "") || (clientNom.Value == "") || (clientTel.Value == ""))
            {

            }
            else
            {
                String path2 = Server.MapPath(".") + "/Comandes/Comanda" + numComandes + ".txt";

                EscriuComandaFitxer(path2);
            }
        }

        private void EscriuComandaFitxer(string path)
        {
            //string resultat = TextBox1.Text;

            StreamWriter writer = new StreamWriter(path);
            try
            {

                // Escrivim primer les Dades Del client:

                //String[] dades
                writer.WriteLine("----------  Dades del Client ----------\n");
                writer.WriteLine("DNI: " + clientDNI.Value);
                writer.WriteLine("Nom: " + clientNom.Value);
                writer.WriteLine("Telèfon: " + clientTel.Value + "\n\n\n");


                // Escrivim primer les Dades Dels Prodcutes Comprats:

                string[] producteComprats1 = (string[])Session["productes_afegits1"];
                string[] producteComprats2 = (string[])Session["productes_afegits2"];
                string[] producteComprats3 = (string[])Session["productes_afegits3"];
                string[] producteComprats4 = (string[])Session["productes_afegits4"];

                writer.WriteLine("----------  Dades dels Productes Comprats ----------\n");

                if (producteComprats1 == null)
                { } 
                else {
                    writer.WriteLine("Nom del Producte: " + producteComprats1[1]);
                    writer.WriteLine("Quantitat del Producte: " + producteComprats1[2] + "\n");
                }

                if (producteComprats2 == null)
                { }
                else {
                    writer.WriteLine("Nom del Producte: " + producteComprats2[1]);
                    writer.WriteLine("Quantitat del Producte: " + producteComprats2[2] + "\n");
                }

                if (producteComprats3 == null)
                { }
                else {
                    writer.WriteLine("Nom del Producte: " + producteComprats3[1]);
                    writer.WriteLine("Quantitat del Producte: " + producteComprats3[2] + "\n");
                }

                if (producteComprats4 == null)
                { }
                else {
                    writer.WriteLine("Nom del Producte: " + producteComprats4[1]);
                    writer.WriteLine("Quantitat del Producte: " + producteComprats4[2]);
                }

                writer.Dispose();
                Response.Redirect("Confirmacio.aspx");
                //EscriureAmbSaltLiniaFinal(writer, resultat);
            }
            catch (IOException exc)
            {
                System.Diagnostics.Debug.WriteLine(exc.Message); // Missatge per terminal en cas de fallar l'escriptura
            }
        }
    }
}