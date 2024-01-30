// Decompiled with JetBrains decompiler
// Type: UTO.SeguridadDataContext
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO
{
  [Database(Name = "BDUTOSeguridad")]
  public class SeguridadDataContext : DataContext
  {
    private static MappingSource mappingSource = (MappingSource) new AttributeMappingSource();

    public SeguridadDataContext(string connection)
      : base(connection, SeguridadDataContext.mappingSource)
    {
    }

    public SeguridadDataContext(IDbConnection connection)
      : base(connection, SeguridadDataContext.mappingSource)
    {
    }

    public SeguridadDataContext(string connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public SeguridadDataContext(IDbConnection connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public Table<ahi_AuditoriaHistorico> ahi_AuditoriaHistoricos => this.GetTable<ahi_AuditoriaHistorico>();

    public Table<usu_Usuario> usu_Usuarios => this.GetTable<usu_Usuario>();

    public Table<aud_Auditoria> aud_Auditorias => this.GetTable<aud_Auditoria>();

    public Table<gru_Grupo> gru_Grupos => this.GetTable<gru_Grupo>();

    public Table<log_Login> log_Logins => this.GetTable<log_Login>();

    public Table<mod_Modulo> mod_Modulos => this.GetTable<mod_Modulo>();

    public Table<ope_Operacion> ope_Operacions => this.GetTable<ope_Operacion>();

    public Table<pgr_PermisoGrupo> pgr_PermisoGrupos => this.GetTable<pgr_PermisoGrupo>();

    public Table<ugr_UsuarioGrupo> ugr_UsuarioGrupos => this.GetTable<ugr_UsuarioGrupo>();
  }
}
