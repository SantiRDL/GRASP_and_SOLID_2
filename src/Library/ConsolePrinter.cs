using System;
namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// La clase se encarga de tomar el string con el contenido de la receta e imprimirlo en la consola.
    /// </summary>
    public class ConsolePrinter
    {
        public static void Imprimir(String receta)
        {
            Console.Write(receta);
        }
    }
}