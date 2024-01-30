// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.CertificacionDataContext
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;

namespace UTO.Certificacion
{
  [Database(Name = "BDUTO")]
  public class CertificacionDataContext : DataContext
  {
    private static MappingSource mappingSource = (MappingSource) new AttributeMappingSource();

    public CertificacionDataContext()
      : base(ConfigurationManager.ConnectionStrings["BDUTOConnectionString3"].ConnectionString, CertificacionDataContext.mappingSource)
    {
    }

    public CertificacionDataContext(string connection)
      : base(connection, CertificacionDataContext.mappingSource)
    {
    }

    public CertificacionDataContext(IDbConnection connection)
      : base(connection, CertificacionDataContext.mappingSource)
    {
    }

    public CertificacionDataContext(string connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public CertificacionDataContext(IDbConnection connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public Table<atr_AreaTrabajo> atr_AreaTrabajos => this.GetTable<atr_AreaTrabajo>();

    public Table<cat_Categoria> cat_Categorias => this.GetTable<cat_Categoria>();

    public Table<cem_CategoriaEmpresa> cem_CategoriaEmpresas => this.GetTable<cem_CategoriaEmpresa>();

    public Table<dep_Departamento> dep_Departamentos => this.GetTable<dep_Departamento>();

    public Table<mun_Municipio> mun_Municipios => this.GetTable<mun_Municipio>();

    public Table<dti_DocumentoTipo> dti_DocumentoTipos => this.GetTable<dti_DocumentoTipo>();

    public Table<tca_TerceroCategoria> tca_TerceroCategorias => this.GetTable<tca_TerceroCategoria>();

    public Table<reg_Regional> reg_Regionals => this.GetTable<reg_Regional>();

    public Table<ate_ActividadTercero> ate_ActividadTerceros => this.GetTable<ate_ActividadTercero>();

    public Table<ado_ActividadDocumento> ado_ActividadDocumentos => this.GetTable<ado_ActividadDocumento>();

    public Table<doc_Documento> doc_Documentos => this.GetTable<doc_Documento>();

    public Table<ter_Tercero> ter_Terceros => this.GetTable<ter_Tercero>();

    public Table<ttt_TerceroTipoTercero> ttt_TerceroTipoTerceros => this.GetTable<ttt_TerceroTipoTercero>();

    public Table<tti_terceroTipo> tti_terceroTipos => this.GetTable<tti_terceroTipo>();

    public Table<ati_ActividadTipo> ati_ActividadTipos => this.GetTable<ati_ActividadTipo>();

    public Table<tec_Tecnico> tec_Tecnicos => this.GetTable<tec_Tecnico>();

    public Table<ted_TecnicoDetalle> ted_TecnicoDetalles => this.GetTable<ted_TecnicoDetalle>();

    public Table<acm_ActividadMaterial> acm_ActividadMaterials => this.GetTable<acm_ActividadMaterial>();

    public Table<ame_ActividadmaterialEntregado> ame_ActividadmaterialEntregados => this.GetTable<ame_ActividadmaterialEntregado>();

    public Table<act_Actividad> act_Actividads => this.GetTable<act_Actividad>();

    [Function(Name = "Cer.spTecnicosBuscar")]
    public ISingleResult<spTecnicosBuscarResult> spTecnicosBuscar([Parameter(DbType = "VarChar(20)")] string documento, [Parameter(DbType = "VarChar(450)")] string nombre) => (ISingleResult<spTecnicosBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) documento, (object) nombre).ReturnValue;

    [Function(Name = "Cer.spTecnicosBuscarActividad")]
    public ISingleResult<spTecnicosBuscarActividadResult> spTecnicosBuscarActividad(
      [Parameter(DbType = "VarChar(20)")] string documento,
      [Parameter(DbType = "VarChar(450)")] string nombre,
      [Parameter(DbType = "Int")] int? tipoDocumento)
    {
      return (ISingleResult<spTecnicosBuscarActividadResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) documento, (object) nombre, (object) tipoDocumento).ReturnValue;
    }

    [Function(Name = "Cer.spEmpresaBuscar")]
    public ISingleResult<spEmpresaBuscarResult> spEmpresaBuscar([Parameter(DbType = "VarChar(20)")] string documento, [Parameter(DbType = "VarChar(450)")] string nombre) => (ISingleResult<spEmpresaBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) documento, (object) nombre).ReturnValue;

    [Function(Name = "Cer.spActividadesBuscar")]
    public ISingleResult<spActividadesBuscarResult> spActividadesBuscar(
      [Parameter(DbType = "DateTime")] DateTime? fechaIni,
      [Parameter(DbType = "DateTime")] DateTime? fechaFin,
      [Parameter(DbType = "VarChar(5)")] string municipio)
    {
      return (ISingleResult<spActividadesBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) fechaIni, (object) fechaFin, (object) municipio).ReturnValue;
    }

    [Function(Name = "Cer.spConsultaTecnico")]
    public ISingleResult<spConsultaTecnicoResult> spConsultaTecnico(
      [Parameter(DbType = "VarChar(2)")] string idDepartamento,
      [Parameter(Name = "IdMunicipio", DbType = "VarChar(5)")] string idMunicipio,
      [Parameter(DbType = "Int")] int? idCategoria,
      [Parameter(DbType = "Int")] int? idArea,
      [Parameter(DbType = "Int")] int? idEmpresa)
    {
      return (ISingleResult<spConsultaTecnicoResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) idDepartamento, (object) idMunicipio, (object) idCategoria, (object) idArea, (object) idEmpresa).ReturnValue;
    }

    [Function(Name = "Cer.spCuboCertificacion")]
    public ISingleResult<spCuboCertificacionResult> spCuboCertificacion() => (ISingleResult<spCuboCertificacionResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod()).ReturnValue;
  }
}
