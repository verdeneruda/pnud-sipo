using DevExpress.Data.Filtering.Helpers;
using DevExpress.Utils.CodedUISupport;
using DevExpress.XtraPivotGrid.Data;
using DevExpress.XtraRichEdit.Internal.PrintLayout;
using Microsoft.Ajax.Utilities;
using NE.CLib.Linq;
using Seguridad.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.IdentityModel.Metadata;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Web;
using UTO.Comercializacion;



/// <summary>
/// Descripción breve de ImportarComercio
/// </summary>
public class ImportarComercio
{
    ComercializacionDataContext MyDataContext;
    public Stream bytArchivo { get; set; }
    string respuesta = "";
    public DataTable dtRegistros { get; set; }
    public CUsuario Usuario { get; set; }

    public ImportarComercio(Stream bteArchivo, ComercializacionDataContext myDataContext, CUsuario cUsuario)
    {
        this.bytArchivo = bteArchivo;
        this.Usuario = cUsuario;
        MyDataContext = myDataContext;
        dtRegistros = new DataTable();
        dtRegistros.Columns.Add("NroRegsitro");
        dtRegistros.Columns.Add("Fecha", typeof(DateTime));
        dtRegistros.Columns.Add("Departamento");
        dtRegistros.Columns.Add("Ciudad");
        dtRegistros.Columns.Add("Identificacion");
        dtRegistros.Columns.Add("Empresa");
        dtRegistros.Columns.Add("Contacto");
        dtRegistros.Columns.Add("Telefono");
        dtRegistros.Columns.Add("Direccion");
        dtRegistros.Columns.Add("CorreoElectronico");
        dtRegistros.Columns.Add("Proveedor", typeof(int));
        dtRegistros.Columns.Add("Sustancia", typeof(int));
        dtRegistros.Columns.Add("Envase");
        dtRegistros.Columns.Add("Presentacion", typeof(int));
        dtRegistros.Columns.Add("NombreComercial", typeof(int));
        dtRegistros.Columns.Add("Fabricante", typeof(int));
        dtRegistros.Columns.Add("PrecioCOP", typeof(decimal));
        dtRegistros.Columns.Add("Observacion");
    }
    public string Ejecutar()
    {
        return EjecutarCargueMasivo();
    }
    private string EjecutarCargueMasivo()
    {
        StreamReader reader;
        MemoryStream archivo = null;
        StreamWriter swOut;
        string linea, salida, retorno=string.Empty;
        int numLinea = 0, rechazados = 0, aceptados = 0;
        archivo = new MemoryStream();
        swOut = new StreamWriter(archivo);
        reader = new StreamReader(bytArchivo);
        
        while (reader.Peek() > -1)
        {
            respuesta = "";
            numLinea = numLinea + 1;
            linea = reader.ReadLine();
            if (linea != "")
            {
                if (!ProcesarLinea(linea, decimal.Parse(numLinea.ToString())))
                {
                    salida = "Linea " + numLinea.ToString() + ": " + respuesta;
                    swOut.WriteLine(salida);
                    rechazados = rechazados + 1;
                }
            }
            else
            {
                salida = "Linea " + numLinea.ToString() + ": no contiene datos";
                swOut.WriteLine(salida);
                rechazados = rechazados + 1;
            }
        }
        if (dtRegistros.Rows.Count > 0)
        {
            // se realiza el distinct de las empresas para obtener lo datos de proveedores y las sustancias
            var dataEmpresa = dtRegistros.AsEnumerable().Select(x=> new { Identificacion = x.Field<string>("Identificacion"), departamento = x.Field<string>("Departamento"), ciudad= x.Field<string>("Ciudad") }).Distinct();
            // por cada empresa se realiza el procesamiento de datos
            foreach (var iEmpresa in dataEmpresa)
            {
                //obtiene la informacion de la encuesta
                var infoDatosEncuesta = dtRegistros.AsEnumerable().Where(x => x.Field<string>("Identificacion") == iEmpresa.Identificacion && x.Field<string>("Departamento") == iEmpresa.departamento && x.Field<string>("Ciudad") == iEmpresa.ciudad).Select(x => new {nroRegistro = x.Field<string>("NroRegsitro"), Identificacion = x.Field<string>("Identificacion"), Empresa = x.Field<string>("Empresa"), Fecha = x.Field<DateTime>("Fecha"), contacto = x.Field<string>("Contacto"), departamento = x.Field<string>("Departamento"), ciudad = x.Field<string>("Ciudad"), direccion = x.Field<string>("Direccion"), telefono = x.Field<string>("Telefono"), correoElectronico = x.Field<string>("CorreoElectronico") }).ToList();

                //obtiene la informacion de los proveedores
                var infoProveedor = dtRegistros.AsEnumerable().Where(x => x.Field<string>("Identificacion") == iEmpresa.Identificacion).Select(x => new { Proveedor = x.Field<Int32>("Proveedor") }).Distinct().ToList();

                //obtienen la información de las sustancias
                var infoSustancias = dtRegistros.AsEnumerable().Where(x => x.Field<string>("Identificacion") == iEmpresa.Identificacion).Select(x => new { fabricante = x.Field<Int32>("Fabricante"), sustancia = x.Field<Int32>("Sustancia"), presentacion = x.Field<Int32>("Presentacion"), marca = x.Field<Int32>("NombreComercial"), precio = x.Field<decimal>("PrecioCOP"), observaciones = x.Field<string>("Observacion") }).ToList();

                ter_Tercero tercero = (ter_Tercero)CLinq.FindByProperty<ter_Tercero>(MyDataContext, "ter_NumeroDocumento", iEmpresa.Identificacion).First();
                if (tercero.ter_Id == 0)
                {
                    // se realiza busqueda por nombre del tercero
                    tercero = (ter_Tercero)CLinq.FindByProperty<ter_Tercero>(MyDataContext, "ter_NombreCompleto", (object)iEmpresa.Identificacion).First();
                }

                if (tercero.ter_Id == 0)
                {
                    ter_Tercero data2 = new ter_Tercero();
                    data2.ter_NombreCompleto = infoDatosEncuesta.First().Empresa;
                    data2.ter_NumeroDocumento = infoDatosEncuesta.First().Identificacion;
                    data2.ter_Direccion = infoDatosEncuesta.First().direccion;
                    data2.ter_Tefono = infoDatosEncuesta.First().telefono;
                    data2.ter_Correo = infoDatosEncuesta.First().correoElectronico;
                    data2.dep_Id = infoDatosEncuesta.First().departamento;
                    data2.mun_Id = infoDatosEncuesta.First().ciudad;
                    ttt_TerceroTipoTercero tttentity = new ttt_TerceroTipoTercero();
                    tttentity.tti_Id = 4;
                    data2.bti_Id = 2;
                    data2.dti_Id = 1;
                    tttentity.ter_Tercero = data2;
                    this.MyDataContext.ter_Terceros.InsertOnSubmit(data2);
                    this.MyDataContext.ttt_TerceroTipoTerceros.InsertOnSubmit(tttentity);
                }
                else if (CLinq.ListByProperties<ttt_TerceroTipoTercero>(MyDataContext, (object)"tti_Id", (object)4, (object)"ter_Id", (object)tercero.ter_Id).Count == 0)
                {
                    this.MyDataContext.ttt_TerceroTipoTerceros.InsertOnSubmit(new ttt_TerceroTipoTercero()
                    {
                        ter_Tercero = tercero,
                        tti_Id = 4
                    });
                }
                 
                // procesar proveedores
                List<cpr_ComercializacionProveedor> listaProveedores = new List<cpr_ComercializacionProveedor>();
                foreach (var iproveedor in infoProveedor)
                {
                    cpr_ComercializacionProveedor detalle = new cpr_ComercializacionProveedor();
                    detalle.ter_Tercero = CLinq.FindByKey<ter_Tercero>(MyDataContext, iproveedor.Proveedor);
                    detalle.cda_ComercializacionDato = new cda_ComercializacionDato();
                    this.MyDataContext.cpr_ComercializacionProveedors.InsertOnSubmit(detalle);
                    listaProveedores.Add(detalle);
                }
                // procesar sustancias
                List<cdd_ComercializacionDatosDetalle> listaSustancias = new List<cdd_ComercializacionDatosDetalle>();
                foreach (var isustancia in infoSustancias)
                {
                    cdd_ComercializacionDatosDetalle detalle = new cdd_ComercializacionDatosDetalle();
                    detalle.cdd_Creado = DateTime.Now;
                    detalle.cdd_Modificado = DateTime.Now;
                    detalle.cdd_Observaciones = isustancia.observaciones;
                    detalle.cdd_Precio = isustancia.precio;
                    detalle.cdd_Usuario = "";
                    detalle.mar_Id = isustancia.marca;
                    detalle.psu_Id = isustancia.presentacion;
                    detalle.sus_Id = isustancia.sustancia;
                    detalle.ter_IdFabricante = isustancia.fabricante;
                    detalle.cda_ComercializacionDato = new cda_ComercializacionDato();
                    listaSustancias.Add(detalle);
                }
                cda_ComercializacionDato cda_ComercializacionDato = new cda_ComercializacionDato();
                cda_ComercializacionDato.cda_Fecha = infoDatosEncuesta.First().Fecha;
                cda_ComercializacionDato.cda_Contacto = infoDatosEncuesta.First().contacto;
                cda_ComercializacionDato.cda_Direccion = infoDatosEncuesta.First().direccion;
                cda_ComercializacionDato.cda_Telefono = infoDatosEncuesta.First().telefono;
                cda_ComercializacionDato.cda_Usuario = this.Usuario.login;
                cda_ComercializacionDato.cda_Modificado = DateTime.Now;
                cda_ComercializacionDato.dep_Id = infoDatosEncuesta.First().departamento;
                cda_ComercializacionDato.mun_Id = infoDatosEncuesta.First().ciudad;
                if (cda_ComercializacionDato.cda_Id == 0)
                {
                    cda_ComercializacionDato.cda_Creado = DateTime.Now;
                    cda_ComercializacionDato.ter_Tercero = tercero;
                    this.MyDataContext.cda_ComercializacionDatos.InsertOnSubmit(cda_ComercializacionDato);
                }
                foreach (var isustancia in listaSustancias)
                {
                    if (isustancia.cdd_Id == 0)
                    {
                        isustancia.cda_ComercializacionDato = cda_ComercializacionDato;
                        this.MyDataContext.cdd_ComercializacionDatosDetalles.InsertOnSubmit(isustancia);
                    }

                }
                foreach (var iproveedor in listaProveedores)
                {
                    if (iproveedor.cda_Id == 0)
                    {
                        iproveedor.cda_ComercializacionDato = cda_ComercializacionDato;
                        this.MyDataContext.cpr_ComercializacionProveedors.InsertOnSubmit(iproveedor);
                    }
                }
                
                this.MyDataContext.SubmitChanges();

                CAuditoria.log(EPermiso.ModificarDatosDeComercializacion, cda_ComercializacionDato.cda_Id.ToString(), cda_ComercializacionDato.ter_Tercero.ter_NumeroDocumento, cda_ComercializacionDato.ter_Tercero.ter_NombreCompleto, "", "", this.Usuario.id);
                salida = "Linea " + infoDatosEncuesta.First().nroRegistro + ": " + "Insertado";
                swOut.WriteLine(salida);
                aceptados = aceptados + 1;
            }
            retorno = "Registros Procesados: " + numLinea.ToString() + " Aceptados: " + aceptados.ToString() + " Rechazados: " + rechazados.ToString();
            swOut.WriteLine(retorno);
            swOut.Close();
        }
        return retorno;
    }

