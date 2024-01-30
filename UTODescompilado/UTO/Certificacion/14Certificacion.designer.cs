// Decompiled with JetBrains decompiler
// Type: UTO.Certificacion.spCuboCertificacionResult
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System.Data.Linq.Mapping;

namespace UTO.Certificacion
{
  public class spCuboCertificacionResult
  {
    private string _Regional;
    private string _Departamento;
    private string _Ciudad;
    private string _Área;
    private string _Certificado;
    private int? _Año_certificacion;
    private int? _Técnicos;
    private string _Categoria;

    [Column(Storage = "_Regional", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string Regional
    {
      get => this._Regional;
      set
      {
        if (!(this._Regional != value))
          return;
        this._Regional = value;
      }
    }

    [Column(Storage = "_Departamento", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string Departamento
    {
      get => this._Departamento;
      set
      {
        if (!(this._Departamento != value))
          return;
        this._Departamento = value;
      }
    }

    [Column(Storage = "_Ciudad", DbType = "VarChar(255) NOT NULL", CanBeNull = false)]
    public string Ciudad
    {
      get => this._Ciudad;
      set
      {
        if (!(this._Ciudad != value))
          return;
        this._Ciudad = value;
      }
    }

    [Column(Storage = "_Área", DbType = "VarChar(70) NOT NULL", CanBeNull = false)]
    public string Área
    {
      get => this._Área;
      set
      {
        if (!(this._Área != value))
          return;
        this._Área = value;
      }
    }

    [Column(Storage = "_Certificado", DbType = "VarChar(14) NOT NULL", CanBeNull = false)]
    public string Certificado
    {
      get => this._Certificado;
      set
      {
        if (!(this._Certificado != value))
          return;
        this._Certificado = value;
      }
    }

    [Column(Name = "[Año certificacion]", Storage = "_Año_certificacion", DbType = "Int")]
    public int? Año_certificacion
    {
      get => this._Año_certificacion;
      set
      {
        int? añoCertificacion = this._Año_certificacion;
        int? nullable = value;
        if ((añoCertificacion.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (añoCertificacion.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._Año_certificacion = value;
      }
    }

    [Column(Storage = "_Técnicos", DbType = "Int")]
    public int? Técnicos
    {
      get => this._Técnicos;
      set
      {
        int? técnicos = this._Técnicos;
        int? nullable = value;
        if ((técnicos.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (técnicos.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this._Técnicos = value;
      }
    }

    [Column(Storage = "_Categoria", DbType = "VarChar(75) NOT NULL", CanBeNull = false)]
    public string Categoria
    {
      get => this._Categoria;
      set
      {
        if (!(this._Categoria != value))
          return;
        this._Categoria = value;
      }
    }
  }
}
