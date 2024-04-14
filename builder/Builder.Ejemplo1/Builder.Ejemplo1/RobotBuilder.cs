using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Ejemplo1
{
    /// Clase que implementa la interfaz IRobotBuilder para construir un objeto Robot paso a paso.
    public class RobotBuilder : IRobotBuilder
    {
        private Robot _robot = new Robot();
        /// Construye los brazos del robot.
        /// <param name="arms">Brazos del robot.</param>
        public void BuildArms(string arms)
        {
            _robot.Arms = arms;
        }
        /// Construye el cuerpo del robot.
        /// <param name="body">Cuerpo del robot.</param>
        public void BuildBody(string body)
        {
            _robot.Body = body;
        }
        /// Construye la cabeza del robot.
        /// <param name="head">Cabeza del robot.</param>
        public void BuildHead(string head)
        {
            _robot.Head = head;
        }
        /// Construye las piernas del robot.
        /// <param name="legs">Piernas del robot.</param>
        public void BuildLegs(string legs)
        {
            _robot.Legs = legs;
        }
        /// Obtiene el robot construido.
        /// <returns>Objeto Robot construido.</returns>
        public Robot GetRobot()
        {
            return _robot;
        }
    }
}
