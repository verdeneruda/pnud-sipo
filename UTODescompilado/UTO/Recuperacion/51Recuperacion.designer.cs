// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.sea_SolicitudEquiposAsignado
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.sea_SolicitudEquiposAsignados")]
  public class sea_SolicitudEquiposAsignado : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _sea_Id;
    private int _seq_Id;
    private int? _eki_Id;
    private string _sea_Serie;
    private string _sea_Placa;
    private int? _sea_Cantidad;
    private string _sea_DireccionAdicional;
    private string _sea_TelefonoAdicional;
    private string _mun_Id;
    private bool? _sea_SedePrinciapl;
    private EntityRef<eki_EquipoKit> _eki_EquipoKit;
    private EntityRef<seq_SolicitudEquipo> _seq_SolicitudEquipo;

    public sea_SolicitudEquiposAsignado()
    {
      this._eki_EquipoKit = new EntityRef<eki_EquipoKit>();
      this._seq_SolicitudEquipo = new EntityRef<seq_SolicitudEquipo>();
    }

    [Column(Storage = "_sea_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int sea_Id
    {
      get => this._sea_Id;
      set
      {
        if (this._sea_Id == value)
          return;
        this.SendPropertyChanging();
        this._sea_Id = value;
        this.SendPropertyChanged(nameof (sea_Id));
      }
    }

    [Column(Storage = "_seq_Id", DbType = "Int NOT NULL")]
    public int seq_Id
    {
      get => this._seq_Id;
      set
      {
        if (this._seq_Id == value)
          return;
        if (this._seq_SolicitudEquipo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._seq_Id = value;
        this.SendPropertyChanged(nameof (seq_Id));
      }
    }

    [Column(Storage = "_eki_Id", DbType = "Int")]
    public int? eki_Id
    {
      get => this._eki_Id;
      set
      {
        int? ekiId = this._eki_Id;
        int? nullable = value;
        if ((ekiId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (ekiId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        if (this._eki_EquipoKit.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._eki_Id = value;
        this.SendPropertyChanged(nameof (eki_Id));
      }
    }

    [Column(Storage = "_sea_Serie", DbType = "VarChar(50)")]
    public string sea_Serie
    {
      get => this._sea_Serie;
      set
      {
        if (!(this._sea_Serie != value))
          return;
        this.SendPropertyChanging();
        this._sea_Serie = value;
        this.SendPropertyChanged(nameof (sea_Serie));
      }
    }

    [Column(Storage = "_sea_Placa", DbType = "VarChar(50)")]
    public string sea_Placa
    {
      get => this._sea_Placa;
      set
      {
        if (!(this._sea_Placa != value))
          return;
        this.SendPropertyChanging();
        this._sea_Placa = value;
        this.SendPropertyChanged(nameof (sea_Placa));
      }
    }

    [Column(Storage = "_sea_Cantidad", DbType = "Int")]
    public int? sea_Cantidad
    {
      get => this._sea_Cantidad;
      set
      {
        int? seaCantidad = this._sea_Cantidad;
        int? nullable = value;
        if ((seaCantidad.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (seaCantidad.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._sea_Cantidad = value;
        this.SendPropertyChanged(nameof (sea_Cantidad));
      }
    }

    [Column(Storage = "_sea_DireccionAdicional", DbType = "VarChar(250)")]
    public string sea_DireccionAdicional
    {
      get => this._sea_DireccionAdicional;
      set
      {
        if (!(this._sea_DireccionAdicional != value))
          return;
        this.SendPropertyChanging();
        this._sea_DireccionAdicional = value;
        this.SendPropertyChanged(nameof (sea_DireccionAdicional));
      }
    }

    [Column(Storage = "_sea_TelefonoAdicional", DbType = "VarChar(50)")]
    public string sea_TelefonoAdicional
    {
      get => this._sea_TelefonoAdicional;
      set
      {
        if (!(this._sea_TelefonoAdicional != value))
          return;
        this.SendPropertyChanging();
        this._sea_TelefonoAdicional = value;
        this.SendPropertyChanged(nameof (sea_TelefonoAdicional));
      }
    }

    [Column(Storage = "_mun_Id", DbType = "VarChar(5)")]
    public string mun_Id
    {
      get => this._mun_Id;
      set
      {
        if (!(this._mun_Id != value))
          return;
        this.SendPropertyChanging();
        this._mun_Id = value;
        this.SendPropertyChanged(nameof (mun_Id));
      }
    }

    [Column(Storage = "_sea_SedePrinciapl", DbType = "Bit")]
    public bool? sea_SedePrinciapl
    {
      get => this._sea_SedePrinciapl;
      set
      {
        bool? seaSedePrinciapl = this._sea_SedePrinciapl;
        bool? nullable = value;
        if ((seaSedePrinciapl.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (seaSedePrinciapl.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._sea_SedePrinciapl = value;
        this.SendPropertyChanged(nameof (sea_SedePrinciapl));
      }
    }

    [Association(Name = "eki_EquipoKit_sea_SolicitudEquiposAsignado", Storage = "_eki_EquipoKit", ThisKey = "eki_Id", OtherKey = "eki_Id", IsForeignKey = true)]
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
          entity.sea_SolicitudEquiposAsignados.Remove(this);
        }
        this._eki_EquipoKit.Entity = value;
        if (value != null)
        {
          value.sea_SolicitudEquiposAsignados.Add(this);
          this._eki_Id = new int?(value.eki_Id);
        }
        else
          this._eki_Id = new int?();
        this.SendPropertyChanged(nameof (eki_EquipoKit));
      }
    }

    [Association(Name = "seq_SolicitudEquipo_sea_SolicitudEquiposAsignado", Storage = "_seq_SolicitudEquipo", ThisKey = "seq_Id", OtherKey = "seq_Id", IsForeignKey = true)]
    public seq_SolicitudEquipo seq_SolicitudEquipo
    {
      get => this._seq_SolicitudEquipo.Entity;
      set
      {
        seq_SolicitudEquipo entity = this._seq_SolicitudEquipo.Entity;
        if (entity == value && this._seq_SolicitudEquipo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._seq_SolicitudEquipo.Entity = (seq_SolicitudEquipo) null;
          entity.sea_SolicitudEquiposAsignados.Remove(this);
        }
        this._seq_SolicitudEquipo.Entity = value;
        if (value != null)
        {
          value.sea_SolicitudEquiposAsignados.Add(this);
          this._seq_Id = value.seq_Id;
        }
        else
          this._seq_Id = 0;
        this.SendPropertyChanged(nameof (seq_SolicitudEquipo));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, sea_SolicitudEquiposAsignado.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
