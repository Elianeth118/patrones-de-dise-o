// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Singleton.ThreadSafe;

// Crear una instancia de la clase ThreadSafeSingleton utilizando el método GetInstance
ThreadSafeSingleton tss = ThreadSafeSingleton.GetInstance();

// Imprimir la referencia de la instancia en la consola
Console.WriteLine($"{tss}");