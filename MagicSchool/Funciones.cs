using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MagicSchool
{
    class Funciones
    {
        // Colegios  

        public static void AgregarColegio(IList<Colegios> lista)
        {
            Colegios colegioNuevo = new Colegios();
        Inicio:
            try
            {
                Console.WriteLine("Introduce un nombre");
                colegioNuevo.nombre = Console.ReadLine();
                Console.WriteLine("Introduce una ciudad");
                colegioNuevo.ciudad = Console.ReadLine();
                Console.WriteLine("Introduce la direccion del colegio");
                colegioNuevo.domicilio = Console.ReadLine();
                Console.WriteLine("Introduce el telefono del colegio");
                colegioNuevo.telefono = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Algun dato no es correcto");
                goto Inicio;
            }
            lista.Add(colegioNuevo);
        }

        public static void MostrarColegios(IList<Colegios> colegios, IList<SuperProfesores> profes)
        {
            foreach (var cole in colegios)
            {
                Console.WriteLine(cole.nombre);
                foreach (var profe in profes) {
                    if (profe.colegioAsignado == cole.nombre)
                    {
                        Console.WriteLine(profe.nombre);
                    }
                    else {
                        Console.WriteLine("No hay coincidencias");
                    }
                }
            }
        }

        // SUPERPROFESORES

        public static void AgregarSuperProfesor(IList<Colegios> listaColegio, IList<SuperProfesores> lista)
        {
            SuperProfesores superProfesor = new SuperProfesores();

        Inicio:
            try
            {
                if (listaColegio.Count() == 0)
                {
                    Console.WriteLine("No se puede agregar un profesor sin que haya colegios");
                    //for (int i; i < listaColegio.Count(); i++) {
                    //    Console.WriteLine("{0} Colegio - {1}", i, listaColegio[i - 1].nombre);
                    //}
                }
                else {
                    Console.WriteLine("Introduce un nombre");
                    superProfesor.nombre = Console.ReadLine();
                    Console.WriteLine("Introduce el telefono del colegio");
                    superProfesor.telefono = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce la edad del profesor");
                    superProfesor.edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce la direccion del domicilio");
                    superProfesor.domicilio = Console.ReadLine();
                    Console.WriteLine("Clase Asignada: ");
                    superProfesor.claseAsignada = Console.ReadLine();
                    Console.WriteLine("Poder Especial: ");
                    superProfesor.elementoEspecial = Console.ReadLine();

                    int contador = 0;
                    int seleccion = 0;
                    foreach (Colegios cole in listaColegio)
                    {
                        contador++;
                        Console.WriteLine("{0} Colegio - {1}", contador, cole.nombre);
                    }
                    Console.WriteLine("Selecciona un colegio");
                    seleccion = int.Parse(Console.ReadLine());
                    superProfesor.colegioAsignado = listaColegio[seleccion - 1].nombre;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Algun dato no es correcto");
                goto Inicio;
            }
            lista.Add(superProfesor);
        }
    
      
      
        public static void MostrarSuperProfe(IList<SuperProfesores> superProfesores)
        {
            foreach (var profe in superProfesores)
            {
                Console.WriteLine(profe);
            }
        }

        //Alumnos

        public static void AgregarAlumno(IList<Alumnos> lista, IList<SuperProfesores> profesores)
        {
            Alumnos superAlumno = new Alumnos();

        Inicio:
            try
            {
                if (profesores.Count() == 0) {
                    Console.WriteLine("No se puede agregar un alumno sin que haya profesores");
                }
                else
                {
                    Console.WriteLine("Introduce un nombre");
                    superAlumno.nombre = Console.ReadLine();
                    Console.WriteLine("Poder Especial: ");
                    superAlumno.elementoEspecial = Console.ReadLine();
                    Console.WriteLine("Introduce la edad del alumno");
                    superAlumno.edad = int.Parse(Console.ReadLine());
                    if (superAlumno.edad >= 20)
                    {
                        superAlumno.poderAstral = true;
                    }
                    else
                    {
                        superAlumno.poderAstral = false;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Algun dato no es correcto");
                goto Inicio;
            }
            lista.Add(superAlumno);
        }

        public static void MostrarAlumnos(IList<Alumnos> miniMagos)
        {
            foreach (var miniMago in miniMagos)
            {
                Console.WriteLine(miniMago);
            }
        }
        public static void EscribirTXT(IList<Colegios>coles, IList<SuperProfesores> profes, IList<Alumnos> mini )
        {
            // Set a variable to the Documents path.
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter colegios = new StreamWriter(Path.Combine(docPath, "Colegios.txt")))
            {
                foreach (var cole in coles)
                    colegios.WriteLine(cole);
            }
            using (StreamWriter superProfesores = new StreamWriter(Path.Combine(docPath, "Profesores.txt")))
            {
                foreach (var pro in profes)
                    superProfesores.WriteLine(pro);
            }
            using (StreamWriter alum = new StreamWriter(Path.Combine(docPath, "Alumnos.txt")))
            {
                foreach (var al in mini)
                    alum.WriteLine(al);
            }

        }
    }
}
