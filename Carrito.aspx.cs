using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P1_Web_Marc
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            string[] agafarSession1 = (string[])Session["productes_afegits1"];
            string[] agafarSession2 = (string[])Session["productes_afegits2"];
            string[] agafarSession3 = (string[])Session["productes_afegits3"];
            string[] agafarSession4 = (string[])Session["productes_afegits4"];

            if (agafarSession1 != null)
            {
                label1.Visible = true;
                string producteCarrito = "<div class='producte'> " +
                 "<img src =" + agafarSession1[0] + " alt = 'Imatge del producte al Carrito'>" +
                 "<p>" + agafarSession1[1] + "</p>" +
                 "<p>Quantitat: </p><input type = 'number' class='quantitatInd' name='quantitatIndividual' min='0' max='100' value= " + agafarSession1[2] + ">" +
                 "</div>";

                ((Label)this.FindControl("label1")).Text = producteCarrito;
                Button1.Visible = true;

            } else { }


            if (agafarSession2 != null)
            {
                label2.Visible = true;
                string producteCarrito = "<div class='producte'> " +
                     "<img src =" + agafarSession2[0] + " alt = 'Imatge del producte al Carrito'>" +
                     "<p>" + agafarSession2[1] + "</p>" +
                     "<p>Quantitat: </p><input type = 'number' class='quantitatInd' name='quantitatIndividual' min='0' max='100' value= " + agafarSession2[2] + ">" +
                     "</div>";

                    ((Label)this.FindControl("label2")).Text = producteCarrito;
                Button2.Visible = true;
            }
            else { }

            if (agafarSession3 != null)
            {
                label3.Visible = true;
                string producteCarrito = "<div class='producte'> " +
                 "<img src =" + agafarSession3[0] + " alt = 'Imatge del producte al Carrito'>" +
                 "<p>" + agafarSession3[1] + "</p>" +
                 "<p>Quantitat: </p><input type = 'number' class='quantitatInd' name='quantitatIndividual' min='0' max='100' value= " + agafarSession3[2] + ">" +
                 "</div>";

                ((Label)this.FindControl("label3")).Text = producteCarrito;
                Button3.Visible = true;
            }
            else { }


            if (agafarSession4 != null)
            {
                label4.Visible = true;
                string producteCarrito = "<div class='producte'> " +
                 "<img src =" + agafarSession4[0] + " alt = 'Imatge del producte al Carrito'>" +
                 "<p>" + agafarSession4[1] + "</p>" +
                 "<p>Quantitat: </p><input type = 'number' class='quantitatInd' name='quantitatIndividual' min='0' max='100' value= " + agafarSession4[2] + ">" +
                 "</div>";

                ((Label)this.FindControl("label4")).Text = producteCarrito;
                Button4.Visible = true;
            }
            else { }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string eliminarProd = null;
            Session["productes_afegits1"] = eliminarProd;
            label1.Visible = false;
            Button1.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string eliminarProd = null;
            Session["productes_afegits2"] = eliminarProd;
            label2.Visible = false;
            Button2.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string eliminarProd = null;
            Session["productes_afegits3"] = eliminarProd;
            label3.Visible = false;
            Button3.Visible = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string eliminarProd = null;
            Session["productes_afegits4"] = eliminarProd;
            label4.Visible = false;
            Button4.Visible = false;
        }
    }
}