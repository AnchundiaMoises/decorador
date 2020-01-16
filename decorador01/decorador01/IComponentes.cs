using System;
using System.Collections.Generic;
using System.Text;

namespace decorador01
{
    interface IComponentes
    {
        //usaremos esta interfas para la decoracion "diseño"
        double Costo();
        string Funciona();
    }
}
