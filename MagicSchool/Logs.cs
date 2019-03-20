using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace MagicSchool
{
    public class Logs
    {

        // Añade LOG y datos introducidos
        public static void LogColegio(string logMessage, IList<Colegios> lista)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter texto = File.AppendText(Path.Combine(docPath, "log.txt"));
            DateTime fechaActual = DateTime.Now;
            texto.WriteLine($"{fechaActual}");
            //w.WriteLine("  :");
            texto.WriteLine($"  :{logMessage}");
            foreach (var a in lista)
            {
                texto.WriteLine($"  :{a.nombre} {a.ciudad} Direccion: {a.domicilio} Contacto: {a.telefono}");
            }
            texto.WriteLine("-------------------------------");
            texto.Close();


        }
        public static void LogProfe(string logMessage, IList<SuperProfesores> profes)
        {   
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter texto = File.AppendText(Path.Combine(docPath, "log.txt"));
            DateTime fechaActual = DateTime.Now;
            texto.WriteLine($"{fechaActual}");
            //w.WriteLine("  :");
            texto.WriteLine($"  :{logMessage}");
            foreach (var a in profes)
            {
                texto.WriteLine($"  :{a.nombre} Clase: {a.claseAsignada} Colegio {a.colegioAsignado} Direccion: {a.domicilio} Contacto: {a.telefono}");
            }
            texto.WriteLine("-------------------------------");
            texto.Close();
        }
        public static void LogAlumnos(string logMessage, IList<Alumnos> alum)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter texto = File.AppendText(Path.Combine(docPath, "log.txt"));
            DateTime fechaActual = DateTime.Now;
            texto.WriteLine($"{fechaActual}");
            //w.WriteLine("  :");
            texto.WriteLine($"  :{logMessage}");
            foreach (var a in alum)
            {
                texto.WriteLine($"  :{a.nombre} SpecialPower:{a.poderEspecial} AstralPower: {a.poderAstral} // Direccion: {a.domicilio} Contacto: {a.telefono}");
            }
            texto.WriteLine("-------------------------------");
            texto.Close();
        }

        // Lee el listado de logs
        public static void DumpLog()
        {   
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamReader r = File.OpenText(Path.Combine(docPath, "log.txt"));
            string sLine="";
            ArrayList arrText = new ArrayList();

                while (sLine != null)
                {
                sLine = r.ReadLine();
                if (sLine != null)
                arrText.Add(sLine);
                }
                r.Close();

                foreach (string sOutput in arrText){
                    Console.WriteLine(sOutput);
                    Console.ReadLine();
                }
                
        }
    }
}
