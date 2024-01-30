// Decompiled with JetBrains decompiler
// Type: UTO.gru_Grupo
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO
{
  [Table(Name = "dbo.gru_Grupo")]
  public class gru_Grupo : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _gru_id;
    private string _gru_nombre;
    private bool? _gru_activo;
    private EntitySet<pgr_PermisoGrupo> _pgr_PermisoGrupos;

    public gru_Grupo() => this._pgr_PermisoGrupos = new EntitySet<pgr_PermisoGrupo>(new Action<pgr_PermisoGrupo>(this.attach_pgr_PermisoGrupos), new Action<pgr_PermisoGrupo>(this.detach_pgr_PermisoGrupos));

    [Column(Storage = "_gru_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int gru_id
    {
      get => this._gru_id;
      set
      {
        if (this._gru_id == value)
          return;
        this.SendPropertyChanging();
        this._gru_id = value;
        this.SendPropertyChanged(nameof (gru_id));
      }
    }

    [Column(Storage = "_gru_nombre", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string gru_nombre
    {
      get => this._gru_nombre;
      set
      {
        if (!(this._gru_nombre != value))
          return;
        this.SendPropertyChanging();
        this._gru_nombre = value;
        this.SendPropertyChanged(nameof (gru_nombre));
      }
    }

    [Column(Storage = "_gru_activo", DbType = "Bit")]
    public bool? gru_activo
    {
      get => this._gru_activo;
      set
      {
        bool? gruActivo = this._gru_activo;
        bool? nullable = value;
        if ((gruActivo.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (gruActivo.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._gru_activo = value;
        this.SendPropertyChanged(nameof (gru_activo));
      }
    }

    [Association(Name = "gru_Grupo_pgr_PermisoGrupo", Storage = "_pgr_PermisoGrupos", ThisKey = "gru_id", OtherKey = "gru_id")]
    public EntitySet<pgr_PermisoGrupo> pgr_PermisoGrupos
    {
      get => this._pgr_PermisoGrupos;
      set => this._pgr_PermisoGrupos.Assign((IEnumerable<pgr_PermisoGrupo>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, gru_Grupo.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_pgr_PermisoGrupos(pgr_PermisoGrupo entity)
    {
      this.SendPropertyChanging();
      entity.gru_Grupo = this;
    }

    private void detach_pgr_PermisoGrupos(pgr_PermisoGrupo entity)
    {
      this.SendPropertyChanging();
      entity.gru_Grupo = (gru_Grupo) null;
    }
  }
}
