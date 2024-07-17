using System;
using System.Globalization;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using Microsoft.VisualBasic;

namespace Pdf2Text
{
    public static class PdfParser
    {

        public static OrdenCompra ImportarPdf(string input)
        {
            DateTime start = DateTime.Now;
            //if (args.Length < 2)
            //{
            //	log("Usage: PDF2TEXT <input filename (PDF)> <output filename (text)>");
            //	return;
            //}
            string tipoDocumento = "";
            //string input = "oc 1010-18.pdf";
            //string ooutput = "oc 1010-18.txt";
            //using (StreamWriter sw = new StreamWriter(ooutput))
            //{
            //	sw.WriteLine(parseUsingPDFBox(input));
            //}
            string fechaPerfeccionamiento = "";
            string texto = parseUsingPDFBox(input);

            var lineasConHtml = texto.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            var lineas = texto.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            int o = 0;
            for (int p = 0; p < lineasConHtml.Length; p++)
            {
                if (!lineasConHtml[p].Contains("http:") && !lineasConHtml[p].Contains("https:") && !lineasConHtml[p].Contains("COMPR.AR"))
                {
                    lineas[o] = lineasConHtml[p];
                    o++;
                }
            }
            OrdenCompra orden = new OrdenCompra();
            for (int i = 0; i < lineas.Length; i++)
            {
                if (lineas[i].Contains(Constantes.ordenCompra) || lineas[i].Contains(Constantes.ordenCompraAbierta))
                {
                    tipoDocumento = lineas[i].Contains(Constantes.ordenCompraAbierta) ? "Abierta" : "Cerrada";
                    i++;
                    string sOrdenCompra = lineas[i];
                    var ordenCompraSplit = sOrdenCompra.Split('-');
                    string sNroOc = ordenCompraSplit[2].Replace("OCA", "").Replace("OC", "") + ordenCompraSplit[1];
                    orden.procedimientoNro = sOrdenCompra.ToString();
                    int nroOc;
                    if (string.Equals(tipoDocumento, "Abierta"))
                    {
                        if (int.TryParse(sNroOc.Insert(2, "0"), out nroOc))
                        {
                            orden.nroOC = nroOc;
                        }
                        else
                        {
                            log("Error en nro OC: " + sOrdenCompra);
                        }
                    }
                    else
                    {
                        if (int.TryParse(sNroOc, out nroOc))
                        {
                            orden.nroOC = nroOc;
                        }
                        else
                        {
                            log("Error en nro OC: " + sOrdenCompra);
                        }
                    }

                    //i++;
                    if (lineas[i].Contains(Constantes.procedimientoTipo))
                    {
                        i++;
                        string sProcedimientoTipo = lineas[i];
                        if (!string.IsNullOrEmpty(sProcedimientoTipo))
                        {
                            orden.procedimientoTipo = sProcedimientoTipo;
                        }
                        else
                        {
                            log("Error en Procedimiento Tipo: " + sProcedimientoTipo);
                        }
                    }
                    //i++;
                    if (lineas[i].Contains(Constantes.procedimientoNro))
                    {
                        i++;
                        string sProcedimientoNro = lineas[i];
                        sProcedimientoNro = sProcedimientoNro.Replace(Constantes.procedimientoNroReemplazar, "").Replace(Constantes.procedimientoNroReemplazarAbierta, "");
                        var procedimientoNroSplit = sProcedimientoNro.Split('-');
                        int procedimientoNro;

                        if (int.TryParse(procedimientoNroSplit[0], out procedimientoNro))
                        {
                            orden.procedimientoNumero = procedimientoNro;
                        }
                        else
                        {
                            log("Error en Procedimiento Nro: " + sProcedimientoNro);
                        }
                    }
                    //i++;
                    if (lineas[i].Contains(Constantes.procedimientoAnio))
                    {
                        i++;
                        string sProcedimientoAnio = lineas[i];
                        int procedimientoAnio;
                        if (int.TryParse(sProcedimientoAnio, out procedimientoAnio))
                        {
                            orden.procedimientoAnio = procedimientoAnio;
                        }
                        else
                        {
                            log("Error en Procedimiento Anio: " + sProcedimientoAnio);
                        }
                    }

                    //CODIGO PARA OBTENER FECHA INICIAL DEL CONTRATO 04/03/2021 
                }
                if (lineas[i].ToLower().Contains("fecha perfeccionamiento:"))
                {
                    i += 1;
                    fechaPerfeccionamiento = lineas[i].ToString().Replace(" ", string.Empty);
                    string sFecha = lineas[i].ToString().Replace(" ", string.Empty);
                    DateTime fecha;
                    if (DateTime.TryParseExact(sFecha, "dd/MM/yyyy", CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fecha))
                    {
                        orden.fechaInicio = fecha;

                    }
                    else if (DateTime.TryParseExact(fechaPerfeccionamiento, "dd/MM/yyyy", CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fecha))
                    {

                        orden.fechaInicio = fecha;
                        //log("Error en Fecha: " + sFecha);
                    }
                    //else
                    //{
                    //    string fechaIngresada;
                    //    fechaIngresada = Interaction.InputBox("Ingrese nueva fecha de perfeccionamineto o Autorizacion");
                    //    if (DateTime.TryParseExact(fechaIngresada, "dd/MM/yyyy", CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fecha))
                    //    {
                    //        orden.fechaInicio = fecha;
                    //    }
                    //    else
                    //    {
                    //        Interaction.MsgBox("Error en fecha de Inicio de la Orden de Compra!!!");
                    //        break;
                    //    }
                    //}


                }

                if (lineas[i].ToLower().Contains("fecha inicio:"))
                {
                    i += 1;
                    string sFecha = lineas[i];
                    DateTime fecha;
                    if (DateTime.TryParseExact(sFecha, "dd/MM/yyyy", CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fecha))
                    {
                        orden.fechaInicio = fecha;

                    }
                    else if (DateTime.TryParseExact(fechaPerfeccionamiento, "dd/MM/yyyy", CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fecha))
                    {

                        orden.fechaInicio = fecha;
                        //log("Error en Fecha: " + sFecha);
                    }
                    //else
                    //{
                    //    string fechaIngresada;
                    //    fechaIngresada = Interaction.InputBox("Ingrese nueva fecha de perfeccionamineto o Autorizacion");
                    //    if (DateTime.TryParseExact(fechaIngresada, "dd/MM/yyy", CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fecha))
                    //    {
                    //        orden.fechaInicio = fecha;
                    //    }
                    //    else
                    //    {
                    //        Interaction.MsgBox("Error en fecha de Inicio de la Orden de Compra!!!");
                    //        break;
                    //    }
                    //}


                }

                if (lineas[i].Contains("Fecha ﬁnalización:"))
                {
                    i += 1;
                    string sFecha = lineas[i];
                    DateTime fecha;
                    if (DateTime.TryParseExact(sFecha, "dd/MM/yyyy", CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fecha))
                    {
                        orden.fecha = fecha;
                    }
                    else
                    {
                        log("Error en Fecha: " + sFecha);
                    }
                }
                /* LINEAS DE CODIGO PARA INCORPORAR CALCULOS DE MULTA*/
                if (lineas[i].ToLower().Contains("duración del contrato:"))
                {
                    i += 1;
                    string UnidadTiempo;
                    string PlazoEntrega;
                    string tipoDias;
                    string LineaDuracionContrato = lineas[i];

                    if (LineaDuracionContrato.Contains("Día"))
                    {
                        UnidadTiempo = "dias";
                    }
                    else if (LineaDuracionContrato.Contains("Mes"))
                    {
                        UnidadTiempo = "Meses";
                    }
                    else if (LineaDuracionContrato.Contains("Año"))
                    {
                        UnidadTiempo = "Años";
                    }
                    else
                    {
                        UnidadTiempo = "dias";
                    }

                    PlazoEntrega = LineaDuracionContrato.Substring(0, LineaDuracionContrato.IndexOf(" "));
                    if (LineaDuracionContrato.ToLower().Contains("hábiles") || LineaDuracionContrato.ToLower().Contains("hábil/es"))
                    {
                        tipoDias = "hábiles";
                    }
                    else if (LineaDuracionContrato.Contains("corrido/s"))
                    {
                        tipoDias = "corridos";
                    }
                    else
                    {
                        tipoDias = "";
                    }

                    orden.Plazo = PlazoEntrega + " " + UnidadTiempo + " " + tipoDias;
                }
                /*****************FIN****************/
                if (lineas[i].Contains(Constantes.expediente) || lineas[i].Contains(Constantes.expedienteAbierta))
                {
                    i++;
                    string sExpediente = lineas[i];
                    var expedienteSplit = sExpediente.Split(new string[] { "- -" }, StringSplitOptions.None);

                    if (expedienteSplit.Length == 2)
                    {
                        orden.expedienteNro = expedienteSplit[0];
                    }
                    else
                    {
                        log("Error en Expediente: " + sExpediente);
                    }
                }

                if (lineas[i].Contains(Constantes.procedimientoNroCompleto) || lineas[i].Contains(Constantes.procedimientoNroCompletoAbierta))
                {
                    i++;
                    string sProcedimientoNroCompleto = lineas[i];

                    if (sProcedimientoNroCompleto.Length > 0)
                    {
                        orden.procedimientoTipo = sProcedimientoNroCompleto;
                    }
                    else
                    {
                        log("Error en sProcedimientoNroCompleto: " + sProcedimientoNroCompleto);
                    }
                }
                if (lineas[i].Contains(Constantes.clase))
                {
                    i++;
                    string Sclase = lineas[i];
                    //int procedimientoAnio;
                    if (!string.IsNullOrEmpty(Sclase))
                    {
                        orden.clase = Sclase;
                    }
                    else
                    {
                        log("Error en Clase: " + Sclase);
                    }
                }
                if (lineas[i].Contains(Constantes.adjudicatarioNombre))
                {
                    i++;
                    string sAdjudicatarioNombre = lineas[i];
                    if (!string.IsNullOrEmpty(sAdjudicatarioNombre))
                    {
                        orden.proveedorDescricion = sAdjudicatarioNombre;
                    }
                    else
                    {
                        log("Error en AdjudicatarioNombre: " + sAdjudicatarioNombre);
                    }
                }
                if (lineas[i].Contains(Constantes.adjudicatarioCodigo))
                {
                    i++;
                    string sAdjudicatarioCodigo = lineas[i];
                    int adjudicatarioCodigo;
                    if (int.TryParse(sAdjudicatarioCodigo, out adjudicatarioCodigo))
                    {
                        orden.proveedorCodigo = adjudicatarioCodigo;
                    }
                    else
                    {
                        log("Error en adjudicatario Codigo: " + sAdjudicatarioCodigo);
                    }
                }

                if (lineas[i].ToLower().Contains(Constantes.cuit) || lineas[i].ToLower().Contains("cuit"))
                {
                    i++;
                    string sCUIT = lineas[i];
                    if (!string.IsNullOrEmpty(sCUIT))
                    {
                        orden.CUIT = sCUIT;
                    }
                    else
                    {
                        log("Error en cuit: " + sCUIT);
                    }



                }

                //*******************DATOS PROVEEDOR******************** 03/10/2022
                if (lineas[i].Contains(Constantes.Domicilio))
                {
                    i++;
                    string domicilioProv = lineas[i];
                    if (!string.IsNullOrEmpty(domicilioProv))
                    {
                        orden.Domicilio = domicilioProv;
                    }
                    else
                    {
                        log("Error en domicilio: " + domicilioProv);
                    }



                }
                if (lineas[i].Contains(Constantes.CodPostal))
                {
                    i++;
                    string codigoPostal = lineas[i];
                    if (!string.IsNullOrEmpty(codigoPostal))
                    {
                        orden.CodPostal = codigoPostal;
                    }
                    else
                    {
                        log("Error en codigo postal " + codigoPostal);
                    }



                }

                if (lineas[i].Contains(Constantes.Localidad))
                {
                    i++;
                    string localidad = lineas[i];
                    if (!string.IsNullOrEmpty(localidad))
                    {
                        orden.Localidad = localidad;
                    }
                    else
                    {
                        log("Error en localidad: " + localidad);
                    }



                }
                if (lineas[i].Contains(Constantes.Provincia))
                {
                    i++;
                    string provincia = lineas[i];
                    if (!string.IsNullOrEmpty(provincia))
                    {
                        orden.Provincia = provincia;
                    }
                    else
                    {
                        log("Error en provincia: " + provincia);
                    }



                }

                if (lineas[i].Contains(Constantes.Telefono))
                {
                    i++;
                    string telefono = lineas[i];
                    if (!string.IsNullOrEmpty(telefono))
                    {
                        orden.Telefono = telefono;
                    }
                    else
                    {
                        log("Error en telefono: " + telefono);
                    }



                }

                if (lineas[i].Contains(Constantes.Email))
                {
                    i++;
                    string email = lineas[i];
                    if (!string.IsNullOrEmpty(email))
                    {
                        orden.Email = email;
                    }
                    else
                    {
                        log("Error en email: " + email);
                    }



                }

                //**************************FIN DATOS PROVEEDORE***********************


                if (lineas[i].Contains(Constantes.importeTotal))
                {
                    i++;
                    string sImporteTotal = lineas[i];
                    sImporteTotal = sImporteTotal.Replace(".", "");
                    //sImporteTotal = sImporteTotal.Replace(',', '.');
                    decimal importeTotal;
                    if (decimal.TryParse(sImporteTotal, out importeTotal))
                    {
                        orden.importeTotal = importeTotal;
                    }
                    else
                    {
                        log("Error en Importe Total: " + sImporteTotal);
                    }
                }
                if (lineas[i].Contains(Constantes.importeBonificado))
                {
                    i++;
                    string sImporteBonificado = lineas[i];
                    sImporteBonificado = sImporteBonificado.Replace(".", "");
                    //sImporteBonificado = sImporteBonificado.Replace(',', '.');
                    decimal importeBonificado;
                    if (decimal.TryParse(sImporteBonificado, out importeBonificado))
                    {
                        orden.importeBonificado = importeBonificado;
                    }
                    else
                    {
                        log("Error en Importe Bonificado: " + sImporteBonificado);
                    }
                }
                if (lineas[i].Contains(Constantes.importeNeto))
                {
                    i++;
                    string sImporteNeto = lineas[i];
                    sImporteNeto = sImporteNeto.Replace(".", "");
                    //sImporteNeto = sImporteNeto.Replace(',', '.');
                    decimal importeNeto;
                    if (decimal.TryParse(sImporteNeto, out importeNeto))
                    {
                        orden.importeNeto = importeNeto;
                    }
                    else
                    {
                        log("Error en Importe Neto: " + sImporteNeto);
                    }
                }
                if (lineas[i].Contains(Constantes.inicioRenglon) || lineas[i] == "unitario Moneda")
                {
                    if (tipoDocumento.Equals("Cerrada"))


                    {
                        i++;
                        int numero;
                        if (!lineas[i].Contains("/") && int.TryParse(lineas[i][0].ToString(), out numero))










                        {



                            LineaOC lineaOC = new LineaOC();
                            //i++;
                            lineaOC.NroOC = orden.nroOC;

                            string sLinea1 = lineas[i];
                            var linea1Split = sLinea1.Split(' ');
                            string sRenglon = linea1Split[0];
                            int renglon;
                            if (int.TryParse(sRenglon, out renglon))
                            {
                                lineaOC.renglon = renglon;
                            }
                            else
                            {
                                log("Error en Renglon: " + sRenglon);
                            }

                            lineaOC.codigoCompleto = linea1Split[2];//primer parte
                                                                    //234- 00999- 0029
                                                                    //2.3.4-999.29
                            i++;
                            string sLinea2 = lineas[i];
                            lineaOC.codigoCompleto += sLinea2;

                            //paso del formato de COMPRAR al formato SLU





                            var codComSplit = lineaOC.codigoCompleto.Split('-');
                            var codComSplit2 = codComSplit[1].Split('.');
                            string sCodigoCompleto = codComSplit[0].Replace(".", "");
                            sCodigoCompleto += string.Format("- {0} -{1}", codComSplit2[0].PadLeft(5, '0'), codComSplit2[1].PadLeft(4, '0'));
                            lineaOC.codigoCompleto = sCodigoCompleto;







                            var linea2Split = sLinea2.Split('.');
                            string sCodigoSistema = linea2Split[0] + linea2Split[1].PadLeft(4, '0');
                            int codigoSistema;
                            if (int.TryParse(sCodigoSistema, out codigoSistema))
                            {
                                lineaOC.codigoSistema = codigoSistema;
                            }
                            else
                            {
                                log("Error en codigoSistema: " + codigoSistema + " codigoCompleto: " + lineaOC.codigoCompleto);
                            }

                            i++;
                            string restoDeLinea = "";
                            while (!lineas[i].Contains(Constantes.finRenglon) && !lineas[i].Contains(Constantes.finRenglones) && i < lineas.Length)
                            {
                                restoDeLinea += lineas[i] + '\n';
                                i++;
                            }

                            var restoSplit = restoDeLinea.Split('\n');
                            //ARRANCO DE ATRAS PARA ADELANTE
                            int j = restoSplit.Length - 1;



















                            j--;
                            string sImporteTotal = restoSplit[j];
                            bool unoMenos = false;
                            if (sImporteTotal.Contains("$"))
                            {
                                unoMenos = true;
                            }
                            sImporteTotal = sImporteTotal.Replace(".", "").Replace("$", "");
                            //sImporteTotal = sImporteTotal.Replace(',', '.');
                            decimal importeTotal;
                            if (decimal.TryParse(sImporteTotal, out importeTotal))
                            {
                                lineaOC.precioTotal = importeTotal;
                            }
                            else
                            {
                                log("Error en Precio Total: " + sImporteTotal);
                            }
                            if (!unoMenos)
                                j--;
                            j--;
                            j--;
                            string sCantUnidPrecio = restoSplit[j];
                            var cantUnidPrecioSplit = sCantUnidPrecio.Split(' ');
                            int inicio = 0;
                            int fin = cantUnidPrecioSplit.Length - 2;

                            string sCantidad = cantUnidPrecioSplit[inicio];
                            decimal cantidad;
                            if (decimal.TryParse(sCantidad, out cantidad))
                            {
                                lineaOC.cantidad = cantidad;
                            }
                            else
                            {
                                log("Error en Cantidad: " + sCantidad);
                            }

                            string sPrecioUnidad = cantUnidPrecioSplit[fin];
                            sPrecioUnidad = sPrecioUnidad.Replace(".", "");
                            //sPrecioUnidad = sPrecioUnidad.Replace(',', '.');
                            decimal precioUnidad;
                            if (decimal.TryParse(sPrecioUnidad, out precioUnidad))
                            {
                                lineaOC.precioUnitario = precioUnidad;
                            }
                            else
                            {
                                log("Error en Precio Unitario: " + sPrecioUnidad);
                            }
                            string unidadMedida = "";
                            inicio++;
                            fin--;

                            for (int k = inicio; k <= fin; k++)
                            {
                                unidadMedida += cantUnidPrecioSplit[k].Trim() + " ";
                            }
                            unidadMedida = unidadMedida.Trim();
                            if (!string.IsNullOrEmpty(unidadMedida))
                            {
                                lineaOC.unidad = unidadMedida;
                            }
                            else
                            {
                                log("Error en UnidadMedida: " + sCantUnidPrecio);
                            }

                            string descripcion = "";
                            for (int l = 0; l < j; l++)
                            {
                                descripcion += restoSplit[l].Trim() + " ";
                            }
                            descripcion = descripcion.Trim();
                            lineaOC.descripcion = descripcion;

                            orden.lineas.Add(lineaOC);
                        }
                    }


                }

                if (lineas[i].Contains(Constantes.inicioRenglonAbierta) || lineas[i].Contains(Constantes.inicioRenglonAbiertaVariante))//inicioRenglonAbierta puede variar leyenda Unitario moneda 03/02/2021
                {
                    //reitera codigo en oc abiertas para obtener DENOMINACION, NROENTE Y CUIT DEL PROVEEDOR
                    //while (!lineas[i].Contains(Constantes.adjudicatarioNombre))
                    //{
                    //    i++;
                    //}
                    //i++;
                    //string sAdjudicatarioNombreAbierta = lineas[i];
                    //if (!string.IsNullOrEmpty(sAdjudicatarioNombreAbierta))
                    //{
                    //    orden.proveedorDescricion = sAdjudicatarioNombreAbierta;
                    //}
                    //else
                    //{
                    //    log("Error en AdjudicatarioNombre: " + sAdjudicatarioNombreAbierta);
                    //}

                    //while (!lineas[i].Contains(Constantes.adjudicatarioCodigo))
                    //{
                    //    i++;
                    //}
                    //i++;
                    //string sAdjudicatarioCodigoAbierta = lineas[i];
                    //int adjudicatarioCodigoAbierta;
                    //if (int.TryParse(sAdjudicatarioCodigoAbierta, out adjudicatarioCodigoAbierta))
                    //{
                    //    orden.proveedorCodigo = adjudicatarioCodigoAbierta;
                    //}
                    //else
                    //{
                    //    log("Error en adjudicatario Codigo: " + sAdjudicatarioCodigoAbierta);
                    //}

                    //while (!lineas[i].ToLower().Contains(Constantes.cuit) && !lineas[i].ToLower().Contains("cuit:"))
                    //{
                    //    i++;
                    //}
                    //i++;
                    //string sCUITAbierta = lineas[i];
                    //if (!string.IsNullOrEmpty(sCUITAbierta))
                    //{
                    //    orden.CUIT = sCUITAbierta;
                    //}
                    //else
                    //{
                    //    log("Error en cuit/cuil/nit: " + sCUITAbierta);
                    //}

                    while (lineas[i].Length != 10 || !lineas[i].Contains(".") || lineas[i].Contains(","))
                    {
                        i++;
                    }
                    //********************LINEAS DE CODIGO AUXILIARES PARA IMPORTACION DE OC Abiertas*******03/02/2021
                    string lineaConCodigo = lineas[i];
                    var lineaSplitAux = lineaConCodigo.Split(' ');
                    string RenglonAux = lineaSplitAux[0];
                    string RenglonAltAux = lineaSplitAux[1];
                    string ippAux = lineaSplitAux[2];
                    int reng = 0;
                    int rengAlt = 0;

                    //***********************************************FIN***********************************//

                    if (int.TryParse(RenglonAux, out reng) && int.TryParse(RenglonAltAux, out rengAlt) && ippAux.Contains("."))
                    {
                        //i++; 03/02/2021 quito incremento
                        int salida = 0;
                        while (lineas[i] != Constantes.finRenglonAbierta && int.TryParse(lineas[i][0].ToString(), out salida))
                        {
                            int numero;
                            if (!lineas[i].Contains("/") && int.TryParse(lineas[i][0].ToString(), out numero))
                            {

                                LineaOC lineaOC = new LineaOC();
                                //i++;
                                string sLinea1 = lineas[i];
                                var linea1Split = sLinea1.Split(' ');
                                string sRenglon = linea1Split[0];
                                int renglon;
                                if (int.TryParse(sRenglon, out renglon))
                                {
                                    lineaOC.renglon = renglon;
                                }
                                else
                                {
                                    log("Error en Renglon: " + sRenglon);
                                }

                                lineaOC.codigoCompleto = linea1Split[2];//primer parte
                                                                        //234- 00999- 0029
                                                                        //2.3.4-999.29
                                i++;
                                string sLinea2 = lineas[i];
                                lineaOC.codigoCompleto += sLinea2;

                                //paso del formato de COMPRAR al formato SLU

                                var codComSplit = lineaOC.codigoCompleto.Split('-');
                                var codComSplit2 = codComSplit[1].Split('.');
                                string sCodigoCompleto = codComSplit[0].Replace(".", "");
                                sCodigoCompleto += string.Format("- {0} -{1}", codComSplit2[0].PadLeft(5, '0'), codComSplit2[1].PadLeft(4, '0'));
                                lineaOC.codigoCompleto = sCodigoCompleto;

                                var linea2Split = sLinea2.Split('.');
                                string sCodigoSistema = linea2Split[0] + linea2Split[1].PadLeft(4, '0');
                                int codigoSistema;
                                if (int.TryParse(sCodigoSistema, out codigoSistema))
                                {
                                    lineaOC.codigoSistema = codigoSistema;
                                }
                                else
                                {
                                    log("Error en codigoSistema: " + codigoSistema + " codigoCompleto: " + lineaOC.codigoCompleto);
                                }

                                i++;
                                string restoDeLinea = "";


                                while (!lineas[i].Contains(Constantes.finRenglonAbierta) && !lineas[i].Contains(Constantes.finRenglonesAbierta) && i < lineas.Length)
                                {
                                    restoDeLinea += lineas[i] + '\n';
                                    i++;
                                }

                                i++;
                                restoDeLinea += lineas[i] + '\n';
                                i++;
                                var restoSplit = restoDeLinea.Replace(' ', '\n').Split('\n');
                                //ARRANCO DE ATRAS PARA ADELANTE
                                int j = restoSplit.Length - 1;
                                j--;
                                string sImporteTotal = restoSplit[j];
                                sImporteTotal = sImporteTotal.Replace(".", "");
                                //sImporteTotal = sImporteTotal.Replace(',', '.');
                                decimal importeTotal;
                                if (decimal.TryParse(sImporteTotal, out importeTotal))
                                {
                                    lineaOC.precioTotal = importeTotal;
                                }
                                else
                                {
                                    log("Error en Precio Total: " + sImporteTotal);
                                }
                                j--;
                                j--;

                                string sPrecioUnidad = restoSplit[j];
                                //sPrecioUnidad = sPrecioUnidad.Replace(',', '.');
                                decimal precioUnidad;
                                if (decimal.TryParse(sPrecioUnidad, out precioUnidad))
                                {
                                    lineaOC.precioUnitario = precioUnidad;
                                }
                                else
                                {
                                    log("Error en Precio Unitario: " + sPrecioUnidad);
                                }

                                j--;
                                j--;
                                j--;

                                string unidadMedida = restoSplit[j];
                                unidadMedida = unidadMedida.Trim();
                                if (!string.IsNullOrEmpty(unidadMedida))
                                {
                                    lineaOC.unidad = unidadMedida;
                                }
                                else
                                {
                                    log("Error en UnidadMedida: " + unidadMedida);
                                }

                                j--;

                                string sCantidad = restoSplit[j];
                                decimal cantidad;
                                if (decimal.TryParse(sCantidad, out cantidad))
                                {
                                    lineaOC.cantidad = cantidad;
                                }
                                else
                                {
                                    log("Error en Cantidad: " + sCantidad);
                                }

                                j--;
                                j--;

                                string descripcion = "";
                                for (int l = 0; l < j; l++)
                                {
                                    descripcion += restoSplit[l].Trim() + " ";
                                }
                                descripcion = descripcion.Trim();
                                lineaOC.descripcion = descripcion;

                                orden.lineas.Add(lineaOC);
                                while (string.IsNullOrEmpty(lineas[i]) && i < lineas.Length)
                                    i++;
                            }
                            else
                            {
                                i++;
                            }
                        }


                    }

                }


                if (lineas[i].Contains(Constantes.totalOrdenAbierta))
                {
                    i++;
                    string sImporteTotal = lineas[i];
                    sImporteTotal = sImporteTotal.Replace(".", "").Replace(" ARS", "");
                    //sImporteTotal = sImporteTotal.Replace(',', '.');
                    decimal importeTotal;
                    if (decimal.TryParse(sImporteTotal, out importeTotal))
                    {
                        orden.importeTotal = importeTotal;
                        orden.importeNeto = importeTotal;
                    }
                    else
                    {
                        log("Error en Importe Total: " + sImporteTotal);
                    }
                }
                //ELIMINAR****
                if (lineas[i].Contains("PRDFINMSAPPB08"))
                {
                    string stop = "";
                }
                //***********

            }
            log("Done. Took " + (DateTime.Now - start));
            return orden;
            //			Console.ReadLine();

        }
        public static void log(string mensaje)
        {

        }
        private static string parseUsingPDFBox(string input)
        {
            PDDocument doc = null;

            try
            {
                doc = PDDocument.load(input);
                PDFTextStripper stripper = new PDFTextStripper();
                return stripper.getText(doc);
            }
            finally
            {
                if (doc != null)
                {
                    doc.close();
                }
            }
        }
    }
}
