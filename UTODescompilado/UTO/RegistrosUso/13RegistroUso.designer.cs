// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.tri_TemporalRegistroReporteImportador
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace UTO.RegistrosUso
{
  [Table(Name = "Rus.tri_TemporalRegistroReporteImportador")]
  public class tri_TemporalRegistroReporteImportador : 
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _id;
    private string _CLIENTE;
    private string _NUMERO;
    private string _CIUDAD;
    private string _DIRECCION;
    private string _SUSTANCIA;
    private string _KILOS;
    private string _PROVEEDOR;
    private string _APLICACION;
    private string _mun_id;
    private string _dep_id;
    private int? _apl_id;
    private int? _sus_id;
    private int? _ter_idCliente;
    private int? _ter_idImportador;
    private string _ERROR;

    [Column(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int id
    {
      get => this._id;
      set
      {
        if (this._id == value)
          return;
        this.SendPropertyChanging();
        this._id = value;
        this.SendPropertyChanged(nameof (id));
      }
    }

    [Column(Storage = "_CLIENTE", DbType = "VarChar(255)")]
    public string CLIENTE
    {
      get => this._CLIENTE;
      set
      {
        if (!(this._CLIENTE != value))
          return;
        this.SendPropertyChanging();
        this._CLIENTE = value;
        this.SendPropertyChanged(nameof (CLIENTE));
      }
    }

    [Column(Storage = "_NUMERO", DbType = "VarChar(255)")]
    public string NUMERO
    {
      get => this._NUMERO;
      set
      {
        if (!(this._NUMERO != value))
          return;
        this.SendPropertyChanging();
        this._NUMERO = value;
        this.SendPropertyChanged(nameof (NUMERO));
      }
    }

    [Column(Storage = "_CIUDAD", DbType = "VarChar(255)")]
    public string CIUDAD
    {
      get => this._CIUDAD;
      set
      {
        if (!(this._CIUDAD != value))
          return;
        this.SendPropertyChanging();
        this._CIUDAD = value;
        this.SendPropertyChanged(nameof (CIUDAD));
      }
    }

    [Column(Storage = "_DIRECCION", DbType = "VarChar(255)")]
    public string DIRECCION
    {
      get => this._DIRECCION;
      set
      {
        if (!(this._DIRECCION != value))
          return;
        this.SendPropertyChanging();
        this._DIRECCION = value;
        this.SendPropertyChanged(nameof (DIRECCION));
      }
    }

    [Column(Storage = "_SUSTANCIA", DbType = "VarChar(255)")]
    public string SUSTANCIA
    {
      get => this._SUSTANCIA;
      set
      {
        if (!(this._SUSTANCIA != value))
          return;
        this.SendPropertyChanging();
        this._SUSTANCIA = value;
        this.SendPropertyChanged(nameof (SUSTANCIA));
      }
    }

    [Column(Storage = "_KILOS", DbType = "VarChar(255)")]
    public string KILOS
    {
      get => this._KILOS;
      set
      {
        if (!(this._KILOS != value))
          return;
        this.SendPropertyChanging();
        this._KILOS = value;
        this.SendPropertyChanged(nameof (KILOS));
      }
    }

    [Column(Storage = "_PROVEEDOR", DbType = "VarChar(255)")]
    public string PROVEEDOR
    {
      get => this._PROVEEDOR;
      set
      {
        if (!(this._PROVEEDOR != value))
          return;
        this.SendPropertyChanging();
        this._PROVEEDOR = value;
        this.SendPropertyChanged(nameof (PROVEEDOR));
      }
    }

    [Column(Storage = "_APLICACION", DbType = "VarChar(255)")]
    public string APLICACION
    {
      get => this._APLICACION;
      set
      {
        if (!(this._APLICACION != value))
          return;
        this.SendPropertyChanging();
        this._APLICACION = value;
        this.SendPropertyChanged(nameof (APLICACION));
      }
    }

    [Column(Storage = "_mun_id", DbType = "VarChar(5)")]
    public string mun_id
    {
      get => this._mun_id;
      set
      {
        if (!(this._mun_id != value))
          return;
        this.SendPropertyChanging();
        this._mun_id = value;
        this.SendPropertyChanged(nameof (mun_id));
      }
    }

    [Column(Storage = "_dep_id", DbType = "VarChar(2)")]
    public string dep_id
    {
      get => this._dep_id;
      set
      {
        if (!(this._dep_id != value))
          return;
        this.SendPropertyChanging();
        this._dep_id = value;
        this.SendPropertyChanged(nameof (dep_id));
      }
    }

    [Column(Storage = "_apl_id", DbType = "Int")]
    public int? apl_id
    {
      get => this._apl_id;
      set
      {
        int? aplId = this._apl_id;
        int? nullable = value;
        if ((aplId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (aplId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._apl_id = value;
        this.SendPropertyChanged(nameof (apl_id));
      }
    }

    [Column(Storage = "_sus_id", DbType = "Int")]
    public int? sus_id
    {
      get => this._sus_id;
      set
      {
        int? susId = this._sus_id;
        int? nullable = value;
        if ((susId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (susId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._sus_id = value;
        this.SendPropertyChanged(nameof (sus_id));
      }
    }

    [Column(Storage = "_ter_idCliente", DbType = "Int")]
    public int? ter_idCliente
    {
      get => this._ter_idCliente;
      set
      {
        int? terIdCliente = this._ter_idCliente;
        int? nullable = value;
        if ((terIdCliente.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (terIdCliente.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._ter_idCliente = value;
        this.SendPropertyChanged(nameof (ter_idCliente));
      }
    }

    [Column(Storage = "_ter_idImportador", DbType = "Int")]
    public int? ter_idImportador
    {
      get => this._ter_idImportador;
      set
      {
        int? terIdImportador = this._ter_idImportador;
        int? nullable = value;
        if ((terIdImportador.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (terIdImportador.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._ter_idImportador = value;
        this.SendPropertyChanged(nameof (ter_idImportador));
      }
    }

    [Column(Storage = "_ERROR", DbType = "VarChar(500)")]
    public string ERROR
    {
      get => this._ERROR;
      set
      {
        if (!(this._ERROR != value))
          return;
        this.SendPropertyChanging();
        this._ERROR = value;
        this.SendPropertyChanged(nameof (ERROR));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, tri_TemporalRegistroReporteImportador.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
