using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pdf2Text
{
    public class OrdenCompra
    {
        public int nroOC { get; set; }
        // public int nroOC;                  //17333
        public DateTime fecha { get; set; }             //11/6/2017
        public string procedimientoTipo { get; set; }   //CONTRATACION DIRECTA
        public string procedimientoNro { get; set; } //NUMERO SLU DE LA ORDEN 68-0333-OC17
        public int procedimientoNumero { get; set; }    //152
        public int procedimientoAnio { get; set; }      //2016
        public string clase { get; set; }      //nuevo atributo Objeto del proceso

        //datos proveedor
        public string CUIT { get; set; }                 //30-57086127-8
        public int proveedorCodigo { get; set; }
        public string proveedorDescricion { get; set; } //PRODMOBI S. A.
        public string Domicilio { get; set; }
        public string CodPostal { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        //datos del instituto requirente
        public int Subprograma { get; set; }
        public int DestCod { get; set; }



        public string expedienteNro { get; set; }       //1 - 2070 / 2016
        public List<LineaOC> lineas { get; set; }
        
        public decimal importeTotal { get; set; }       // 217204.00
        
        public decimal importeBonificado { get; set; }  // 0.00
        
        public decimal importeNeto { get; set; }        // 217204.00
                                                        //[Required]
                                                        //[DisplayName("Subprograma")]
                                                        //public int SubProgramaCodigo { get; set; }       //0
                                                        //[DisplayName("Destinatario")]
                                                        //public int DestCodigo { get; set; }
        /// <summary>
        /************************03/03/2021 **************************/
        
        public DateTime fechaInicio { get; set; } //fecha de inicio del documento contractual
        public string Plazo { get; set; } //cantidad de dias para cumplimentar la orden de compra
        
        public DateTime vencimiento { get; set; }

        //public string Utiempo;//Unidad de tiempo dias meses años, etc
        //public string  tipoDias; //para determinar el conteo de dias habiles o corridos

        //public DateTime fechaVto; //campo calculado fechainicio+plazo
        public string Operador { get; set; }
        public OrdenCompra()
        {
            lineas = new List<LineaOC>();
        }
    }
}
