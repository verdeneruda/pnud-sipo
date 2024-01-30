// Decompiled with JetBrains decompiler
// Type: UTO.Comercializacion.ComercializacionDataContext
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;

namespace UTO.Comercializacion
{
  [Database(Name = "BDUTO")]
  public class ComercializacionDataContext : DataContext
  {
    private static MappingSource mappingSource = (MappingSource) new AttributeMappingSource();

    public ComercializacionDataContext()
      : base(ConfigurationManager.ConnectionStrings["BDUTOConnectionString3"].ConnectionString, ComercializacionDataContext.mappingSource)
    {
    }

    public ComercializacionDataContext(string connection)
      : base(connection, ComercializacionDataContext.mappingSource)
    {
    }

    public ComercializacionDataContext(IDbConnection connection)
      : base(connection, ComercializacionDataContext.mappingSource)
    {
    }

    public ComercializacionDataContext(string connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public ComercializacionDataContext(IDbConnection connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public Table<mar_Marca> mar_Marcas => this.GetTable<mar_Marca>();

    public Table<mun_Municipio> mun_Municipios => this.GetTable<mun_Municipio>();

    public Table<dep_Departamento> dep_Departamentos => this.GetTable<dep_Departamento>();

    public Table<sus_Sustancia> sus_Sustancias => this.GetTable<sus_Sustancia>();

    public Table<psu_PresentacionSustancia> psu_PresentacionSustancias => this.GetTable<psu_PresentacionSustancia>();

    public Table<cda_ComercializacionDato> cda_ComercializacionDatos => this.GetTable<cda_ComercializacionDato>();

    public Table<reg_Regional> reg_Regionals => this.GetTable<reg_Regional>();

    public Table<ter_Tercero> ter_Terceros => this.GetTable<ter_Tercero>();

    public Table<ttt_TerceroTipoTercero> ttt_TerceroTipoTerceros => this.GetTable<ttt_TerceroTipoTercero>();

    public Table<tti_terceroTipo> tti_terceroTipos => this.GetTable<tti_terceroTipo>();

    public Table<cdd_ComercializacionDatosDetalle> cdd_ComercializacionDatosDetalles => this.GetTable<cdd_ComercializacionDatosDetalle>();

    public Table<cpr_ComercializacionProveedor> cpr_ComercializacionProveedors => this.GetTable<cpr_ComercializacionProveedor>();

    [Function(Name = "Com.spEncuestaBuscar")]
    public ISingleResult<spEncuestaBuscarResult> spEncuestaBuscar(
      [Parameter(DbType = "VarChar(20)")] string nit,
      [Parameter(DbType = "Int")] int? idEmpresa,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal,
      [Parameter(DbType = "VarChar(3)")] string departamento,
      [Parameter(DbType = "VarChar(5)")] string municipio)
    {
      return (ISingleResult<spEncuestaBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) nit, (object) idEmpresa, (object) fechaInicial, (object) fechaFinal, (object) departamento, (object) municipio).ReturnValue;
    }

    [Function(Name = "Com.spConsultaSustancia")]
    public ISingleResult<spConsultaSustanciaResult> spConsultaSustancia(
      [Parameter(DbType = "Int")] int? idSustancia,
      [Parameter(DbType = "Int")] int? idPresentacion,
      [Parameter(DbType = "VarChar(2)")] string idDepartamento,
      [Parameter(DbType = "VarChar(5)")] string idCiudad,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal)
    {
      return (ISingleResult<spConsultaSustanciaResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) idSustancia, (object) idPresentacion, (object) idDepartamento, (object) idCiudad, (object) fechaInicial, (object) fechaFinal).ReturnValue;
    }

    [Function(Name = "Com.spConsultaPromedio")]
    public ISingleResult<spConsultaPromedioResult> spConsultaPromedio(
      [Parameter(DbType = "Int")] int? idSustancia,
      [Parameter(DbType = "Int")] int? idPresentacion,
      [Parameter(DbType = "VarChar(2)")] string idDepartamento,
      [Parameter(DbType = "VarChar(5)")] string idCiudad,
      [Parameter(DbType = "DateTime")] DateTime? fechaInicial,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal)
    {
      return (ISingleResult<spConsultaPromedioResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) idSustancia, (object) idPresentacion, (object) idDepartamento, (object) idCiudad, (object) fechaInicial, (object) fechaFinal).ReturnValue;
    }

    [Function(Name = "Com.spEncuestaEmpresaBuscar")]
    public ISingleResult<spEncuestaEmpresaBuscarResult> spEncuestaEmpresaBuscar(
      [Parameter(DbType = "VarChar(20)")] string nit,
      [Parameter(DbType = "VarChar(450)")] string nombre)
    {
      return (ISingleResult<spEncuestaEmpresaBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) nit, (object) nombre).ReturnValue;
    }
  }
}
