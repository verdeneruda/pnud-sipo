// Decompiled with JetBrains decompiler
// Type: UTO.Comunes.ComunesDataContext
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;

namespace UTO.Comunes
{
  [Database(Name = "BDUTO")]
  public class ComunesDataContext : DataContext
  {
    private static MappingSource mappingSource = (MappingSource) new AttributeMappingSource();

    public ComunesDataContext()
      : base(ConfigurationManager.ConnectionStrings["BDUTOConnectionString2"].ConnectionString, ComunesDataContext.mappingSource)
    {
    }

    public ComunesDataContext(string connection)
      : base(connection, ComunesDataContext.mappingSource)
    {
    }

    public ComunesDataContext(IDbConnection connection)
      : base(connection, ComunesDataContext.mappingSource)
    {
    }

    public ComunesDataContext(string connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public ComunesDataContext(IDbConnection connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public Table<tpr_TerceroProyecto> tpr_TerceroProyectos => this.GetTable<tpr_TerceroProyecto>();

    public Table<dti_DocumentoTipo> dti_DocumentoTipos => this.GetTable<dti_DocumentoTipo>();

    public Table<bti_beneficiarioTipo> bti_beneficiarioTipos => this.GetTable<bti_beneficiarioTipo>();

    public Table<mun_Municipio> mun_Municipios => this.GetTable<mun_Municipio>();

    public Table<dep_Departamento> dep_Departamentos => this.GetTable<dep_Departamento>();

    public Table<reg_Regional> reg_Regionals => this.GetTable<reg_Regional>();

    public Table<pyg_ProyectoGrupo> pyg_ProyectoGrupos => this.GetTable<pyg_ProyectoGrupo>();

    public Table<tgr_TerceroGrupo> tgr_TerceroGrupos => this.GetTable<tgr_TerceroGrupo>();

    public Table<tti_terceroTipo> tti_terceroTipos => this.GetTable<tti_terceroTipo>();

    public Table<ttt_TerceroTipoTercero> ttt_TerceroTipoTerceros => this.GetTable<ttt_TerceroTipoTercero>();

    public Table<sus_Sustancia> sus_Sustancias => this.GetTable<sus_Sustancia>();

    public Table<pas_Pai> pas_Pais => this.GetTable<pas_Pai>();

    public Table<ter_Tercero> ter_Terceros => this.GetTable<ter_Tercero>();

    [Function(Name = "Uto.spBeneficiarioBuscar")]
    public ISingleResult<spBeneficiarioBuscarResult> spBeneficiarioBuscar(
      [Parameter(DbType = "VarChar(255)")] string beneficiario,
      [Parameter(DbType = "VarChar(20)")] string documento,
      [Parameter(DbType = "Int")] int? tipoDocumento)
    {
      return (ISingleResult<spBeneficiarioBuscarResult>) this.ExecuteMethodCall((object) this, (MethodInfo) MethodBase.GetCurrentMethod(), (object) beneficiario, (object) documento, (object) tipoDocumento).ReturnValue;
    }
  }
}
