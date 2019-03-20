using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MagicSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //StreamWriter texto = File.AppendText(Path.Combine(docPath, "log.txt"));
           


            IList<Colegios> colegios = new List<Colegios>();
            IList<SuperProfesores> superProfesores = new List<SuperProfesores>();
            IList<Alumnos> alumnos = new List<Alumnos>();

        Menu:
            Console.WriteLine("-------Selecciona una opcion-------");
            Console.WriteLine("1. Nuevo Colegio");
            Console.WriteLine("2. Nuevo profesor");
            Console.WriteLine("3. Nuevo alumno");
            Console.WriteLine("4. Listado de colegios y profesores");
            Console.WriteLine("5. Listado de alumnos");
            Console.WriteLine("6. Ver LOG");
            Console.WriteLine("7. Exportar listados completos");
            Console.WriteLine("8. EXIT");


            Console.WriteLine("Introduce una opcion");

            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Funciones.AgregarColegio(colegios);
                    Logs.LogColegio("Colegio Insertado", colegios);
                    Console.ReadKey();
                    Console.Clear();
                    goto Menu;
                case "2":
                    Funciones.AgregarSuperProfesor(colegios,superProfesores);
                    Console.ReadKey();
                    Console.Clear();
                    Logs.LogProfe("SuperProfesor Insertado", superProfesores);
                    goto Menu;
                case "3":
                    Funciones.AgregarAlumno(alumnos, superProfesores);
                    Console.ReadKey();
                    Console.Clear();
                    Logs.LogAlumnos("Alumno Insertado", alumnos);
                    goto Menu;
                case "4":
                    Funciones.MostrarColegios(colegios, superProfesores);
                    Console.ReadKey();
                    Console.Clear();
                    goto Menu;
                case "5":
                    Funciones.MostrarAlumnos(alumnos);
                    Console.ReadKey();
                    Console.Clear();
                    goto Menu;
                case "6":
                    Logs.DumpLog();
                    Console.ReadKey();
                    Console.Clear();
                    goto Menu;
                case "7":
                    Funciones.EscribirTXT(colegios, superProfesores, alumnos);
                    Console.ReadKey();
                    Console.Clear();
                    goto Menu;
                case "8":
                    break;
                default:
                    goto Menu;

            }
        }
    }

}

