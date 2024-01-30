using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using DevExpress.Data.Browsing;
using NE.CLib;
using NE.CLib.Linq;
using Seguridad.Servicio;
using UTO;
using UTO.Comercializacion;

/// <summary>
/// Descripción breve de Validar
/// </summary>
public class Validar
{
    ComercializacionDataContext context;
    public Validar(ComercializacionDataContext comercializacionDataContext)
    {
        context = comercializacionDataContext;
    }
    public bool EsNumero(string Valor)
    {
        bool Result = false;
        try
        {
            decimal i = Decimal.Parse(Valor);
            Result = true;
        }
        catch
        {
            // Ignore errors
        }
        return Result;
    }
    public bool EsFecha(string Valor)
    {
        bool Result = false;
        try
        {
            DateTime i = ConvertirFecha(Valor);
            Result = true;
        }
        catch
        {
            // Ignore errors
        }
        return Result;
    }

    

    public bool EsDepartamento(string Valor)
    {
        var departamento = CLinq.ListByProperty<dep_Departamento>(context, "dep_Id", Valor);
        if(departamento.Count > 0)
            return true;
        return false;
    }
    private DateTime ConvertirFecha(string Dato)
    {
        int iDia = 0, iMes = 0, iYear = 0;
        DateTime dtFecha;
        try
        {
            if (EsNumero(Dato.Substring(0, 2)))
                iDia = int.Parse(Dato.Substring(0, 2));
            if (EsNumero(Dato.Substring(3, 2)))
                iMes = int.Parse(Dato.Substring(3, 2));
            if (EsNumero(Dato.Substring(6, 4)))
                iYear = int.Parse(Dato.Substring(6, 4));
            dtFecha = new DateTime(iYear, iMes, iDia);
            return (dtFecha);
        }
        catch
        {
            throw new ApplicationException("Fecha no es valida");
        }

    }

    internal bool EsMunicipio(string Valor)
    {
        var municipio = CLinq.ListByProperty<mun_Municipio>(context, "mun_Id", Valor);
        if (municipio.Count > 0)
            return true;
        return false;
    }

    internal bool EsProveedor(int Valor)
    {
        var proveedor = CLinq.ListByProperty<cpr_ComercializacionProveedor>(context, "cda_Id", Valor);
        if (proveedor.Count > 0)
            return true;
        return false;
    }

    internal bool EsSustancia(int Valor)
    {
        var sustancia = CLinq.ListByProperty<sus_Sustancia>(context, "sus_Id", Valor);
        if (sustancia.Count > 0)
            return true;
        return false;
    }

    internal bool EsPresentacion(int Valor)
    {
        var resultado = CLinq.ListByProperty<psu_PresentacionSustancia>(context, "psu_Id", Valor);
        if (resultado.Count > 0)
            return true;
        return false;
    }

    internal bool EsMarca(int Valor)
    {
        var resultado = CLinq.ListByProperty<mar_Marca>(context, "mar_Id", Valor);
        if (resultado.Count > 0)
            return true;
        return false;
    }

    internal bool EsFabricante(int Valor)
    {
        var resultado = CLinq.ListByProperty<ter_Tercero>(context, "ter_Id", Valor);
        if (resultado.Count > 0)
            return true;
        return false;
    }
}