// Decompiled with JetBrains decompiler
// Type: UTO.ImportacionExportacion.rex_RegistroExportacion
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.ImportacionExportacion
{
  [Table(Name = "Iye.rex_RegistroExportacion")]
  public class rex_RegistroExportacion : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rex_Id;
    private string _rex_NumeroRegistro;
    private int _ter_Id;
    private int? _pas_Id;
    private string _rex_PuertoEmbargue;
    private int? _adu_Id;
    private int? _cvb_Id;
    private DateTime? _rex_FechaVigencia;
    private string _rex_NumeroVistoBueno;
    private DateTime? _rex_FechaVistoBueno;
    private DateTime? _rex_FechaRequerimiento;
    private string _rex_Usuario;
    private DateTime? _rex_Creado;
    private DateTime? _rex_Modificado;
    private EntitySet<res_RegistroExportacionSustancia> _res_RegistroExportacionSustancias;
    private EntityRef<adu_Aduana> _adu_Aduana;
    private EntityRef<cvb_ConceptoVistoBueno> _cvb_ConceptoVistoBueno;
    private EntityRef<pas_Pai> _pas_Pai;
    private EntityRef<ter_Tercero> _ter_Tercero;

    public rex_RegistroExportacion()
    {
      this._res_RegistroExportacionSustancias = new EntitySet<res_RegistroExportacionSustancia>(new Action<res_RegistroExportacionSustancia>(this.attach_res_RegistroExportacionSustancias), new Action<res_RegistroExportacionSustancia>(this.detach_res_RegistroExportacionSustancias));
      this._adu_Aduana = new EntityRef<adu_Aduana>();
      this._cvb_ConceptoVistoBueno = new EntityRef<cvb_ConceptoVistoBueno>();
      this._pas_Pai = new EntityRef<pas_Pai>();
      this._ter_Tercero = new EntityRef<ter_Tercero>();
    }

    [Column(Storage = "_rex_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int rex_Id
    {
      get => this._rex_Id;
      set
      {
        if (this._rex_Id == value)
          return;
        this.SendPropertyChanging();
        this._rex_Id = value;
        this.SendPropertyChanged(nameof (rex_Id));
      }
    }

    [Column(Storage = "_rex_NumeroRegistro", DbType = "VarChar(25)")]
    public string rex_NumeroRegistro
    {
      get => this._rex_NumeroRegistro;
      set
      {
        if (!(this._rex_NumeroRegistro != value))
          return;
        this.SendPropertyChanging();
        this._rex_NumeroRegistro = value;
        this.SendPropertyChanged(nameof (rex_NumeroRegistro));
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

    [Column(Storage = "_pas_Id", DbType = "Int")]
    public int? pas_Id
    {
      get => this._pas_Id;
      set
      {
        int? pasId = this._pas_Id;
        int? nullable = value;
        if ((pasId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (pasId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        if (this._pas_Pai.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._pas_Id = value;
        this.SendPropertyChanged(nameof (pas_Id));
      }
    }

    [Column(Storage = "_rex_PuertoEmbargue", DbType = "VarChar(150)")]
    public string rex_PuertoEmbargue
    {
      get => this._rex_PuertoEmbargue;
      set
      {
        if (!(this._rex_PuertoEmbargue != value))
          return;
        this.SendPropertyChanging();
        this._rex_PuertoEmbargue = value;
        this.SendPropertyChanged(nameof (rex_PuertoEmbargue));
      }
    }

    [Column(Storage = "_adu_Id", DbType = "Int")]
    public int? adu_Id
    {
      get => this._adu_Id;
      set
      {
        int? aduId = this._adu_Id;
        int? nullable = value;
        if ((aduId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (aduId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        if (this._adu_Aduana.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._adu_Id = value;
        this.SendPropertyChanged(nameof (adu_Id));
      }
    }

    [Column(Storage = "_cvb_Id", DbType = "Int")]
    public int? cvb_Id
    {
      get => this._cvb_Id;
      set
      {
        int? cvbId = this._cvb_Id;
        int? nullable = value;
        if ((cvbId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (cvbId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        if (this._cvb_ConceptoVistoBueno.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._cvb_Id = value;
        this.SendPropertyChanged(nameof (cvb_Id));
      }
    }

    [Column(Storage = "_rex_FechaVigencia", DbType = "DateTime")]
    public DateTime? rex_FechaVigencia
    {
      get => this._rex_FechaVigencia;
      set
      {
        DateTime? rexFechaVigencia = this._rex_FechaVigencia;
        DateTime? nullable = value;
        if ((rexFechaVigencia.HasValue != nullable.HasValue ? 1 : (!rexFechaVigencia.HasValue ? 0 : (rexFechaVigencia.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._rex_FechaVigencia = value;
        this.SendPropertyChanged(nameof (rex_FechaVigencia));
      }
    }

    [Column(Storage = "_rex_NumeroVistoBueno", DbType = "VarChar(150)")]
    public string rex_NumeroVistoBueno
    {
      get => this._rex_NumeroVistoBueno;
      set
      {
        if (!(this._rex_NumeroVistoBueno != value))
          return;
        this.SendPropertyChanging();
        this._rex_NumeroVistoBueno = value;
        this.SendPropertyChanged(nameof (rex_NumeroVistoBueno));
      }
    }

    [Column(Storage = "_rex_FechaVistoBueno", DbType = "DateTime")]
    public DateTime? rex_FechaVistoBueno
    {
      get => this._rex_FechaVistoBueno;
      set
      {
        DateTime? rexFechaVistoBueno = this._rex_FechaVistoBueno;
        DateTime? nullable = value;
        if ((rexFechaVistoBueno.HasValue != nullable.HasValue ? 1 : (!rexFechaVistoBueno.HasValue ? 0 : (rexFechaVistoBueno.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._rex_FechaVistoBueno = value;
        this.SendPropertyChanged(nameof (rex_FechaVistoBueno));
      }
    }

    [Column(Storage = "_rex_FechaRequerimiento", DbType = "DateTime")]
    public DateTime? rex_FechaRequerimiento
    {
      get => this._rex_FechaRequerimiento;
      set
      {
        DateTime? fechaRequerimiento = this._rex_FechaRequerimiento;
        DateTime? nullable = value;
        if ((fechaRequerimiento.HasValue != nullable.HasValue ? 1 : (!fechaRequerimiento.HasValue ? 0 : (fechaRequerimiento.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._rex_FechaRequerimiento = value;
        this.SendPropertyChanged(nameof (rex_FechaRequerimiento));
      }
    }

    [Column(Storage = "_rex_Usuario", DbType = "VarChar(50)")]
    public string rex_Usuario
    {
      get => this._rex_Usuario;
      set
      {
        if (!(this._rex_Usuario != value))
          return;
        this.SendPropertyChanging();
        this._rex_Usuario = value;
        this.SendPropertyChanged(nameof (rex_Usuario));
      }
    }

    [Column(Storage = "_rex_Creado", DbType = "DateTime")]
    public DateTime? rex_Creado
    {
      get => this._rex_Creado;
      set
      {
        DateTime? rexCreado = this._rex_Creado;
        DateTime? nullable = value;
        if ((rexCreado.HasValue != nullable.HasValue ? 1 : (!rexCreado.HasValue ? 0 : (rexCreado.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._rex_Creado = value;
        this.SendPropertyChanged(nameof (rex_Creado));
      }
    }

    [Column(Storage = "_rex_Modificado", DbType = "DateTime")]
    public DateTime? rex_Modificado
    {
      get => this._rex_Modificado;
      set
      {
        DateTime? rexModificado = this._rex_Modificado;
        DateTime? nullable = value;
        if ((rexModificado.HasValue != nullable.HasValue ? 1 : (!rexModificado.HasValue ? 0 : (rexModificado.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._rex_Modificado = value;
        this.SendPropertyChanged(nameof (rex_Modificado));
      }
    }

    [Association(Name = "rex_RegistroExportacion_res_RegistroExportacionSustancia", Storage = "_res_RegistroExportacionSustancias", ThisKey = "rex_Id", OtherKey = "rex_Id")]
    public EntitySet<res_RegistroExportacionSustancia> res_RegistroExportacionSustancias
    {
      get => this._res_RegistroExportacionSustancias;
      set => this._res_RegistroExportacionSustancias.Assign((IEnumerable<res_RegistroExportacionSustancia>) value);
    }

    [Association(Name = "adu_Aduana_rex_RegistroExportacion", Storage = "_adu_Aduana", ThisKey = "adu_Id", OtherKey = "adu_Id", IsForeignKey = true)]
    public adu_Aduana adu_Aduana
    {
      get => this._adu_Aduana.Entity;
      set
      {
        adu_Aduana entity = this._adu_Aduana.Entity;
        if (entity == value && this._adu_Aduana.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._adu_Aduana.Entity = (adu_Aduana) null;
          entity.rex_RegistroExportacions.Remove(this);
        }
        this._adu_Aduana.Entity = value;
        if (value != null)
        {
          value.rex_RegistroExportacions.Add(this);
          this._adu_Id = new int?(value.adu_Id);
        }
        else
          this._adu_Id = new int?();
        this.SendPropertyChanged(nameof (adu_Aduana));
      }
    }

    [Association(Name = "cvb_ConceptoVistoBueno_rex_RegistroExportacion", Storage = "_cvb_ConceptoVistoBueno", ThisKey = "cvb_Id", OtherKey = "cvb_Id", IsForeignKey = true)]
    public cvb_ConceptoVistoBueno cvb_ConceptoVistoBueno
    {
      get => this._cvb_ConceptoVistoBueno.Entity;
      set
      {
        cvb_ConceptoVistoBueno entity = this._cvb_ConceptoVistoBueno.Entity;
        if (entity == value && this._cvb_ConceptoVistoBueno.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._cvb_ConceptoVistoBueno.Entity = (cvb_ConceptoVistoBueno) null;
          entity.rex_RegistroExportacions.Remove(this);
        }
        this._cvb_ConceptoVistoBueno.Entity = value;
        if (value != null)
        {
          value.rex_RegistroExportacions.Add(this);
          this._cvb_Id = new int?(value.cvb_Id);
        }
        else
          this._cvb_Id = new int?();
        this.SendPropertyChanged(nameof (cvb_ConceptoVistoBueno));
      }
    }

    [Association(Name = "pas_Pai_rex_RegistroExportacion", Storage = "_pas_Pai", ThisKey = "pas_Id", OtherKey = "pas_Id", IsForeignKey = true)]
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
          entity.rex_RegistroExportacions.Remove(this);
        }
        this._pas_Pai.Entity = value;
        if (value != null)
        {
          value.rex_RegistroExportacions.Add(this);
          this._pas_Id = new int?(value.pas_Id);
        }
        else
          this._pas_Id = new int?();
        this.SendPropertyChanged(nameof (pas_Pai));
      }
    }

    [Association(Name = "ter_Tercero_rex_RegistroExportacion", Storage = "_ter_Tercero", ThisKey = "ter_Id", OtherKey = "ter_Id", IsForeignKey = true)]
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
          entity.rex_RegistroExportacions.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.rex_RegistroExportacions.Add(this);
          this._ter_Id = value.ter_Id;
        }
        else
          this._ter_Id = 0;
        this.SendPropertyChanged(nameof (ter_Tercero));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, rex_RegistroExportacion.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_res_RegistroExportacionSustancias(res_RegistroExportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.rex_RegistroExportacion = this;
    }

    private void detach_res_RegistroExportacionSustancias(res_RegistroExportacionSustancia entity)
    {
      this.SendPropertyChanging();
      entity.rex_RegistroExportacion = (rex_RegistroExportacion) null;
    }
  }
}