    private bool ProcesarLinea(string linea, decimal nroLinea)
    {
        string dato="",strNombreEmpresa = "", strContacto = "", strTelefono = "", strDireccion = "", strCorreoElectronico = "", strEnvase = "", strObservaciones = "", strDepartamentoId = "", strMunicipioId = "", strIdentificacion = "";
        int codProveedor=-1, codSustancia=-1, codPresentacion = -1, codFabricante = -1, codMarca = -1;
        decimal decPrecioCop = -1;
        DateTime? dtFechaVisita= null;
        string[] split;
        int pos;
        Validar validar = new Validar(MyDataContext);
        try
        {
            split = linea.Split(';');
            pos = split.GetUpperBound(0);
            if (pos != 16)
            {
                respuesta = "La linea del archivo no tiene los campos requeridos";
                return false;
            }

            /// Fecha Visita
            if (split[0].ToString().Trim() == string.Empty)
            {
                respuesta += "La fecha de Visita no puede estar vacia; ";
            }
            else if (!validar.EsFecha(split[0].ToString().Trim()))
            {
                respuesta += "La fecha de Visita no tiene el formato correcto dd/MM/yyyy; "; 
            }
            else
            {
                dtFechaVisita = Convert.ToDateTime(split[0].ToString().Trim());
            }
            /// Departamento
            if (split[1].ToString().Trim() == string.Empty)
            {
                respuesta += "El departamento no puede estar vacio; ";
            }
            else if (!validar.EsNumero(split[1].ToString().Trim()))
            {
                respuesta += "El departamento debe ser numerico; ";
            }
            else if (!validar.EsDepartamento(split[1].ToString().Trim()))
            {
                respuesta += "El departamento no es valido; ";
            }
            else 
            {
                strDepartamentoId = split[1].ToString().Trim();
            }
            ///Municipio
            if (split[2].ToString().Trim() == string.Empty)
            {
                respuesta += "El municipio no puede estar vacio; ";
            }
            else if (!validar.EsNumero(split[2].ToString().Trim()))
            {
                respuesta += "El municipio debe ser numerico; ";
            }
            else if (!validar.EsMunicipio(split[2].ToString().Trim()))
            {
                respuesta += "El municipio no es valido; ";
            }
            else
            {
                strMunicipioId = split[2].ToString().Trim();
            }

            /// Identificacion
            if (split[3].ToString().Trim() == string.Empty)
            {
                respuesta += "La Identificación no puede estar vacia; ";
            }
            else
            {
                strIdentificacion = split[3].ToString().Trim();
            }
            /// Nombre empresa
            if (split[4].ToString().Trim() == string.Empty)
            {
                respuesta += "El nombre empresa no puede estar vacia; ";
            }
            else
            {
                strNombreEmpresa = split[4].ToString().Trim();
            }
            ///Contacto
            if (split[5].ToString().Trim() != string.Empty)
                strContacto = split[5].ToString().Trim();
            ///Telefono
            if (split[6].ToString().Trim() != string.Empty)
                strTelefono = split[6].ToString().Trim();
            ///Direccion
            if (split[7].ToString().Trim() != string.Empty)
                strDireccion = split[7].ToString().Trim();
            //Correo electronico
            if (split[8].ToString().Trim() != string.Empty)
                strCorreoElectronico = split[8].ToString().Trim();
            //Proveedor
            if (split[9].ToString().Trim() == string.Empty)
            {
                respuesta += "El proveedor no puede estar vacio; ";
            }
            else if (!validar.EsNumero(split[9].ToString().Trim()))
            {
                respuesta += "El proveedor debe ser numerico; ";
            }
            else if (!validar.EsProveedor(Convert.ToInt32(split[9].ToString())))
            {
                respuesta += "El proveedor no es valido; ";
            }
            else
            {
                codProveedor = Convert.ToInt32(split[9].ToString().Trim());
            }
            //Sustancia
            if (split[10].ToString().Trim() == string.Empty)
            {
                respuesta += "La sustancia no puede estar vacio; ";
            }
            else if (!validar.EsNumero(split[10].ToString().Trim()))
            {
                respuesta += "La sustancia debe ser numerico; ";
            }
            else if (!validar.EsSustancia(Convert.ToInt32(split[10].ToString())))
            {
                respuesta += "La sustancia no es valido; ";
            }
            else
            {
                codSustancia = Convert.ToInt32(split[10].ToString().Trim());
            }
            //Envase
            if (split[11].ToString().Trim() != string.Empty)
                strEnvase = split[11].ToString().Trim();
            //Presentacion
            if (split[12].ToString().Trim() == string.Empty)
            {
                respuesta += "La presentación no puede estar vacio; ";
            }
            else if (!validar.EsNumero(split[12].ToString().Trim()))
            {
                respuesta += "La prestanción debe ser numerico; ";
            }
            else if (!validar.EsPresentacion(Convert.ToInt32(split[12].ToString())))
            {
                respuesta += "La presentación no es valido; ";
            }
            else
            {
                codPresentacion = Convert.ToInt32(split[12].ToString().Trim());
            }
            //Nombre Comercial Marca
            if (split[13].ToString().Trim() == string.Empty)
            {
                respuesta += "El nombre comercial no puede estar vacio; ";
            }
            else if (!validar.EsNumero(split[13].ToString().Trim()))
            {
                respuesta += "El nombre comercial debe ser numerico; ";
            }
            else if (!validar.EsMarca(Convert.ToInt32(split[13].ToString())))
            {
                respuesta += "El nombre comercial no es valido; ";
            }
            else
            {
                codMarca = Convert.ToInt32(split[13].ToString().Trim());
            }
            // Fabricante
            if (split[14].ToString().Trim() == string.Empty)
            {
                respuesta += "El fabricante no puede estar vacio; ";
            }
            else if (!validar.EsNumero(split[14].ToString().Trim()))
            {
                respuesta += "El fabricante debe ser numerico; ";
            }
            else if (!validar.EsFabricante(Convert.ToInt32(split[14].ToString())))
            {
                respuesta += "El fabricante no es valido; ";
            }
            else
            {
                codFabricante = Convert.ToInt32(split[14].ToString().Trim());
            }
            // Precio COP
            if (split[15].ToString().Trim() == string.Empty)
            {
                respuesta += "El precio COP no puede estar vacio; ";
            }
            else if (!validar.EsNumero(split[15].ToString().Trim()))
            {
                respuesta += "El precio COP debe ser numerico; ";
            }
            else
            {
                decPrecioCop = Convert.ToDecimal(split[15].ToString().Trim());
            }
            //Envase
            if (split[16].ToString().Trim() != string.Empty)
                strObservaciones = split[16].ToString().Trim();

            // se crea el datatable de los registros
            if (respuesta == string.Empty)
            {
                DataRow dataRow = dtRegistros.NewRow();
                dataRow[0] = nroLinea;
                dataRow[1] = dtFechaVisita;
                dataRow[2] = strDepartamentoId;
                dataRow[3] = strMunicipioId;
                dataRow[4] = strIdentificacion;
                dataRow[5] = strNombreEmpresa;
                dataRow[6] = strContacto;
                dataRow[7] = strTelefono;
                dataRow[8] = strDireccion;
                dataRow[9] = strCorreoElectronico;
                dataRow[10] = codProveedor;
                dataRow[11] = codSustancia;
                dataRow[12] = strEnvase;
                dataRow[13] = codPresentacion;
                dataRow[14] = codMarca;
                dataRow[15] = codFabricante;
                dataRow[16] = decPrecioCop;
                dataRow[17] = strObservaciones;
                dtRegistros.Rows.Add(dataRow);
                return true;
            }
            else
                return false;

        }
        catch (Exception)
        {

            throw;
        }
    }

    
}
