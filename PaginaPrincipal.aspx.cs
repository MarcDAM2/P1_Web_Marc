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
        static int i = 0;
        string[] valueSession = new string[3];
        string[] nomProductes = new string[4];
        int prodDisponible = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) // Només omplir la llista
            {

                String path = Server.MapPath(".") + "/Productes/";
                String[] FitxersProductes = Directory.GetFiles(path, "producte*.txt", SearchOption.AllDirectories);
                estocProd = 1;
                i = 0;
                foreach (String fitxerProd in FitxersProductes)
                {
                    LLegirFitxer(fitxerProd);
                }

                if (prodDisponible == 0)
                {
                    labelSInProd.Text = "No hi ha stock de productes disponibles, torni haviat c: ";
                }
            }
        }

        private string LLegirFitxer(string path)
        {
            string resultat = "Lectura errònia";
            StreamReader reader = null;
            try
            {
                int quantitat = 0;
                reader = new StreamReader(path);
                string[] dadesProductes = reader.ReadToEnd().Split(';');
                string imatgeProd = "/Productes/producte" + estocProd + ".jpg";

                Button[] botons = new Button[4];
                botons[0] = Button1;
                botons[1] = Button2;
                botons[2] = Button3;
                botons[3] = Button4;

                TextBox[] quantitats = new TextBox[4];
                quantitats[0] = quantitat1;
                quantitats[1] = quantitat2;
                quantitats[2] = quantitat3;
                quantitats[3] = quantitat4;

                //Ruta del fitxer quan estic a Classe
                if (File.Exists("J:/DAM 2nd/M13 Projecte/Projecte1/CodiWebForms/P1_Web_Marc/Productes/producte" + estocProd + ".jpg")
                    && dadesProductes[0] != "" && dadesProductes[1] != "" && dadesProductes[2] != "")

                //Ruta dels fitxers quan estic a Casa
                //if(File.Exists("E:/DAM 2nd/M13 Projecte/Projecte1/CodiWebForms/P1_Web_Marc/Productes/producte" + estocProd + ".jpg")
                //    && dadesProductes[0] != "" && dadesProductes[1] != "" && dadesProductes[2] != "")
                {
                    string producte = "<div class='producte'> " +
                     "<img src =" + imatgeProd + " alt = 'Imatge del producte1'>" +
                     "<p class='nomProducte'>" + dadesProductes[0] + "</p>" +
                     "<p class = 'preu'>" + dadesProductes[1] + "</p><br>" +
                     "<p class='descripcio'> Descripció: " + dadesProductes[2] + "</p>" +
                     "</div>";

                    nomProductes[i] = dadesProductes[0];
                    labelSInProd.Visible = false;

                    //Agafem el nom de cada producte
                    if ( i == 0)
                    {
                        string dadesProdSession;
                        dadesProdSession = nomProductes[0];
                        Session["nom_producte1"] = dadesProdSession;
                        quantitatVisible.Visible = true;
                    } else if( i == 1)
                    {
                        string dadesProdSession;
                        dadesProdSession = nomProductes[1];
                        Session["nom_producte2"] = dadesProdSession;
                        quantitatVisible2.Visible = true;
                    } else if ( i == 2)
                    {
                        string dadesProdSession;
                        dadesProdSession = nomProductes[2];
                        Session["nom_producte3"] = dadesProdSession;
                        quantitatVisible3.Visible = true;
                    }
                    else
                    {
                        string dadesProdSession;
                        dadesProdSession = nomProductes[3];
                        Session["nom_producte4"] = dadesProdSession;
                        quantitatVisible4.Visible = true;
                    }

                    ((Label)this.FindControl("label_prod" + estocProd)).Text = producte;
                    estocProd++;
                    i++;
                    prodDisponible++;
                }
                else
                {
                    botons[i].Visible = false;
                    quantitats[i].Visible = false;
                    estocProd++;
                    i++;
                }

            }
            catch (IOException exc)
            {
                System.Diagnostics.Debug.WriteLine(exc.Message); // Missatge per terminal en cas de fallar la lectura
            }
            return resultat;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string imatgeProd = "/Productes/producte1.jpg";

            string nomProd;
            nomProd = (string)Session["nom_producte1"];

            valueSession[0] = imatgeProd;
            valueSession[1] = nomProd;
            valueSession[2] = quantitat1.Text;

            // La session "valors_matriu" serà accessible sempre, encara que es recarregui la pàgina diverses vegades
            Session["productes_afegits1"] = valueSession;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string imatgeProd = "/Productes/producte2.jpg";

            string nomProd;
            nomProd = (string)Session["nom_producte2"];

            valueSession[0] = imatgeProd;
            valueSession[1] = nomProd;
            valueSession[2] = quantitat2.Text;

            // La session "valors_matriu" serà accessible sempre, encara que es recarregui la pàgina diverses vegades
            Session["productes_afegits2"] = valueSession;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string imatgeProd = "/Productes/producte3.jpg";

            string nomProd;
            nomProd = (string)Session["nom_producte3"];

            valueSession[0] = imatgeProd;
            valueSession[1] = nomProd;
            valueSession[2] = quantitat3.Text;

            // La session "valors_matriu" serà accessible sempre, encara que es recarregui la pàgina diverses vegades
            Session["productes_afegits3"] = valueSession;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            string imatgeProd = "/Productes/producte4.jpg";

            string nomProd;
            nomProd = (string)Session["nom_producte4"];

            valueSession[0] = imatgeProd;
            valueSession[1] = nomProd;
            valueSession[2] = quantitat4.Text;

            // La session "valors_matriu" serà accessible sempre, encara que es recarregui la pàgina diverses vegades
            Session["productes_afegits4"] = valueSession;
        }
    }
}