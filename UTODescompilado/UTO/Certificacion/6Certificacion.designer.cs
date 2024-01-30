// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.ted_TecnicoDetalle
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Certificacion
{
  [Table(Name = "Cer.ted_TecnicoDetalle")]
  public class ted_TecnicoDetalle : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ted_Id;
    private int _tec_Id;
    private DateTime _ted_FechaCertificacion;
    private DateTime _ted_Vigencia;
    private bool _ted_Actualizado;
    private bool _ted_Carnetizado;
    private string _ted_NumeroCarnet;
    private string _ted_Usuario;
    private DateTime _ted_Creado;
    private DateTime _ted_Modificado;
    private EntityRef<tec_Tecnico> _tec_Tecnico;

    public ted_TecnicoDetalle() => this._tec_Tecnico = new EntityRef<tec_Tecnico>();

    [Column(Storage = "_ted_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int ted_Id
    {
      get => this._ted_Id;
      set
      {
        if (this._ted_Id == value)
          return;
        this.SendPropertyChanging();
        this._ted_Id = value;
        this.SendPropertyChanged(nameof (ted_Id));
      }
    }

    [Column(Storage = "_tec_Id", DbType = "Int NOT NULL")]
    public int tec_Id
    {
      get => this._tec_Id;
      set
      {
        if (this._tec_Id == value)
          return;
        if (this._tec_Tecnico.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._tec_Id = value;
        this.SendPropertyChanged(nameof (tec_Id));
      }
    }

    [Column(Storage = "_ted_FechaCertificacion", DbType = "DateTime NOT NULL")]
    public DateTime ted_FechaCertificacion
    {
      get => this._ted_FechaCertificacion;
      set
      {
        if (!(this._ted_FechaCertificacion != value))
          return;
        this.SendPropertyChanging();
        this._ted_FechaCertificacion = value;
        this.SendPropertyChanged(nameof (ted_FechaCertificacion));
      }
    }

    [Column(Storage = "_ted_Vigencia", DbType = "DateTime NOT NULL")]
    public DateTime ted_Vigencia
    {
      get => this._ted_Vigencia;
      set
      {
        if (!(this._ted_Vigencia != value))
          return;
        this.SendPropertyChanging();
        this._ted_Vigencia = value;
        this.SendPropertyChanged(nameof (ted_Vigencia));
      }
    }

    [Column(Storage = "_ted_Actualizado", DbType = "Bit NOT NULL")]
    public bool ted_Actualizado
    {
      get => this._ted_Actualizado;
      set
      {
        if (this._ted_Actualizado == value)
          return;
        this.SendPropertyChanging();
        this._ted_Actualizado = value;
        this.SendPropertyChanged(nameof (ted_Actualizado));
      }
    }

    [Column(Storage = "_ted_Carnetizado", DbType = "Bit NOT NULL")]
    public bool ted_Carnetizado
    {
      get => this._ted_Carnetizado;
      set
      {
        if (this._ted_Carnetizado == value)
          return;
        this.SendPropertyChanging();
        this._ted_Carnetizado = value;
        this.SendPropertyChanged(nameof (ted_Carnetizado));
      }
    }

    [Column(Storage = "_ted_NumeroCarnet", DbType = "VarChar(20) NOT NULL", CanBeNull = false)]
    public string ted_NumeroCarnet
    {
      get => this._ted_NumeroCarnet;
      set
      {
        if (!(this._ted_NumeroCarnet != value))
          return;
        this.SendPropertyChanging();
        this._ted_NumeroCarnet = value;
        this.SendPropertyChanged(nameof (ted_NumeroCarnet));
      }
    }

    [Column(Storage = "_ted_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string ted_Usuario
    {
      get => this._ted_Usuario;
      set
      {
        if (!(this._ted_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._ted_Usuario = value;
        this.SendPropertyChanged(nameof (ted_Usuario));
      }
    }

    [Column(Storage = "_ted_Creado", DbType = "DateTime NOT NULL")]
    public DateTime ted_Creado
    {
      get => this._ted_Creado;
      set
      {
        if (!(this._ted_Creado != value))
          return;
        this.SendPropertyChanging();
        this._ted_Creado = value;
        this.SendPropertyChanged(nameof (ted_Creado));
      }
    }

    [Column(Storage = "_ted_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime ted_Modificado
    {
      get => this._ted_Modificado;
      set
      {
        if (!(this._ted_Modificado != value))
          return;
        this.SendPropertyChanging();
        this._ted_Modificado = value;
        this.SendPropertyChanged(nameof (ted_Modificado));
      }
    }

    [Association(Name = "tec_Tecnico_ted_TecnicoDetalle", Storage = "_tec_Tecnico", ThisKey = "tec_Id", OtherKey = "tec_Id", IsForeignKey = true)]
    public tec_Tecnico tec_Tecnico
    {
      get => this._tec_Tecnico.Entity;
      set
      {
        tec_Tecnico entity = this._tec_Tecnico.Entity;
        if (entity == value && this._tec_Tecnico.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._tec_Tecnico.Entity = (tec_Tecnico) null;
          entity.ted_TecnicoDetalles.Remove(this);
        }
        this._tec_Tecnico.Entity = value;
        if (value != null)
        {
          value.ted_TecnicoDetalles.Add(this);
          this._tec_Id = value.tec_Id;
        }
        else
          this._tec_Id = 0;
        this.SendPropertyChanged(nameof (tec_Tecnico));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, ted_TecnicoDetalle.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
