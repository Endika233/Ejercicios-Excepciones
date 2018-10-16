using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = 5 / Convert.ToInt32(Console.ReadLine());

            }
            //catch (DivideByZeroException ex)//ex es como declarar una variable con el mensaje por defecto
            //{
            //    Console.WriteLine("Has dividido entre cero");
            //    Console.WriteLine(ex.ToString());//Te escribe el mensaje "por defecto"
            //    Console.ReadLine();
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Has introducido una letra en vez de un num");
            //    Console.WriteLine(ex.ToString());
            //    Console.Read();
            //}
            catch (Exception ex)//este para cualquier error
            {
                Console.WriteLine("Oooops");
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
            Console.WriteLine("Seguimos?");
            Console.ReadKey();//si que sigue
            //thow new exception("el mensaje que quieras")////para personalizar el mensaje que te sale en el visual con el error

        }
    }
}
