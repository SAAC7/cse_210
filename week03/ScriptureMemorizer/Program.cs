using System;
using System.Collections.Generic; // Agregado
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
         // Ejemplo de creación de una referencia y pasaje.
         Reference reference = new Reference("John", 3, 16);
         string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

         Scripture scripture = new Scripture(reference, text);

         while (true)
         {
             Console.Clear();
             Console.WriteLine(scripture.Display());
             Console.WriteLine();
             Console.WriteLine("Press ENTER to continue or 'quit' to finish.");
             string input = Console.ReadLine();
             if (input.Trim().ToLower() == "quit")
                 break;
             scripture.HideWords();
             if (scripture.IsCompletelyHidden())
             {
                 Console.Clear();
                 Console.WriteLine(scripture.Display());
                 Console.WriteLine("\n¡Todas las palabras han sido ocultas! Fin del programa.");
                 break;
             }
         }
    }
}