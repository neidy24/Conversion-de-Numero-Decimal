using System;


namespace Conversion_de_Decimal
{
    class Program
    {

        // Neidy Franchesca del Orbe
        // Matrícula 17-minutos-1-045
        // Sección 0463

        static void Main(string[] args) 
        {

            int seleccion, numero, binario, octal, hexadecimal;
            int x;

            Console.Clear();
            Console.Title = "CONVERSION DE NUMEROS DECIMALES";
            do
            {
                Console.Write("Neidy Franchesca del Orbe\t");
                Console.Write("Matrícula 17-minutos-1-045 \t");
                Console.Write("Sección 0463\t\n\n");
                Console.WriteLine("----------------------");
                do
                {
                    
                    Console.WriteLine("Introducir Numero decimal:  ");

                    while (!Int32.TryParse(Console.ReadLine(), out numero))
                    {
                        Console.WriteLine("Opcion Invalida, Intentelo de Nuevo ");
                        /* Si es el valor introducido es correcto saldra del ciclo */
                    }
                    Console.Clear();
                    Console.WriteLine("SELECCIONE EL TIPO DE CONVERSION\n");
                    Console.WriteLine("1-Binario");
                    Console.WriteLine("2-Octal");
                    Console.WriteLine("3-Hexadecimal");
                    Console.WriteLine("4-Salir\n\n");
                    //métodos son acciones, las propiedades son valores
                    Console.WriteLine("Seleccione:  ");
                    Console.WriteLine("-------------");

                    while (!Int32.TryParse(Console.ReadLine(), out seleccion))
                    {
                        Console.WriteLine("Opcion Invalida, Intentelo de Nuevo ");
                        /* Si es el valor introducido es correcto saldra del ciclo */
                    }


                    if (seleccion > 4)
                    {
                        Console.WriteLine("Opcion Invalida, Intentelo de Nuevo");

                    }
                    else
                    {

                        switch (seleccion)
                        {
                            case 1:
                                Console.Clear();
                                String resultado = String.Empty;
                                binario = numero;
                                while (binario > 0)
                                {
                                    int resto = binario % 2;
                                    binario = binario / 2;
                                    resultado = resto.ToString() + resultado;
                                }
                                Console.WriteLine("Resultado de la Conversion");
                                Console.WriteLine("El numero " + numero + " Convertido a Binario es Igual: ");
                                Console.WriteLine(resultado);
                                break;

                            case 2:
                                Console.Clear();
                                resultado = String.Empty;
                                octal = numero;
                                while (octal > 0)
                                {
                                    int resto = octal % 8;
                                    octal = octal / 8;
                                    resultado = resto.ToString() + resultado;
                                }
                                Console.WriteLine("El numero " + numero + " Convertido a Octal es Igual: ");
                                Console.WriteLine(resultado);
                                break;

                            case 3:
                                Console.Clear();
                                resultado = String.Empty;
                                hexadecimal = numero;
                                //  if ((hexadecimal < 10) && (hexadecimal > 15)) 
                                switch (hexadecimal)
                                {
                                    case 10:
                                        Console.WriteLine("Resultado:");
                                        Console.WriteLine("A\n\n");
                                        break;
                                    case 11:
                 
                                        Console.WriteLine("Resultado:");
                                        Console.WriteLine("B\n\n");
                                        break;
                                    case 12:
                                        Console.WriteLine("Resultado:");
                                        Console.WriteLine("C\n\n");
                                        break;
                                    case 13:
                                        Console.WriteLine("Resultado:");
                                        Console.WriteLine("D\n\n");
                                        break;
                                    case 14:
                                        Console.WriteLine("Resultado:");
                                        Console.WriteLine("E\n\n");
                                        break;
                                    case 15:
                                        Console.WriteLine("Resultado:");
                                        Console.WriteLine("F\n\n");
                                        break;
                                }
                                while (hexadecimal > 0)
                                {
                                    int resto = hexadecimal % 16;
                                    hexadecimal = hexadecimal / 16;
                                    resultado = resto.ToString() + resultado;
                                }

                                Console.WriteLine("El numero " + numero + " Convertido a Hexadecimal es Igual: ");
                                Console.WriteLine(resultado);

                                break;

                        }
                    }

                } while (seleccion == 1 || seleccion == 2 || seleccion == 3);
                Console.WriteLine("Realmente desea Salir de la Aplicacion");
                Console.Write("[1]SI\t");
                Console.Write("[2]NO\t");
      
                while (!Int32.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Opcion Invalida, Intentelo de Nuevo ");
                    /* Si es el valor introducido es correcto saldra del ciclo */
                }

                if (x == 1)
                {
                    Environment.Exit(0);
                }
                Console.Clear();
            } while (x == 2);
        }
    }
}
