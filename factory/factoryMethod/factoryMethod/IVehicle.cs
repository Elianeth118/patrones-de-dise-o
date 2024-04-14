using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethod
{
    /// Interfaz que define el comportamiento básico de un vehículo.
    public interface IVehicle
    {
        /// Inicia el vehículo.
        void Start();
        /// Detiene el vehículo.
        void Stop();
        /// Hace que el vehículo se ponga en movimiento.
        void Drive();
    }
}