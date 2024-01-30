using System;
using UTO.ImportacionExportacion;

public partial class ImportacionExportacion_RegistroExportacionCargue : BaseModulo
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
                ImportarComercio importarComercio = new ImportarExportacion(this.fluArchivoCargue.PostedFile.InputStream, MyDataContext, this.Usuario);
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

    protected void buttonCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegistroExportacionBuscar.aspx", false);
    }
}