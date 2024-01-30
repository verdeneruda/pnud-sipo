// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.ImportacionExportacionDataContext
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;

namespace UTO.ImportacionExportacion
{
  [Database(Name = "BDUTO")]
  public class ImportacionExportacionDataContext : DataContext
  {
    private static MappingSource mappingSource = (MappingSource) new AttributeMappingSource();

    public ImportacionExportacionDataContext()
      : base(ConfigurationManager.ConnectionStrings["BDUTOConnectionString"].ConnectionString, ImportacionExportacionDataContext.mappingSource)
    {
    }

    public ImportacionExportacionDataContext(string connection)
      : base(connection, ImportacionExportacionDataContext.mappingSource)
    {
    }

    public ImportacionExportacionDataContext(IDbConnection connection)
      : base(connection, ImportacionExportacionDataContext.mappingSource)
    {
    }

    public ImportacionExportacionDataContext(string connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public ImportacionExportacionDataContext(IDbConnection connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public Table<cvb_ConceptoVistoBueno> cvb_ConceptoVistoBuenos => this.GetTable<cvb_ConceptoVistoBueno>();

    public Table<sus_Sustancia> sus_Sustancias => this.GetTable<sus_Sustancia>();

    public Table<adu_Aduana> adu_Aduanas => this.GetTable<adu_Aduana>();

    public Table<pas_Pai> pas_Pais => this.GetTable<pas_Pai>();

    public Table<psu_PresentacionSustancia> psu_PresentacionSustancias => this.GetTable<psu_PresentacionSustancia>();

    public Table<rex_RegistroExportacion> rex_RegistroExportacions => this.GetTable<rex_RegistroExportacion>();

    public Table<cip_ConsultaImportacion> cip_ConsultaImportacions => this.GetTable<cip_ConsultaImportacion>();

    public Table<cae_CargueArchivoExportacion> cae_CargueArchivoExportacions => this.GetTable<cae_CargueArchivoExportacion>();

    public Table<ttt_TerceroTipoTercero> ttt_TerceroTipoTerceros => this.GetTable<ttt_TerceroTipoTercero>();

    public Table<tti_terceroTipo> tti_terceroTipos => this.GetTable<tti_terceroTipo>();

    public Table<mun_Municipio> mun_Municipios => this.GetTable<mun_Municipio>();

    public Table<dti_DocumentoTipo> dti_DocumentoTipos => this.GetTable<dti_DocumentoTipo>();

    public Table<dep_Departamento> dep_Departamentos => this.GetTable<dep_Departamento>();

    public Table<cai_CargueArchivoImportacion> cai_CargueArchivoImportacions => this.GetTable<cai_CargueArchivoImportacion>();

    public Table<dim_DeclaracionImportacion> dim_DeclaracionImportacions => this.GetTable<dim_DeclaracionImportacion>();

    public Table<tdi_TemporalDeclaracionImportacion> tdi_TemporalDeclaracionImportacions => this.GetTable<tdi_TemporalDeclaracionImportacion>();

    public Table<dex_DeclaracionExportacion> dex_DeclaracionExportacions => this.GetTable<dex_DeclaracionExportacion>();

    public Table<tde_TemporalDeclaracionExportacion> tde_TemporalDeclaracionExportacions => this.GetTable<tde_TemporalDeclaracionExportacion>();

    public Table<lmd_LicenciaMedioAmbientalDetalle> lmd_LicenciaMedioAmbientalDetalles => this.GetTable<lmd_LicenciaMedioAmbientalDetalle>();

    public Table<lma_LicenciaMedioAmbiental> lma_LicenciaMedioAmbientals => this.GetTable<lma_LicenciaMedioAmbiental>();

    public Table<mar_Marca> mar_Marcas => this.GetTable<mar_Marca>();

    public Table<meq_MarcaEquipo> meq_MarcaEquipos => this.GetTable<meq_MarcaEquipo>();

    public Table<cim_CertificacionImportador> cim_CertificacionImportadors => this.GetTable<cim_CertificacionImportador>();

    public Table<rit_RegistroImportacionEstado> rit_RegistroImportacionEstados => this.GetTable<rit_RegistroImportacionEstado>();

    public Table<ter_Tercero> ter_Terceros => this.GetTable<ter_Tercero>();

    public Table<ear_EquipoArancel> ear_EquipoArancels => this.GetTable<ear_EquipoArancel>();

    public Table<uni_Unidad> uni_Unidads => this.GetTable<uni_Unidad>();

    public Table<ris_RegistroImportacionSustancia> ris_RegistroImportacionSustancias => this.GetTable<ris_RegistroImportacionSustancia>();

    public Table<rie_RegistroImportacionEquipo> rie_RegistroImportacionEquipos => this.GetTable<rie_RegistroImportacionEquipo>();

    public Table<res_RegistroExportacionSustancia> res_RegistroExportacionSustancias => this.GetTable<res_RegistroExportacionSustancia>();

    public Table<rim_RegistroImportacion> rim_RegistroImportacions => this.GetTable<rim_RegistroImportacion>();

    [Function(Name = "Iye.spRegistroImportacionBuscar")]
    public ISingleResult<spRegistroImportacionBuscarResult> spRegistroImportacionBuscar(
      [Parameter(DbType = "VarChar(25)")] string licencia,
      [Parameter(DbType = "VarChar(255)")] string importador,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal,
      [Parameter(DbType = "Int")] int? sustancia,
      [Parameter(DbType = "VarChar(25)")] string tipo)
    {
      return (ISingleResult<spRegistroImportacionBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) licencia, (object) importador, (object) fechaInicial, (object) fechaFinal, (object) sustancia, (object) tipo).ReturnValue;
    }

    [Function(Name = "Iye.spRegistroExportacionBuscar")]
    public ISingleResult<spRegistroExportacionBuscarResult> spRegistroExportacionBuscar(
      [Parameter(DbType = "VarChar(25)")] string licencia,
      [Parameter(DbType = "VarChar(255)")] string importador,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal,
      [Parameter(DbType = "Int")] int? sustancia,
      [Parameter(DbType = "Int")] int? pais)
    {
      return (ISingleResult<spRegistroExportacionBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) licencia, (object) importador, (object) fechaInicial, (object) fechaFinal, (object) sustancia, (object) pais).ReturnValue;
    }

