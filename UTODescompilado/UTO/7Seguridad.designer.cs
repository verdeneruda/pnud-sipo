// Decompiled with JetBrains decompiler
// Type: UTO.ope_Operacion
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
  [Table(Name = "dbo.ope_Operacion")]
  public class ope_Operacion : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ope_id;
    private int _mod_id;
    private bool _ope_auditar;
    private string _ope_key1;
    private string _ope_key2;
    private string _ope_key3;
    private string _ope_key4;
    private string _ope_nombre;
    private string _ope_key1Nombre;
    private string _ope_key2Nombre;
    private string _ope_key3Nombre;
    private string _ope_key4Nombre;
    private bool? _ope_permiso;
    private EntitySet<ahi_AuditoriaHistorico> _ahi_AuditoriaHistoricos;
    private EntitySet<aud_Auditoria> _aud_Auditorias;
    private EntitySet<pgr_PermisoGrupo> _pgr_PermisoGrupos;
    private EntityRef<mod_Modulo> _mod_Modulo;

    public ope_Operacion()
    {
      this._ahi_AuditoriaHistoricos = new EntitySet<ahi_AuditoriaHistorico>(new Action<ahi_AuditoriaHistorico>(this.attach_ahi_AuditoriaHistoricos), new Action<ahi_AuditoriaHistorico>(this.detach_ahi_AuditoriaHistoricos));
      this._aud_Auditorias = new EntitySet<aud_Auditoria>(new Action<aud_Auditoria>(this.attach_aud_Auditorias), new Action<aud_Auditoria>(this.detach_aud_Auditorias));
      this._pgr_PermisoGrupos = new EntitySet<pgr_PermisoGrupo>(new Action<pgr_PermisoGrupo>(this.attach_pgr_PermisoGrupos), new Action<pgr_PermisoGrupo>(this.detach_pgr_PermisoGrupos));
      this._mod_Modulo = new EntityRef<mod_Modulo>();
    }

    [Column(Storage = "_ope_id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int ope_id
    {
      get => this._ope_id;
      set
      {
        if (this._ope_id == value)
          return;
        this.SendPropertyChanging();
        this._ope_id = value;
        this.SendPropertyChanged(nameof (ope_id));
      }
    }

    [Column(Storage = "_mod_id", DbType = "Int NOT NULL")]
    public int mod_id
    {
      get => this._mod_id;
      set
      {
        if (this._mod_id == value)
          return;
        if (this._mod_Modulo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._mod_id = value;
        this.SendPropertyChanged(nameof (mod_id));
      }
    }

    [Column(Storage = "_ope_auditar", DbType = "Bit NOT NULL")]
    public bool ope_auditar
    {
      get => this._ope_auditar;
      set
      {
        if (this._ope_auditar == value)
          return;
        this.SendPropertyChanging();
        this._ope_auditar = value;
        this.SendPropertyChanged(nameof (ope_auditar));
      }
    }

    [Column(Storage = "_ope_key1", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string ope_key1
    {
      get => this._ope_key1;
      set
      {
        if (!(this._ope_key1 != value))
          return;
        this.SendPropertyChanging();
        this._ope_key1 = value;
        this.SendPropertyChanged(nameof (ope_key1));
      }
    }

    [Column(Storage = "_ope_key2", DbType = "VarChar(50)")]
    public string ope_key2
    {
      get => this._ope_key2;
      set
      {
        if (!(this._ope_key2 != value))
          return;
        this.SendPropertyChanging();
        this._ope_key2 = value;
        this.SendPropertyChanged(nameof (ope_key2));
      }
    }

    [Column(Storage = "_ope_key3", DbType = "VarChar(50)")]
    public string ope_key3
    {
      get => this._ope_key3;
      set
      {
        if (!(this._ope_key3 != value))
          return;
        this.SendPropertyChanging();
        this._ope_key3 = value;
        this.SendPropertyChanged(nameof (ope_key3));
      }
    }

    [Column(Storage = "_ope_key4", DbType = "VarChar(50)")]
    public string ope_key4
    {
      get => this._ope_key4;
      set
      {
        if (!(this._ope_key4 != value))
          return;
        this.SendPropertyChanging();
        this._ope_key4 = value;
        this.SendPropertyChanged(nameof (ope_key4));
      }
    }

    [Column(Storage = "_ope_nombre", DbType = "VarChar(250) NOT NULL", CanBeNull = false)]
    public string ope_nombre
    {
      get => this._ope_nombre;
      set
      {
        if (!(this._ope_nombre != value))
          return;
        this.SendPropertyChanging();
        this._ope_nombre = value;
        this.SendPropertyChanged(nameof (ope_nombre));
      }
    }

    [Column(Storage = "_ope_key1Nombre", DbType = "VarChar(50)")]
    public string ope_key1Nombre
    {
      get => this._ope_key1Nombre;
      set
      {
        if (!(this._ope_key1Nombre != value))
          return;
        this.SendPropertyChanging();
        this._ope_key1Nombre = value;
        this.SendPropertyChanged(nameof (ope_key1Nombre));
      }
    }

    [Column(Storage = "_ope_key2Nombre", DbType = "VarChar(50)")]
    public string ope_key2Nombre
    {
      get => this._ope_key2Nombre;
      set
      {
        if (!(this._ope_key2Nombre != value))
          return;
        this.SendPropertyChanging();
        this._ope_key2Nombre = value;
        this.SendPropertyChanged(nameof (ope_key2Nombre));
      }
    }

    [Column(Storage = "_ope_key3Nombre", DbType = "VarChar(50)")]
    public string ope_key3Nombre
    {
      get => this._ope_key3Nombre;
      set
      {
        if (!(this._ope_key3Nombre != value))
          return;
        this.SendPropertyChanging();
        this._ope_key3Nombre = value;
        this.SendPropertyChanged(nameof (ope_key3Nombre));
      }
    }

    [Column(Storage = "_ope_key4Nombre", DbType = "VarChar(50)")]
    public string ope_key4Nombre
    {
      get => this._ope_key4Nombre;
      set
      {
        if (!(this._ope_key4Nombre != value))
          return;
        this.SendPropertyChanging();
        this._ope_key4Nombre = value;
        this.SendPropertyChanged(nameof (ope_key4Nombre));
      }
    }

    [Column(Storage = "_ope_permiso", DbType = "Bit")]
    public bool? ope_permiso
    {
      get => this._ope_permiso;
      set
      {
        bool? opePermiso = this._ope_permiso;
        bool? nullable = value;
        if ((opePermiso.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (opePermiso.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._ope_permiso = value;
        this.SendPropertyChanged(nameof (ope_permiso));
      }
    }

    [Association(Name = "ope_Operacion_ahi_AuditoriaHistorico", Storage = "_ahi_AuditoriaHistoricos", ThisKey = "ope_id", OtherKey = "ope_id")]
    public EntitySet<ahi_AuditoriaHistorico> ahi_AuditoriaHistoricos
    {
      get => this._ahi_AuditoriaHistoricos;
      set => this._ahi_AuditoriaHistoricos.Assign((IEnumerable<ahi_AuditoriaHistorico>) value);
    }

    [Association(Name = "ope_Operacion_aud_Auditoria", Storage = "_aud_Auditorias", ThisKey = "ope_id", OtherKey = "ope_id")]
    public EntitySet<aud_Auditoria> aud_Auditorias
    {
      get => this._aud_Auditorias;
      set => this._aud_Auditorias.Assign((IEnumerable<aud_Auditoria>) value);
    }

    [Association(Name = "ope_Operacion_pgr_PermisoGrupo", Storage = "_pgr_PermisoGrupos", ThisKey = "ope_id", OtherKey = "ope_id")]
    public EntitySet<pgr_PermisoGrupo> pgr_PermisoGrupos
    {
      get => this._pgr_PermisoGrupos;
      set => this._pgr_PermisoGrupos.Assign((IEnumerable<pgr_PermisoGrupo>) value);
    }

    [Association(Name = "mod_Modulo_ope_Operacion", Storage = "_mod_Modulo", ThisKey = "mod_id", OtherKey = "mod_id", IsForeignKey = true)]
    public mod_Modulo mod_Modulo
    {
      get => this._mod_Modulo.Entity;
      set
      {
        mod_Modulo entity = this._mod_Modulo.Entity;
        if (entity == value && this._mod_Modulo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._mod_Modulo.Entity = (mod_Modulo) null;
          entity.ope_Operacions.Remove(this);
        }
        this._mod_Modulo.Entity = value;
        if (value != null)
        {
          value.ope_Operacions.Add(this);
          this._mod_id = value.mod_id;
        }
        else
          this._mod_id = 0;
        this.SendPropertyChanged(nameof (mod_Modulo));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, ope_Operacion.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_ahi_AuditoriaHistoricos(ahi_AuditoriaHistorico entity)
    {
      this.SendPropertyChanging();
      entity.ope_Operacion = this;
    }

    private void detach_ahi_AuditoriaHistoricos(ahi_AuditoriaHistorico entity)
    {
      this.SendPropertyChanging();
      entity.ope_Operacion = (ope_Operacion) null;
    }

    private void attach_aud_Auditorias(aud_Auditoria entity)
    {
      this.SendPropertyChanging();
      entity.ope_Operacion = this;
    }

    private void detach_aud_Auditorias(aud_Auditoria entity)
    {
      this.SendPropertyChanging();
      entity.ope_Operacion = (ope_Operacion) null;
    }

    private void attach_pgr_PermisoGrupos(pgr_PermisoGrupo entity)
    {
      this.SendPropertyChanging();
      entity.ope_Operacion = this;
    }

    private void detach_pgr_PermisoGrupos(pgr_PermisoGrupo entity)
    {
      this.SendPropertyChanging();
      entity.ope_Operacion = (ope_Operacion) null;
    }
  }
}
