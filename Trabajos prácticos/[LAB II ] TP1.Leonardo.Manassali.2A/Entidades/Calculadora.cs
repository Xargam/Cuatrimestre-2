﻿using System;

namespace Entidades
{
	public class Calculadora
	{
		#region Metodos

		/// <summary>
		/// Verifica que un operador sea de alguna operación básica: (* / + - ) Devuelve "true" en caso de que sea correcto.
		/// </summary>
		/// <param name="operador">Varible en formato string con operador a validar.</param>
		/// <returns></returns>
		private static string ValidarOperador(string operador)
		{
			string verificacion = "true";
			if (operador != "*" && operador != "+" && operador != "-" && operador != "/")
			{
				verificacion = "+";
			}
			return verificacion;
		}

		/// <summary>
		/// Realiza una de las cuatro operaciones básicas entre dos instancias de Numero.
		/// </summary>
		/// <param name="num1">Operando uno.<param>
		/// <param name="num2">Operando dos.</param>
		/// <param name="operador">Establece la operación a realizar: "+" , "-" , "*" , "/" </param>
		/// <returns></returns>
		public static double Operar(Numero num1, Numero num2, string operador)
		{
			double resultado = 0;
			switch (operador)
			{
				case "+":
					resultado = num1 + num2;
					break;
				case "-":
					resultado = num1 - num2;
					break;
				case "*":
					resultado = num1 * num2;
					break;
				case "/":
					resultado = num1 / num2;
					resultado = (Double.IsNaN(resultado) || Double.IsInfinity(resultado)) ? Double.MinValue : resultado;
					break;
			}
			return resultado;
		}

		#endregion
	}
}
