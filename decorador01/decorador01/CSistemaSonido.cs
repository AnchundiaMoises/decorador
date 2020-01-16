using System;
using System.Collections.Generic;
using System.Text;

namespace decorador01
{
    class CSistemaSonido : IComponentes
    {
        //variables de referencia hasia quien decoramos
        private IComponentes decoramosA;
        public CSistemaSonido(IComponentes pComponente)
        {
            decoramosA = pComponente;
        }
        public override string ToString()
        {
            return "Radio 360yz+\r\n" + decoramosA.ToString();
        }
        //metodos de la interfaz
        public double Costo()
        {
            //calculamos el costo
            //el costo de lo que decoramos mas mi costo como componente.
            return decoramosA.Costo() + 10000;
        }
        public string Funciona()
        {
            return decoramosA.Funciona() + ",Ensendemos el radio";
        }
    }
}
