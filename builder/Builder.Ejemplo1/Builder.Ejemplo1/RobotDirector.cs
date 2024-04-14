using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Ejemplo1
{
    namespace Builder.Ejemplo1
    {
        /// Clase interna que actúa como director en el patrón Builder para construir un robot de manera específica.
        internal class RobotDirector
        {
            private IRobotBuilder _robotBuilder;
            /// Constructor que recibe un objeto implementando la interfaz IRobotBuilder.
            /// <param name="robotBuilder">Implementación de IRobotBuilder utilizada para construir el robot.</param>
            public RobotDirector(IRobotBuilder robotBuilder)
            {
                _robotBuilder = robotBuilder;
            }
            /// Método que inicia la construcción del robot utilizando el IRobotBuilder proporcionado.
            public void ConstructorRobot()
            {
                _robotBuilder.BuildHead("Redonda");
                _robotBuilder.BuildBody("Metal");
                _robotBuilder.BuildArms("Garras");
                _robotBuilder.BuildLegs("Ruedas");
            }
        }
    }
}

