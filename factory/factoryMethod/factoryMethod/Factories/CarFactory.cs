using factoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethod.Factories
{
    /// Clase que representa una fábrica de carros.
    /// Extiende la clase base VehicleFactory.
    public class CarFactory:VehicleFactory
    {
        /// Crea una instancia de carros.
        /// <returns>Un Carro.</returns>
        public override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
