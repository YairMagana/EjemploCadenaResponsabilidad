using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCadenaResponsabilidad
{

    class Program
    {
        static void Main(string[] args)
        {

            var coordinador = new Coordinador();
            var gerente = new Gerente();
            var subdirector = new Subdirector();
            var director = new Director();

            coordinador
                .SiguientePosibleAutorizador(gerente)
                .SiguientePosibleAutorizador(subdirector)
                .SiguientePosibleAutorizador(director);


            string s = Console.ReadLine();
            decimal v;
            Console.WriteLine("Ingresar monto:");
            if (decimal.TryParse(s, out v))
            {
                string r = coordinador.DecidirAprobacion(v);
                if (string.IsNullOrEmpty(r))
                    r = $"Compra de Aires Acondicionados \"DENEGADA\"";

                Console.WriteLine(r);
            }
            else
                Console.WriteLine("Valor incorrecto");

            Console.ReadLine();
        }
    }
}
