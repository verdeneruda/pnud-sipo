// Decompiled with JetBrains decompiler
// Type: UTO.aud_Auditoria
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO
{
  [Table(Name = "dbo.aud_Auditoria")]
  public class aud_Auditoria : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _aud_id;
    private int _ope_id;
    private int _usu_id;
    private string _aud_comentario;
    private DateTime _aud_fecha;
    private string _aud_key1;
    private string _aud_key2;
    private string _aud_key3;
    private string _aud_key4;
    private EntityRef<usu_Usuario> _usu_Usuario;
    private EntityRef<ope_Operacion> _ope_Operacion;

    public aud_Auditoria()
    {
      this._usu_Usuario = new EntityRef<usu_Usuario>();
      this._ope_Operacion = new EntityRef<ope_Operacion>();
    }

    [Column(Storage = "_aud_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int aud_id
    {
      get => this._aud_id;
      set
      {
        if (this._aud_id == value)
          return;
        this.SendPropertyChanging();
        this._aud_id = value;
        this.SendPropertyChanged(nameof (aud_id));
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

    [Column(Storage = "_aud_comentario", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string aud_comentario
    {
      get => this._aud_comentario;
      set
      {
        if (!(this._aud_comentario != value))
          return;
        this.SendPropertyChanging();
        this._aud_comentario = value;
        this.SendPropertyChanged(nameof (aud_comentario));
      }
    }

    [Column(Storage = "_aud_fecha", DbType = "DateTime NOT NULL")]
    public DateTime aud_fecha
    {
      get => this._aud_fecha;
      set
      {
        if (!(this._aud_fecha != value))
          return;
        this.SendPropertyChanging();
        this._aud_fecha = value;
        this.SendPropertyChanged(nameof (aud_fecha));
      }
    }

    [Column(Storage = "_aud_key1", DbType = "VarChar(250) NOT NULL", CanBeNull = false)]
    public string aud_key1
    {
      get => this._aud_key1;
      set
      {
        if (!(this._aud_key1 != value))
          return;
        this.SendPropertyChanging();
        this._aud_key1 = value;
        this.SendPropertyChanged(nameof (aud_key1));
      }
    }

    [Column(Storage = "_aud_key2", DbType = "VarChar(250) NOT NULL", CanBeNull = false)]
    public string aud_key2
    {
      get => this._aud_key2;
      set
      {
        if (!(this._aud_key2 != value))
          return;
        this.SendPropertyChanging();
        this._aud_key2 = value;
        this.SendPropertyChanged(nameof (aud_key2));
      }
    }

    [Column(Storage = "_aud_key3", DbType = "VarChar(250) NOT NULL", CanBeNull = false)]
    public string aud_key3
    {
      get => this._aud_key3;
      set
      {
        if (!(this._aud_key3 != value))
          return;
        this.SendPropertyChanging();
        this._aud_key3 = value;
        this.SendPropertyChanged(nameof (aud_key3));
      }
    }

    [Column(Storage = "_aud_key4", DbType = "VarChar(250) NOT NULL", CanBeNull = false)]
    public string aud_key4
    {
      get => this._aud_key4;
      set
      {
        if (!(this._aud_key4 != value))
          return;
        this.SendPropertyChanging();
        this._aud_key4 = value;
        this.SendPropertyChanged(nameof (aud_key4));
      }
    }

    [Association(Name = "usu_Usuario_aud_Auditoria", Storage = "_usu_Usuario", ThisKey = "usu_id", OtherKey = "usu_id", IsForeignKey = true)]
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
          entity.aud_Auditorias.Remove(this);
        }
        this._usu_Usuario.Entity = value;
        if (value != null)
        {
          value.aud_Auditorias.Add(this);
          this._usu_id = value.usu_id;
        }
        else
          this._usu_id = 0;
        this.SendPropertyChanged(nameof (usu_Usuario));
      }
    }

    [Association(Name = "ope_Operacion_aud_Auditoria", Storage = "_ope_Operacion", ThisKey = "ope_id", OtherKey = "ope_id", IsForeignKey = true)]
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
          entity.aud_Auditorias.Remove(this);
        }
        this._ope_Operacion.Entity = value;
        if (value != null)
        {
          value.aud_Auditorias.Add(this);
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
      this.PropertyChanging((object) this, aud_Auditoria.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
