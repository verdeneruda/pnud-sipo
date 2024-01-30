// Decompiled with JetBrains decompiler
// Type: UTO.BasePage
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace UTO
{
  public class BasePage : Page
  {
    private string localGuid;

    protected LocalInformation LocalInfo
    {
      get => (LocalInformation) this.Session[this.LocalGuid];
      set => this.Session[this.LocalGuid] = (object) value;
    }

    protected string LocalGuid
    {
      get => (string) this.ViewState[nameof (LocalGuid)];
      set => this.localGuid = value;
    }

    protected object SendParams
    {
      set => this.Session["Page.Params"] = value;
    }

    protected object MyParams => this.LocalInfo.MyParams;

    protected CUsuario Usuario
    {
      set => this.Session[nameof (Usuario)] = (object) value;
      get => this.Session[nameof (Usuario)] as CUsuario;
    }

    protected List<CPermisos> MapaPermisos
    {
      set => this.Session[nameof (MapaPermisos)] = (object) value;
      get => this.Session[nameof (MapaPermisos)] as List<CPermisos>;
    }

    protected MPMain MyMaster => this.Master as MPMain;

    protected void Page_PreLoad(object sender, EventArgs e)
    {
      bool flag1 = false;
      bool flag2 = false;
      if (this.Usuario == null)
      {
        this.autenticarPublico();
        if (this.Usuario.tienePermisos)
          flag1 = true;
        else
          flag2 = true;
      }
      if (this.MapaPermisos == null)
        this.MapaPermisos = CSeguridad.getPermisosMapa(this.Server.MapPath("~/app_data/mapaPermisos.xml"));
      if (this.MyMaster == null)
        ;
      if (!this.IsPostBack && this.ViewState["LocalGuid"] == null)
      {
        this.ViewState["LocalGuid"] = (object) Guid.NewGuid().ToString();
        this.LocalInfo = new LocalInformation();
        this.LocalInfo.MyDataContext = this.newDataContext(CConfig.readConnString());
        this.LocalInfo.MyParams = this.Session["Page.Params"];
        this.SendParams = (object) null;
      }
      if (flag1)
        this.Response.Redirect("~/Default.aspx");
      if (!flag2)
        return;
      this.Response.Redirect("~/Seguridad/login.aspx");
    }

    protected virtual DataContext newDataContext(string connectionString) => throw new NotImplementedException("Método debe ser sobrecargado");

    protected void Page_Error(object sender, EventArgs e)
    {
      Exception baseException = this.Server.GetLastError().GetBaseException();
      this.Session["PaginaError.MensajeError"] = (object) string.Format("<b>Error en: </b> {0}<br/><b>Mensaje de Error:</b> {1}", (object) this.Request.Url.ToString(), (object) baseException.Message);
      string.Format("{0}Logs\\", (object) HttpRuntime.AppDomainAppPath);
      this.Response.Redirect("~/PaginaError.aspx");
    }

    protected void Clear() => this.Session.Remove(this.LocalGuid);

    protected void autenticarPublico()
    {
      CUsuario cusuario = new CUsuario();
      cusuario.autenticar("publico", "", false);
      this.Usuario = cusuario;
    }

    public void ExportarDv(DataView dv)
    {
      string str = string.Format("Consulta{0}.xls", (object) DateTime.Now.ToShortDateString());
      HttpResponse response = HttpContext.Current.Response;
      response.ContentType = "application/text";
      response.ContentEncoding = Encoding.Unicode;
      response.AddHeader("Content-Disposition", "attachment; filename=" + str);
      if (dv != null)
      {
        int count = dv.Table.Columns.Count;
        for (int index = 0; index < count; ++index)
        {
          response.Write(dv.Table.Columns[index].ColumnName);
          if (index < count - 1)
            response.Write("\t");
        }
        response.Write("\r\n");
        foreach (DataRowView dataRowView in dv)
        {
          for (int ndx = 0; ndx < count; ++ndx)
          {
            string s = dataRowView[ndx].ToString().Replace(Environment.NewLine, " ");
            response.Write(s);
            if (ndx < count - 1)
              response.Write("\t");
          }
          response.Write("\r\n");
        }
      }
      response.End();
    }

    public void Exportar(GridView grid)
    {
      StringBuilder sb = new StringBuilder();
      HtmlTextWriter writer = new HtmlTextWriter((TextWriter) new StringWriter(sb));
      Page page = new Page();
      HtmlForm child = new HtmlForm();
      grid.EnableViewState = false;
      page.EnableEventValidation = false;
      page.DesignerInitialize();
      page.Controls.Add((Control) child);
      child.Controls.Add((Control) grid);
      page.RenderControl(writer);
      this.Response.Clear();
      this.Response.Buffer = true;
      this.Response.ContentType = "application/vnd.ms-excel";
      this.Response.AddHeader("Content-Disposition", "attachment;filename=data.xls");
      this.Response.Charset = "UTF-8";
      this.Response.ContentEncoding = Encoding.Default;
      this.Response.Write(sb.ToString());
      this.Response.End();
    }
  }
}
