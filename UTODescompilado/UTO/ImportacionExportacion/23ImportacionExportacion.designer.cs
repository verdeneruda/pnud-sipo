// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.cim_CertificacionImportador
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  [Table(Name = "Iye.cim_CertificacionImportador")]
  public class cim_CertificacionImportador : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _cim_Id;
    private string _cim_NumeroRadicado;
    private DateTime _cim_FechaRadicado;
    private int _ter_IdRadicadoPor;
    private int _ter_IdImportador;
    private int _pas_IdProcedencia;
    private int _ter_IdEmpresa;
    private int _meq_Id;
    private string _cim_Descripcion;
    private DateTime _cim_FechaCertificado;
    private bool? _cim_AutorizaOtroRadicado;
    private string _cim_NumeroRadicadoUtilizado;
    private DateTime? _cim_FechaRadicadoUtilizado;
    private string _cim_Usuario;
    private DateTime _cim_Creado;
    private DateTime _cim_Modificado;
    private bool? _cim_Fabricante;
    private bool? _cim_Distribuidor;
    private EntityRef<meq_MarcaEquipo> _meq_MarcaEquipo;
    private EntityRef<pas_Pai> _pas_Pai;
    private EntityRef<ter_Tercero> _ter_Tercero;
    private EntityRef<ter_Tercero> _ter_Tercero1;
    private EntityRef<ter_Tercero> _ter_Tercero2;

    public cim_CertificacionImportador()
    {
      this._meq_MarcaEquipo = new EntityRef<meq_MarcaEquipo>();
      this._pas_Pai = new EntityRef<pas_Pai>();
      this._ter_Tercero = new EntityRef<ter_Tercero>();
      this._ter_Tercero1 = new EntityRef<ter_Tercero>();
      this._ter_Tercero2 = new EntityRef<ter_Tercero>();
    }

    [Column(Storage = "_cim_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int cim_Id
    {
      get => this._cim_Id;
      set
      {
        if (this._cim_Id == value)
          return;
        this.SendPropertyChanging();
        this._cim_Id = value;
        this.SendPropertyChanged(nameof (cim_Id));
      }
    }

    [Column(Storage = "_cim_NumeroRadicado", DbType = "VarChar(25) NOT NULL", CanBeNull = false)]
    public string cim_NumeroRadicado
    {
      get => this._cim_NumeroRadicado;
      set
      {
        if (!(this._cim_NumeroRadicado != value))
          return;
        this.SendPropertyChanging();
        this._cim_NumeroRadicado = value;
        this.SendPropertyChanged(nameof (cim_NumeroRadicado));
      }
    }

    [Column(Storage = "_cim_FechaRadicado", DbType = "DateTime NOT NULL")]
    public DateTime cim_FechaRadicado
    {
      get => this._cim_FechaRadicado;
      set
      {
        if (!(this._cim_FechaRadicado != value))
          return;
        this.SendPropertyChanging();
        this._cim_FechaRadicado = value;
        this.SendPropertyChanged(nameof (cim_FechaRadicado));
      }
    }

    [Column(Storage = "_ter_IdRadicadoPor", DbType = "Int NOT NULL")]
    public int ter_IdRadicadoPor
    {
      get => this._ter_IdRadicadoPor;
      set
      {
        if (this._ter_IdRadicadoPor == value)
          return;
        if (this._ter_Tercero2.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ter_IdRadicadoPor = value;
        this.SendPropertyChanged(nameof (ter_IdRadicadoPor));
      }
    }

    [Column(Storage = "_ter_IdImportador", DbType = "Int NOT NULL")]
    public int ter_IdImportador
    {
      get => this._ter_IdImportador;
      set
      {
        if (this._ter_IdImportador == value)
          return;
        if (this._ter_Tercero1.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ter_IdImportador = value;
        this.SendPropertyChanged(nameof (ter_IdImportador));
      }
    }

    [Column(Storage = "_pas_IdProcedencia", DbType = "Int NOT NULL")]
    public int pas_IdProcedencia
    {
      get => this._pas_IdProcedencia;
      set
      {
        if (this._pas_IdProcedencia == value)
          return;
        if (this._pas_Pai.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._pas_IdProcedencia = value;
        this.SendPropertyChanged(nameof (pas_IdProcedencia));
      }
    }

    [Column(Storage = "_ter_IdEmpresa", DbType = "Int NOT NULL")]
    public int ter_IdEmpresa
    {
      get => this._ter_IdEmpresa;
      set
      {
        if (this._ter_IdEmpresa == value)
          return;
        if (this._ter_Tercero.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ter_IdEmpresa = value;
        this.SendPropertyChanged(nameof (ter_IdEmpresa));
      }
    }

    [Column(Storage = "_meq_Id", DbType = "Int NOT NULL")]
    public int meq_Id
    {
      get => this._meq_Id;
      set
      {
        if (this._meq_Id == value)
          return;
        if (this._meq_MarcaEquipo.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._meq_Id = value;
        this.SendPropertyChanged(nameof (meq_Id));
      }
    }

    [Column(Storage = "_cim_Descripcion", DbType = "VarChar(2500)")]
    public string cim_Descripcion
    {
      get => this._cim_Descripcion;
      set
      {
        if (!(this._cim_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._cim_Descripcion = value;
        this.SendPropertyChanged(nameof (cim_Descripcion));
      }
    }

    [Column(Storage = "_cim_FechaCertificado", DbType = "DateTime NOT NULL")]
    public DateTime cim_FechaCertificado
    {
      get => this._cim_FechaCertificado;
      set
      {
        if (!(this._cim_FechaCertificado != value))
          return;
        this.SendPropertyChanging();
        this._cim_FechaCertificado = value;
        this.SendPropertyChanged(nameof (cim_FechaCertificado));
      }
    }

    [Column(Storage = "_cim_AutorizaOtroRadicado", DbType = "Bit")]
    public bool? cim_AutorizaOtroRadicado
    {
      get => this._cim_AutorizaOtroRadicado;
      set
      {
        bool? autorizaOtroRadicado = this._cim_AutorizaOtroRadicado;
        bool? nullable = value;
        if ((autorizaOtroRadicado.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (autorizaOtroRadicado.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._cim_AutorizaOtroRadicado = value;
        this.SendPropertyChanged(nameof (cim_AutorizaOtroRadicado));
      }
    }

    [Column(Storage = "_cim_NumeroRadicadoUtilizado", DbType = "VarChar(25)")]
    public string cim_NumeroRadicadoUtilizado
    {
      get => this._cim_NumeroRadicadoUtilizado;
      set
      {
        if (!(this._cim_NumeroRadicadoUtilizado != value))
          return;
        this.SendPropertyChanging();
        this._cim_NumeroRadicadoUtilizado = value;
        this.SendPropertyChanged(nameof (cim_NumeroRadicadoUtilizado));
      }
    }

    [Column(Storage = "_cim_FechaRadicadoUtilizado", DbType = "DateTime")]
    public DateTime? cim_FechaRadicadoUtilizado
    {
      get => this._cim_FechaRadicadoUtilizado;
      set
      {
        DateTime? radicadoUtilizado = this._cim_FechaRadicadoUtilizado;
        DateTime? nullable = value;
        if ((radicadoUtilizado.HasValue != nullable.HasValue ? 1 : (!radicadoUtilizado.HasValue ? 0 : (radicadoUtilizado.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._cim_FechaRadicadoUtilizado = value;
        this.SendPropertyChanged(nameof (cim_FechaRadicadoUtilizado));
      }
    }

    [Column(Storage = "_cim_Usuario", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
    public string cim_Usuario
    {
      get => this._cim_Usuario;
      set
      {
        if (!(this._cim_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._cim_Usuario = value;
        this.SendPropertyChanged(nameof (cim_Usuario));
      }
    }

    [Column(Storage = "_cim_Creado", DbType = "DateTime NOT NULL")]
    public DateTime cim_Creado
    {
      get => this._cim_Creado;
      set
      {
        if (!(this._cim_Creado != value))
          return;
        this.SendPropertyChanging();
        this._cim_Creado = value;
        this.SendPropertyChanged(nameof (cim_Creado));
      }
    }

    [Column(Storage = "_cim_Modificado", DbType = "DateTime NOT NULL")]
    public DateTime cim_Modificado
    {
      get => this._cim_Modificado;
      set
      {
        if (!(this._cim_Modificado != value))
          return;
        this.SendPropertyChanging();
        this._cim_Modificado = value;
        this.SendPropertyChanged(nameof (cim_Modificado));
      }
    }

    [Column(Storage = "_cim_Fabricante", DbType = "Bit")]
    public bool? cim_Fabricante
    {
      get => this._cim_Fabricante;
      set
      {
        bool? cimFabricante = this._cim_Fabricante;
        bool? nullable = value;
        if ((cimFabricante.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (cimFabricante.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._cim_Fabricante = value;
        this.SendPropertyChanged(nameof (cim_Fabricante));
      }
    }

    [Column(Storage = "_cim_Distribuidor", DbType = "Bit")]
    public bool? cim_Distribuidor
    {
      get => this._cim_Distribuidor;
      set
      {
        bool? cimDistribuidor = this._cim_Distribuidor;
        bool? nullable = value;
        if ((cimDistribuidor.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (cimDistribuidor.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._cim_Distribuidor = value;
        this.SendPropertyChanged(nameof (cim_Distribuidor));
      }
    }

    [Association(Name = "meq_MarcaEquipo_cim_CertificacionImportador", Storage = "_meq_MarcaEquipo", ThisKey = "meq_Id", OtherKey = "meq_id", IsForeignKey = true)]
    public meq_MarcaEquipo meq_MarcaEquipo
    {
      get => this._meq_MarcaEquipo.Entity;
      set
      {
        meq_MarcaEquipo entity = this._meq_MarcaEquipo.Entity;
        if (entity == value && this._meq_MarcaEquipo.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._meq_MarcaEquipo.Entity = (meq_MarcaEquipo) null;
          entity.cim_CertificacionImportadors.Remove(this);
        }
        this._meq_MarcaEquipo.Entity = value;
        if (value != null)
        {
          value.cim_CertificacionImportadors.Add(this);
          this._meq_Id = value.meq_id;
        }
        else
          this._meq_Id = 0;
        this.SendPropertyChanged(nameof (meq_MarcaEquipo));
      }
    }

    [Association(Name = "pas_Pai_cim_CertificacionImportador", Storage = "_pas_Pai", ThisKey = "pas_IdProcedencia", OtherKey = "pas_Id", IsForeignKey = true)]
    public pas_Pai pas_Pai
    {
      get => this._pas_Pai.Entity;
      set
      {
        pas_Pai entity = this._pas_Pai.Entity;
        if (entity == value && this._pas_Pai.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._pas_Pai.Entity = (pas_Pai) null;
          entity.cim_CertificacionImportadors.Remove(this);
        }
        this._pas_Pai.Entity = value;
        if (value != null)
        {
          value.cim_CertificacionImportadors.Add(this);
          this._pas_IdProcedencia = value.pas_Id;
        }
        else
          this._pas_IdProcedencia = 0;
        this.SendPropertyChanged(nameof (pas_Pai));
      }
    }

    [Association(Name = "ter_Tercero_cim_CertificacionImportador", Storage = "_ter_Tercero", ThisKey = "ter_IdEmpresa", OtherKey = "ter_Id", IsForeignKey = true)]
    public ter_Tercero ter_Tercero
    {
      get => this._ter_Tercero.Entity;
      set
      {
        ter_Tercero entity = this._ter_Tercero.Entity;
        if (entity == value && this._ter_Tercero.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._ter_Tercero.Entity = (ter_Tercero) null;
          entity.cim_CertificacionImportadors.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.cim_CertificacionImportadors.Add(this);
          this._ter_IdEmpresa = value.ter_Id;
        }
        else
          this._ter_IdEmpresa = 0;
        this.SendPropertyChanged(nameof (ter_Tercero));
      }
    }

    [Association(Name = "ter_Tercero_cim_CertificacionImportador1", Storage = "_ter_Tercero1", ThisKey = "ter_IdImportador", OtherKey = "ter_Id", IsForeignKey = true)]
    public ter_Tercero ter_Tercero1
    {
      get => this._ter_Tercero1.Entity;
      set
      {
        ter_Tercero entity = this._ter_Tercero1.Entity;
        if (entity == value && this._ter_Tercero1.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._ter_Tercero1.Entity = (ter_Tercero) null;
          entity.cim_CertificacionImportadors1.Remove(this);
        }
        this._ter_Tercero1.Entity = value;
        if (value != null)
        {
          value.cim_CertificacionImportadors1.Add(this);
          this._ter_IdImportador = value.ter_Id;
        }
        else
          this._ter_IdImportador = 0;
        this.SendPropertyChanged(nameof (ter_Tercero1));
      }
    }

    [Association(Name = "ter_Tercero_cim_CertificacionImportador2", Storage = "_ter_Tercero2", ThisKey = "ter_IdRadicadoPor", OtherKey = "ter_Id", IsForeignKey = true)]
    public ter_Tercero ter_Tercero2
    {
      get => this._ter_Tercero2.Entity;
      set
      {
        ter_Tercero entity = this._ter_Tercero2.Entity;
        if (entity == value && this._ter_Tercero2.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._ter_Tercero2.Entity = (ter_Tercero) null;
          entity.cim_CertificacionImportadors2.Remove(this);
        }
        this._ter_Tercero2.Entity = value;
        if (value != null)
        {
          value.cim_CertificacionImportadors2.Add(this);
          this._ter_IdRadicadoPor = value.ter_Id;
        }
        else
          this._ter_IdRadicadoPor = 0;
        this.SendPropertyChanged(nameof (ter_Tercero2));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, cim_CertificacionImportador.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
