using System;

namespace fiobonacci_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroAnterior = -1;
            int proximoNumero = 1;
            int resultado;

            for (var i = 0; i < 15; i++)
            {
                resultado = numeroAnterior + proximoNumero;
                numeroAnterior = proximoNumero;
                proximoNumero = resultado;

                Console.WriteLine( ",  ");
            }
        }
    }
}
