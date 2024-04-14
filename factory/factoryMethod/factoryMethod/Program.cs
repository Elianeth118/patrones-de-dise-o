// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using factoryMethod;
using factoryMethod.Factories;

Console.WriteLine("Bienvenido al Coder Cave Factory Method Example");
// Se inicializa la variable vehiclFactory como nula para ser asignada más adelante.
VehicleFactory vehicleFactory = null;

while (true)
{
    Console.WriteLine("\nPor favor, indica el tipo de vehículo: 1) Carro, 2) Motocicleta, 3) Bicicleta, 4) Salir");
    // Se lee la opción de notificacion proporcionada por el usuario.
    int vehicleChoice = Convert.ToInt32(Console.ReadLine());

    switch (vehicleChoice)
    {
        case 1:
            // Si la opción es 1, se crea una instancia de CarFactory y se asigna a vehicleFactory.
            vehicleFactory = new CarFactory();
            break;
        case 2:
            // Si la opción es 2, se crea una instancia de MotorcycleFactory y se asigna a vehicleFactory.
            vehicleFactory = new MotorcycleFactory();
            break;
        case 3:
            // Si la opción es 3, se crea una instancia de BikeFactory y se asigna a vehicleFactory.
            vehicleFactory = new BikeFactory();
            break;
        case 4:
            // Si la opción es 4, se sale del bucle while.
            Console.WriteLine("Gracias por usar el sistema");
            return;
        default:
            Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
            continue;
    }

    // Se ordena un vehículo utilizando la fábrica correspondiente.
    IVehicle vehicle = vehicleFactory.OrderVehicle();
    Console.WriteLine($"Usarás un {vehicle.GetType().Name}.\n");
}
       
    
