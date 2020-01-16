using System;
using System.Collections.Generic;
using System.Text;

namespace decorador01
{
    class CSuspension:IComponentes
    {
        //variable de referencia a quien decoramos
        private IComponentes decoramoaA;

        //pasamos el objeto  que va a ser decorado
        public CSuspension(IComponentes pComponente)
        {
            decoramoaA = pComponente;
        }
        public override string ToString()
        {
            return "Suspension de alto desempeño\r\n " + decoramoaA.ToString();

        }
        //metodos de la interfas
        public double Costo()
        {
            //calculamos el costo 
            //el costo de lo decorado  mas el costo como componenres
            return decoramoaA.Costo() + 6666;
        }
        public string Funciona()
        {
            return decoramoaA.Funciona() + ",Elevando suspencion";
        }
    }
}
