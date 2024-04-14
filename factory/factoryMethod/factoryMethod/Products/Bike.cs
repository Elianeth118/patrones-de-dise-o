using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethod.Products
{
    /// Clase que representa una bicicleta.
    /// Implementa la interfaz IVehicle.
    public class Bike : IVehicle
    {
        /// Hace que la bicicleta se ponga en movimiento.
        public void Drive()
        {
            Console.WriteLine("Andando en Bici");
        }
        /// Inicia la bicicleta.
        public void Start()
        {
            Console.WriteLine("Iniciando bici");
        }
        /// Detiene la bicicleta.
        public void Stop()
        {
            Console.WriteLine("Detener la bici");
        }
    }
}
