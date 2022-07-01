using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inyecciondependencia
{
    public class Cantinero
    {
        //PiñaColada bebida;
        IBebida bebida;
        public Cantinero(IBebida _bebida)
        {
            //this.bebida = new PiñaColada();
            this.bebida = _bebida;
        }
        public void Preparar()
        {
            this.bebida.Preparar();
        }
    }
}
