using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inyecciondependencia
{
    public class MedidasDeSeda:IBebida
    {
        public  string tipo { get; set; }
        public MedidasDeSeda(string tipo)
        {
            this.tipo = tipo;
        }
        public void Preparar()
        {
            Console.WriteLine("se hace una media de seda"+ tipo);
        }
    }
}
