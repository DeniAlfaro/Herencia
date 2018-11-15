using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    public class Kanguro : AnimalTerrestre
    {
        public Kanguro()
        {
            Nombre = "Kanguro";
        }
        public void SaltarBienAlto()
        {
            Console.WriteLine("Hola soy un " + Nombre + " y estoy saltando alto");
        }
    }
}
