// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.RegistroUsoDataContext
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;

namespace UTO.RegistrosUso
{
  [Database(Name = "BDUTO")]
  public class RegistroUsoDataContext : DataContext
  {
    private static MappingSource mappingSource = (MappingSource) new AttributeMappingSource();

    public RegistroUsoDataContext()
      : base(ConfigurationManager.ConnectionStrings["BDUTOConnectionString"].ConnectionString, RegistroUsoDataContext.mappingSource)
    {
    }

    public RegistroUsoDataContext(string connection)
      : base(connection, RegistroUsoDataContext.mappingSource)
    {
    }

    public RegistroUsoDataContext(IDbConnection connection)
      : base(connection, RegistroUsoDataContext.mappingSource)
    {
    }

    public RegistroUsoDataContext(string connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public RegistroUsoDataContext(IDbConnection connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public Table<apl_Aplicacion> apl_Aplicacions => this.GetTable<apl_Aplicacion>();

    public Table<ceq_CategoriaEquipo> ceq_CategoriaEquipos => this.GetTable<ceq_CategoriaEquipo>();

    public Table<rri_RegistroReporteImportador> rri_RegistroReporteImportadors => this.GetTable<rri_RegistroReporteImportador>();

    public Table<sec_Sector> sec_Sectors => this.GetTable<sec_Sector>();

    public Table<utf_UsuarioTipoFinal> utf_UsuarioTipoFinals => this.GetTable<utf_UsuarioTipoFinal>();

    public Table<mun_Municipio> mun_Municipios => this.GetTable<mun_Municipio>();

    public Table<dep_Departamento> dep_Departamentos => this.GetTable<dep_Departamento>();

    public Table<sus_Sustancia> sus_Sustancias => this.GetTable<sus_Sustancia>();

    public Table<psu_PresentacionSustancia> psu_PresentacionSustancias => this.GetTable<psu_PresentacionSustancia>();

    public Table<ter_Tercero> ter_Terceros => this.GetTable<ter_Tercero>();

    public Table<ttt_TerceroTipoTercero> ttt_TerceroTipoTerceros => this.GetTable<ttt_TerceroTipoTercero>();

    public Table<tti_terceroTipo> tti_terceroTipos => this.GetTable<tti_terceroTipo>();

    public Table<ufe_UsuarioFinalDetalle> ufe_UsuarioFinalDetalles => this.GetTable<ufe_UsuarioFinalDetalle>();

    public Table<ufd_UsuarioFinalDato> ufd_UsuarioFinalDatos => this.GetTable<ufd_UsuarioFinalDato>();

    public Table<reg_Regional> reg_Regionals => this.GetTable<reg_Regional>();

    public Table<eti_EquipoTipo> eti_EquipoTipos => this.GetTable<eti_EquipoTipo>();

    public Table<rid_RegistroImportadorDetalle> rid_RegistroImportadorDetalles => this.GetTable<rid_RegistroImportadorDetalle>();

    public Table<tri_TemporalRegistroReporteImportador> tri_TemporalRegistroReporteImportadors => this.GetTable<tri_TemporalRegistroReporteImportador>();

    [Function(Name = "Rus.spImportadoresBuscar")]
    public ISingleResult<spImportadoresBuscarResult> spImportadoresBuscar(
      [Parameter(DbType = "Int")] int? idEmpresa,
      [Parameter(DbType = "Int")] int? idSustancia)
    {
      return (ISingleResult<spImportadoresBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) idEmpresa, (object) idSustancia).ReturnValue;
    }

    [Function(Name = "Rus.spUsuariosBuscar")]
    public ISingleResult<spUsuariosBuscarResult> spUsuariosBuscar(
      [Parameter(DbType = "VarChar(20)")] string nit,
      [Parameter(DbType = "Int")] int? idEmpresa,
      [Parameter(DbType = "VarChar(2)")] string idDepartamento,
      [Parameter(DbType = "VarChar(5)")] string idCiudad)
    {
      return (ISingleResult<spUsuariosBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) nit, (object) idEmpresa, (object) idDepartamento, (object) idCiudad).ReturnValue;
    }

    [Function(Name = "Rus.spUsuarioEmpresaBuscar")]
    public ISingleResult<spUsuarioEmpresaBuscarResult> spUsuarioEmpresaBuscar(
      [Parameter(DbType = "VarChar(20)")] string nit,
      [Parameter(DbType = "VarChar(450)")] string nombre)
    {
      return (ISingleResult<spUsuarioEmpresaBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) nit, (object) nombre).ReturnValue;
    }

    [Function(Name = "Rus.spConsultaImportadores")]
    public ISingleResult<spConsultaImportadoresResult> spConsultaImportadores(
      [Parameter(DbType = "Int")] int? idImportador,
      [Parameter(DbType = "Int")] int? idSustancia,
      [Parameter(DbType = "VarChar(2)")] string idDepartamento,
      [Parameter(DbType = "VarChar(5)")] string idCiudad,
      [Parameter(DbType = "Int")] int? idAplicacion,
      [Parameter(DbType = "Int")] int? anno)
    {
      return (ISingleResult<spConsultaImportadoresResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) idImportador, (object) idSustancia, (object) idDepartamento, (object) idCiudad, (object) idAplicacion, (object) anno).ReturnValue;
    }

    [Function(Name = "Rus.spConsultaUsuarioFinal")]
    public ISingleResult<spConsultaUsuarioFinalResult> spConsultaUsuarioFinal(
      [Parameter(DbType = "DateTime")] DateTime? fechaInicio,
      [Parameter(DbType = "DateTime")] DateTime? fechaFinal,
      [Parameter(DbType = "VarChar(2)")] string idDepartamento,
      [Parameter(DbType = "VarChar(5)")] string idCiudad,
      [Parameter(DbType = "Int")] int? idSector,
      [Parameter(DbType = "Int")] int? idSustancia)
    {
      return (ISingleResult<spConsultaUsuarioFinalResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) fechaInicio, (object) fechaFinal, (object) idDepartamento, (object) idCiudad, (object) idSector, (object) idSustancia).ReturnValue;
    }
  }
}
