using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibCrearAdmin;
using System.IO;

namespace ParcialComp1_0509
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = crearAdmin.inicio();
            while (showMenu)
            {
                showMenu = MenuPrinc();
            }

        }
        public static bool MenuPrinc()
        {

            Console.Clear();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("*                         BIENVENIDO AL SISTEMA ADMIN                            *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("1. Registrar nuevo usuario ");
            Console.WriteLine("2. Generar los archivos");
            Console.WriteLine("3. Borrar archivo");
            Console.WriteLine("4. Finaliza el programa");
            Console.Write("\nOpcion: ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    //registrar nuevo usuario
                    //nuevoUsuario();
                    return true;

                case 2:
                    // generar los archivos
                    //generarArchivos();

                    return true;

                case 3:
                    //borrar archivo
                    //deleteArch();
                    return true;

                case 4:
                    //Finaliza el programa
                    Environment.Exit(0);
                    return false;

                default:

                    Console.WriteLine("Opción no válida, vuelva a intentar");
                    return true;

            }

            Console.ReadKey();
        }

        public static Dictionary<object, object> registrarUser()
        {//registrar un nuevo usuario
            string[] datUsuario = new string[2];


            Console.WriteLine("********* BIENVENIDO AL REGISTRO DE USUARIOS *********");
            Console.Write("Introduzca el usuario: ");
            string newUser = Console.ReadLine();

            Console.Write("Introduzca la contraseña: ");
            string newPassword = Console.ReadLine();

            Console.Write("Confirme la contraseña: ");
            string confirNewPass = Console.ReadLine();

            if (newPassword == confirNewPass)
            {
                datUsuario[0] = newUser;
                datUsuario[1] = newPassword;
                Console.WriteLine("Las contraseñas coinciden... guardado");
                //agrega los datos del arreglo al dictionary
                Dictionary<object, object> usuarios = new Dictionary<object, object>();
                usuarios.Add(datUsuario[0], datUsuario[1]);
                Console.ReadKey();
                return usuarios;
            }
            else
            {
                Console.WriteLine("Las contraseñas no coinciden");
                Console.ReadKey();
                return null;
            }

        }

        private static string getPath()
        {
            string path = @"C:\Users\harol\source\repos\EjerciciosPrimerComputoC#\ParcialComp1-0509\";
            return path;
        }

        public static void generarArchivos()
        {
            string path = @"C:\usuario\harol\source\repos\EjerciciosPrimerComputoC#\Program-ParcialComputo1\";

            string Harold = "A lo largo de este primer computo he aprendido muchas cosas, por ejemplo; he tenido mis primeros acercamientos con C#, uno de los lenguajes más utillizados en programación, probablemente lo que se me ha hecho un poco más difícil, es la creación de ciertos métodos para capturar el texto en los archivos txt, " +
                "pero me he comprometido ha estudiar y práticar mucho con el manejo de los archivos para poder dominar este tema, en general puedo decir que hay muchas cosas que desconozco, es muy básico lo que sé, pero la creación de herramientas tecnológicas es algo muy emocionante, manejar las versiones con git, compartir el trabajo con compañeros, " +
                "y las ventajas que nos dan todas herramientas que tenemos a nuestra disposición me motiva aún más, espero poder seguir aprendiendo muchas cosas también el próximo computo y demás ciclos, comprometiendome a estudiar tambien por mi cuenta para superar mis debilidades en ciertos temas.";

            string Meylin = "En lo personal los aprendizajes que adquirí fueron varios ya que aprendí a crear la biblioteca de clases, el diccionario de dato, pero lo que más aprendí fue lo relacionado a GitHub, desde el inicio que se vinculo esa herramienta con Visual Studio, luego al crear los repositorios y clonarlos para subirlos a GitHub." +
                            "Las dificultades que enfrente fueron al momento de iniciar un proyecto con el lenguaje de C#, ya que era un entorno totalmente nuevo para mi y no sabia como utilizarlo; y esta dificultad la estoy superando he leyendo un poco mas sobre ese lenguaje y practicando lo enseñado en las clases.";

            string Fatima = "Personalmente he adquirido varios conocimientos iniciando con el lenguaje C# del que no conocía muy bien, tampoco sobre GitHub ya que anteriormente lo había visto en lo que buscaba alguna información o ejemplo en el ciclo anterior pero no paso por mi mente que lo utilizaría." +
                            "Luego de eso comenzamos a hacer ejercicios en las practicas y para mandar el comprobante que habíamos trabajado creamos una cuenta en Git y luego lo vinculamos con el Visual Studio para así crear y clonar los repositorios y subirlos a la web, creamos librerías y las diferentes ramas, así como también a configurar y subir los repositorios a GitHub." +
                            "Las dificultades que enfentre fueron muchas y soy sincera que ante un nuevo entorno se nota difícil, además que mi maquina es un poco lenta y la conexión en la cual me perdía a la hora de las practicas, pero digamos que poco a poco puedo ir avanzando mas que todo practicando y pidiendo ayuda cuando siento que de verdad no encuentro salida a las dificultades.";

            string Diego = "Durante este computo aprendí a utilizar el entorno de visual estudio, para desarrollar programas de consola para Windows, además de a ver aprendido a utilizarlo de forma correcta aprendí sobre las herramientas que nos proporciona el IDE, también aprendí mas sobre la estructura de un programa sobre los usings, los espacios de nombre y las clases los cuales son fundamentales para que un programa pueda inicializarse de forma correcta." +
                           "Una de las dificultades que tuve durante el computo fue el trabajar directamente desde el Git Bash, para crear, clonar o actualizar los repositorios que tenemos en GitHub, sin embargo, el material que se nos proporciono en canvas y ver las videoconferencias de nuevo me fue muy útil para comprender más sobre como se trabajar desde el Git Bash";



            for (int i = 0; i < 1; i++)
            {
                //crear los archivos
                if (!File.Exists(getPath() + "Harold.txt"))//comprueba si el archivo no existe
                {
                    using (StreamWriter sw = File.AppendText(getPath() + "Harold.txt"))
                    {
                        sw.WriteLine(Harold);
                        sw.Close();
                    }
                }


                if (!File.Exists(getPath() + "Meylin.txt"))
                {
                    using (StreamWriter sw = File.AppendText(getPath() + "Meylin.txt"))
                    {
                        sw.WriteLine(Meylin);
                        sw.Close();
                    }
                }


                if (!File.Exists(getPath() + "Fatima.txt"))
                {
                    using (StreamWriter sw = File.AppendText(getPath() + "Fatima.txt"))
                    {
                        sw.WriteLine(Fatima);
                        sw.Close();
                    }

                }

                if (!File.Exists(getPath() + "Diego.txt"))
                {
                    using (StreamWriter sw = File.AppendText(getPath() + "Diego.txt"))
                    {
                        sw.WriteLine(Diego);
                        sw.Close();
                    }
                }

                Console.WriteLine("¡Archivos generados con éxito!");
                Console.ReadKey();
            }
        }
        public static void deleteArch()
        {
            Console.WriteLine("ESCOJA EL ARCHIVO QUE DESEA ELIMINAR");
            Console.WriteLine("1. Harold SMIS001621");
            Console.WriteLine("2. Meylin SMIS032721");
            Console.WriteLine("3. Fátima SMIS003321");
            Console.WriteLine("4. Diego SMIS918520");
            Console.Write("Opción: ");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    {
                        File.Delete(getPath() + "Harold.txt");
                        Console.WriteLine("Archivo Eliminado");
                        break;
                    }
                case 2:
                    {
                        File.Delete(getPath() + "Meylin.txt");
                        Console.WriteLine("Archivo Eliminado");
                        break;
                    }
                case 3:
                    {
                        File.Delete(getPath() + "Fatima.txt");
                        Console.WriteLine("Archivo Eliminado");
                        break;
                    }
                case 4:
                    {
                        File.Delete(getPath() + "Diego.txt");
                        Console.WriteLine("Archivo Eliminado");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opción no válida");
                        break;
                    }
            }

        }




    }
}
