using System;
namespace inyecciondependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            IBebida oBebida = new MedidasDeSeda("picante");
            Cantinero oCantinero = new Cantinero(oBebida);
            oCantinero.Preparar();
        }
    }
}