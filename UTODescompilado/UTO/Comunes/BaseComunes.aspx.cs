// Decompiled with JetBrains decompiler
// Type: UTO.Comunes.BaseComunes
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using System;
using System.Data.Linq;
using System.Web.UI.HtmlControls;

namespace UTO.Comunes
{
  public class BaseComunes : BasePage
  {
    protected HtmlForm form1;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected override DataContext newDataContext(string connectionString) => (DataContext) null;
  }
}
