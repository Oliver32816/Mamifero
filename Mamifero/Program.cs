﻿// See https://aka.ms/new-console-template for more information

//Variables 
using Herencia;
int litrosleche;
string nombre;
double peso;
int nBigotes; 

//Ingresar y mostrar clase gato
Console.WriteLine("------Clase gato------");
Console.Write("Ingresa el nombre del gato: ");
nombre = Console.ReadLine();

Console.Write("Ingresa el peso: "); 
peso = double.Parse(Console.ReadLine());

Console.Write("Ingresa el numero de bigotes: ");
nBigotes = int.Parse(Console.ReadLine());

//Instancia de los objetos 
//Gato 
Gato gato1 = new Gato(nombre, peso, nBigotes);

Console.WriteLine(); 
gato1.mostrarGato();

//Cambiando el nombre al gato
gato1.setNombre("Lucifer");
nombre = gato1.getNombre();
Console.WriteLine("\n---Le cambie el nombre al gato----\n");
gato1.mostrarGato(); 


//Mostrar clase vaca 
Console.WriteLine("\n------Clase Vaca-------\n");

Console.Write("Ingresa el nombre de la vaca: ");
nombre = Console.ReadLine();

Console.Write("Ingresa el peso: ");
peso = double.Parse(Console.ReadLine());

Console.Write("Ingresa los litros de leche: ");
litrosleche = int.Parse(Console.ReadLine());

Vaca vaca = new Vaca(nombre, peso, litrosleche);

Console.WriteLine();
vaca.mostrarVaca();
vaca.Comida();


Console.WriteLine("\n---------Clase Ballena--------\n");
//Mostrar clase ballena
Console.Write("Ingresa el nombre de la ballena: ");
nombre = Console.ReadLine();

Console.Write("Ingresa el peso: ");
peso = double.Parse(Console.ReadLine());


Ballena ballena = new Ballena(nombre, peso);
Console.WriteLine();
ballena.mostrarballena();