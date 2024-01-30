// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.RecuperacionDataContext
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;

namespace UTO.Recuperacion
{
  [Database(Name = "BDUTO")]
  public class RecuperacionDataContext : DataContext
  {
    private static MappingSource mappingSource = (MappingSource) new AttributeMappingSource();

    public RecuperacionDataContext()
      : base(ConfigurationManager.ConnectionStrings["BDUTOConnectionString5"].ConnectionString, RecuperacionDataContext.mappingSource)
    {
    }

    public RecuperacionDataContext(string connection)
      : base(connection, RecuperacionDataContext.mappingSource)
    {
    }

    public RecuperacionDataContext(IDbConnection connection)
      : base(connection, RecuperacionDataContext.mappingSource)
    {
    }

    public RecuperacionDataContext(string connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public RecuperacionDataContext(IDbConnection connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public Table<gde_GasDestino> gde_GasDestinos => this.GetTable<gde_GasDestino>();

    public Table<gti_GasTipo> gti_GasTipos => this.GetTable<gti_GasTipo>();

    public Table<gus_GasUso> gus_GasUsos => this.GetTable<gus_GasUso>();

    public Table<nes_NovedadEstado> nes_NovedadEstados => this.GetTable<nes_NovedadEstado>();

    public Table<nki_NovedadKit> nki_NovedadKits => this.GetTable<nki_NovedadKit>();

    public Table<nti_NovedadTipo> nti_NovedadTipos => this.GetTable<nti_NovedadTipo>();

    public Table<rrd_ReporteRegeneracionDocumento> rrd_ReporteRegeneracionDocumentos => this.GetTable<rrd_ReporteRegeneracionDocumento>();

    public Table<ses_SolicitudEstado> ses_SolicitudEstados => this.GetTable<ses_SolicitudEstado>();

    public Table<ski_SolicitudKit> ski_SolicitudKits => this.GetTable<ski_SolicitudKit>();

    public Table<mun_Municipio> mun_Municipios => this.GetTable<mun_Municipio>();

    public Table<cre_CentroRegeneracion> cre_CentroRegeneracions => this.GetTable<cre_CentroRegeneracion>();

    public Table<bti_beneficiarioTipo> bti_beneficiarioTipos => this.GetTable<bti_beneficiarioTipo>();

    public Table<reg_Regional> reg_Regionals => this.GetTable<reg_Regional>();

    public Table<dti_DocumentoTipo> dti_DocumentoTipos => this.GetTable<dti_DocumentoTipo>();

    public Table<kco_KitCompra> kco_KitCompras => this.GetTable<kco_KitCompra>();

    public Table<pap_ProyectoAprobado> pap_ProyectoAprobados => this.GetTable<pap_ProyectoAprobado>();

    public Table<tpr_TerceroProyecto> tpr_TerceroProyectos => this.GetTable<tpr_TerceroProyecto>();

    public Table<dve_DocumentoVerificar> dve_DocumentoVerificars => this.GetTable<dve_DocumentoVerificar>();

    public Table<dvs_DocumentoVerificarSolicitud> dvs_DocumentoVerificarSolicituds => this.GetTable<dvs_DocumentoVerificarSolicitud>();

    public Table<sdo_SolicitudDocumento> sdo_SolicitudDocumentos => this.GetTable<sdo_SolicitudDocumento>();

    public Table<nea_NovedadEquiposAsignado> nea_NovedadEquiposAsignados => this.GetTable<nea_NovedadEquiposAsignado>();

    public Table<ndo_NovedadDocumento> ndo_NovedadDocumentos => this.GetTable<ndo_NovedadDocumento>();

    public Table<dvn_DocumentoVerificarNovedad> dvn_DocumentoVerificarNovedads => this.GetTable<dvn_DocumentoVerificarNovedad>();

    public Table<psu_PresentacionSustancia> psu_PresentacionSustancias => this.GetTable<psu_PresentacionSustancia>();

    public Table<rud_ReporteUsoDocumento> rud_ReporteUsoDocumentos => this.GetTable<rud_ReporteUsoDocumento>();

    public Table<rcd_ReporteConsolidadoDetalle> rcd_ReporteConsolidadoDetalles => this.GetTable<rcd_ReporteConsolidadoDetalle>();

    public Table<rco_ReporteConsolidadoDocumento> rco_ReporteConsolidadoDocumentos => this.GetTable<rco_ReporteConsolidadoDocumento>();

    public Table<doc_Documento> doc_Documentos => this.GetTable<doc_Documento>();

    public Table<cre_ConsultaRecuperacion> cre_ConsultaRecuperacions => this.GetTable<cre_ConsultaRecuperacion>();

    public Table<neq_NovedadEquipo> neq_NovedadEquipos => this.GetTable<neq_NovedadEquipo>();

    public Table<tgr_TerceroGrupo> tgr_TerceroGrupos => this.GetTable<tgr_TerceroGrupo>();

    public Table<pyg_ProyectoGrupo> pyg_ProyectoGrupos => this.GetTable<pyg_ProyectoGrupo>();

    public Table<ttt_TerceroTipoTercero> ttt_TerceroTipoTerceros => this.GetTable<ttt_TerceroTipoTercero>();

    public Table<rrc_ReporteRegeneracionConsolidado> rrc_ReporteRegeneracionConsolidados => this.GetTable<rrc_ReporteRegeneracionConsolidado>();

    public Table<cti_CorrespondenciaTipo> cti_CorrespondenciaTipos => this.GetTable<cti_CorrespondenciaTipo>();

    public Table<rdt_ReporteUsoDetalle> rdt_ReporteUsoDetalles => this.GetTable<rdt_ReporteUsoDetalle>();

    public Table<rdu_ReporteUso> rdu_ReporteUsos => this.GetTable<rdu_ReporteUso>();

    public Table<rre_ReporteRegeneracion> rre_ReporteRegeneracions => this.GetTable<rre_ReporteRegeneracion>();

    public Table<dep_Departamento> dep_Departamentos => this.GetTable<dep_Departamento>();

    public Table<ter_Tercero> ter_Terceros => this.GetTable<ter_Tercero>();

    public Table<eki_EquipoKit> eki_EquipoKits => this.GetTable<eki_EquipoKit>();

    public Table<lco_LicitacionCompra> lco_LicitacionCompras => this.GetTable<lco_LicitacionCompra>();

    public Table<pre_ProyectoRecuperacion> pre_ProyectoRecuperacions => this.GetTable<pre_ProyectoRecuperacion>();

    public Table<seq_SolicitudEquipo> seq_SolicitudEquipos => this.GetTable<seq_SolicitudEquipo>();

    public Table<rdb_ReporteUsoBarrido> rdb_ReporteUsoBarridos => this.GetTable<rdb_ReporteUsoBarrido>();

    public Table<tim_TipoMantenimiento> tim_TipoMantenimientos => this.GetTable<tim_TipoMantenimiento>();

    public Table<rbd_ReporteUsoBarridoDocumento> rbd_ReporteUsoBarridoDocumentos => this.GetTable<rbd_ReporteUsoBarridoDocumento>();

    public Table<rcr_ReporteCentroRegeneracion> rcr_ReporteCentroRegeneracions => this.GetTable<rcr_ReporteCentroRegeneracion>();

    public Table<rcd_ReporteCentroRegeneracionDetalle> rcd_ReporteCentroRegeneracionDetalles => this.GetTable<rcd_ReporteCentroRegeneracionDetalle>();

    public Table<cea_CentroAcopio> cea_CentroAcopios => this.GetTable<cea_CentroAcopio>();

    public Table<rca_ReporteCentroAcopio> rca_ReporteCentroAcopios => this.GetTable<rca_ReporteCentroAcopio>();

    public Table<rad_ReporteCentroAcopioDetalle> rad_ReporteCentroAcopioDetalles => this.GetTable<rad_ReporteCentroAcopioDetalle>();

    public Table<sea_SolicitudEquiposAsignado> sea_SolicitudEquiposAsignados => this.GetTable<sea_SolicitudEquiposAsignado>();

    [Function(Name = "Uto.spComboAno")]
    public ISingleResult<spComboAnoResult> spComboAno([Parameter(DbType = "Int")] int? antes, [Parameter(DbType = "Int")] int? despues) => (ISingleResult<spComboAnoResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) antes, (object) despues).ReturnValue;

    [Function(Name = "Rrr.spReporteUsoBuscar")]
    public ISingleResult<spReporteUsoBuscarResult> spReporteUsoBuscar(
      [Parameter(DbType = "VarChar(2)")] string departamento,
      [Parameter(DbType = "VarChar(5)")] string municipio,
      [Parameter(DbType = "Int")] int? regional,
      [Parameter(DbType = "VarChar(255)")] string beneficiario,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal,
      [Parameter(DbType = "Int")] int? anno,
      [Parameter(DbType = "VarChar(255)")] string contrato)
    {
      return (ISingleResult<spReporteUsoBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) departamento, (object) municipio, (object) regional, (object) beneficiario, (object) fechaInicial, (object) fechaFinal, (object) anno, (object) contrato).ReturnValue;
    }

