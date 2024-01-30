// Decompiled with JetBrains decompiler
// Type: UTO.MPMain
// Assembly: UTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F3D0C79F-C842-4586-96B4-8CD7E28EB2D2
// Assembly location: D:\SIPO\Fuentes\UTO\UTO\bin\UTO.dll

using DevExpress.Web;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace UTO
{
  public class MPMain : MasterPage
  {
    protected ContentPlaceHolder head;
    protected HtmlForm form1;
    protected Image Image1;
    protected Image Image2;
    protected ASPxMenu ASPxMenu1;
    protected ASPxNavBar ASPxNavBar1;
    protected ASPxSiteMapDataSource SiteMapMain;
    protected ASPxSiteMapDataSource SiteMapSesion;
    protected ASPxTreeView ASPxTreeView1;
    protected ContentPlaceHolder ContentPlaceHolder1;

    protected void ASPxNavBar1_DataBound(object sender, EventArgs e)
    {
      if (!(this.Session["MapaPermisos"] is List<CPermisos>))
      {
        this.ASPxNavBar1.Visible = false;
        this.ASPxTreeView1.Visible = false;
      }
      else
      {
        this.ASPxNavBar1.Visible = false;
        this.ASPxTreeView1.Visible = false;
        CUsuario cusuario = this.Session["Usuario"] as CUsuario;
        for (int index = 0; index < this.ASPxTreeView1.Nodes.Count; ++index)
        {
          Collection collection = this.ASPxTreeView1.Nodes[index].Collection;
        }
        if (cusuario.autenticado && cusuario.login != "publico")
        {
          this.ASPxMenu1.Items[0].Visible = false;
          this.ASPxMenu1.Items[1].Visible = true;
          this.ASPxMenu1.Items[2].Visible = true;
          this.ASPxTreeView1.Visible = true;
        }
        else
        {
          this.ASPxMenu1.Items[0].Visible = true;
          this.ASPxMenu1.Items[1].Visible = false;
          this.ASPxMenu1.Items[2].Visible = false;
        }
      }
    }

    protected void ASPxTreeView1_DataBound(object sender, EventArgs e)
    {
      List<CPermisos> cpermisosList = this.Session["MapaPermisos"] as List<CPermisos>;
      CUsuario cusuario = this.Session["Usuario"] as CUsuario;
      if (cpermisosList == null)
        return;
      for (int index1 = 0; index1 < this.ASPxTreeView1.Nodes.Count; ++index1)
      {
        Collection collection = this.ASPxTreeView1.Nodes[index1].Collection;
        bool flag1 = false;
        int num;
        if (index1 != 8)
        {
          for (int index2 = 0; index2 < this.ASPxTreeView1.Nodes[index1].Nodes.Count; ++index2)
          {
            num = 0;
            string upper = this.ASPxTreeView1.Nodes[index1].Nodes[index2].NavigateUrl.ToUpper();
            bool flag2 = false;
            int index3;
            for (index3 = 0; index3 < cpermisosList.Count; ++index3)
            {
              if (upper.EndsWith(cpermisosList[index3].path.ToUpper()))
              {
                flag2 = true;
                break;
              }
            }
            if (flag2)
            {
              string[] strArray = cpermisosList[index3].operaciones.Split(',');
              bool flag3 = false;
              foreach (string s in strArray)
              {
                if (cusuario.permiteOperacion(int.Parse(s)))
                {
                  flag3 = true;
                  break;
                }
              }
              this.ASPxTreeView1.Nodes[index1].Nodes[index2].Visible = flag3;
              flag1 = flag1 || flag3;
            }
            this.ASPxTreeView1.Nodes[index1].Visible = flag1;
          }
        }
        else
        {
          for (int index4 = 0; index4 < this.ASPxTreeView1.Nodes[index1].Nodes[2].Nodes.Count; ++index4)
          {
            num = 0;
            string upper = this.ASPxTreeView1.Nodes[index1].Nodes[2].Nodes[index4].NavigateUrl.ToUpper();
            bool flag4 = false;
            int index5;
            for (index5 = 0; index5 < cpermisosList.Count; ++index5)
            {
              if (upper.EndsWith(cpermisosList[index5].path.ToUpper()))
              {
                flag4 = true;
                break;
              }
            }
            if (flag4)
            {
              string[] strArray = cpermisosList[index5].operaciones.Split(',');
              bool flag5 = false;
              foreach (string s in strArray)
              {
                if (cusuario.permiteOperacion(int.Parse(s)))
                {
                  flag5 = true;
                  break;
                }
              }
              this.ASPxTreeView1.Nodes[index1].Nodes[2].Nodes[index4].Visible = flag5;
              flag1 = flag1 || flag5;
            }
            this.ASPxTreeView1.Nodes[index1].Nodes[2].Visible = flag1;
          }
          bool flag6 = false;
          for (int index6 = 0; index6 < this.ASPxTreeView1.Nodes[index1].Nodes[1].Nodes.Count; ++index6)
          {
            num = 0;
            string upper = this.ASPxTreeView1.Nodes[index1].Nodes[1].Nodes[index6].NavigateUrl.ToUpper();
            bool flag7 = false;
            int index7;
            for (index7 = 0; index7 < cpermisosList.Count; ++index7)
            {
              if (upper.EndsWith(cpermisosList[index7].path.ToUpper()))
              {
                flag7 = true;
                break;
              }
            }
            if (flag7)
            {
              string[] strArray = cpermisosList[index7].operaciones.Split(',');
              bool flag8 = false;
              foreach (string s in strArray)
              {
                if (cusuario.permiteOperacion(int.Parse(s)))
                {
                  flag8 = true;
                  break;
                }
              }
              this.ASPxTreeView1.Nodes[index1].Nodes[1].Nodes[index6].Visible = flag8;
              flag6 = flag6 || flag8;
            }
            this.ASPxTreeView1.Nodes[index1].Nodes[1].Visible = flag6;
          }
          bool flag9 = false;
          for (int index8 = 0; index8 < this.ASPxTreeView1.Nodes[index1].Nodes[0].Nodes[0].Nodes.Count; ++index8)
          {
            num = 0;
            string upper = this.ASPxTreeView1.Nodes[index1].Nodes[0].Nodes[0].Nodes[index8].NavigateUrl.ToUpper();
            bool flag10 = false;
            int index9;
            for (index9 = 0; index9 < cpermisosList.Count; ++index9)
            {
              if (upper.EndsWith(cpermisosList[index9].path.ToUpper()))
              {
                flag10 = true;
                break;
              }
            }
            if (flag10)
            {
              string[] strArray = cpermisosList[index9].operaciones.Split(',');
              bool flag11 = false;
              foreach (string s in strArray)
              {
                if (cusuario.permiteOperacion(int.Parse(s)))
                {
                  flag11 = true;
                  break;
                }
              }
              this.ASPxTreeView1.Nodes[index1].Nodes[0].Nodes[0].Nodes[index8].Visible = flag11;
              flag9 = flag9 || flag11;
            }
            this.ASPxTreeView1.Nodes[index1].Nodes[0].Nodes[0].Visible = flag9;
          }
          bool flag12 = false;
          for (int index10 = 0; index10 < this.ASPxTreeView1.Nodes[index1].Nodes[0].Nodes[1].Nodes.Count; ++index10)
          {
            num = 0;
            string upper = this.ASPxTreeView1.Nodes[index1].Nodes[0].Nodes[1].Nodes[index10].NavigateUrl.ToUpper();
            bool flag13 = false;
            int index11;
            for (index11 = 0; index11 < cpermisosList.Count; ++index11)
            {
              if (upper.EndsWith(cpermisosList[index11].path.ToUpper()))
              {
                flag13 = true;
                break;
              }
            }
            if (flag13)
            {
              string[] strArray = cpermisosList[index11].operaciones.Split(',');
              bool flag14 = false;
              foreach (string s in strArray)
              {
                if (cusuario.permiteOperacion(int.Parse(s)))
                {
                  flag14 = true;
                  break;
                }
              }
              this.ASPxTreeView1.Nodes[index1].Nodes[0].Nodes[1].Nodes[index10].Visible = flag14;
              flag12 = flag12 || flag14;
            }
            this.ASPxTreeView1.Nodes[index1].Nodes[0].Nodes[1].Visible = flag12;
          }
          this.ASPxTreeView1.Nodes[index1].Nodes[0].Visible = this.ASPxTreeView1.Nodes[index1].Nodes[0].Nodes[1].Visible || this.ASPxTreeView1.Nodes[index1].Nodes[0].Nodes[0].Visible;
          this.ASPxTreeView1.Nodes[index1].Visible = this.ASPxTreeView1.Nodes[index1].Nodes[0].Visible || this.ASPxTreeView1.Nodes[index1].Nodes[1].Visible || this.ASPxTreeView1.Nodes[index1].Nodes[2].Visible;
        }
      }
    }
  }
}
