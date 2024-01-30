using System;
using System.Collections.Generic;
using System.IO;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using NE.CLib;
using NE.CLib.Linq;
using Seguridad.Servicio;
using UTO;
using UTO.Comercializacion;

public partial class Comercializacion_EncuestaRegistroCargue : BaseModulo
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void buttonProcesarArchivo_Click(object sender, EventArgs e)
    {
        try
        {
            this.labelResult.Text = string.Empty;
            //ControlError1.Visible = false;
            // Se valida la seleccion de un archivo
            if (!this.fluArchivoCargue.HasFile)
            {
                throw new Exception("Debe seleccionar un archivo");
            }
            else
            {
                ImportarComercio importarComercio = new ImportarComercio(this.fluArchivoCargue.PostedFile.InputStream, MyDataContext, this.Usuario);
                string result = importarComercio.Ejecutar();
                this.labelResult.Text = result.ToString();

            }

        }
        catch (Exception exe)
        {
            ControlError1.Visible = true;
            ControlError1.Show(exe);
        }
       
    }
    protected void buttoncancelar_Click(object sender, EventArgs e) { this.Response.Redirect("~/Comercializacion/EncuestaBuscar.aspx"); }
}