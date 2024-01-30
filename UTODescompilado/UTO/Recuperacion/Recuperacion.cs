// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.rdu_ReporteUso
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
  [Table(Name = "Rrr.rdu_ReporteUso")]
  public class rdu_ReporteUso : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _rdu_Id;
    private int _ter_Id;
    private string _rdu_Periodo;
    private int _rdu_Ano;
    private bool _rdu_EnvioCentroRegeneracion;
    private bool _rdu_ReportaProblemas;
    private int? _cre_Id;
    private string _rdu_Observaciones;
    private int? _rud_Id;
    private bool _rdu_SolucionProblema;
    private string _rdu_AccionRealizada;
    private EntitySet<rud_ReporteUsoDocumento> _rud_ReporteUsoDocumentos;
    private EntitySet<rdt_ReporteUsoDetalle> _rdt_ReporteUsoDetalles;
    private EntityRef<cre_CentroRegeneracion> _cre_CentroRegeneracion;
    private EntityRef<ter_Tercero> _ter_Tercero;

    public string OrdenAno
    {
      get
      {
        string str = this.rdu_Ano.ToString();
        string ordenAno;
        switch (this.rdu_Periodo.ToUpper())
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

    public rdu_ReporteUso()
    {
      this._rud_ReporteUsoDocumentos = new EntitySet<rud_ReporteUsoDocumento>(new Action<rud_ReporteUsoDocumento>(this.attach_rud_ReporteUsoDocumentos), new Action<rud_ReporteUsoDocumento>(this.detach_rud_ReporteUsoDocumentos));
      this._rdt_ReporteUsoDetalles = new EntitySet<rdt_ReporteUsoDetalle>(new Action<rdt_ReporteUsoDetalle>(this.attach_rdt_ReporteUsoDetalles), new Action<rdt_ReporteUsoDetalle>(this.detach_rdt_ReporteUsoDetalles));
      this._cre_CentroRegeneracion = new EntityRef<cre_CentroRegeneracion>();
      this._ter_Tercero = new EntityRef<ter_Tercero>();
    }

    [Column(Storage = "_rdu_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int rdu_Id
    {
      get => this._rdu_Id;
      set
      {
        if (this._rdu_Id == value)
          return;
        this.SendPropertyChanging();
        this._rdu_Id = value;
        this.SendPropertyChanged(nameof (rdu_Id));
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

    [Column(Storage = "_rdu_Periodo", DbType = "VarChar(30) NOT NULL", CanBeNull = false)]
    public string rdu_Periodo
    {
      get => this._rdu_Periodo;
      set
      {
        if (!(this._rdu_Periodo != value))
          return;
        this.SendPropertyChanging();
        this._rdu_Periodo = value;
        this.SendPropertyChanged(nameof (rdu_Periodo));
      }
    }

    [Column(Storage = "_rdu_Ano", DbType = "Int NOT NULL")]
    public int rdu_Ano
    {
      get => this._rdu_Ano;
      set
      {
        if (this._rdu_Ano == value)
          return;
        this.SendPropertyChanging();
        this._rdu_Ano = value;
        this.SendPropertyChanged(nameof (rdu_Ano));
      }
    }

    [Column(Storage = "_rdu_EnvioCentroRegeneracion", DbType = "Bit NOT NULL")]
    public bool rdu_EnvioCentroRegeneracion
    {
      get => this._rdu_EnvioCentroRegeneracion;
      set
      {
        if (this._rdu_EnvioCentroRegeneracion == value)
          return;
        this.SendPropertyChanging();
        this._rdu_EnvioCentroRegeneracion = value;
        this.SendPropertyChanged(nameof (rdu_EnvioCentroRegeneracion));
      }
    }

    [Column(Storage = "_rdu_ReportaProblemas", DbType = "Bit NOT NULL")]
    public bool rdu_ReportaProblemas
    {
      get => this._rdu_ReportaProblemas;
      set
      {
        if (this._rdu_ReportaProblemas == value)
          return;
        this.SendPropertyChanging();
        this._rdu_ReportaProblemas = value;
        this.SendPropertyChanged(nameof (rdu_ReportaProblemas));
      }
    }

    [Column(Storage = "_cre_Id", DbType = "Int")]
    public int? cre_Id
    {
      get => this._cre_Id;
      set
      {
        int? creId = this._cre_Id;
        int? nullable = value;
        if ((creId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (creId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        if (this._cre_CentroRegeneracion.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._cre_Id = value;
        this.SendPropertyChanged(nameof (cre_Id));
      }
    }

    [Column(Storage = "_rdu_Observaciones", DbType = "VarChar(MAX)")]
    public string rdu_Observaciones
    {
      get => this._rdu_Observaciones;
      set
      {
        if (!(this._rdu_Observaciones != value))
          return;
        this.SendPropertyChanging();
        this._rdu_Observaciones = value;
        this.SendPropertyChanged(nameof (rdu_Observaciones));
      }
    }

    [Column(Storage = "_rud_Id", DbType = "Int")]
    public int? rud_Id
    {
      get => this._rud_Id;
      set
      {
        int? rudId = this._rud_Id;
        int? nullable = value;
        if ((rudId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (rudId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._rud_Id = value;
        this.SendPropertyChanged(nameof (rud_Id));
      }
    }

    [Column(Storage = "_rdu_SolucionProblema", DbType = "Bit NOT NULL")]
    public bool rdu_SolucionProblema
    {
      get => this._rdu_SolucionProblema;
      set
      {
        if (this._rdu_SolucionProblema == value)
          return;
        this.SendPropertyChanging();
        this._rdu_SolucionProblema = value;
        this.SendPropertyChanged(nameof (rdu_SolucionProblema));
      }
    }

    [Column(Storage = "_rdu_AccionRealizada", DbType = "VarChar(MAX) NOT NULL", CanBeNull = false)]
    public string rdu_AccionRealizada
    {
      get => this._rdu_AccionRealizada;
      set
      {
        if (!(this._rdu_AccionRealizada != value))
          return;
        this.SendPropertyChanging();
        this._rdu_AccionRealizada = value;
        this.SendPropertyChanged(nameof (rdu_AccionRealizada));
      }
    }

    [Association(Name = "rdu_ReporteUso_rud_ReporteUsoDocumento", Storage = "_rud_ReporteUsoDocumentos", ThisKey = "rdu_Id", OtherKey = "rdu_Id")]
    public EntitySet<rud_ReporteUsoDocumento> rud_ReporteUsoDocumentos
    {
      get => this._rud_ReporteUsoDocumentos;
      set => this._rud_ReporteUsoDocumentos.Assign((IEnumerable<rud_ReporteUsoDocumento>) value);
    }

    [Association(Name = "rdu_ReporteUso_rdt_ReporteUsoDetalle", Storage = "_rdt_ReporteUsoDetalles", ThisKey = "rdu_Id", OtherKey = "rdu_Id")]
    public EntitySet<rdt_ReporteUsoDetalle> rdt_ReporteUsoDetalles
    {
      get => this._rdt_ReporteUsoDetalles;
      set => this._rdt_ReporteUsoDetalles.Assign((IEnumerable<rdt_ReporteUsoDetalle>) value);
    }

    [Association(Name = "cre_CentroRegeneracion_rdu_ReporteUso", Storage = "_cre_CentroRegeneracion", ThisKey = "cre_Id", OtherKey = "cre_Id", IsForeignKey = true)]
    public cre_CentroRegeneracion cre_CentroRegeneracion
    {
      get => this._cre_CentroRegeneracion.Entity;
      set
      {
        cre_CentroRegeneracion entity = this._cre_CentroRegeneracion.Entity;
        if (entity == value && this._cre_CentroRegeneracion.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._cre_CentroRegeneracion.Entity = (cre_CentroRegeneracion) null;
          entity.rdu_ReporteUsos.Remove(this);
        }
        this._cre_CentroRegeneracion.Entity = value;
        if (value != null)
        {
          value.rdu_ReporteUsos.Add(this);
          this._cre_Id = new int?(value.cre_Id);
        }
        else
          this._cre_Id = new int?();
        this.SendPropertyChanged(nameof (cre_CentroRegeneracion));
      }
    }

    [Association(Name = "ter_Tercero_rdu_ReporteUso", Storage = "_ter_Tercero", ThisKey = "ter_Id", OtherKey = "ter_Id", IsForeignKey = true)]
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
          entity.rdu_ReporteUsos.Remove(this);
        }
        this._ter_Tercero.Entity = value;
        if (value != null)
        {
          value.rdu_ReporteUsos.Add(this);
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
      this.PropertyChanging((object) this, rdu_ReporteUso.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_rud_ReporteUsoDocumentos(rud_ReporteUsoDocumento entity)
    {
      this.SendPropertyChanging();
      entity.rdu_ReporteUso = this;
    }

    private void detach_rud_ReporteUsoDocumentos(rud_ReporteUsoDocumento entity)
    {
      this.SendPropertyChanging();
      entity.rdu_ReporteUso = (rdu_ReporteUso) null;
    }

    private void attach_rdt_ReporteUsoDetalles(rdt_ReporteUsoDetalle entity)
    {
      this.SendPropertyChanging();
      entity.rdu_ReporteUso = this;
    }

    private void detach_rdt_ReporteUsoDetalles(rdt_ReporteUsoDetalle entity)
    {
      this.SendPropertyChanging();
      entity.rdu_ReporteUso = (rdu_ReporteUso) null;
    }
  }
}
