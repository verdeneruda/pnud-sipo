// Decompiled with JetBrains decompiler
// Type: UTO.usu_Usuario
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
  [Table(Name = "dbo.usu_Usuario")]
  public class usu_Usuario : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _usu_id;
    private string _usu_usuarioWindows;
    private string _usu_usuarioSql;
    private string _usu_claveSql;
    private string _usu_usuarioSigob;
    private string _usu_claveSigob;
    private bool? _usu_activo;
    private EntitySet<ahi_AuditoriaHistorico> _ahi_AuditoriaHistoricos;
    private EntitySet<aud_Auditoria> _aud_Auditorias;

    public usu_Usuario()
    {
      this._ahi_AuditoriaHistoricos = new EntitySet<ahi_AuditoriaHistorico>(new Action<ahi_AuditoriaHistorico>(this.attach_ahi_AuditoriaHistoricos), new Action<ahi_AuditoriaHistorico>(this.detach_ahi_AuditoriaHistoricos));
      this._aud_Auditorias = new EntitySet<aud_Auditoria>(new Action<aud_Auditoria>(this.attach_aud_Auditorias), new Action<aud_Auditoria>(this.detach_aud_Auditorias));
    }

    [Column(Storage = "_usu_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int usu_id
    {
      get => this._usu_id;
      set
      {
        if (this._usu_id == value)
          return;
        this.SendPropertyChanging();
        this._usu_id = value;
        this.SendPropertyChanged(nameof (usu_id));
      }
    }

    [Column(Storage = "_usu_usuarioWindows", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string usu_usuarioWindows
    {
      get => this._usu_usuarioWindows;
      set
      {
        if (!(this._usu_usuarioWindows != value))
          return;
        this.SendPropertyChanging();
        this._usu_usuarioWindows = value;
        this.SendPropertyChanged(nameof (usu_usuarioWindows));
      }
    }

    [Column(Storage = "_usu_usuarioSql", DbType = "VarChar(50)")]
    public string usu_usuarioSql
    {
      get => this._usu_usuarioSql;
      set
      {
        if (!(this._usu_usuarioSql != value))
          return;
        this.SendPropertyChanging();
        this._usu_usuarioSql = value;
        this.SendPropertyChanged(nameof (usu_usuarioSql));
      }
    }

    [Column(Storage = "_usu_claveSql", DbType = "VarChar(250)")]
    public string usu_claveSql
    {
      get => this._usu_claveSql;
      set
      {
        if (!(this._usu_claveSql != value))
          return;
        this.SendPropertyChanging();
        this._usu_claveSql = value;
        this.SendPropertyChanged(nameof (usu_claveSql));
      }
    }

    [Column(Storage = "_usu_usuarioSigob", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string usu_usuarioSigob
    {
      get => this._usu_usuarioSigob;
      set
      {
        if (!(this._usu_usuarioSigob != value))
          return;
        this.SendPropertyChanging();
        this._usu_usuarioSigob = value;
        this.SendPropertyChanged(nameof (usu_usuarioSigob));
      }
    }

    [Column(Storage = "_usu_claveSigob", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string usu_claveSigob
    {
      get => this._usu_claveSigob;
      set
      {
        if (!(this._usu_claveSigob != value))
          return;
        this.SendPropertyChanging();
        this._usu_claveSigob = value;
        this.SendPropertyChanged(nameof (usu_claveSigob));
      }
    }

    [Column(Storage = "_usu_activo", DbType = "Bit")]
    public bool? usu_activo
    {
      get => this._usu_activo;
      set
      {
        bool? usuActivo = this._usu_activo;
        bool? nullable = value;
        if ((usuActivo.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (usuActivo.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._usu_activo = value;
        this.SendPropertyChanged(nameof (usu_activo));
      }
    }

    [Association(Name = "usu_Usuario_ahi_AuditoriaHistorico", Storage = "_ahi_AuditoriaHistoricos", ThisKey = "usu_id", OtherKey = "usu_id")]
    public EntitySet<ahi_AuditoriaHistorico> ahi_AuditoriaHistoricos
    {
      get => this._ahi_AuditoriaHistoricos;
      set => this._ahi_AuditoriaHistoricos.Assign((IEnumerable<ahi_AuditoriaHistorico>) value);
    }

    [Association(Name = "usu_Usuario_aud_Auditoria", Storage = "_aud_Auditorias", ThisKey = "usu_id", OtherKey = "usu_id")]
    public EntitySet<aud_Auditoria> aud_Auditorias
    {
      get => this._aud_Auditorias;
      set => this._aud_Auditorias.Assign((IEnumerable<aud_Auditoria>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, usu_Usuario.emptyChangingEventArgs);
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
      entity.usu_Usuario = this;
    }

    private void detach_ahi_AuditoriaHistoricos(ahi_AuditoriaHistorico entity)
    {
      this.SendPropertyChanging();
      entity.usu_Usuario = (usu_Usuario) null;
    }

    private void attach_aud_Auditorias(aud_Auditoria entity)
    {
      this.SendPropertyChanging();
      entity.usu_Usuario = this;
    }

    private void detach_aud_Auditorias(aud_Auditoria entity)
    {
      this.SendPropertyChanging();
      entity.usu_Usuario = (usu_Usuario) null;
    }
  }
}
