using System;
using IO;

/*
42. Crear el código necesario para lanzar una excepción DivideByZeroException en un método estático,
capturarla en un constructor de instancia y relanzarla hacia otro constructor de instancia que creará
una excepción propia llamada UnaException(utilizar innerException para almacenar la excepción
original) y volver a lanzarla.Luego pasará por un método de instancia que generará una excepción
propia llamada MiException.MiException será capturada en el Main, mostrando el mensaje de
error que esta almacena y los mensajes de todas las excepciones almacenadas en sus
innerException
*/

namespace Ejercicio_54
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Ejercicio 54";
            string ruta = "";

            try
            {
                MiClase3 obj = new MiClase3();
                obj.MetodoDeInstancia();
            }
            catch (Exception e)
            {
                ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + DateTime.Now.ToString("yyyyMMdd-hhmm") + ".txt";
                ArchivoTexto.Guardar(ruta, e.Message);
            }
            Console.WriteLine(ArchivoTexto.Leer(ruta));
            Console.ReadKey();
        }
        public static void MiMetodo()
        {
            throw new DivideByZeroException();
        }
    }
}
