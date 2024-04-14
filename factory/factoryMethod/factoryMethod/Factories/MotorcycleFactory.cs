using factoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethod.Factories
{
    /// Clase que representa una fábrica de motocicletas.
    /// Extiende la clase base VehicleFactory.
    public class MotorcycleFactory:VehicleFactory
    {
        /// Crea una instancia de motocicletas.
        /// <returns>Una motocicleta.</returns>
        public override IVehicle CreateVehicle()
        {
            return new Motocircly();
        }
    }
}
