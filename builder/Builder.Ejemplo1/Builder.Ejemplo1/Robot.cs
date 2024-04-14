using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Ejemplo1
{
    /// Representa un objeto Robot con diferentes partes, como cabeza, cuerpo, brazos y piernas.
    public class Robot
    {
        /// Obtiene o establece la cabeza del robot.
        public string Head { get; set; }
        /// Obtiene o establece el cuerpo del robot
        public string Body { get; set; }
        /// Obtiene o establece los brazos del robot.
        public string Arms { get; set; }
        /// Obtiene o establece las piernas del robot.
        public string Legs { get; set; }
        /// Muestra la información del robot, incluyendo cabeza, cuerpo y piernas.
        public void DisplayRobotInfo()
        {
            Console.WriteLine("Robot Info:");
            Console.WriteLine($"Head: {Head}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"Legs: {Legs}");
        }
    }
}

