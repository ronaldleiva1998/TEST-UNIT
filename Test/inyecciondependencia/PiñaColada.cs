using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inyecciondependencia
{
    public class PiñaColada: IBebida
    {
        public void Preparar()
        {
            Console.WriteLine("se hace una piña colada");
        }
    }
}
