using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialGabrielaNahomyLopez
{
    internal class Program
    {
        static string[] artistas = new string[15];
        static string[] titulos = new string[15];
        static int[] duracion = new int[15];
        static double[] tamaño = new double[15];
        static int totaldecanciones = 0;

        static string[] codigos = new string[15];
        static string[] nombres = new string[15];
        static DateTime[] fechasNacimiento = new DateTime[15];
        static string[] grados = new string[15];
        static int[] añosRegistro = new int[15];
        static int totalAlumnos = 0;


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Seleccione una opcion del menu.");
                Console.WriteLine("1. Menu Canciones: ");
                Console.WriteLine("2. Menu Alumnos: ");
                Console.WriteLine("3. Salir del menu. ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        MenuCanciones();
                        break;
                    case 2:
                        MenuAlumnos();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Esta opcion no es valida.Elija una opcion valida.");
                        break;

                }
            }
        }

        static void MenuCanciones()
        {
            while (totaldecanciones < 15)
            {
                Console.WriteLine("Ingrese los datos de la cancion");
                Console.Write("Nombre del artista: ");
                string artista = Console.ReadLine();
                Console.Write("Titulo de la cancion: ");
                string titulo = Console.ReadLine();
                Console.Write("Duracion de la cancion: ");
                int Duracion = int.Parse(Console.ReadLine());
                Console.Write("Tamaño del fichero: ");
                double Tamaño = double.Parse(Console.ReadLine());

                artistas[totaldecanciones] = artista;
                titulos[totaldecanciones] = titulo;
                duracion[totaldecanciones] = Duracion;
                tamaño[totaldecanciones] = Tamaño;

                totaldecanciones++;

                Console.WriteLine("La Cancion fue almacenada.\n");

                if (totaldecanciones >= 15)
                {
                    Console.WriteLine("Ya a alcanzado el limite de canciones.");
                    break;
                }

                Console.Write("¿Desea agregar otra cancion? (S/N): ");
                string respuesta = Console.ReadLine();

                if (respuesta.ToUpper() != "S")
                {
                    break;
                }

            }

            Console.WriteLine("\nEstas son tus canciones almacenadas: ");
            for (int i = 0; i < totaldecanciones; i++)
            {
                Console.WriteLine($"Cancion {i + 1}: ");
                Console.WriteLine($"Artista: {artistas[i]}");
                Console.WriteLine($"Título: {titulos[i]}");
                Console.WriteLine($"Duración: {duracion[i]}");
                Console.WriteLine($"Tamaño del fichero: {tamaño[i]}\n");
            }

            Console.WriteLine("Presione alguna tecla para salir del programa Gracias :)");
            Console.ReadKey();
        }
    }

    static void MenuAlumnos()
    {
        while (true)
        {
            Console.WriteLine("Gestión de Alumnos en Centro Escolar. Elija una Opcion: ");
            Console.WriteLine("1. Agregar a un nuevo Alumno");
            Console.WriteLine("2. Mostrar el listado de Alumnos");
            Console.WriteLine("3. Buscar Alumno por Código");
            Console.WriteLine("4. Editar Información del Alumno usando su Codigo");
            Console.WriteLine("5. Salir");

            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        AgregarAlumno();
                        break;
                    case 2:
                        MostrarListadoAlumnos();
                        break;
                    case 3:
                        BuscarAlumnoPorCodigo();
                        break;
                    case 4:
                        EditarInformacionAlumno();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Introduce un número del 1 al 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opción no válida. Introduce un número del 1 al 5.");
            }
        }
    }

    static void AgregarAlumno()
    {
        if (totalAlumnos < NombreCompleto.Length)
        {
            Console.WriteLine("Ingrese el nombre completo del alumno: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el código del alumno: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la fecha de nacimiento del alumno (dd-MM-yyyy): ");
            DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el grado a cursar: ");
            int grado = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el año de registro: ");
            int añoRegistro = int.Parse(Console.ReadLine());

            alumnos[cantidadAlumnos] = new Alumno
            {
                Codigo = codigo,
                NombreCompleto = nombre,
                FechaNacimiento = fechaNacimiento,
                Grado = grado,
                AñoRegistro = añoRegistro
            };

            cantidadAlumnos++;
            Console.WriteLine("El Alumno ha sido agregado.");
        }
        else
        {
            Console.WriteLine("No se pueden agregar más alumnos. La capacidad máxima se ha alcanzado.");
        }
    }

    static void MostrarListadoAlumnos()
    {
        if (totalAlumnos < NombreCompleto.length)
        {
            Console.WriteLine("No hay alumnos registrados.");
            return;
        }

        Console.WriteLine("Listado de Alumnos:");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("| Código | Nombre Completo     | Fecha Nacimiento | Grado | Año Registro |");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        foreach (var alumno in NombreCompleto)
        {
            if (alumno.Codigo != 0)
            {
                Console.WriteLine($"| {alumno.Codigo,-6} | {alumno.NombreCompleto,-20} | {alumno.FechaNacimiento:dd-MM-yyyy}     | {alumno.Grado,-5} | {alumno.AñoRegistro,-12} |");
            }
        }

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }

    static void BuscarAlumnoPorCodigo()
    {
        Console.WriteLine("Ingrese el código del alumno a buscar: ");
        int codigoBusqueda = int.Parse(Console.ReadLine());

        foreach (var alumno in alumnos)
        {
            if (alumno.Codigo == codigoBusqueda)
            {
                Console.WriteLine("Información del Alumno: ");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"Código: {alumno.Codigo} ");
                Console.WriteLine($"Nombre Completo: {alumno.NombreCompleto}");
                Console.WriteLine($"Fecha de Nacimiento: {alumno.FechaNacimiento:dd-MM-yyyy} ");
                Console.WriteLine($"Grado: {alumno.Grado}");
                Console.WriteLine($"Año de Registro: {alumno.AñoRegistro}");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                return;
            }
        }

        Console.WriteLine($"No se encontró ningún alumno con el código {codigoBusqueda}. ");
    }

    static void EditarInformacionAlumno()
    {
        Console.WriteLine("Ingrese el código del alumno a editar: ");
        int codigoBusqueda = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidadAlumnos; i++)
        {
            if (alumnos[i].Codigo == codigoBusqueda)
            {
                Console.WriteLine("Ingrese la nueva información del alumno. ");
                Console.WriteLine("Nombre Completo:");
                alumnos[i].NombreCompleto = Console.ReadLine();

                Console.WriteLine("Fecha de Nacimiento (dd-MM-yyyy): ");
                alumnos[i].FechaNacimiento = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Grado: ");
                alumnos[i].Grado = int.Parse(Console.ReadLine());

                Console.WriteLine("Año de Registro: ");
                alumnos[i].AñoRegistro = int.Parse(Console.ReadLine());

                Console.WriteLine("La información del alumno ha sido actualizada. ");
                return;
            }
        }

        Console.WriteLine($"No se encontró ningún alumno con el código {codigoBusqueda}. ");
    }
}






