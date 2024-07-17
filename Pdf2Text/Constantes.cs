using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pdf2Text
{
    public static class Constantes
    {
        public const string ordenCompra = "Número Orden de compra:";
        public const string ordenCompraAbierta = "Número de la Orden de Compra Abierta:";
        public const string procedimientoTipo = "Tipo:";
        public const string procedimientoNro = "Deompra generada por Proceso Nº ";
        public const string procedimientoNroReemplazarAbierta = "Orden de Compscripción:";
        public const string procedimientoNroReemplazar = "Orden de cra Abierta generada por Proceso Nº ";
        public const string procedimientoAnio = "Ejercicio:";
        public const string clase = "Clase:";//nuevo. dato objeto del proceso
        public const string DispAdjudicacion = "Número acto administrativo de adjudicación:";//nuevo. dato objeto del proceso
        public const string fechaFinal = "Fecha inicio:";
        public const string fechaInicio = "Fecha inicio:";
        public const string expediente = "Número expediente:";
        public const string expedienteAbierta = "Número de Expediente:";
        //***************DATOS PROVEEDOR**********//
        public const string adjudicatarioNombre = "Razón social:"; //Razón social:
        public const string adjudicatarioCodigo = "Número ente:";
        public const string cuit = "número cuit/cuil/nit:";
        public const string Domicilio = "Domicilio:";
        public const string CodPostal = "Código postal:";
        public const string Localidad = "Localidad:";
        public const string Provincia = "Provincia:";
        public const string Telefono = "Teléfono:";
        public const string Email = "Email:";

        public const string importeTotal = "Importe total";
        public const string importeBonificado = "Importe boniﬁcado";
        public const string importeNeto = "Importe neto";
        public const string inicioRenglon = "unitario Moneda";
        //modificacion para ordenes abiertas con error
        //reemplaza 'Total' por 'unitario Moneda Precio Total'
        public const string inicioRenglonAbierta = "unitario Moneda Precio Total";
        public const string inicioRenglonAbiertaVariante = "unitario Moneda";
        public const string finRenglon = "Renglón Alternativa";

        //modificacion para ordenes abiertas
        // se modifica finRenglonAbierta "Documento de Clausulas Particulares: por 'total de la orden de compra abierta'"
        // hago enroque entre finregnlonabierta y finrenglonesabierta
        //public const string finRenglonAbierta = "Argentino";
        public const string finRenglonAbierta = "906 - Administración Nacional de Laboratorios e Institutos de Salud “Dr. Carlos Malbrán”";
        //public const string finRenglonAbierta = "Documento de Clausulas Particulares: por total de la orden de compra abierta";
        public const string finRenglones = "";
        public const string finRenglonesAbierta = "Argentino";
        public const string procedimientoNroCompleto = "Número procedimiento:";
        public const string procedimientoNroCompletoAbierta = "Número de Proceso de Compras:";
        public const string totalOrdenAbierta = "Total de la Orden de Compra Abierta:";

        //*******************PARA CÁLCULOS DE MULTA***************************//
        /*teniendo en cuenta que la fecha de finalizacion indicada en el documento no siemprees la correcta
         es que debe ser calculada realizando el cálculo a partir de la fecha de autorización sumando el 
        plazo de entrega (en el caso de días hábiles, restando los festivos*/

        //public const string 



    }
}
