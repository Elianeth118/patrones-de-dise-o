using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethod.Products
{
    /// Clase que representa una motocicleta.
    /// Implementa la interfaz IVehicle.
    public class Motocircly:IVehicle
    {
        /// Hace que la motocicleta se ponga en movimiento.
        public void Drive()
        {
            Console.WriteLine("Andando en motocicleta");
        }
        /// Inicia  la motocicleta
        public void Start()
        {
            Console.WriteLine("Iniciando mostocicleta");
        }
        /// Detiene la motocicleta 
        public void Stop()
        {
            Console.WriteLine("Detener la motocicleta");
        }
    }
}
