// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.rdb_ReporteUsoBarrido
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.Recuperacion
{
  [Table(Name = "Rrr.rdb_ReporteUsoBarrido")]
  public class rdb_ReporteUsoBarrido : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rdb_Id;
    private int _ter_Id;
    private string _rdb_Periodo;
    private int _rdb_Ano;
    private int _rdb_NitrogenoCilindro;
    private Decimal _rdb_NitrogenoKilo;
    private string _rdb_NitrogenoObservacion;
    private int _tim_IdNitrogeno;
    private int _rdb_FiltroUnidad;
    private int _tim_IdFiltro;
    private string _rdb_FiltroObservacion;
    private int _rdb_AcidezUnidad;
    private int _tim_IdAcidez;
    private string _rdb_AcidezObservacion;
    private EntitySet<rbd_ReporteUsoBarridoDocumento> _rbd_ReporteUsoBarridoDocumentos;
    private EntityRef<ter_Tercero> _ter_Tercero;
    private EntityRef<tim_TipoMantenimiento> _tim_TipoMantenimiento;
    private EntityRef<tim_TipoMantenimiento> _tim_TipoMantenimiento1;
    private EntityRef<tim_TipoMantenimiento> _tim_TipoMantenimiento2;

    public string OrdenAno
    {
      get
      {
        string str = this.rdb_Ano.ToString();
        string ordenAno;
        switch (this.rdb_Periodo.ToUpper())
        {
          case "PRIMERO":
            ordenAno = str + "1";
            break;
          case "SEGUNDO":
            ordenAno = str + "2";
            break;
          case "TERCERO":
            ordenAno = str + "3";
            break;
          case "CUARTO":
            ordenAno = str + "4";
            break;
          default:
            ordenAno = str + "1";
            break;
        }
        return ordenAno;
      }
    }

    public rdb_ReporteUsoBarrido()
    {
      this._rbd_ReporteUsoBarridoDocumentos = new EntitySet<rbd_ReporteUsoBarridoDocumento>(new Action<rbd_ReporteUsoBarridoDocumento>(this.attach_rbd_ReporteUsoBarridoDocumentos), new Action<rbd_ReporteUsoBarridoDocumento>(this.detach_rbd_ReporteUsoBarridoDocumentos));
      this._ter_Tercero = new EntityRef<ter_Tercero>();
      this._tim_TipoMantenimiento = new EntityRef<tim_TipoMantenimiento>();
      this._tim_TipoMantenimiento1 = new EntityRef<tim_TipoMantenimiento>();
      this._tim_TipoMantenimiento2 = new EntityRef<tim_TipoMantenimiento>();
    }

    [Column(Storage = "_rdb_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int rdb_Id
    {
      get => this._rdb_Id;
      set
      {
        if (this._rdb_Id == value)
          return;
        this.SendPropertyChanging();
        this._rdb_Id = value;
        this.SendPropertyChanged(nameof (rdb_Id));
      }
    }

    [Column(Storage = "_ter_Id", DbType = "Int NOT NULL")]
    public int ter_Id
    {
      get => this._ter_Id;
      set
      {
        if (this._ter_Id == value)
          return;
        if (this._ter_Tercero.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._ter_Id = value;
        this.SendPropertyChanged(nameof (ter_Id));
      }
    }

    [Column(Storage = "_rdb_Periodo", DbType = "VarChar(30) NOT NULL", CanBeNull = false)]
    public string rdb_Periodo
    {
      get => this._rdb_Periodo;
      set
      {
        if (!(this._rdb_Periodo != value))
          return;
        this.SendPropertyChanging();
        this._rdb_Periodo = value;
        this.SendPropertyChanged(nameof (rdb_Periodo));
      }
    }

    [Column(Storage = "_rdb_Ano", DbType = "Int NOT NULL")]
    public int rdb_Ano
    {
      get => this._rdb_Ano;
      set
      {
        if (this._rdb_Ano == value)
          return;
        this.SendPropertyChanging();
        this._rdb_Ano = value;
        this.SendPropertyChanged(nameof (rdb_Ano));
      }
    }

    [Column(Storage = "_rdb_NitrogenoCilindro", DbType = "Int NOT NULL")]
    public int rdb_NitrogenoCilindro
    {
      get => this._rdb_NitrogenoCilindro;
      set
      {
        if (this._rdb_NitrogenoCilindro == value)
          return;
        this.SendPropertyChanging();
        this._rdb_NitrogenoCilindro = value;
        this.SendPropertyChanged(nameof (rdb_NitrogenoCilindro));
      }
    }

    [Column(Storage = "_rdb_NitrogenoKilo", DbType = "Decimal(10,3) NOT NULL")]
    public Decimal rdb_NitrogenoKilo
    {
      get => this._rdb_NitrogenoKilo;
      set
      {
        if (!(this._rdb_NitrogenoKilo != value))
          return;
        this.SendPropertyChanging();
        this._rdb_NitrogenoKilo = value;
        this.SendPropertyChanged(nameof (rdb_NitrogenoKilo));
      }
    }

    [Column(Storage = "_rdb_NitrogenoObservacion", DbType = "VarChar(MAX) NOT NULL", CanBeNull = false)]
    public string rdb_NitrogenoObservacion
    {
      get => this._rdb_NitrogenoObservacion;
      set
      {
        if (!(this._rdb_NitrogenoObservacion != value))
          return;
        this.SendPropertyChanging();
        this._rdb_NitrogenoObservacion = value;
        this.SendPropertyChanged(nameof (rdb_NitrogenoObservacion));
      }
    }

    [Column(Storage = "_tim_IdNitrogeno", DbType = "Int NOT NULL")]
    public int tim_IdNitrogeno
    {
      get => this._tim_IdNitrogeno;
      set
      {
        if (this._tim_IdNitrogeno == value)
          return;
        if (this._tim_TipoMantenimiento2.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._tim_IdNitrogeno = value;
        this.SendPropertyChanged(nameof (tim_IdNitrogeno));
      }
    }

    [Column(Storage = "_rdb_FiltroUnidad", DbType = "Int NOT NULL")]
    public int rdb_FiltroUnidad
    {
      get => this._rdb_FiltroUnidad;
      set
      {
        if (this._rdb_FiltroUnidad == value)
          return;
        this.SendPropertyChanging();
        this._rdb_FiltroUnidad = value;
        this.SendPropertyChanged(nameof (rdb_FiltroUnidad));
      }
    }

    [Column(Storage = "_tim_IdFiltro", DbType = "Int NOT NULL")]
    public int tim_IdFiltro
    {
      get => this._tim_IdFiltro;
      set
      {
        if (this._tim_IdFiltro == value)
          return;
        if (this._tim_TipoMantenimiento1.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._tim_IdFiltro = value;
        this.SendPropertyChanged(nameof (tim_IdFiltro));
      }
    }

    [Column(Storage = "_rdb_FiltroObservacion", DbType = "VarChar(MAX) NOT NULL", CanBeNull = false)]
    public string rdb_FiltroObservacion
    {
      get => this._rdb_FiltroObservacion;
      set
      {
        if (!(this._rdb_FiltroObservacion != value))
          return;
        this.SendPropertyChanging();
        this._rdb_FiltroObservacion = value;
        this.SendPropertyChanged(nameof (rdb_FiltroObservacion));
      }
    }

    [Column(Storage = "_rdb_AcidezUnidad", DbType = "Int NOT NULL")]
    public int rdb_AcidezUnidad
    {
      get => this._rdb_AcidezUnidad;
      set
      {
        if (this._rdb_AcidezUnidad == value)
          return;
        this.SendPropertyChanging();
        this._rdb_AcidezUnidad = value;
        this.SendPropertyChanged(nameof (rdb_AcidezUnidad));
      }
    }

    [Column(Storage = "_tim_IdAcidez", DbType = "Int NOT NULL")]
    public int tim_IdAcidez
    {
      get => this._tim_IdAcidez;
      set
      {
        if (this._tim_IdAcidez == value)
          return;
        if (this._tim_TipoMantenimiento.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._tim_IdAcidez = value;
        this.SendPropertyChanged(nameof (tim_IdAcidez));
      }
    }

    [Column(Storage = "_rdb_AcidezObservacion", DbType = "VarChar(MAX) NOT NULL", CanBeNull = false)]
    public string rdb_AcidezObservacion
    {
      get => this._rdb_AcidezObservacion;
      set
      {
        if (!(this._rdb_AcidezObservacion != value))
          return;
        this.SendPropertyChanging();
        this._rdb_AcidezObservacion = value;
        this.SendPropertyChanged(nameof (rdb_AcidezObservacion));
      }
    }

    [Association(Name = "rdb_ReporteUsoBarrido_rbd_ReporteUsoBarridoDocumento", Storage = "_rbd_ReporteUsoBarridoDocumentos", ThisKey = "rdb_Id", OtherKey = "rdb_Id")]
    public EntitySet<rbd_ReporteUsoBarridoDocumento> rbd_ReporteUsoBarridoDocumentos
    {
      get => this._rbd_ReporteUsoBarridoDocumentos;
      set => this._rbd_ReporteUsoBarridoDocumentos.Assign((IEnumerable<rbd_ReporteUsoBarridoDocumento>) value);
    }

    [Association(Name = "ter_Tercero_rdb_ReporteUsoBarrido", Storage = "_ter_Tercero", ThisKey = "ter_Id", OtherKey = "ter_Id", IsForeignKey = true)]
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
          entity.rdb_ReporteUsoBarridos.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.rdb_ReporteUsoBarridos.Add(this);
          this._ter_Id = value.ter_Id;
        }
        else
          this._ter_Id = 0;
        this.SendPropertyChanged(nameof (ter_Tercero));
      }
    }

    [Association(Name = "tim_TipoMantenimiento_rdb_ReporteUsoBarrido", Storage = "_tim_TipoMantenimiento", ThisKey = "tim_IdAcidez", OtherKey = "tim_Id", IsForeignKey = true)]
    public tim_TipoMantenimiento tim_TipoMantenimiento
    {
      get => this._tim_TipoMantenimiento.Entity;
      set
      {
        tim_TipoMantenimiento entity = this._tim_TipoMantenimiento.Entity;
        if (entity == value && this._tim_TipoMantenimiento.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._tim_TipoMantenimiento.Entity = (tim_TipoMantenimiento) null;
          entity.rdb_ReporteUsoBarridos.Remove(this);
        }
        this._tim_TipoMantenimiento.Entity = value;
        if (value != null)
        {
          value.rdb_ReporteUsoBarridos.Add(this);
          this._tim_IdAcidez = value.tim_Id;
        }
        else
          this._tim_IdAcidez = 0;
        this.SendPropertyChanged(nameof (tim_TipoMantenimiento));
      }
    }

    [Association(Name = "tim_TipoMantenimiento_rdb_ReporteUsoBarrido1", Storage = "_tim_TipoMantenimiento1", ThisKey = "tim_IdFiltro", OtherKey = "tim_Id", IsForeignKey = true)]
    public tim_TipoMantenimiento tim_TipoMantenimiento1
    {
      get => this._tim_TipoMantenimiento1.Entity;
      set
      {
        tim_TipoMantenimiento entity = this._tim_TipoMantenimiento1.Entity;
        if (entity == value && this._tim_TipoMantenimiento1.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._tim_TipoMantenimiento1.Entity = (tim_TipoMantenimiento) null;
          entity.rdb_ReporteUsoBarridos1.Remove(this);
        }
        this._tim_TipoMantenimiento1.Entity = value;
        if (value != null)
        {
          value.rdb_ReporteUsoBarridos1.Add(this);
          this._tim_IdFiltro = value.tim_Id;
        }
        else
          this._tim_IdFiltro = 0;
        this.SendPropertyChanged(nameof (tim_TipoMantenimiento1));
      }
    }

    [Association(Name = "tim_TipoMantenimiento_rdb_ReporteUsoBarrido2", Storage = "_tim_TipoMantenimiento2", ThisKey = "tim_IdNitrogeno", OtherKey = "tim_Id", IsForeignKey = true)]
    public tim_TipoMantenimiento tim_TipoMantenimiento2
    {
      get => this._tim_TipoMantenimiento2.Entity;
      set
      {
        tim_TipoMantenimiento entity = this._tim_TipoMantenimiento2.Entity;
        if (entity == value && this._tim_TipoMantenimiento2.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._tim_TipoMantenimiento2.Entity = (tim_TipoMantenimiento) null;
          entity.rdb_ReporteUsoBarridos2.Remove(this);
        }
        this._tim_TipoMantenimiento2.Entity = value;
        if (value != null)
        {
          value.rdb_ReporteUsoBarridos2.Add(this);
          this._tim_IdNitrogeno = value.tim_Id;
        }
        else
          this._tim_IdNitrogeno = 0;
        this.SendPropertyChanged(nameof (tim_TipoMantenimiento2));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, rdb_ReporteUsoBarrido.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_rbd_ReporteUsoBarridoDocumentos(rbd_ReporteUsoBarridoDocumento entity)
    {
      this.SendPropertyChanging();
      entity.rdb_ReporteUsoBarrido = this;
    }

    private void detach_rbd_ReporteUsoBarridoDocumentos(rbd_ReporteUsoBarridoDocumento entity)
    {
      this.SendPropertyChanging();
      entity.rdb_ReporteUsoBarrido = (rdb_ReporteUsoBarrido) null;
    }
  }
}
