using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProyectoClases.Helper
{
    public class HelperFiles
    {
        //necesitamos 2 metodos leer y escribir deben ser asincronos
        //en los metodos de clase  no grafica debemos utilizar
        //la clase task para metodos asincronos
        //1)si es un void se utiliza Task
        //2) si es un return se utiliza Task<ClaseReturn>
        public async Task WriteFileAsync(string path, string content)
        {
            FileInfo file = new FileInfo(path);
            using(TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(content);
                await writer.FlushAsync();
                writer.Close();
            }
        }
        public async Task<string> ReadFileAsync(string path)
        {
            FileInfo file = new FileInfo(path);
            using(TextReader reader= file.OpenText())
            {
                string data = await reader.ReadToEndAsync();
                reader.Close();
                return data;
            }
        }
    }
}
