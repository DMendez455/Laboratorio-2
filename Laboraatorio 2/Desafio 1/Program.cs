using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Ingresos
{
    public static void SumarIngresos()
    {
        Console.Write("Ingrese su nombre: ");
        string nombreUsuario = Console.ReadLine();

        double[] ingresosMeses = new double[3];

        for (int i = 0; i < ingresosMeses.Length; i++)
        {
            Console.Write($"Introduzca sus ingresos del mes {i + 1}: ");
            ingresosMeses[i] = double.Parse(Console.ReadLine());
        }

        double sumaIngresos = 0;
        foreach (double ingreso in ingresosMeses)
        {
            sumaIngresos += ingreso;
        }

        double promedioIngresos = sumaIngresos / ingresosMeses.Length;

        Console.WriteLine($"\nHola {nombreUsuario}, en total ganaste ${sumaIngresos:F2} y tu promediaste ${promedioIngresos:F2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ingresos.SumarIngresos();
    }
}