    [Function(Name = "Iye.spIndicadoresGestion")]
    public int spIndicadoresGestion([Parameter(DbType = "DateTime")] DateTime? fechaInicial, [Parameter(DbType = "DateTime")] DateTime? fechaFinal) => (int) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) fechaInicial, (object) fechaFinal).ReturnValue;

    [Function(Name = "Iye.spConsultaVistoBuenoImportacion")]
    public ISingleResult<spConsultaVistoBuenoImportacionResult> spConsultaVistoBuenoImportacion(
      [Parameter(DbType = "VarChar(25)")] string vistoBueno,
      [Parameter(DbType = "VarChar(25)")] string licencia,
      [Parameter(DbType = "VarChar(255)")] string importador,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal,
      [Parameter(DbType = "Int")] int? sustancia,
      [Parameter(DbType = "VarChar(25)")] string marca)
    {
      return (ISingleResult<spConsultaVistoBuenoImportacionResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) vistoBueno, (object) licencia, (object) importador, (object) fechaInicial, (object) fechaFinal, (object) sustancia, (object) marca).ReturnValue;
    }

    [Function(Name = "Iye.spConsultaVBDeclaracionImportacion")]
    public ISingleResult<spConsultaVBDeclaracionImportacionResult> spConsultaVBDeclaracionImportacion(
      [Parameter(DbType = "VarChar(25)")] string licencia,
      [Parameter(DbType = "VarChar(255)")] string importador,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal,
      [Parameter(DbType = "Int")] int? sustancia,
      [Parameter(DbType = "VarChar(25)")] string marca)
    {
      return (ISingleResult<spConsultaVBDeclaracionImportacionResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) licencia, (object) importador, (object) fechaInicial, (object) fechaFinal, (object) sustancia, (object) marca).ReturnValue;
    }

    [Function(Name = "Iye.spConsultaVistoBuenoExportacion")]
    public ISingleResult<spConsultaVistoBuenoExportacionResult> spConsultaVistoBuenoExportacion(
      [Parameter(DbType = "VarChar(25)")] string vistoBueno,
      [Parameter(DbType = "VarChar(25)")] string licencia,
      [Parameter(DbType = "VarChar(255)")] string importador,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal,
      [Parameter(DbType = "Int")] int? sustancia)
    {
      return (ISingleResult<spConsultaVistoBuenoExportacionResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) vistoBueno, (object) licencia, (object) importador, (object) fechaInicial, (object) fechaFinal, (object) sustancia).ReturnValue;
    }

    [Function(Name = "Iye.spConsultaVBDeclaracionExportacion")]
    public ISingleResult<spConsultaVBDeclaracionExportacionResult> spConsultaVBDeclaracionExportacion(
      [Parameter(DbType = "VarChar(25)")] string licencia,
      [Parameter(DbType = "VarChar(255)")] string importador,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal,
      [Parameter(DbType = "Int")] int? sustancia)
    {
      return (ISingleResult<spConsultaVBDeclaracionExportacionResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) licencia, (object) importador, (object) fechaInicial, (object) fechaFinal, (object) sustancia).ReturnValue;
    }

    [Function(Name = "Uto.spComboAno")]
    public ISingleResult<spComboAnoResult> spComboAno([Parameter(DbType = "Int")] int? antes, [Parameter(DbType = "Int")] int? despues) => (ISingleResult<spComboAnoResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) antes, (object) despues).ReturnValue;

    [Function(Name = "Iye.spCargueArchivo")]
    public int spCargueArchivo([Parameter(DbType = "Int")] int? anno) => (int) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) anno).ReturnValue;

    [Function(Name = "Iye.spCargueArchivoExportacion")]
    public int spCargueArchivoExportacion([Parameter(DbType = "Int")] int? anno) => (int) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) anno).ReturnValue;

    [Function(Name = "Iye.spCuboDeclaracion")]
    public ISingleResult<spCuboDeclaracionResult> spCuboDeclaracion() => (ISingleResult<spCuboDeclaracionResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod()).ReturnValue;

    [Function(Name = "Iye.spCuboImportacion")]
    public ISingleResult<spCuboImportacionResult> spCuboImportacion() => (ISingleResult<spCuboImportacionResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod()).ReturnValue;

    [Function(Name = "Iye.spCertificacionBuscar")]
    public ISingleResult<spCertificacionBuscarResult> spCertificacionBuscar(
      [Parameter(DbType = "VarChar(25)")] string radicado,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal,
      [Parameter(DbType = "VarChar(255)")] string radicadopor,
      [Parameter(DbType = "VarChar(255)")] string importador)
    {
      return (ISingleResult<spCertificacionBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) radicado, (object) fechaInicial, (object) fechaFinal, (object) radicadopor, (object) importador).ReturnValue;
    }

    [Function(Name = "Iye.spLicenciaBuscar")]
    public ISingleResult<spLicenciaBuscarResult> spLicenciaBuscar(
      [Parameter(DbType = "VarChar(25)")] string resolucion,
      [Parameter(DbType = "VarChar(255)")] string empresa,
      [Parameter(DbType = "Int")] int? sustancia)
    {
      return (ISingleResult<spLicenciaBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) resolucion, (object) empresa, (object) sustancia).ReturnValue;
    }
  }
}
