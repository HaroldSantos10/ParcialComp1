using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCrearAdmin
{
    public class crearAdmin
    {

        public static bool inicio()
        {//creación del Admin

            bool iniciar = false;
            string user, password;

            user = "Admin";
            password = "123";


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("**********************************************************************************");
                Console.WriteLine("*                             BIENVENIDO AL SISTEMA                              *");
                Console.WriteLine("**********************************************************************************");


                Console.Write("Usuario: ");
                string usuario = Console.ReadLine();

                Console.Write("Contraseña: ");
                string contraseña = Console.ReadLine();

                if ((usuario == user) & (contraseña == password))
                {
                    Console.Clear();
                    iniciar = true;
                    break;

                }
                else
                {
                    Console.WriteLine($"Usuario o contraseña incorrectos, intento #{i + 1}");

                    Console.ReadKey();
                    Console.Clear();

                    if (i == 2)
                    {
                        Console.WriteLine("Se cerrará el programa");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }

                }

            }

            return iniciar;

        }

    }
}
