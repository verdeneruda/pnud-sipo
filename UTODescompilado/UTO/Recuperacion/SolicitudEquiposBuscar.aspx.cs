// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.SolicitudEquiposBuscar
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using NE.CLib.Linq;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace UTO.Recuperacion
{
  public class SolicitudEquiposBuscar : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaSolicitudesEquipos;
    protected ControlError ControlError1;
    protected Label labelparametros;
    protected Label labelDepartamento;
    protected DropDownList comboDepartamento;
    protected Label labelCiudad;
    protected DropDownList comboCiudad;
    protected Label labelRegional;
    protected DropDownList comboRegional;
    protected Label labelNombreBeneficiario;
    protected TextBox textNombreBeneficiario;
    protected Label labelTipoDocumento;
    protected DropDownList comboTipoDocumento;
    protected Label labelDocumento;
    protected TextBox textDocumento;
    protected Label label2;
    protected DropDownList comboEstado;
    protected Label label3;
    protected CheckBoxList checkTipo;
    protected Label labelFechaInicial;
    protected TextBox textFechaInicial;
    protected CalendarExtender calendarfecha;
    protected Button buttonBuscar;
    protected Button buttonAdicionar;
    protected GridView gridBuscarSolicitudEquipos;
    protected SqlDataSource solicitudEquiposBuscarDataSource;

    private int proyectoId
    {
      get => Convert.ToInt32(this.ViewState["SolicitudEquipo.Tipo"] ?? (object) 0);
      set => this.ViewState["SolicitudEquipo.Tipo"] = (object) value;
    }

    private int audEliminar
    {
      get => Convert.ToInt32(this.ViewState["SolicitudEquipo.audEliminar"] ?? (object) 0);
      set => this.ViewState["SolicitudEquipo.audEliminar"] = (object) value;
    }

    protected new void Page_Load(object sender, EventArgs e)
    {
      if (!this.IsPostBack)
      {
        this.proyectoId = this.Request.QueryString["tipo"] == null ? 1 : Convert.ToInt32(this.Request.QueryString["tipo"]);
        this.InitData();
      }
      switch (this.proyectoId)
      {
        case 1:
          this.labelBusquedaSolicitudesEquipos.Text = "Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Recuperación, reciclaje y regeneración de gases refrigerantes - Buscar solicitud equipos";
          this.buttonAdicionar.Visible = this.Usuario.permiteOperacion(EPermiso.AdicionarSolicitudDeEquipos);
          this.gridBuscarSolicitudEquipos.Columns[0].Visible = this.Usuario.permiteOperacion(EPermiso.ModificarSolicitudEquipos);
          this.gridBuscarSolicitudEquipos.Columns[1].Visible = this.Usuario.permiteOperacion(EPermiso.EliminarSolicitudEquipos);
          this.gridBuscarSolicitudEquipos.Columns[2].Visible = this.Usuario.permiteOperacion(EPermiso.BuscarSolicitudDeEquipos);
          this.audEliminar = 804;
          break;
        case 2:
          this.labelBusquedaSolicitudesEquipos.Text = "Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Kit de barrido y limpieza con nitrógeno y filtros de alto rendimiento - Eliminación del R-141b en Actividades de Limpieza - Buscar solicitud equipos";
          this.buttonAdicionar.Visible = this.Usuario.permiteOperacion(EPermiso.AdicionarSolicitudDeEquipos);
          this.gridBuscarSolicitudEquipos.Columns[0].Visible = this.Usuario.permiteOperacion(EPermiso.ModificarSolicitudEquipos);
          this.gridBuscarSolicitudEquipos.Columns[1].Visible = this.Usuario.permiteOperacion(EPermiso.EliminarSolicitudEquipos);
          this.gridBuscarSolicitudEquipos.Columns[2].Visible = this.Usuario.permiteOperacion(EPermiso.BuscarSolicitudDeEquipos);
          this.audEliminar = 804;
          break;
        case 3:
          this.labelBusquedaSolicitudesEquipos.Text = "Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Centros de regeneración - Buscar solicitud equipos";
          this.buttonAdicionar.Visible = this.Usuario.permiteOperacion(EPermiso.AdicionarReportesCentroDeRegeneracion);
          this.gridBuscarSolicitudEquipos.Columns[0].Visible = this.Usuario.permiteOperacion(EPermiso.ModificarReportesCentroDeRegeneracion);
          this.gridBuscarSolicitudEquipos.Columns[1].Visible = this.Usuario.permiteOperacion(EPermiso.EliminarReportesCentroDeRegeneracion);
          this.gridBuscarSolicitudEquipos.Columns[2].Visible = this.Usuario.permiteOperacion(EPermiso.BuscarReportesCentroDeRegeneracion);
          this.audEliminar = 818;
          break;
        case 4:
          this.labelBusquedaSolicitudesEquipos.Text = "Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Centros de acopio - Buscar solicitud equipos";
          this.buttonAdicionar.Visible = this.Usuario.permiteOperacion(EPermiso.AdicionarSolicitudCentroAcopio);
          this.gridBuscarSolicitudEquipos.Columns[0].Visible = this.Usuario.permiteOperacion(EPermiso.ModificarSolicitudCentroAcopio);
          this.gridBuscarSolicitudEquipos.Columns[1].Visible = this.Usuario.permiteOperacion(EPermiso.EliminarSolicitudCentroAcopio);
          this.gridBuscarSolicitudEquipos.Columns[2].Visible = this.Usuario.permiteOperacion(EPermiso.BuscarSolicitudCentroAcopio);
          this.audEliminar = 838;
          break;
      }
    }

    public void InitData()
    {
      this.comboDepartamento.DataSource = (object) CLinq.ListAll<dep_Departamento>((DataContext) this.MyDataContext);
      this.comboDepartamento.DataBind();
      this.comboDepartamento.Items.Insert(0, "");
      this.comboRegional.DataSource = (object) CLinq.ListAll<reg_Regional>((DataContext) this.MyDataContext);
      this.comboRegional.DataBind();
      this.comboRegional.Items.Insert(0, "");
      this.comboEstado.DataSource = (object) CLinq.ListAll<ses_SolicitudEstado>((DataContext) this.MyDataContext);
      this.comboEstado.DataBind();
      this.comboEstado.Items.Insert(0, "");
      this.comboTipoDocumento.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>((DataContext) this.MyDataContext);
      this.comboTipoDocumento.DataBind();
      this.comboTipoDocumento.Items.Insert(0, "");
    }

    protected void buttonBuscar_Click(object sender, EventArgs e)
    {
      DateTime dateTime = DateTime.Parse("1900-01-01");
      int num = 0;
      if (this.textFechaInicial.Text != "")
        dateTime = DateTime.Parse(this.textFechaInicial.Text);
      foreach (ListItem listItem in this.checkTipo.Items)
      {
        if (listItem.Selected)
          num += int.Parse(listItem.Value);
      }
      this.solicitudEquiposBuscarDataSource.SelectParameters["departamento"].DefaultValue = this.comboDepartamento.SelectedValue != "" ? this.comboDepartamento.SelectedValue : "0";
      this.solicitudEquiposBuscarDataSource.SelectParameters["municipio"].DefaultValue = this.comboCiudad.SelectedValue != "" ? this.comboCiudad.SelectedValue : "0";
      this.solicitudEquiposBuscarDataSource.SelectParameters["regional"].DefaultValue = this.comboRegional.SelectedValue != "" ? this.comboRegional.SelectedValue : "0";
      this.solicitudEquiposBuscarDataSource.SelectParameters["beneficiario"].DefaultValue = this.textNombreBeneficiario.Text != "" ? this.textNombreBeneficiario.Text : "%";
      this.solicitudEquiposBuscarDataSource.SelectParameters["fechaInicial"].DefaultValue = this.textFechaInicial.Text != "" ? dateTime.ToString("MM/dd/yyyy") : "1/1/1900";
      this.solicitudEquiposBuscarDataSource.SelectParameters["estado"].DefaultValue = this.comboEstado.SelectedValue != "" ? this.comboEstado.SelectedValue : "0";
      this.solicitudEquiposBuscarDataSource.SelectParameters["tipo"].DefaultValue = num.ToString();
      this.solicitudEquiposBuscarDataSource.SelectParameters["tipoDoc"].DefaultValue = this.comboTipoDocumento.SelectedValue != "" ? this.comboTipoDocumento.SelectedValue : "0";
      this.solicitudEquiposBuscarDataSource.SelectParameters["documento"].DefaultValue = this.textDocumento.Text != "" ? this.textDocumento.Text : "%";
      this.solicitudEquiposBuscarDataSource.SelectParameters["proyecto"].DefaultValue = this.proyectoId.ToString();
    }

    protected void buttonAdicionar_Click(object sender, EventArgs e)
    {
      this.SendParams = (object) new BaseModulo.strSendParam()
      {
        id = 0,
        tipo = ""
      };
      this.Server.Transfer("~/Recuperacion/SolicitudEquiposRegistrar.aspx?tipo=" + this.proyectoId.ToString());
    }

    protected void gridBuscarSolicitudEquipos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (e.CommandName.Equals("Modificar"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarSolicitudEquipos.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Modificar"
        };
        if (this.proyectoId == 1)
          this.Server.Transfer("~/Recuperacion/SolicitudEquiposRegistrar.aspx");
        else
          this.Server.Transfer("~/Recuperacion/SolicitudEquiposRegistrar.aspx?tipo=" + this.proyectoId.ToString());
      }
      if (e.CommandName.Equals("Ver"))
      {
        this.SendParams = (object) new BaseModulo.strSendParam()
        {
          id = int.Parse(this.gridBuscarSolicitudEquipos.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString()),
          tipo = "Ver"
        };
        if (this.proyectoId == 1)
          this.Server.Transfer("~/Recuperacion/SolicitudEquiposRegistrar.aspx");
        else
          this.Server.Transfer("~/Recuperacion/SolicitudEquiposRegistrar.aspx?tipo=" + this.proyectoId.ToString());
      }
      if (!e.CommandName.Equals("Eliminar"))
        return;
      int keyValue = int.Parse(this.gridBuscarSolicitudEquipos.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString());
      seq_SolicitudEquipo byKey = CLinq.FindByKey<seq_SolicitudEquipo>((DataContext) this.MyDataContext, (object) keyValue);
      string terNumeroDocumento = byKey.ter_Tercero.ter_NumeroDocumento;
      try
      {
        if (byKey.ses_Id > 2)
          throw new Exception("" + "No puede eliminar esta solicitud porque esta en proceso de aprobación. <br />");
        this.ControlError1.Visible = false;
        int pageIndex = this.gridBuscarSolicitudEquipos.PageIndex;
        int pageSize = this.gridBuscarSolicitudEquipos.PageSize;
        int num = int.Parse((string) e.CommandArgument) - pageIndex * pageSize;
        SqlConnection sqlConnection = new SqlConnection(this.MyDataContext.Connection.ConnectionString);
        sqlConnection.Open();
        SqlCommand sqlCommand = new SqlCommand();
        sqlCommand.Connection = sqlConnection;
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.CommandText = "Rrr.spEliminarSolicitud";
        SqlParameter sqlParameter = new SqlParameter();
        sqlParameter.ParameterName = "@id";
        sqlParameter.SqlDbType = SqlDbType.Int;
        sqlParameter.Direction = ParameterDirection.Input;
        sqlParameter.Value = (object) keyValue;
        sqlCommand.Parameters.Add(sqlParameter);
        sqlCommand.ExecuteNonQuery();
        sqlConnection.Close();
        this.gridBuscarSolicitudEquipos.DataSource = (object) null;
        this.gridBuscarSolicitudEquipos.DataBind();
        this.gridBuscarSolicitudEquipos.DataSource = (object) null;
        this.gridBuscarSolicitudEquipos.DataBind();
        CAuditoria.log((EPermiso) this.audEliminar, keyValue.ToString(), terNumeroDocumento, "", "", "", this.Usuario.id);
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    protected void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e) => this.listarMunicipio(this.comboDepartamento.SelectedValue);

    protected void listarMunicipio(string departamento)
    {
      List<mun_Municipio> munMunicipioList = CLinq.ListByProperty<mun_Municipio>((DataContext) this.MyDataContext, "dep_Id", (object) departamento);
      this.comboCiudad.SelectedValue = (string) null;
      if (munMunicipioList.Count > 0)
      {
        this.comboCiudad.DataSource = (object) munMunicipioList;
        this.comboCiudad.DataBind();
        this.comboCiudad.Items.Insert(0, "");
      }
      else
        this.comboCiudad.Items.Insert(0, "");
    }
  }
}
