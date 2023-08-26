using System;

//Escribir un programa que convierta un valor
//dado en grados Fahrenheit a grados Celsius

Console.WriteLine("valor en Fahrenheit");
double valor1= double.Parse(Console.ReadLine());

double celsius = (valor1 - 32) * 5 / 9;

Console.WriteLine(valor1 + " Fahrenheit equivalen a "+celsius+" grados celsius");