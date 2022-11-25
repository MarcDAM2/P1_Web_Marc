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

            String path = Server.MapPath(".") + "/Comandes/";
            String[] fitxersComandes = Directory.GetFiles(path, "Comanda*.txt", SearchOption.AllDirectories);
            int numComandes = fitxersComandes.Length;
            numComandes++;

            if ((clientDNI.Value == "") || (clientNom.Value == "") || (clientTel.Value == ""))
            {

            }
            else
            {
                String path2 = Server.MapPath(".") + "/Comandes/comanda" + numComandes + ".txt";

                EscriuComandaFitxer(path2);
            }
        }

        private void EscriuComandaFitxer(string path)
        {
            //string resultat = TextBox1.Text;

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(path);
                //EscriureAmbSaltLiniaFinal(writer, resultat);
            }
            catch (IOException exc)
            {
                System.Diagnostics.Debug.WriteLine(exc.Message); // Missatge per terminal en cas de fallar l'escriptura
            }
            finally
            {
                if (writer != null)
                    writer.Dispose(); // També es pot utilitzar .Close()
            }
        }
    }
}