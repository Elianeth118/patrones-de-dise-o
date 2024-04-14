// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Builder.Ejemplo1;
using Builder.Ejemplo1.Builder.Ejemplo1;

// Creación de un objeto RobotBuilder que implementa la interfaz IRobotBuilder.
IRobotBuilder robotBuilder = new RobotBuilder();

// Creación de un objeto RobotDirector, pasando el RobotBuilder al constructor.
RobotDirector robotDirector = new RobotDirector(robotBuilder);

// Inicio del proceso de construcción del robot según las especificaciones del director.
robotDirector.ConstructorRobot();

// Obtención del robot construido utilizando el método GetRobot() de RobotBuilder.
Robot robot = robotBuilder.GetRobot();

// Mostrar la información del robot utilizando el método DisplayRobotInfo().
robot.DisplayRobotInfo();
