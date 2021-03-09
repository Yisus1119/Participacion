using System;

namespace EjerciciodeHoy
{
    class Program
    {
        struct datos
        {
            public string cliente1;
            public string cliente2;
            public string cliente3;
            static void Main(string[] args)
            {
                int seleccion;
                int[] depositar = new int[3];
                int[] retirar = { 20000 };
                int rsFinal=0;

                datos NombreClientes;

                NombreClientes.cliente1 = "Juan";
                NombreClientes.cliente2 = "Pedro";
                NombreClientes.cliente3 = "Lola";
                int retirar1 = 0;
                int retirar2 = 0;
                int retirar3 = 0;


                Console.WriteLine("Ingrese su nombre: ");
                string client = Console.ReadLine();

                //procedimiento para el cliente 1
                if (client == NombreClientes.cliente1)
                {
                    Console.WriteLine("Bienvenido al banco FDP Juan");
                    do
                    {
                        Console.WriteLine("Seleccione que tipo de operación quiere realizar: ");
                        Console.WriteLine("1. Deposito");
                        Console.WriteLine("2. Retiro");
                        Console.WriteLine("3. Mostrar cuanto se deposito/retiro");
                        Console.WriteLine("4. salir");
                        Console.WriteLine("Seleccione una opcion (1-4)");
                        seleccion = Convert.ToInt32(Console.ReadLine());


                        switch (seleccion)
                        {
                            case 1:
                                Console.WriteLine("cuanto quiere depositar: ");
                                depositar[0] = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2:
                                Console.WriteLine("Cuanto desea retirar: ");
                                retirar1 = Convert.ToInt32(Console.ReadLine());

                                break;

                            case 3:
                                Console.WriteLine("el total depositado es: " + depositar[0]);
                                Console.WriteLine("El total retirado es: " + retirar1);

                                break;

                            


                        }

                    } while (seleccion != 4);
                        
                }
                else
                {

                }

                //procedimiento para el cliente 2
                if (client == NombreClientes.cliente2)
                {
                    Console.WriteLine("Bienvenido al banco FDP Pedro");
                    do
                    {
                        Console.WriteLine("Seleccione que tipo de operación quiere realizar: ");
                        Console.WriteLine("1. Deposito");
                        Console.WriteLine("2. Retiro");
                        Console.WriteLine("3. Mostrar cuanto se deposito/retiro");
                        Console.WriteLine("4. salir");
                        Console.WriteLine("Seleccione una opcion (1-4)");
                        seleccion = Convert.ToInt32(Console.ReadLine());

                        switch (seleccion)
                        {
                            case 1:
                                Console.WriteLine("cuanto quiere depositar: ");
                                depositar[1] = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2:
                                Console.WriteLine("Cuanto desea retirar: ");
                                retirar2 = Convert.ToInt32(Console.ReadLine());

                                break;

                            case 3:
                                Console.WriteLine("El total depositado es:" + depositar[1]);
                                Console.WriteLine("El total retirado es: " + retirar2);
                                break;

                            


                        }

                    } while (seleccion != 4);
                }
                else
                {

                }

                //procedimiento para el cliente 3
                if (client == NombreClientes.cliente3)
                {
                    Console.WriteLine("Bienvenido al banco FDP Lola");
                    do
                    {
                        Console.WriteLine("Seleccione que tipo de operación quiere realizar: ");
                        Console.WriteLine("1. Deposito");
                        Console.WriteLine("2. Retiro");
                        Console.WriteLine("3. Mostrar cuanto se deposito/retiro");
                        Console.WriteLine("4. salir");
                        Console.WriteLine("Seleccione una opcion (1-4)");
                        seleccion = Convert.ToInt32(Console.ReadLine());

                        switch (seleccion)
                        {
                            case 1:
                                Console.WriteLine("cuanto quiere depositar: ");
                                depositar[2] = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2:
                                Console.WriteLine("Cuanto desea retirar: ");
                                retirar3 = Convert.ToInt32(Console.ReadLine());
                                break;

                            case 3:
                                Console.WriteLine("El total depositado es: " + depositar[2]);
                                Console.WriteLine("El total retirado es: " + retirar3);
                                break;


                        }

                    } while (seleccion != 4);

                }
                else
                {
                    Console.WriteLine("Su nombre no esta registrado");
                }

rsFinal = depositar[0]+depositar[1]+depositar[2];
Console.WriteLine(rsFinal);

            }
        }
    }

}
