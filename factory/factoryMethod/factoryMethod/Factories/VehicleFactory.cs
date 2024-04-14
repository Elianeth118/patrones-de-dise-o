using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethod.Factories
{
    /// Clase abstracta que sirve como base para las fábricas de vehículos.
    /// Define un método abstracto para la creación de vehículos y un método concreto para ordenar un vehículo.
    public abstract class VehicleFactory
    {
        /// Método abstracto para crear un vehículo.
        /// <returns>El vehículo creado.</returns>
        public abstract IVehicle CreateVehicle();
        /// Ordena un vehículo.
        /// <returns>El vehículo ordenado.</returns>
        public IVehicle OrderVehicle()
        {
            // Crea un vehículo utilizando el método abstracto CreateVehicle().
            IVehicle vehicle = CreateVehicle();

            // Inicia, conduce y detiene el vehículo.
            vehicle.Start();
            vehicle.Drive();
            vehicle.Stop();

            // Devuelve el vehículo ordenado.
            return vehicle;
        }
    }
}

