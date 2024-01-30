// Decompiled with JetBrains decompiler
// Type: UTO.Proyectos.ProyectosDataContext
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;

namespace UTO.Proyectos
{
  [Database(Name = "BDUTO")]
  public class ProyectosDataContext : DataContext
  {
    private static MappingSource mappingSource = (MappingSource) new AttributeMappingSource();

    public ProyectosDataContext()
      : base(ConfigurationManager.ConnectionStrings["BDUTOConnectionString2"].ConnectionString, ProyectosDataContext.mappingSource)
    {
    }

    public ProyectosDataContext(string connection)
      : base(connection, ProyectosDataContext.mappingSource)
    {
    }

    public ProyectosDataContext(IDbConnection connection)
      : base(connection, ProyectosDataContext.mappingSource)
    {
    }

    public ProyectosDataContext(string connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public ProyectosDataContext(IDbConnection connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public Table<pse_ProyectoSector> pse_ProyectoSectors => this.GetTable<pse_ProyectoSector>();

    public Table<pti_ProyectoTipo> pti_ProyectoTipos => this.GetTable<pti_ProyectoTipo>();

    public Table<dep_Departamento> dep_Departamentos => this.GetTable<dep_Departamento>();

    public Table<mun_Municipio> mun_Municipios => this.GetTable<mun_Municipio>();

    public Table<pyg_ProyectoGrupo> pyg_ProyectoGrupos => this.GetTable<pyg_ProyectoGrupo>();

    public Table<pap_ProyectoAprobado> pap_ProyectoAprobados => this.GetTable<pap_ProyectoAprobado>();

    public Table<doc_Documento> doc_Documentos => this.GetTable<doc_Documento>();

    public Table<pdo_ProyectoDocumento> pdo_ProyectoDocumentos => this.GetTable<pdo_ProyectoDocumento>();

    [Function(Name = "Pro.spProyectoConsulta")]
    public ISingleResult<spProyectoConsultaResult> spProyectoConsulta(
      [Parameter(DbType = "VarChar(150)")] string nombre,
      [Parameter(DbType = "Int")] int? tipo,
      [Parameter(DbType = "VarChar(2)")] string departamento,
      [Parameter(DbType = "VarChar(5)")] string municipio,
      [Parameter(DbType = "Int")] int? sector)
    {
      return (ISingleResult<spProyectoConsultaResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) nombre, (object) tipo, (object) departamento, (object) municipio, (object) sector).ReturnValue;
    }

    [Function(Name = "Pro.spProyectoBuscar")]
    public ISingleResult<spProyectoBuscarResult> spProyectoBuscar(
      [Parameter(DbType = "VarChar(2)")] string codigo,
      [Parameter(DbType = "VarChar(150)")] string nombre,
      [Parameter(DbType = "Int")] int? tipo)
    {
      return (ISingleResult<spProyectoBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) codigo, (object) nombre, (object) tipo).ReturnValue;
    }
  }
}
