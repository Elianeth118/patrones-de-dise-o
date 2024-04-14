using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Ejemplo1
{
    /// <summary>
    /// Interfaz que define el contrato para construir un objeto Robot paso a paso.
    public interface IRobotBuilder
    {
        /// Construye la cabeza del robot.
        /// <param name="head">Cabeza del robot.</param>
        void BuildHead(string head);
        /// Construye el cuerpo del robot.
        /// <param name="body">Cuerpo del robot.</param>
        void BuildBody(string body);
        /// Construye los brazos del robot.
        /// <param name="arms">Brazos del robot.</param>
        void BuildArms(string arms);
        /// Construye las piernas del robot.
        /// <param name="legs">Piernas del robot.</param>
        void BuildLegs(string legs);
        /// Obtiene el robot construido.
        /// <returns>Objeto Robot construido.</returns>
        Robot GetRobot();
    }
}
