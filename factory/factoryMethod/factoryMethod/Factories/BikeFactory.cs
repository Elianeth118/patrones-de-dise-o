using factoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace factoryMethod.Factories
{
    /// Clase que representa una fábrica de bicicletas.
    /// Extiende la clase base VehicleFactory.
    public class BikeFactory : VehicleFactory
    {
        /// Crea una instancia de bicicleta.
        /// <returns>Una bicicleta.</returns>
        public override IVehicle CreateVehicle()
        {
            return new Bike();
        }
    }
}
