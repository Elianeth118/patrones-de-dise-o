using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethod.Products
{
    /// Clase que representa un carro.
    /// Implementa la interfaz IVehicle.
    public class Car:IVehicle
    {
        /// Hace que el carro se ponga en movimiento.
        public void Drive()
        {
            Console.WriteLine("Andando en auto");
        }
        /// Inicia el carro
        public void Start()
        {
            Console.WriteLine("Iniciando auto");
        }
        /// Detiene el carro
        public void Stop()
        {
            Console.WriteLine("Detener el auto");
        }
    }
}
