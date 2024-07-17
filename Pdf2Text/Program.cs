using System;
using System.Globalization;
using System.IO;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;

namespace Pdf2Text
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            //if (args.Length < 2)
            //{
            //	Console.WriteLine("Usage: PDF2TEXT <input filename (PDF)> <output filename (text)>");
            //	return;
            //}

            string input = "oc 1010-18.pdf";
            //string ooutput = "oc 1010-18.txt";
            //using (StreamWriter sw = new StreamWriter(ooutput))
            //{
            //	sw.WriteLine(parseUsingPDFBox(input));
            //}

            string texto = parseUsingPDFBox(input);

            var lineas = texto.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            OrdenCompra orden = new OrdenCompra();
            for (int i = 0; i < lineas.Length; i++)
            {
                if (lineas[i].Contains(Constantes.ordenCompra))
                {
                    i++;
                    string sOrdenCompra = lineas[i];
                    var ordenCompraSplit = sOrdenCompra.Split('-');
                    string sNroOc = ordenCompraSplit[2].Replace("OC", "") + ordenCompraSplit[1];
                    int nroOc;
                    if (int.TryParse(sNroOc, out nroOc))
                    {
                        orden.nroOC = nroOc;
                    }
                    else
                    {
                        Console.WriteLine("Error en nro OC: " + sOrdenCompra);
                    }
                    i++;
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
                            Console.WriteLine("Error en Procedimiento Tipo: " + sProcedimientoTipo);
                        }
                    }
                    i++;
                    if (lineas[i].Contains(Constantes.procedimientoNro))
                    {
                        i++;
                        string sProcedimientoNro = lineas[i];
                        sProcedimientoNro = sProcedimientoNro.Replace(Constantes.procedimientoNroReemplazar, "");
                        var procedimientoNroSplit = sProcedimientoNro.Split('-');
                        int procedimientoNro;

                        if (int.TryParse(procedimientoNroSplit[0], out procedimientoNro))
                        {
                            orden.procedimientoNumero = procedimientoNro;
                        }
                        else
                        {
                            Console.WriteLine("Error en Procedimiento Nro: " + sProcedimientoNro);
                        }
                    }
                    i++;
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
                            Console.WriteLine("Error en Procedimiento Anio: " + sProcedimientoAnio);
                        }
                    }
                }
                
                if (lineas[i].Contains(Constantes.fechaFinal))
                {
                    i++;
                    string sFecha = lineas[i];
                    DateTime fecha;
                    if (DateTime.TryParseExact(sFecha, "dd/MM/yyyy", CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fecha))
                    {
                        orden.fecha = fecha;
                    }
                    else
                    {
                        Console.WriteLine("Error en Fecha: " + sFecha);
                    }
                }

                if (lineas[i].Contains(Constantes.expediente))
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
                        Console.WriteLine("Error en Expediente: " + sExpediente);
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
                        Console.WriteLine("Error en AdjudicatarioNombre: " + sAdjudicatarioNombre);
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
                        Console.WriteLine("Error en adjudicatario Codigo: " + sAdjudicatarioCodigo);
                    }
                }

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
                        Console.WriteLine("Error en Importe Total: " + sImporteTotal);
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
                        Console.WriteLine("Error en Importe Bonificado: " + sImporteBonificado);
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
                        Console.WriteLine("Error en Importe Neto: " + sImporteNeto);
                    }
                }
                if (lineas[i] ==Constantes.inicioRenglon)
                {
                    LineaOC lineaOC = new LineaOC();
                    i++;
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
                        Console.WriteLine("Error en Renglon: " + sRenglon);
                    }

                    lineaOC.codigoCompleto = linea1Split[2];//primer parte
                    i++;
                    string sLinea2 = lineas[i];
                    lineaOC.codigoCompleto += sLinea2;
                    var linea2Split = sLinea2.Split('.');
                    string sCodigoSistema = linea2Split[0] + linea2Split[1].PadLeft(4, '0');
                    int codigoSistema;
                    if (int.TryParse(sCodigoSistema, out codigoSistema))
                    {
                        lineaOC.codigoSistema = codigoSistema;
                    }
                    else
                    {
                        Console.WriteLine("Error en codigoSistema: " + codigoSistema + " codigoCompleto: " + lineaOC.codigoCompleto);
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
                    int j = restoSplit.Length-1;
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
                        Console.WriteLine("Error en Precio Total: " + sImporteTotal);
                    }
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
                        Console.WriteLine("Error en Cantidad: " + sCantidad);
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
                        Console.WriteLine("Error en Precio Unitario: " + sPrecioUnidad);
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
                        Console.WriteLine("Error en UnidadMedida: " + sCantUnidPrecio);
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
            Console.WriteLine("Done. Took " + (DateTime.Now - start));

            //			Console.ReadLine();

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
