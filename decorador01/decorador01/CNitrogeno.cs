using System;
using System.Collections.Generic;
using System.Text;

namespace decorador01
{
    class CNitrogeno : IComponentes
    {
        //variable de referencia hacia decoramos
        private IComponentes decoramosA;

        public CNitrogeno(IComponentes pComponentes)
        {
            decoramosA = pComponentes;

        }
        public override string ToString()
        {
            return "Sistema de nitrogeno \r\n" + decoramosA.ToString();
        }
        //metodo de interfas
        public double Costo()
        {
            //Calcilamos el costo
            //el costo de lo que decoramos mas mi costo como componentes
            return decoramosA.Costo() + 10000;
        }
        public string Funciona()
        {
            return decoramosA.Funciona() + ",Nitrogeno losto";
        }
        public void UsaN()
        {
            Console.WriteLine("Nitrogeno en uso");
        }
    }
}
