// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.ConsultaFicha
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using AjaxControlToolkit;
using DevExpress.Web;
using NE.CLib.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTO.Recuperacion
{
  public class ConsultaFicha : BaseModulo
  {
    protected ToolkitScriptManager ToolkitScriptManager1;
    protected Label labelBusquedaSolicitudesEquipos;
    protected ControlError ControlError1;
    protected Panel PanelBuscarTercero;
    protected Label labelparametros;
    protected Label labelNombreBeneficiario;
    protected TextBox textNombreBeneficiarioBuscar;
    protected Label label3;
    protected DropDownList comboTipoDocumentoBuscar;
    protected Label labelNumeroDocumento;
    protected TextBox textNumeroDocumentoBuscar;
    protected Button buttonBuscarTercero;
    protected Button buttonExportar;
    protected ASPxGridView gvConsulta;
    protected ASPxGridViewExporter exportGrid;
    protected GridView GridViewTerceroBuscar;
    protected SqlDataSource dsBuscarTercero;
    protected Button buttonVolver;
    protected Literal literalHTML;

    private int proyectoId
    {
      get => Convert.ToInt32(this.ViewState["SolicitudEquipo.Tipo"] ?? (object) 0);
      set => this.ViewState["SolicitudEquipo.Tipo"] = (object) value;
    }

    protected new void Page_Load(object sender, EventArgs e)
    {
      if (!this.IsPostBack)
      {
        this.proyectoId = this.Request.QueryString["tipo"] == null ? 0 : Convert.ToInt32(this.Request.QueryString["tipo"]);
        this.InitData();
      }
      switch (this.proyectoId)
      {
        case 0:
          this.labelBusquedaSolicitudesEquipos.Text = "Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Recuperación, reciclaje y regeneración de gases refrigerantes - Consulta";
          break;
        case 1:
          this.labelBusquedaSolicitudesEquipos.Text = "Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Kit de barrido y limpieza con nitrógeno y filtros de alto rendimiento - Eliminación del R-141b en Actividades de Limpieza - Consulta";
          break;
        case 2:
          this.labelBusquedaSolicitudesEquipos.Text = "Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Centros de regeneración - Consulta";
          break;
        case 3:
          this.labelBusquedaSolicitudesEquipos.Text = "Proyectos de dotación de equipos y herramientas  para el sector de refrigeración y aire acondicionado - Centros de acopio - Consulta";
          break;
      }
    }

    private void InitData()
    {
      this.comboTipoDocumentoBuscar.DataSource = (object) CLinq.ListAll<dti_DocumentoTipo>((DataContext) this.MyDataContext);
      this.comboTipoDocumentoBuscar.DataBind();
      this.comboTipoDocumentoBuscar.Items.Insert(0, "");
    }

    protected void buttonBuscarTercero_Click(object sender, EventArgs e)
    {
      DataView dataView = new DataView();
      try
      {
        this.dsBuscarTercero.SelectParameters["beneficiario"].DefaultValue = this.textNombreBeneficiarioBuscar.Text == "" ? "%" : this.textNombreBeneficiarioBuscar.Text;
        this.dsBuscarTercero.SelectParameters["documento"].DefaultValue = this.textNumeroDocumentoBuscar.Text == "" ? "%" : this.textNumeroDocumentoBuscar.Text;
        this.dsBuscarTercero.SelectParameters["tipoDocumento"].DefaultValue = this.comboTipoDocumentoBuscar.SelectedValue == "" ? "0" : this.comboTipoDocumentoBuscar.SelectedValue;
        this.dsBuscarTercero.SelectParameters["tipo"].DefaultValue = (this.proyectoId + 1).ToString();
        if (((DataView) this.dsBuscarTercero.Select((DataSourceSelectArguments) null)).Count == 0)
          throw new Exception("La búsqueda no encontró resultados.");
      }
      catch (Exception ex)
      {
      }
    }

    protected void GridViewTerceroBuscar_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      try
      {
        if (!e.CommandName.Equals("Seleccionar"))
          return;
        this.PanelBuscarTercero.Visible = false;
        this.GenerarHTML(CLinq.FindByKey<ter_Tercero>((DataContext) this.MyDataContext, (object) int.Parse(this.GridViewTerceroBuscar.DataKeys[int.Parse((string) e.CommandArgument)].Value.ToString())));
      }
      catch (Exception ex)
      {
        this.ControlError1.Visible = true;
        this.ControlError1.Show(ex);
      }
    }

    private void GenerarHTML(ter_Tercero tercero)
    {
      List<seq_SolicitudEquipo> list1 = CLinq.FindByProperty<seq_SolicitudEquipo>((DataContext) this.MyDataContext, "ter_id", (object) tercero.ter_Id).ToList<seq_SolicitudEquipo>();
      List<rcd_ReporteCentroRegeneracionDetalle> list2 = this.MyDataContext.rcd_ReporteCentroRegeneracionDetalles.Where<rcd_ReporteCentroRegeneracionDetalle>((Expression<System.Func<rcd_ReporteCentroRegeneracionDetalle, bool>>) (a => a.rcd_Tercero == tercero.ter_NombreCompleto)).OrderByDescending<rcd_ReporteCentroRegeneracionDetalle, DateTime>((Expression<System.Func<rcd_ReporteCentroRegeneracionDetalle, DateTime>>) (a => a.rcd_Fecha)).ToList<rcd_ReporteCentroRegeneracionDetalle>();
      List<rad_ReporteCentroAcopioDetalle> list3 = this.MyDataContext.rad_ReporteCentroAcopioDetalles.Where<rad_ReporteCentroAcopioDetalle>((Expression<System.Func<rad_ReporteCentroAcopioDetalle, bool>>) (a => a.rad_Tercero == tercero.ter_NombreCompleto)).OrderByDescending<rad_ReporteCentroAcopioDetalle, DateTime>((Expression<System.Func<rad_ReporteCentroAcopioDetalle, DateTime>>) (a => a.rad_Fecha)).ToList<rad_ReporteCentroAcopioDetalle>();
      List<rdu_ReporteUso> list4 = this.MyDataContext.rdu_ReporteUsos.Where<rdu_ReporteUso>((Expression<System.Func<rdu_ReporteUso, bool>>) (a => a.ter_Id == tercero.ter_Id)).ToList<rdu_ReporteUso>().OrderByDescending<rdu_ReporteUso, string>((System.Func<rdu_ReporteUso, string>) (a => a.OrdenAno)).ToList<rdu_ReporteUso>();
      List<rdb_ReporteUsoBarrido> listaReporteUsoBarrido = this.MyDataContext.rdb_ReporteUsoBarridos.Where<rdb_ReporteUsoBarrido>((Expression<System.Func<rdb_ReporteUsoBarrido, bool>>) (a => a.ter_Id == tercero.ter_Id)).ToList<rdb_ReporteUsoBarrido>();
      listaReporteUsoBarrido = listaReporteUsoBarrido.OrderByDescending<rdb_ReporteUsoBarrido, string>((System.Func<rdb_ReporteUsoBarrido, string>) (a => a.OrdenAno)).ToList<rdb_ReporteUsoBarrido>();
      this.LocalInfo.SetData("idTercero", (object) tercero.ter_Id);
      string str1 = "" + " <link href=\"~/App_Themes/reportes.css\" rel=\"stylesheet\" type=\"text/css\" />" + "<table width=\"100%\" border=\"1\" class=\"tablaInforme\"> " + "<tr><th>INFORMACION DEL TERCERO</th></tr>" + "<tr><td class=\"labelInforme\" >Nombre</td><td colspan=\"3\">" + tercero.ter_NombreCompleto + "</td></tr>" + "<tr><td class=\"labelInforme\">Tipo de documento</td><td>" + tercero.dti_DocumentoTipo.dti_Descripcion + "</td><td class=\"labelInforme\">Documento</td><td>" + tercero.ter_NumeroDocumento + "</td></tr>" + "<tr><td class=\"labelInforme\">E-mail</td><td>" + tercero.ter_Correo + "</td><td class=\"labelInforme\">Dirección</td><td>" + tercero.ter_Direccion + "</td></tr>" + "<tr><td class=\"labelInforme\">Departamento</td><td>" + tercero.dep_Departamento.dep_Descripcion + "</td><td class=\"labelInforme\">Ciudad</td><td>" + tercero.mun_Municipio.mun_Descripcion + "</td></tr>" + "<tr><td class=\"labelInforme\">Teléfono</td><td>" + tercero.ter_Tefono + "</td><td class=\"labelInforme\">Fax</td><td>" + tercero.ter_Fax + "</td></tr>" + "<tr><td class=\"labelInforme\">Celular</td><td>" + tercero.ter_Celular + "</td><td class=\"labelInforme\">RUT</td><td>" + tercero.ter_Rut + "</td></tr>" + "<tr><th>&nbsp</th></tr>" + "<tr><th>SOLICITUDES</th></tr>";
      if (list1.Count != 0)
      {
        for (int index1 = 0; index1 < list1.Count; ++index1)
        {
          List<sea_SolicitudEquiposAsignado> list5 = CLinq.FindByProperty<sea_SolicitudEquiposAsignado>((DataContext) this.MyDataContext, "seq_id", (object) list1[index1].seq_Id).ToList<sea_SolicitudEquiposAsignado>();
          string str2 = str1 + "<tr><td colspan=\"4\"><table width=\"100%\" border=\"1\" class=\"tablaInforme\">" + "<tr><th>Solicitud " + (index1 + 1).ToString() + "</th></tr>" + "<tr><td class=\"labelInforme\">Fecha de solicitud</td><td>" + list1[index1].seq_FechaSolicitud.ToString("dd/MM/yyyy") + "</td><td class=\"labelInforme\">proyecto</td><td>" + list1[index1].pre_ProyectoRecuperacion.pre_Descripcion + "</td></tr>";
          if (list5.Count > 0)
          {
            string str3 = str2 + "<tr><th>LISTA DE EQUIPOS</th></tr>" + "<tr><td colspan=\"4\"><table width=\"100%\" border=\"1\" class=\"tablaInforme\">" + "<tr><td>Equipo</td><td>Cantidad</td></tr>";
            for (int index2 = 0; index2 < list5.Count; ++index2)
              str3 = str3 + "<tr><td>" + list5[index2].eki_EquipoKit.eki_Nombre + "</td><td>" + list5[index2].sea_Cantidad.ToString() + "</td></tr>";
            str2 = str3 + "</table></td></tr>";
          }
          str1 = str2 + "</table></td></tr>";
        }
      }
      else
        str1 += "<tr><th>No hay solicitudes de equipos</th></tr>";
      string str4 = str1 + "<tr><th>REPORTES DE USO RRR</th></tr>";
      string str5;
      if (list4.Count != 0)
      {
        string str6 = str4 + "<tr><td colspan=\"4\"><table width=\"100%\" border=\"1\" class=\"tablaInforme\">" + "<tr><td>Periodo</td><td>Año</td><td>Sustancias reportadas</td></tr>";
        for (int index3 = 0; index3 < list4.Count; ++index3)
        {
          string str7 = str6 + "<tr><td>" + list4[index3].rdu_Periodo.ToUpper() + "</td><td>" + (object) list4[index3].rdu_Ano + "</td><td>";
          if (list4[index3].rdt_ReporteUsoDetalles.Count > 0)
          {
            for (int index4 = 0; index4 < list4[index3].rdt_ReporteUsoDetalles.Count; ++index4)
              str7 = str7 + "<li>" + list4[index3].rdt_ReporteUsoDetalles[index4].gti_GasTipo.gti_Descripcion + "; " + list4[index3].rdt_ReporteUsoDetalles[index4].gus_GasUso.gus_Descripcion + "; " + list4[index3].rdt_ReporteUsoDetalles[index4].rdt_Cantidad.ToString() + "kg" + "</li>";
          }
          else
            str7 += "&nbsp;";
          str6 = str7 + "</td></tr>";
        }
        str5 = str6 + "</table></td></tr>";
      }
      else
        str5 = str4 + "<tr><th>No hay reportes al respecto</th></tr>";
      string str8 = str5 + "<tr><th>REPORTES DE USO BARRIDO</th></tr>";
      string str9;
      if (listaReporteUsoBarrido.Count != 0)
      {
        string str10 = str8 + "<tr><td colspan=\"4\"><table width=\"100%\" border=\"1\" class=\"tablaInforme\">" + "<tr><td>Periodo</td><td>Año</td><td>Reporte</td></tr>";
        for (int j = 0; j < listaReporteUsoBarrido.Count; ++j)
          str10 = str10 + "<tr><td>" + listaReporteUsoBarrido[j].rdb_Periodo.ToUpper() + "</td><td>" + (object) listaReporteUsoBarrido[j].rdb_Ano + "</td><td>" + "<li style=\"list-style: none;\"><b>Nitrógeno utilizado</b></li>" + "<li>Número de cilindros: " + listaReporteUsoBarrido[j].rdb_NitrogenoCilindro.ToString() + "</li>" + "<li>Cantidad de nitrógeno (kg): " + listaReporteUsoBarrido[j].rdb_NitrogenoKilo.ToString() + "</li>" + "<li>Tipo de mantenimiento: " + this.MyDataContext.tim_TipoMantenimientos.FirstOrDefault<tim_TipoMantenimiento>((Expression<System.Func<tim_TipoMantenimiento, bool>>) (a => a.tim_Id == listaReporteUsoBarrido[j].tim_IdNitrogeno)).tim_Descripcion + "</li>" + "<li>Observaciones: " + listaReporteUsoBarrido[j].rdb_NitrogenoObservacion + "</li>" + "<li style=\"list-style: none;\"><b>Filtros de alto rendimiento utilizados</b></li>" + "<li>Unidades: " + listaReporteUsoBarrido[j].rdb_FiltroUnidad.ToString() + "</li>" + "<li>Tipo de mantenimiento: " + this.MyDataContext.tim_TipoMantenimientos.FirstOrDefault<tim_TipoMantenimiento>((Expression<System.Func<tim_TipoMantenimiento, bool>>) (a => a.tim_Id == listaReporteUsoBarrido[j].tim_IdFiltro)).tim_Descripcion + "</li>" + "<li>Observaciones: " + listaReporteUsoBarrido[j].rdb_FiltroObservacion + "</li>" + "<li style=\"list-style: none;\"><b>Test de acidez utilizados</b></li>" + "<li>Unidades: " + listaReporteUsoBarrido[j].rdb_AcidezUnidad.ToString() + "</li>" + "<li>Tipo de mantenimiento: " + this.MyDataContext.tim_TipoMantenimientos.FirstOrDefault<tim_TipoMantenimiento>((Expression<System.Func<tim_TipoMantenimiento, bool>>) (a => a.tim_Id == listaReporteUsoBarrido[j].tim_IdAcidez)).tim_Descripcion + "</li>" + "<li>Observaciones: " + listaReporteUsoBarrido[j].rdb_AcidezObservacion + "</li>" + "</td></tr>";
        str9 = str10 + "</table></td></tr>";
      }
      else
        str9 = str8 + "<tr><th>No hay reportes al respecto</th></tr>";
      string str11 = str9 + "<tr><th>CENTROS DE REGENERACIÓN</th></tr>";
      string str12;
      if (list2.Count != 0)
      {
        string str13 = str11 + "<tr><td colspan=\"4\"><table width=\"100%\" border=\"1\" class=\"tablaInforme\">" + "<tr><td>Fecha</td><td>Sustancia</td><td>Cantidad (Kg)</td><td>Centro</td></tr>";
        for (int index = 0; index < list2.Count; ++index)
          str13 = str13 + "<tr><td>" + list2[index].rcd_Fecha.ToString("dd/MM/yyyy") + "</td><td>" + list2[index].gti_GasTipo.gti_Descripcion + "; " + list2[index].gde_GasDestino.gde_Descripcion + "</td><td>" + list2[index].rcd_Cantidad.ToString() + "</td><td>" + list2[index].rcr_ReporteCentroRegeneracion.cre_CentroRegeneracion.cre_Descripcion + "</td></tr>";
        str12 = str13 + "</table></td></tr>";
      }
      else
        str12 = str11 + "<tr><th>No hay reportes al respecto</th></tr>";
      string str14 = str12 + "<tr><th>CENTROS DE ACOPIO</th></tr>";
      string str15;
      if (list3.Count != 0)
      {
        string str16 = str14 + "<tr><td colspan=\"4\"><table width=\"100%\" border=\"1\" class=\"tablaInforme\">" + "<tr><td>Fecha</td><td>Sustancia</td><td>Cantidad (Kg)</td><td>Centro</td></tr>";
        for (int index = 0; index < list3.Count; ++index)
          str16 = str16 + "<tr><td>" + list3[index].rad_Fecha.ToString("dd/MM/yyyy") + "</td><td>" + list3[index].gti_GasTipo.gti_Descripcion + "</td><td>" + list3[index].rad_Cantidad.ToString() + "</td><td>" + list3[index].rca_ReporteCentroAcopio.cea_CentroAcopio.cea_Descripcion + "</td></tr>";
        str15 = str16 + "</table></td></tr>";
      }
      else
        str15 = str14 + "<tr><th>No hay reportes al respecto</th></tr>";
      this.literalHTML.Text = str15 + "</table>";
      this.buttonVolver.Visible = true;
    }

    protected void buttonExportar_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.gvConsulta.Selection.Count == 0)
        {
          this.exportGrid.ExportedRowType = GridViewExportedRowType.All;
          this.exportGrid.FileName = "Conusulta_" + DateTime.Now.ToString("ddMMyyyyHHmmss");
        }
        this.exportGrid.WriteXlsxToResponse();
      }
      catch (Exception ex)
      {
      }
    }

    protected void buttonVolver_Click(object sender, EventArgs e)
    {
      this.literalHTML.Text = "";
      this.PanelBuscarTercero.Visible = true;
      this.buttonVolver.Visible = false;
    }
  }
}
