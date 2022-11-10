using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P1_Web_Marc
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static int estocProd = 1;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) // Només omplir la llista
            {
                String path = Server.MapPath(".") + "/Productes/";
                String[] FitxersProductes = Directory.GetFiles(path, "producte*.txt", SearchOption.AllDirectories);
                estocProd = 1;
                foreach (String fitxerProd in FitxersProductes)
                {
                    LLegirFitxer(fitxerProd);
                }
            }
        }

        private string LLegirFitxer(string path)
        {
            string resultat = "Lectura errònia";
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(path);
                string[] dadesProductes = reader.ReadToEnd().Split(';');
                string imatgeProd = "/Productes/producte" + estocProd + ".jpg";
                string producte = "<div class='producte'> " +
                    "<img src =" + imatgeProd + " alt = 'Imatge del producte1'><br>" +
                    "<p class='nomProducte'>" + dadesProductes[0] + "</p><br>" +
                    "<p>" + dadesProductes[1] + "</p><br>" +
                    "<p class='descripcio'>" + dadesProductes[2] + "</p>" +
                        "<div class='quantitat'>" +
                            "<p> Quantitat: </p>" +
                            "<input type = 'number' class='quantitatInd' name='quantitatIndividual' min='0' max='100'>" +
                        "</div>" +
                        "<asp:Button ID ='Butto1' runat= 'server' class='botoComprar'>Afegeix al Carrito<asp:Button/>" +
                    "</div>";

                ((Label)this.FindControl("label_prod" + estocProd)).Text = producte;
                estocProd++;

            }
            catch (IOException exc)
            {
                System.Diagnostics.Debug.WriteLine(exc.Message); // Missatge per terminal en cas de fallar la lectura
            }

            return resultat;
        }
    }
}