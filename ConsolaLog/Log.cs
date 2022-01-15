using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsolaLog
{
    public class Log
    {
        private string Path = "";

        public Log(string path) {
            this.Path = path;
        }

        public void Add(string sLog) {
            //comprobar si el directorio existe
            CreateDirectory();

            string nombre = GetNameFile();
            string cadena = "";
            cadena += DateTime.Now + " - " + sLog  + Environment.NewLine;

            StreamWriter sw = new StreamWriter(Path+"/"+nombre, true);
            sw.Write(cadena);
            sw.Close();
        }

        private string GetNameFile() {
            string nombre = "";
            nombre = "log_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".txt";
            return nombre;
        }

        private void CreateDirectory() {
            try
            {
                if (!Directory.Exists(Path))
                    Directory.CreateDirectory(Path);
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