    [Function(Name = "Rrr.spReporteCentroBuscar")]
    public ISingleResult<spReporteCentroBuscarResult> spReporteCentroBuscar(
      [Parameter(DbType = "Int")] int? centro,
      [Parameter(DbType = "VarChar(255)")] string beneficiario,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal)
    {
      return (ISingleResult<spReporteCentroBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) centro, (object) beneficiario, (object) fechaInicial, (object) fechaFinal).ReturnValue;
    }

    [Function(Name = "Rrr.spConsultaNovedad")]
    public ISingleResult<spConsultaNovedadResult> spConsultaNovedad(
      [Parameter(DbType = "VarChar(2)")] string departamento,
      [Parameter(DbType = "VarChar(5)")] string municipio,
      [Parameter(DbType = "Int")] int? regional,
      [Parameter(DbType = "VarChar(255)")] string beneficiario,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal)
    {
      return (ISingleResult<spConsultaNovedadResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) departamento, (object) municipio, (object) regional, (object) beneficiario, (object) fechaInicial, (object) fechaFinal).ReturnValue;
    }

    [Function(Name = "Rrr.spConsultaPoliza")]
    public ISingleResult<spConsultaPolizaResult> spConsultaPoliza(
      [Parameter(DbType = "VarChar(2)")] string departamento,
      [Parameter(DbType = "VarChar(5)")] string municipio,
      [Parameter(DbType = "Int")] int? regional,
      [Parameter(DbType = "VarChar(255)")] string beneficiario,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal)
    {
      return (ISingleResult<spConsultaPolizaResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) departamento, (object) municipio, (object) regional, (object) beneficiario, (object) fechaInicial, (object) fechaFinal).ReturnValue;
    }

    [Function(Name = "Rrr.spConsultaReporteUso")]
    public int spConsultaReporteUso(
      [Parameter(DbType = "VarChar(2)")] string departamento,
      [Parameter(DbType = "VarChar(5)")] string municipio,
      [Parameter(DbType = "Int")] int? regional,
      [Parameter(DbType = "VarChar(255)")] string beneficiario,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal,
      [Parameter(DbType = "Int")] int? anno)
    {
      return (int) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) departamento, (object) municipio, (object) regional, (object) beneficiario, (object) fechaInicial, (object) fechaFinal, (object) anno).ReturnValue;
    }

    [Function(Name = "Rrr.spConsultaReporteRegeneracion")]
    public ISingleResult<spConsultaReporteRegeneracionResult> spConsultaReporteRegeneracion(
      [Parameter(DbType = "VarChar(255)")] string beneficiario,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal)
    {
      return (ISingleResult<spConsultaReporteRegeneracionResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) beneficiario, (object) fechaInicial, (object) fechaFinal).ReturnValue;
    }

    [Function(Name = "Rrr.spSolicitudEquipoBuscar")]
    public ISingleResult<spSolicitudEquipoBuscarResult> spSolicitudEquipoBuscar(
      [Parameter(DbType = "VarChar(2)")] string departamento,
      [Parameter(DbType = "VarChar(5)")] string municipio,
      [Parameter(DbType = "Int")] int? regional,
      [Parameter(DbType = "VarChar(255)")] string beneficiario,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal,
      [Parameter(DbType = "Int")] int? estado)
    {
      return (ISingleResult<spSolicitudEquipoBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) departamento, (object) municipio, (object) regional, (object) beneficiario, (object) fechaInicial, (object) fechaFinal, (object) estado).ReturnValue;
    }

    [Function(Name = "Rrr.spNovedadEquipoBuscar")]
    public ISingleResult<spNovedadEquipoBuscarResult> spNovedadEquipoBuscar(
      [Parameter(DbType = "VarChar(2)")] string departamento,
      [Parameter(DbType = "VarChar(5)")] string municipio,
      [Parameter(DbType = "Int")] int? regional,
      [Parameter(DbType = "VarChar(255)")] string beneficiario,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal,
      [Parameter(DbType = "Int")] int? tipoNovedad)
    {
      return (ISingleResult<spNovedadEquipoBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) departamento, (object) municipio, (object) regional, (object) beneficiario, (object) fechaInicial, (object) fechaFinal, (object) tipoNovedad).ReturnValue;
    }

    [Function(Name = "Rrr.spReporteCentroConsolidadoBuscar")]
    public ISingleResult<spReporteCentroConsolidadoBuscarResult> spReporteCentroConsolidadoBuscar(
      [Parameter(DbType = "Int")] int? centro,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal)
    {
      return (ISingleResult<spReporteCentroConsolidadoBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) centro, (object) fechaInicial, (object) fechaFinal).ReturnValue;
    }

    [Function(Name = "Rrr.spBeneficiarioBuscar")]
    public ISingleResult<spBeneficiarioBuscarResult> spBeneficiarioBuscar(
      [Parameter(DbType = "VarChar(255)")] string beneficiario,
      [Parameter(DbType = "VarChar(20)")] string documento,
      [Parameter(DbType = "Int")] int? tipoDocumento)
    {
      return (ISingleResult<spBeneficiarioBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) beneficiario, (object) documento, (object) tipoDocumento).ReturnValue;
    }

    [Function(Name = "Rrr.spBeneficiarioBuscarCorrespondencia")]
    public ISingleResult<spBeneficiarioBuscarCorrespondenciaResult> spBeneficiarioBuscarCorrespondencia(
      [Parameter(DbType = "VarChar(255)")] string beneficiario,
      [Parameter(DbType = "VarChar(20)")] string documento,
      [Parameter(DbType = "Int")] int? tipoDocumento,
      [Parameter(DbType = "VarChar(2)")] string departamento,
      [Parameter(DbType = "VarChar(5)")] string municipio,
      [Parameter(DbType = "Int")] int? regional)
    {
      return (ISingleResult<spBeneficiarioBuscarCorrespondenciaResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) beneficiario, (object) documento, (object) tipoDocumento, (object) departamento, (object) municipio, (object) regional).ReturnValue;
    }
  }
}
