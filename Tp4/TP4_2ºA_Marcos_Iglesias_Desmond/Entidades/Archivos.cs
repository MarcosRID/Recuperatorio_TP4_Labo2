using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public static class Archivos<T> where T : new()
    {

        public static void Serializar(T objeto, string path) 
        {
            XmlTextWriter escribir;
            XmlSerializer serializo;

            try
            {
                path = path + ".xml";
                escribir = new XmlTextWriter(path, Encoding.UTF8);

                escribir.Formatting = Formatting.Indented;

                serializo = new XmlSerializer(typeof(T));
                serializo.Serialize(escribir, objeto);

                escribir.Close();

            }
            catch (Exception e)
            {
                Archivos<Exception>.SerializarExceptionATexto(e);
            }

        }


        public static T Deserializar(string path)
        {
            using (XmlTextReader lector = new XmlTextReader(path))
            {
                XmlSerializer serializo = null;
                T rta;
                try
                {
                    serializo = new XmlSerializer(typeof(T));
                    return (T)serializo.Deserialize(lector);
                }
                catch (InvalidOperationException e)
                {
                    Archivos<Exception>.SerializarExceptionATexto(e);
                }
                catch (Exception e)
                {
                    Archivos<Exception>.SerializarExceptionATexto(e);
                }

                return default;
            }
        }

        public static void SerializarTexto(string texto, string path, bool append)
        {

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            path = Path.Combine(path, "Archivo.txt");

            using (StreamWriter sw = new StreamWriter(path, append))
            {
                sw.WriteLine(texto);
                sw.Close();
            }

        }

        public static void SerializarExceptionATexto(Exception exception)
        {

            string path = Path.Combine(Directory.GetCurrentDirectory(), "Historial_Errores");

            Archivos<Exception>.SerializarTexto("*** MESSAGE ***", path, true);
            Archivos<Exception>.SerializarTexto(exception.Message, path, true);
            Archivos<Exception>.SerializarTexto("*** STACK TRACE ***", path, true);
            Archivos<Exception>.SerializarTexto(exception.StackTrace, path, true);
            if (exception.InnerException is not null)
            {
                Archivos<Exception>.SerializarTexto("*** INNER EXCEPTION***", path, true);
                Archivos<Exception>.SerializarTexto(exception.InnerException.ToString(), path, true);

            }
            Archivos<Exception>.SerializarTexto("__________________________________", path, true);
        }
    }
}
