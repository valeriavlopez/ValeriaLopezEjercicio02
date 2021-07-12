using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValeriaLopezEjercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
			//	Definir LadoA, LadoB, LadoC como real;
			Double LadoA, LadoB, LadoC;
			//	Escribir "Ingresar los lados del Triangulo";
			Console.WriteLine("Ingresar los lados del Triangulo");
			//	Escribir "Ingrese Lado A: ";
			Console.Write("Ingresar Lado A: ");
			LadoA = Convert.ToDouble(Console.ReadLine());
			Console.Write("Ingresar Lado B: ");
			LadoB = Convert.ToDouble(Console.ReadLine());
			Console.Write("Ingresar Lado C: ");
			LadoC = Convert.ToDouble(Console.ReadLine());
            //	si(LadoA + LadoB) > LadoC y(LadoB + LadoC) > LadoA y(LadoA + LadoC) > LadoB Entonces
            if ((LadoA + LadoB) > LadoC && (LadoB + LadoC) > LadoA && (LadoA + LadoC) > LadoB)
            {
                if (LadoA == LadoB && LadoB == LadoC)
                {
					Console.WriteLine("El Triangulo es Equilatero");
                }
				if (LadoA == LadoB && LadoB != LadoC) || (LadoA != LadoB && LadoB == LadoC);
                {
					Console.WriteLine("El Triangulo es Isoceles");
                }
                if (LadoA != LadoB && LadoB != LadoC && LadoC != LadoA)
                {

					Console.WriteLine("El Triangulo es Escaleno");
                }
            }
			else
            {
				Console.WriteLine("Las medidas ingresadas no conforman un triangulo");
            }

			//				 Si LadoA = LadoB y LadoB = LadoC Entonces
			//					 Escribir "El Triangulo es Equilatero";
			//	FinSi
			//Si(LadoA = LadoB y LadoB <> LadoC) o(LadoA <> LadoB y LadoB = LadoC)Entonces
			//		  Escribir "El Triangulo es Isoceles";
			//	FinSi
			//	Si LadoA<> LadoB y LadoB<> LadoC y LadoC<> LadoA Entonces
			//		 Escribir "El Triangulo es Escaleno";
			//	FinSi
			//SiNo
			//Escribir "Las medidas ingresadas no conforman un triangulo";

			//	FinSi

		}
    }
}
