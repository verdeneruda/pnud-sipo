// Decompiled with JetBrains decompiler
// Type: UTO.log_Login
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace UTO
{
  [Table(Name = "dbo.log_Login")]
  public class log_Login : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _log_id;
    private string _log_nombre;
    private string _log_password;
    private string _log_variable;

    [Column(Storage = "_log_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
    public int log_id
    {
      get => this._log_id;
      set
      {
        if (this._log_id == value)
          return;
        this.SendPropertyChanging();
        this._log_id = value;
        this.SendPropertyChanged(nameof (log_id));
      }
    }

    [Column(Storage = "_log_nombre", DbType = "VarChar(100)")]
    public string log_nombre
    {
      get => this._log_nombre;
      set
      {
        if (!(this._log_nombre != value))
          return;
        this.SendPropertyChanging();
        this._log_nombre = value;
        this.SendPropertyChanged(nameof (log_nombre));
      }
    }

    [Column(Storage = "_log_password", DbType = "VarChar(250)")]
    public string log_password
    {
      get => this._log_password;
      set
      {
        if (!(this._log_password != value))
          return;
        this.SendPropertyChanging();
        this._log_password = value;
        this.SendPropertyChanged(nameof (log_password));
      }
    }

    [Column(Storage = "_log_variable", DbType = "VarChar(100)")]
    public string log_variable
    {
      get => this._log_variable;
      set
      {
        if (!(this._log_variable != value))
          return;
        this.SendPropertyChanging();
        this._log_variable = value;
        this.SendPropertyChanged(nameof (log_variable));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, log_Login.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
