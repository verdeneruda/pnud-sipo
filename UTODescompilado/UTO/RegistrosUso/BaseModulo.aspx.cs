﻿// Decompiled with JetBrains decompiler
// Type: UTO.RegistrosUso.BaseModulo
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq;

namespace UTO.RegistrosUso
{
  public class BaseModulo : BasePage
  {
    protected override DataContext newDataContext(string connectionString) => (DataContext) new RegistroUsoDataContext(connectionString);

    protected RegistroUsoDataContext MyDataContext => this.LocalInfo.MyDataContext as RegistroUsoDataContext;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    public struct strSendParam
    {
      private int _id;
      private string _tipo;

      public int id
      {
        get => this._id;
        set => this._id = value;
      }

      public string tipo
      {
        get => this._tipo;
        set => this._tipo = value;
      }
    }
  }
}
