// Decompiled with JetBrains decompiler
// Type: UTO.DisposicionFinal.DisposicionFinalDataContext
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;

namespace UTO.DisposicionFinal
{
  [Database(Name = "BDUTO")]
  public class DisposicionFinalDataContext : DataContext
  {
    private static MappingSource mappingSource = (MappingSource) new AttributeMappingSource();

    public DisposicionFinalDataContext()
      : base(ConfigurationManager.ConnectionStrings["BDUTOConnectionString3"].ConnectionString, DisposicionFinalDataContext.mappingSource)
    {
    }

    public DisposicionFinalDataContext(string connection)
      : base(connection, DisposicionFinalDataContext.mappingSource)
    {
    }

    public DisposicionFinalDataContext(IDbConnection connection)
      : base(connection, DisposicionFinalDataContext.mappingSource)
    {
    }

    public DisposicionFinalDataContext(string connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public DisposicionFinalDataContext(IDbConnection connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public Table<des_DisposicionEstado> des_DisposicionEstados => this.GetTable<des_DisposicionEstado>();

    public Table<psu_PresentacionSustancia> psu_PresentacionSustancias => this.GetTable<psu_PresentacionSustancia>();

    public Table<sus_Sustancia> sus_Sustancias => this.GetTable<sus_Sustancia>();

    public Table<mun_Municipio> mun_Municipios => this.GetTable<mun_Municipio>();

    public Table<dep_Departamento> dep_Departamentos => this.GetTable<dep_Departamento>();

    public Table<ttt_TerceroTipoTercero> ttt_TerceroTipoTerceros => this.GetTable<ttt_TerceroTipoTercero>();

    public Table<tti_terceroTipo> tti_terceroTipos => this.GetTable<tti_terceroTipo>();

    public Table<ter_Tercero> ter_Terceros => this.GetTable<ter_Tercero>();

    public Table<reg_Regional> reg_Regionals => this.GetTable<reg_Regional>();

    public Table<dfd_DisposicionFinalDato> dfd_DisposicionFinalDatos => this.GetTable<dfd_DisposicionFinalDato>();

    public Table<ddd_DisposicionDatosDetalle> ddd_DisposicionDatosDetalles => this.GetTable<ddd_DisposicionDatosDetalle>();

    public Table<dti_DocumentoTipo> dti_DocumentoTipos => this.GetTable<dti_DocumentoTipo>();

    [Function(Name = "Dis.spSustanciaEmpresaBuscar")]
    public ISingleResult<spSustanciaEmpresaBuscarResult> spSustanciaEmpresaBuscar(
      [Parameter(DbType = "VarChar(20)")] string nit,
      [Parameter(DbType = "VarChar(450)")] string nombre)
    {
      return (ISingleResult<spSustanciaEmpresaBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) nit, (object) nombre).ReturnValue;
    }

    [Function(Name = "Dis.spSustanciaBuscar")]
    public ISingleResult<spSustanciaBuscarResult> spSustanciaBuscar(
      [Parameter(DbType = "VarChar(20)")] string nit,
      [Parameter(DbType = "Int")] int? idEmpresa,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal,
      [Parameter(DbType = "Int")] int? idSustancia)
    {
      return (ISingleResult<spSustanciaBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) nit, (object) idEmpresa, (object) fechaInicial, (object) fechaFinal, (object) idSustancia).ReturnValue;
    }

    [Function(Name = "Dis.spConsultaNacional")]
    public ISingleResult<spConsultaNacionalResult> spConsultaNacional(
      [Parameter(DbType = "Int")] int? idSustancia,
      [Parameter(DbType = "Int")] int? idEstado,
      [Parameter(DbType = "VarChar(2)")] string idDepartamento,
      [Parameter(DbType = "VarChar(5)")] string idCiudad,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal,
      [Parameter(DbType = "Int")] int? idEmpresa)
    {
      return (ISingleResult<spConsultaNacionalResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) idSustancia, (object) idEstado, (object) idDepartamento, (object) idCiudad, (object) fechaInicial, (object) fechaFinal, (object) idEmpresa).ReturnValue;
    }

    [Function(Name = "Dis.spConsultaNacionalPublico")]
    public ISingleResult<spConsultaNacionalPublicoResult> spConsultaNacionalPublico(
      [Parameter(DbType = "Int")] int? idSustancia,
      [Parameter(DbType = "Int")] int? idEstado,
      [Parameter(DbType = "VarChar(2)")] string idDepartamento,
      [Parameter(DbType = "VarChar(5)")] string idCiudad,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal)
    {
      return (ISingleResult<spConsultaNacionalPublicoResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) idSustancia, (object) idEstado, (object) idDepartamento, (object) idCiudad, (object) fechaInicial, (object) fechaFinal).ReturnValue;
    }
  }
}
