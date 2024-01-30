// Decompiled with JetBrains decompiler
// Type: UTO.ahi_AuditoriaHistorico
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO
{
  [Table(Name = "dbo.ahi_AuditoriaHistorico")]
  public class ahi_AuditoriaHistorico : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ahi_id;
    private int _ope_id;
    private int _usu_id;
    private string _ahi_comentario;
    private DateTime _ahi_fecha;
    private string _ahi_key1;
    private string _ahi_key2;
    private string _ahi_key3;
    private string _ahi_key4;
    private EntityRef<usu_Usuario> _usu_Usuario;
    private EntityRef<ope_Operacion> _ope_Operacion;

    public ahi_AuditoriaHistorico()
    {
      this._usu_Usuario = new EntityRef<usu_Usuario>();
      this._ope_Operacion = new EntityRef<ope_Operacion>();
    }

    [Column(Storage = "_ahi_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int ahi_id
    {
      get => this._ahi_id;
      set
      {
        if (this._ahi_id == value)
          return;
        this.SendPropertyChanging();
        this._ahi_id = value;
        this.SendPropertyChanged(nameof (ahi_id));
      }
    }

    [Column(Storage = "_ope_id", DbType = "Int NOT NULL")]
    public int ope_id
    {
      get => this._ope_id;
      set
      {
        if (this._ope_id == value)
          return;
        if (this._ope_Operacion.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ope_id = value;
        this.SendPropertyChanged(nameof (ope_id));
      }
    }

    [Column(Storage = "_usu_id", DbType = "Int NOT NULL")]
    public int usu_id
    {
      get => this._usu_id;
      set
      {
        if (this._usu_id == value)
          return;
        if (this._usu_Usuario.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._usu_id = value;
        this.SendPropertyChanged(nameof (usu_id));
      }
    }

    [Column(Storage = "_ahi_comentario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string ahi_comentario
    {
      get => this._ahi_comentario;
      set
      {
        if (!(this._ahi_comentario != value))
          return;
        this.SendPropertyChanging();
        this._ahi_comentario = value;
        this.SendPropertyChanged(nameof (ahi_comentario));
      }
    }

    [Column(Storage = "_ahi_fecha", DbType = "DateTime NOT NULL")]
    public DateTime ahi_fecha
    {
      get => this._ahi_fecha;
      set
      {
        if (!(this._ahi_fecha != value))
          return;
        this.SendPropertyChanging();
        this._ahi_fecha = value;
        this.SendPropertyChanged(nameof (ahi_fecha));
      }
    }

    [Column(Storage = "_ahi_key1", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string ahi_key1
    {
      get => this._ahi_key1;
      set
      {
        if (!(this._ahi_key1 != value))
          return;
        this.SendPropertyChanging();
        this._ahi_key1 = value;
        this.SendPropertyChanged(nameof (ahi_key1));
      }
    }

    [Column(Storage = "_ahi_key2", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string ahi_key2
    {
      get => this._ahi_key2;
      set
      {
        if (!(this._ahi_key2 != value))
          return;
        this.SendPropertyChanging();
        this._ahi_key2 = value;
        this.SendPropertyChanged(nameof (ahi_key2));
      }
    }

    [Column(Storage = "_ahi_key3", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string ahi_key3
    {
      get => this._ahi_key3;
      set
      {
        if (!(this._ahi_key3 != value))
          return;
        this.SendPropertyChanging();
        this._ahi_key3 = value;
        this.SendPropertyChanged(nameof (ahi_key3));
      }
    }

    [Column(Storage = "_ahi_key4", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string ahi_key4
    {
      get => this._ahi_key4;
      set
      {
        if (!(this._ahi_key4 != value))
          return;
        this.SendPropertyChanging();
        this._ahi_key4 = value;
        this.SendPropertyChanged(nameof (ahi_key4));
      }
    }

    [Association(Name = "usu_Usuario_ahi_AuditoriaHistorico", Storage = "_usu_Usuario", ThisKey = "usu_id", OtherKey = "usu_id", IsForeignKey = true)]
    public usu_Usuario usu_Usuario
    {
      get => this._usu_Usuario.Entity;
      set
      {
        usu_Usuario entity = this._usu_Usuario.Entity;
        if (entity == value && this._usu_Usuario.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._usu_Usuario.Entity = (usu_Usuario) null;
          entity.ahi_AuditoriaHistoricos.Remove(this);
        }
        this._usu_Usuario.Entity = value;
        if (value != null)
        {
          value.ahi_AuditoriaHistoricos.Add(this);
          this._usu_id = value.usu_id;
        }
        else
          this._usu_id = 0;
        this.SendPropertyChanged(nameof (usu_Usuario));
      }
    }

    [Association(Name = "ope_Operacion_ahi_AuditoriaHistorico", Storage = "_ope_Operacion", ThisKey = "ope_id", OtherKey = "ope_id", IsForeignKey = true)]
    public ope_Operacion ope_Operacion
    {
      get => this._ope_Operacion.Entity;
      set
      {
        ope_Operacion entity = this._ope_Operacion.Entity;
        if (entity == value && this._ope_Operacion.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._ope_Operacion.Entity = (ope_Operacion) null;
          entity.ahi_AuditoriaHistoricos.Remove(this);
        }
        this._ope_Operacion.Entity = value;
        if (value != null)
        {
          value.ahi_AuditoriaHistoricos.Add(this);
          this._ope_id = value.ope_id;
        }
        else
          this._ope_id = 0;
        this.SendPropertyChanged(nameof (ope_Operacion));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, ahi_AuditoriaHistorico.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
