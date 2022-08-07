using System;
using System.Globalization;
//using System.Collections.Generic;
//using System.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace CursoCSharp.API
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform==PlatformID.Unix ||
                Environment.OSVersion.Platform==PlatformID.MacOSX)
                ? Environment.ExpandEnvironmentVariables("HOME")
                :Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
    class PrimeiroArquivo
    {
        public static void Executar()
        {
             var path = @"~/primeiro_arquivo.txt".ParseHome();
           
            if (!File.Exists(path))
            {
           using (StreamWriter sw = File.CreateText(path))
         //       var sw = File.CreateText(path);
                {
                    sw.WriteLine("Este é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo");
                }
            }
            else
            {
               // Console.WriteLine("Falha");
            }

               using (StreamWriter sw = File.AppendText(path)) {
         //   var sw = File.AppendText(path);
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto");


            }
        }
    }
}
