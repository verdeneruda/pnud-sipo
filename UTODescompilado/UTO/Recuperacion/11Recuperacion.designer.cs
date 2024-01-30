// Decompiled with JetBrains decompiler
// Type: UTO.Recuperacion.cre_CentroRegeneracion
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
  [Table(Name = "Uto.cre_CentroRegeneracion")]
  public class cre_CentroRegeneracion : 
    INotifyPropertyChanging,
    INotifyPropertyChanged,
    IComparable<cre_CentroRegeneracion>
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _cre_Id;
    private string _cre_Descripcion;
    private EntitySet<rrc_ReporteRegeneracionConsolidado> _rrc_ReporteRegeneracionConsolidados;
    private EntitySet<rdu_ReporteUso> _rdu_ReporteUsos;
    private EntitySet<rre_ReporteRegeneracion> _rre_ReporteRegeneracions;
    private EntitySet<rcr_ReporteCentroRegeneracion> _rcr_ReporteCentroRegeneracions;

    public cre_CentroRegeneracion()
    {
      this._rrc_ReporteRegeneracionConsolidados = new EntitySet<rrc_ReporteRegeneracionConsolidado>(new Action<rrc_ReporteRegeneracionConsolidado>(this.attach_rrc_ReporteRegeneracionConsolidados), new Action<rrc_ReporteRegeneracionConsolidado>(this.detach_rrc_ReporteRegeneracionConsolidados));
      this._rdu_ReporteUsos = new EntitySet<rdu_ReporteUso>(new Action<rdu_ReporteUso>(this.attach_rdu_ReporteUsos), new Action<rdu_ReporteUso>(this.detach_rdu_ReporteUsos));
      this._rre_ReporteRegeneracions = new EntitySet<rre_ReporteRegeneracion>(new Action<rre_ReporteRegeneracion>(this.attach_rre_ReporteRegeneracions), new Action<rre_ReporteRegeneracion>(this.detach_rre_ReporteRegeneracions));
      this._rcr_ReporteCentroRegeneracions = new EntitySet<rcr_ReporteCentroRegeneracion>(new Action<rcr_ReporteCentroRegeneracion>(this.attach_rcr_ReporteCentroRegeneracions), new Action<rcr_ReporteCentroRegeneracion>(this.detach_rcr_ReporteCentroRegeneracions));
    }

    [Column(Storage = "_cre_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
    public int cre_Id
    {
      get => this._cre_Id;
      set
      {
        if (this._cre_Id == value)
          return;
        this.SendPropertyChanging();
        this._cre_Id = value;
        this.SendPropertyChanged(nameof (cre_Id));
      }
    }

    [Column(Storage = "_cre_Descripcion", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string cre_Descripcion
    {
      get => this._cre_Descripcion;
      set
      {
        if (!(this._cre_Descripcion != value))
          return;
        this.SendPropertyChanging();
        this._cre_Descripcion = value;
        this.SendPropertyChanged(nameof (cre_Descripcion));
      }
    }

    [Association(Name = "cre_CentroRegeneracion_rrc_ReporteRegeneracionConsolidado", Storage = "_rrc_ReporteRegeneracionConsolidados", ThisKey = "cre_Id", OtherKey = "cre_Id")]
    public EntitySet<rrc_ReporteRegeneracionConsolidado> rrc_ReporteRegeneracionConsolidados
    {
      get => this._rrc_ReporteRegeneracionConsolidados;
      set => this._rrc_ReporteRegeneracionConsolidados.Assign((IEnumerable<rrc_ReporteRegeneracionConsolidado>) value);
    }

    [Association(Name = "cre_CentroRegeneracion_rdu_ReporteUso", Storage = "_rdu_ReporteUsos", ThisKey = "cre_Id", OtherKey = "cre_Id")]
    public EntitySet<rdu_ReporteUso> rdu_ReporteUsos
    {
      get => this._rdu_ReporteUsos;
      set => this._rdu_ReporteUsos.Assign((IEnumerable<rdu_ReporteUso>) value);
    }

    [Association(Name = "cre_CentroRegeneracion_rre_ReporteRegeneracion", Storage = "_rre_ReporteRegeneracions", ThisKey = "cre_Id", OtherKey = "cre_Id")]
    public EntitySet<rre_ReporteRegeneracion> rre_ReporteRegeneracions
    {
      get => this._rre_ReporteRegeneracions;
      set => this._rre_ReporteRegeneracions.Assign((IEnumerable<rre_ReporteRegeneracion>) value);
    }

    [Association(Name = "cre_CentroRegeneracion_rcr_ReporteCentroRegeneracion", Storage = "_rcr_ReporteCentroRegeneracions", ThisKey = "cre_Id", OtherKey = "cre_Id")]
    public EntitySet<rcr_ReporteCentroRegeneracion> rcr_ReporteCentroRegeneracions
    {
      get => this._rcr_ReporteCentroRegeneracions;
      set => this._rcr_ReporteCentroRegeneracions.Assign((IEnumerable<rcr_ReporteCentroRegeneracion>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, cre_CentroRegeneracion.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_rrc_ReporteRegeneracionConsolidados(
      rrc_ReporteRegeneracionConsolidado entity)
    {
      this.SendPropertyChanging();
      entity.cre_CentroRegeneracion = this;
    }

    private void detach_rrc_ReporteRegeneracionConsolidados(
      rrc_ReporteRegeneracionConsolidado entity)
    {
      this.SendPropertyChanging();
      entity.cre_CentroRegeneracion = (cre_CentroRegeneracion) null;
    }

    private void attach_rdu_ReporteUsos(rdu_ReporteUso entity)
    {
      this.SendPropertyChanging();
      entity.cre_CentroRegeneracion = this;
    }

    private void detach_rdu_ReporteUsos(rdu_ReporteUso entity)
    {
      this.SendPropertyChanging();
      entity.cre_CentroRegeneracion = (cre_CentroRegeneracion) null;
    }

    private void attach_rre_ReporteRegeneracions(rre_ReporteRegeneracion entity)
    {
      this.SendPropertyChanging();
      entity.cre_CentroRegeneracion = this;
    }

    private void detach_rre_ReporteRegeneracions(rre_ReporteRegeneracion entity)
    {
      this.SendPropertyChanging();
      entity.cre_CentroRegeneracion = (cre_CentroRegeneracion) null;
    }

    private void attach_rcr_ReporteCentroRegeneracions(rcr_ReporteCentroRegeneracion entity)
    {
      this.SendPropertyChanging();
      entity.cre_CentroRegeneracion = this;
    }

    private void detach_rcr_ReporteCentroRegeneracions(rcr_ReporteCentroRegeneracion entity)
    {
      this.SendPropertyChanging();
      entity.cre_CentroRegeneracion = (cre_CentroRegeneracion) null;
    }

    public int CompareTo(cre_CentroRegeneracion other) => this.cre_Descripcion.CompareTo(other.cre_Descripcion);
  }
}
