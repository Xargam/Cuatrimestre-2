﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_43;

namespace Ejercicio_43
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Ejercicio 43";
			MotoCross m1 = new MotoCross(4, "hola", 5);
			MotoCross m2 = new MotoCross(4, "hola", 5);
			MotoCross m3 = new MotoCross(5, "hola2", 100);
			MotoCross m4 = new MotoCross(6, "hola3", 20);
			MotoCross m5 = new MotoCross(7, "hola4", 21);
			AutoF1 f1 = new AutoF1(10, "jeje");
			AutoF1 f2 = new AutoF1(11, "jeje");
			AutoF1 f3 = new AutoF1(12, "jeje");
			AutoF1 f4 = new AutoF1(13, "jeje");
			Competencia c1 = new Competencia(10, 3, Competencia.TipoCompetencia.MotoCross);
			try
			{
				if ( c1 + m1 )
					;

				if ( c1 + m2 )
					;

				if ( c1 + m3 )
					;

				if ( c1 + m4 )
					;

				if ( c1 + m5 )
					;

				if ( c1 + f1 )
					;
				if ( c1 + f2 )
					;

				if ( c1 + f3 )
					;

				if ( c1 + f4 )
					;
			}
			catch ( CompetenciaNoDisponibleException e)
			{
				CompetenciaNoDisponibleException ee = new CompetenciaNoDisponibleException("Hotel trivago","Clase.com","Metodo.com", e);
				//Console.WriteLine(e.NombreClase + '\n' + e.NombreMetodo + "\n\n");
				Console.WriteLine(ee.ToString());
			}
				

			Console.WriteLine(c1.MostrarDatos());
			Console.WriteLine(m1.MostrarDatos());
			Console.WriteLine(f2.MostrarDatos());
			Console.WriteLine(((VehiculoDeCarrera)f2).MostrarDatos());
			Console.ReadLine();
		}
	}
}
