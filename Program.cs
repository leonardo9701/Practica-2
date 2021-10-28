using System;

namespace Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saludos binger!");
            Console.WriteLine("¿Cansado?");
            Console.WriteLine("Es momento de evaluar esa nueva serie que seguro terminaste en una sentada, comencemos con lo basico");
            Console.WriteLine("¿Cual es el nombre se esa serie o programa de tv?");
            string nombre = Console.ReadLine();
            Console.WriteLine("¿Te resulto gracioso?");
            string gracioso = "";
            while (true)
            {
                gracioso = Console.ReadLine();
                if (gracioso != "y" && gracioso != "n")
                {
                    Console.WriteLine("Vamos, quiero una respuesta corta solo 'y', en casi de si y 'n' en caso de no");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("¿Te resulto interesante?");
            string interesante = "";
            while (true)
            {
                interesante = Console.ReadLine();
                if (interesante != "y" && interesante != "n")
                {
                    Console.WriteLine("Vamos, quiero una respuesta corta solo 'y', en casi de si y 'n' en caso de no");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Ahora seamos un poco mas especificos");
            Console.WriteLine("¿La narrativa general de los sucesos parecio completa?(y/n)");
            string narrativa = "";
            while (true)
            {
                narrativa = Console.ReadLine();
                if (narrativa != "y" && narrativa != "n")
                {
                    Console.WriteLine("Vamos, quiero una respuesta corta solo 'y', en casi de si y 'n' en caso de no");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("¿La descripcion general de la historia parecio completa?(y/n)");
            string descripcion = "";
            while (true)
            {
                descripcion = Console.ReadLine();
                if (descripcion != "y" && descripcion != "n")
                {
                    Console.WriteLine("Vamos, quiero una respuesta corta solo 'y', en casi de si y 'n' en caso de no");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("¿Los argumentos de la historia parecieron validos?(y/n)");
            string argumentos = "";
            while (true)
            {
                argumentos = Console.ReadLine();
                if (argumentos != "y" && argumentos != "n")
                {
                    Console.WriteLine("Vamos, quiero una respuesta corta solo 'y', en casi de si y 'n' en caso de no");
                }
                else
                {
                    break;
                }
            }

            if (gracioso == "y")
            {
                if (interesante == "y")
                {
                    Console.WriteLine(nombre + " sera un exitazo, asi, sin mas");
                    Environment.Exit(0);
                }
                else
                {
                    if (narrativa == "y")
                    {
                        if (descripcion == "y")
                        {
                            if (argumentos == "y")
                            {
                                Console.WriteLine(nombre +" es buena pero tal vez no sea para todos");
                                Environment.Exit(0);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(nombre + " ni le busques, es mala");
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                if (interesante == "y")
                {
                    if (narrativa == "y")
                    {
                        if (descripcion == "y")
                        {
                            if (argumentos == "y")
                            {
                                Console.WriteLine(nombre + " es buena pero tal vez no sea para todos");
                                Environment.Exit(0);
                            }
                        }
                    }
                }
            }
        }
    }
}
