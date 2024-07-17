using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pdf2Text
{
    public class OrdenCompra
    {
        public int nroOC;                  //17333
        public DateTime fecha;             //11/6/2017
        public string procedimientoTipo;   //CONTRATACION DIRECTA
        public int procedimientoNumero;    //152
        public int procedimientoAnio;      //2016
        public int proveedorCodigo;        //320736
        public string proveedorDescricion; //PRODMOBI S. A.
        public string expedienteNro;       //1 - 2070 / 2016
        public List<LineaOC> lineas;
        public decimal importeTotal;       // 217204.00
        public decimal importeBonificado;  // 0.00
        public decimal importeNeto;        // 217204.00
        public string subProgramaOC;       //0

        public OrdenCompra()
        {
            lineas = new List<LineaOC>();
        }
    }
}
