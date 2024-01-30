// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.nea_NovedadEquiposAsignado
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.nea_NovedadEquiposAsignados")]
  public class nea_NovedadEquiposAsignado : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _nea_Id;
    private int _neq_Id;
    private int _eki_Id;
    private string _nea_Serie;
    private string _nea_Placa;
    private int? _nea_Cantidad;
    private EntityRef<neq_NovedadEquipo> _neq_NovedadEquipo;
    private EntityRef<eki_EquipoKit> _eki_EquipoKit;

    public nea_NovedadEquiposAsignado()
    {
      this._neq_NovedadEquipo = new EntityRef<neq_NovedadEquipo>();
      this._eki_EquipoKit = new EntityRef<eki_EquipoKit>();
    }

    [Column(Storage = "_nea_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int nea_Id
    {
      get => this._nea_Id;
      set
      {
        if (this._nea_Id == value)
          return;
        this.SendPropertyChanging();
        this._nea_Id = value;
        this.SendPropertyChanged(nameof (nea_Id));
      }
    }

    [Column(Storage = "_neq_Id", DbType = "Int NOT NULL")]
    public int neq_Id
    {
      get => this._neq_Id;
      set
      {
        if (this._neq_Id == value)
          return;
        if (this._neq_NovedadEquipo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._neq_Id = value;
        this.SendPropertyChanged(nameof (neq_Id));
      }
    }

    [Column(Storage = "_eki_Id", DbType = "Int NOT NULL")]
    public int eki_Id
    {
      get => this._eki_Id;
      set
      {
        if (this._eki_Id == value)
          return;
        if (this._eki_EquipoKit.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._eki_Id = value;
        this.SendPropertyChanged(nameof (eki_Id));
      }
    }

    [Column(Storage = "_nea_Serie", DbType = "VarChar(50)")]
    public string nea_Serie
    {
      get => this._nea_Serie;
      set
      {
        if (!(this._nea_Serie != value))
          return;
        this.SendPropertyChanging();
        this._nea_Serie = value;
        this.SendPropertyChanged(nameof (nea_Serie));
      }
    }

    [Column(Storage = "_nea_Placa", DbType = "VarChar(50)")]
    public string nea_Placa
    {
      get => this._nea_Placa;
      set
      {
        if (!(this._nea_Placa != value))
          return;
        this.SendPropertyChanging();
        this._nea_Placa = value;
        this.SendPropertyChanged(nameof (nea_Placa));
      }
    }

    [Column(Storage = "_nea_Cantidad", DbType = "Int")]
    public int? nea_Cantidad
    {
      get => this._nea_Cantidad;
      set
      {
        int? neaCantidad = this._nea_Cantidad;
        int? nullable = value;
        if ((neaCantidad.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (neaCantidad.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._nea_Cantidad = value;
        this.SendPropertyChanged(nameof (nea_Cantidad));
      }
    }

    [Association(Name = "neq_NovedadEquipo_nea_NovedadEquiposAsignado", Storage = "_neq_NovedadEquipo", ThisKey = "neq_Id", OtherKey = "neq_Id", IsForeignKey = true)]
    public neq_NovedadEquipo neq_NovedadEquipo
    {
      get => this._neq_NovedadEquipo.Entity;
      set
      {
        neq_NovedadEquipo entity = this._neq_NovedadEquipo.Entity;
        if (entity == value && this._neq_NovedadEquipo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._neq_NovedadEquipo.Entity = (neq_NovedadEquipo) null;
          entity.nea_NovedadEquiposAsignados.Remove(this);
        }
        this._neq_NovedadEquipo.Entity = value;
        if (value != null)
        {
          value.nea_NovedadEquiposAsignados.Add(this);
          this._neq_Id = value.neq_Id;
        }
        else
          this._neq_Id = 0;
        this.SendPropertyChanged(nameof (neq_NovedadEquipo));
      }
    }

    [Association(Name = "eki_EquipoKit_nea_NovedadEquiposAsignado", Storage = "_eki_EquipoKit", ThisKey = "eki_Id", OtherKey = "eki_Id", IsForeignKey = true)]
    public eki_EquipoKit eki_EquipoKit
    {
      get => this._eki_EquipoKit.Entity;
      set
      {
        eki_EquipoKit entity = this._eki_EquipoKit.Entity;
        if (entity == value && this._eki_EquipoKit.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._eki_EquipoKit.Entity = (eki_EquipoKit) null;
          entity.nea_NovedadEquiposAsignados.Remove(this);
        }
        this._eki_EquipoKit.Entity = value;
        if (value != null)
        {
          value.nea_NovedadEquiposAsignados.Add(this);
          this._eki_Id = value.eki_Id;
        }
        else
          this._eki_Id = 0;
        this.SendPropertyChanged(nameof (eki_EquipoKit));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, nea_NovedadEquiposAsignado.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
