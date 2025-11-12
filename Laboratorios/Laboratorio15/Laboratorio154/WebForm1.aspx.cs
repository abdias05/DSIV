using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Laboratorio154
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        public object MessageBox { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int num1 = 0; 
            int num2 = 0;
       
            try
            {
                 num1 = Convert.ToInt32(TextBox1.Text);

            }
            catch (FormatException)
            {
                string texto = "Error: numero invalido";
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "MessageBoxScript","window.alert('" + texto + "');",true);
            }

            catch (OverflowException)
            {
                String texto = "Error: el numero es demasiado grande";
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "MessageBoxScript", "window.alert('" + texto + "');", true);
            }

            try
            {
                 num2 = Convert.ToInt32(TextBox2.Text);

            }
            catch (FormatException)
            {
                string texto2 = "Error: numero invalido";
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "MessageBoxScript", "window.alert('" + texto2 + "');", true);
            }

            catch (OverflowException)
            {
                String texto2 = "Error: el numero es demasiado grande";
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "MessageBoxScript", "window.alert('" + texto2 + "');", true);
            }

            suma= num1 + num2;

            Label1.Text = "El resultado es = " + suma.ToString() + "";            
        }
    }
}