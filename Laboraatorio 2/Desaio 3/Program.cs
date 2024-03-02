using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Dasafio_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese el primer valor:");
                string valor1 = Console.ReadLine();

                Console.WriteLine("Ingrese el segundo valor:");
                string valor2 = Console.ReadLine();

                int num1 = int.Parse(valor1);
                int num2 = int.Parse(valor2);

                int suma = num1 + num2;

                Console.WriteLine("La suma es: " + suma);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error al convertir los valores a números: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al sumar los valores: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Proceso finalizado");
            }
        }
    }
}
