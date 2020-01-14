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
            // Configuración de cadena de responsabilidad
            IAutorizador coordinador = new Coordinador();
            IAutorizador gerente = new Gerente();
            IAutorizador subdirector = new Subdirector();
            IAutorizador director = new Director();

            coordinador
                .SiguientePosibleAutorizador(gerente)
                .SiguientePosibleAutorizador(subdirector)
                .SiguientePosibleAutorizador(director);

            decimal v;
            Console.WriteLine("Ingresar monto:");
            string s = Console.ReadLine();
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
