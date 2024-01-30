// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.ter_Tercero
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UTO.RegistrosUso
{
  [Table(Name = "Uto.ter_Tercero")]
  public class ter_Tercero : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<ter_Tercero>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ter_Id;
    private int _dti_Id;
    private string _ter_NumeroDocumento;
    private int _bti_Id;
    private string _ter_NombreCompleto;
    private int? _reg_Id;
    private string _dep_Id;
    private string _mun_Id;
    private string _ter_Tefono;
    private string _ter_Direccion;
    private string _ter_Correo;
    private string _ter_Fax;
    private string _ter_Celular;
    private EntitySet<rri_RegistroReporteImportador> _rri_RegistroReporteImportadors;
    private EntitySet<ttt_TerceroTipoTercero> _ttt_TerceroTipoTerceros;
    private EntitySet<ufd_UsuarioFinalDato> _ufd_UsuarioFinalDatos;
    private EntitySet<rid_RegistroImportadorDetalle> _rid_RegistroImportadorDetalles;
    private EntityRef<dep_Departamento> _dep_Departamento;
    private EntityRef<mun_Municipio> _mun_Municipio;
    private EntityRef<reg_Regional> _reg_Regional;

    public ter_Tercero()
    {
      this._rri_RegistroReporteImportadors = new EntitySet<rri_RegistroReporteImportador>(new Action<rri_RegistroReporteImportador>(this.attach_rri_RegistroReporteImportadors), new Action<rri_RegistroReporteImportador>(this.detach_rri_RegistroReporteImportadors));
      this._ttt_TerceroTipoTerceros = new EntitySet<ttt_TerceroTipoTercero>(new Action<ttt_TerceroTipoTercero>(this.attach_ttt_TerceroTipoTerceros), new Action<ttt_TerceroTipoTercero>(this.detach_ttt_TerceroTipoTerceros));
      this._ufd_UsuarioFinalDatos = new EntitySet<ufd_UsuarioFinalDato>(new Action<ufd_UsuarioFinalDato>(this.attach_ufd_UsuarioFinalDatos), new Action<ufd_UsuarioFinalDato>(this.detach_ufd_UsuarioFinalDatos));
      this._rid_RegistroImportadorDetalles = new EntitySet<rid_RegistroImportadorDetalle>(new Action<rid_RegistroImportadorDetalle>(this.attach_rid_RegistroImportadorDetalles), new Action<rid_RegistroImportadorDetalle>(this.detach_rid_RegistroImportadorDetalles));
      this._dep_Departamento = new EntityRef<dep_Departamento>();
      this._mun_Municipio = new EntityRef<mun_Municipio>();
      this._reg_Regional = new EntityRef<reg_Regional>();
    }

    [Column(Storage = "_ter_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int ter_Id
    {
      get => this._ter_Id;
      set
      {
        if (this._ter_Id == value)
          return;
        this.SendPropertyChanging();
        this._ter_Id = value;
        this.SendPropertyChanged(nameof (ter_Id));
      }
    }

    [Column(Storage = "_dti_Id", DbType = "Int NOT NULL")]
    public int dti_Id
    {
      get => this._dti_Id;
      set
      {
        if (this._dti_Id == value)
          return;
        this.SendPropertyChanging();
        this._dti_Id = value;
        this.SendPropertyChanged(nameof (dti_Id));
      }
    }

    [Column(Storage = "_ter_NumeroDocumento", DbType = "VarChar(20) NOT NULL", CanBeNull = false)]
    public string ter_NumeroDocumento
    {
      get => this._ter_NumeroDocumento;
      set
      {
        if (!(this._ter_NumeroDocumento != value))
          return;
        this.SendPropertyChanging();
        this._ter_NumeroDocumento = value;
        this.SendPropertyChanged(nameof (ter_NumeroDocumento));
      }
    }

    [Column(Storage = "_bti_Id", DbType = "Int NOT NULL")]
    public int bti_Id
    {
      get => this._bti_Id;
      set
      {
        if (this._bti_Id == value)
          return;
        this.SendPropertyChanging();
        this._bti_Id = value;
        this.SendPropertyChanged(nameof (bti_Id));
      }
    }

    [Column(Storage = "_ter_NombreCompleto", DbType = "VarChar(450)")]
    public string ter_NombreCompleto
    {
      get => this._ter_NombreCompleto;
      set
      {
        if (!(this._ter_NombreCompleto != value))
          return;
        this.SendPropertyChanging();
        this._ter_NombreCompleto = value;
        this.SendPropertyChanged(nameof (ter_NombreCompleto));
      }
    }

    [Column(Storage = "_reg_Id", DbType = "Int")]
    public int? reg_Id
    {
      get => this._reg_Id;
      set
      {
        int? regId = this._reg_Id;
        int? nullable = value;
        if ((regId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (regId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        if (this._reg_Regional.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._reg_Id = value;
        this.SendPropertyChanged(nameof (reg_Id));
      }
    }

    [Column(Storage = "_dep_Id", DbType = "VarChar(2) NOT NULL", CanBeNull = false)]
    public string dep_Id
    {
      get => this._dep_Id;
      set
      {
        if (!(this._dep_Id != value))
          return;
        if (this._dep_Departamento.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._dep_Id = value;
        this.SendPropertyChanged(nameof (dep_Id));
      }
    }

    [Column(Storage = "_mun_Id", DbType = "VarChar(5) NOT NULL", CanBeNull = false)]
    public string mun_Id
    {
      get => this._mun_Id;
      set
      {
        if (!(this._mun_Id != value))
          return;
        if (this._mun_Municipio.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._mun_Id = value;
        this.SendPropertyChanged(nameof (mun_Id));
      }
    }

    [Column(Storage = "_ter_Tefono", DbType = "VarChar(15)")]
    public string ter_Tefono
    {
      get => this._ter_Tefono;
      set
      {
        if (!(this._ter_Tefono != value))
          return;
        this.SendPropertyChanging();
        this._ter_Tefono = value;
        this.SendPropertyChanged(nameof (ter_Tefono));
      }
    }

    [Column(Storage = "_ter_Direccion", DbType = "VarChar(50)")]
    public string ter_Direccion
    {
      get => this._ter_Direccion;
      set
      {
        if (!(this._ter_Direccion != value))
          return;
        this.SendPropertyChanging();
        this._ter_Direccion = value;
        this.SendPropertyChanged(nameof (ter_Direccion));
      }
    }

    [Column(Storage = "_ter_Correo", DbType = "VarChar(50)")]
    public string ter_Correo
    {
      get => this._ter_Correo;
      set
      {
        if (!(this._ter_Correo != value))
          return;
        this.SendPropertyChanging();
        this._ter_Correo = value;
        this.SendPropertyChanged(nameof (ter_Correo));
      }
    }

    [Column(Storage = "_ter_Fax", DbType = "VarChar(15)")]
    public string ter_Fax
    {
      get => this._ter_Fax;
      set
      {
        if (!(this._ter_Fax != value))
          return;
        this.SendPropertyChanging();
        this._ter_Fax = value;
        this.SendPropertyChanged(nameof (ter_Fax));
      }
    }

    [Column(Storage = "_ter_Celular", DbType = "VarChar(15)")]
    public string ter_Celular
    {
      get => this._ter_Celular;
      set
      {
        if (!(this._ter_Celular != value))
          return;
        this.SendPropertyChanging();
        this._ter_Celular = value;
        this.SendPropertyChanged(nameof (ter_Celular));
      }
    }

    [Association(Name = "ter_Tercero_rri_RegistroReporteImportador", Storage = "_rri_RegistroReporteImportadors", ThisKey = "ter_Id", OtherKey = "ter_Id")]
    public EntitySet<rri_RegistroReporteImportador> rri_RegistroReporteImportadors
    {
      get => this._rri_RegistroReporteImportadors;
      set => this._rri_RegistroReporteImportadors.Assign((IEnumerable<rri_RegistroReporteImportador>) value);
    }

    [Association(Name = "ter_Tercero_ttt_TerceroTipoTercero", Storage = "_ttt_TerceroTipoTerceros", ThisKey = "ter_Id", OtherKey = "ter_Id")]
    public EntitySet<ttt_TerceroTipoTercero> ttt_TerceroTipoTerceros
    {
      get => this._ttt_TerceroTipoTerceros;
      set => this._ttt_TerceroTipoTerceros.Assign((IEnumerable<ttt_TerceroTipoTercero>) value);
    }

    [Association(Name = "ter_Tercero_ufd_UsuarioFinalDato", Storage = "_ufd_UsuarioFinalDatos", ThisKey = "ter_Id", OtherKey = "ter_Id")]
    public EntitySet<ufd_UsuarioFinalDato> ufd_UsuarioFinalDatos
    {
      get => this._ufd_UsuarioFinalDatos;
      set => this._ufd_UsuarioFinalDatos.Assign((IEnumerable<ufd_UsuarioFinalDato>) value);
    }

    [Association(Name = "ter_Tercero_rid_RegistroImportadorDetalle", Storage = "_rid_RegistroImportadorDetalles", ThisKey = "ter_Id", OtherKey = "ter_Id")]
    public EntitySet<rid_RegistroImportadorDetalle> rid_RegistroImportadorDetalles
    {
      get => this._rid_RegistroImportadorDetalles;
      set => this._rid_RegistroImportadorDetalles.Assign((IEnumerable<rid_RegistroImportadorDetalle>) value);
    }

    [Association(Name = "dep_Departamento_ter_Tercero", Storage = "_dep_Departamento", ThisKey = "dep_Id", OtherKey = "dep_Id", IsForeignKey = true)]
    public dep_Departamento dep_Departamento
    {
      get => this._dep_Departamento.Entity;
      set
      {
        dep_Departamento entity = this._dep_Departamento.Entity;
        if (entity == value && this._dep_Departamento.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._dep_Departamento.Entity = (dep_Departamento) null;
          entity.ter_Terceros.Remove(this);
        }
        this._dep_Departamento.Entity = value;
        if (value != null)
        {
          value.ter_Terceros.Add(this);
          this._dep_Id = value.dep_Id;
        }
        else
          this._dep_Id = (string) null;
        this.SendPropertyChanged(nameof (dep_Departamento));
      }
    }

    [Association(Name = "mun_Municipio_ter_Tercero", Storage = "_mun_Municipio", ThisKey = "mun_Id", OtherKey = "mun_Id", IsForeignKey = true)]
    public mun_Municipio mun_Municipio
    {
      get => this._mun_Municipio.Entity;
      set
      {
        mun_Municipio entity = this._mun_Municipio.Entity;
        if (entity == value && this._mun_Municipio.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._mun_Municipio.Entity = (mun_Municipio) null;
          entity.ter_Terceros.Remove(this);
        }
        this._mun_Municipio.Entity = value;
        if (value != null)
        {
          value.ter_Terceros.Add(this);
          this._mun_Id = value.mun_Id;
        }
        else
          this._mun_Id = (string) null;
        this.SendPropertyChanged(nameof (mun_Municipio));
      }
    }

    [Association(Name = "reg_Regional_ter_Tercero", Storage = "_reg_Regional", ThisKey = "reg_Id", OtherKey = "reg_Id", IsForeignKey = true)]
    public reg_Regional reg_Regional
    {
      get => this._reg_Regional.Entity;
      set
      {
        reg_Regional entity = this._reg_Regional.Entity;
        if (entity == value && this._reg_Regional.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._reg_Regional.Entity = (reg_Regional) null;
          entity.ter_Terceros.Remove(this);
        }
        this._reg_Regional.Entity = value;
        if (value != null)
        {
          value.ter_Terceros.Add(this);
          this._reg_Id = new int?(value.reg_Id);
        }
        else
          this._reg_Id = new int?();
        this.SendPropertyChanged(nameof (reg_Regional));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, ter_Tercero.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_rri_RegistroReporteImportadors(rri_RegistroReporteImportador entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero = this;
    }

    private void detach_rri_RegistroReporteImportadors(rri_RegistroReporteImportador entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero = (ter_Tercero) null;
    }

    private void attach_ttt_TerceroTipoTerceros(ttt_TerceroTipoTercero entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero = this;
    }

    private void detach_ttt_TerceroTipoTerceros(ttt_TerceroTipoTercero entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero = (ter_Tercero) null;
    }

    private void attach_ufd_UsuarioFinalDatos(ufd_UsuarioFinalDato entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero = this;
    }

    private void detach_ufd_UsuarioFinalDatos(ufd_UsuarioFinalDato entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero = (ter_Tercero) null;
    }

    private void attach_rid_RegistroImportadorDetalles(rid_RegistroImportadorDetalle entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero = this;
    }

    private void detach_rid_RegistroImportadorDetalles(rid_RegistroImportadorDetalle entity)
    {
      this.SendPropertyChanging();
      entity.ter_Tercero = (ter_Tercero) null;
    }

    public override string ToString() => this.ter_NumeroDocumento;

    public int CompareTo(ter_Tercero other) => this.ter_NombreCompleto.CompareTo(other.ter_NombreCompleto);
  }
}
