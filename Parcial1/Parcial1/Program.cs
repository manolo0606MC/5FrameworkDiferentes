using System;
using System.IO;

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)

        {
            string Nombre = Input(" Ingrese Nombre:  ");
            string Apellidos = Input(" Ingrese Apellidos:  ");
            string Nacionalidad = Input(" Ingrese Nacionalidad:  ");
            string Direccion = Input(" Ingrese Direccion:  ");
            string Edad = Input(" Ingrese Su Edad:  ");
            string Descripcion = Input("Ingrese la descripción personal:  ");
            string Habilidades = Input("Ingrese algunas habilidades personales:  ");

            string ruta = "C:\\Parcial-1";

            if (Directory.Exists(ruta) == false)
            {
                Directory.CreateDirectory(ruta);
            }

            string css = "th{border:2px solid black;padding:20px;background:rgb(39,56,88)}table{border-collapse:collapse;margin:0 auto}body{background-color:rgb(139,236,41)}td{border:2px solid black;padding:20px;background:rgb(93,162,184)}h1,h2{text-align:center;font-size:40px;background:rgb(93, 162,184);border-radius:20px}";
            string html = "<html><head><style>"+css+"</style><title>Datos</title></head><body><h1> Datos Personales Ingresados</h1><h2> Datos y Tabla</h2><table><tr><th> Nombre</th><td>"+Nombre+"</td></tr><tr><th> Apellidos</th><td>"+Apellidos+"</td></tr><tr><th> Nacionalida</th><td>"+Nacionalidad+"</td></tr><tr><th> Direccion</th><td>"+Direccion+"</td></tr><tr><th> Edad</th><td>"+Edad+ "</td></tr></table><h3> Páginas Relacionadas</h3><ul><li> Logotípo Caracteristico</li></ul> <a href='logo.html'> Ver Logotipo UMG </a><hr><ul><li> Características De la persona</li></ul> <a href='descripcion.html'> Ver Habilidades de la persona </a><hr>></body></html>";
            string html1 = "<html><head><title> Logotipo de Universidad</title></head><body bgcolor='#FF7900'><center><h1 style='color: red; font-family: fantasy; background-color: springgreen;'> Logotipo de la Universidad Mariano Galvez de Guatemala</h1><hr></center><center><h2 style='background-color: springgreen; font-family: fantasy; color: red;'> Campus Jutiapa</h2></center><center> <img src='C:\\Users\\wilso\\OneDrive\\Escritorio\\DesarrolloWeb\\Parcial1/logoumg.jpg' style='width: 500px;'></center></body></html>";
            string html2 = "<html><head><style>"+css+"</style><title>Descripcion Personal</title></head><body><h1> Descripción de la persona que ingreso los Datos</h1><hr><h2> Algunas Habilidaes Importantes !!!</h2><hr><hr><table><tr><th> Descripcion</th><td>"+Descripcion+"</td></tr><tr><th> Habilidades</th><td>"+Habilidades+"</td></tr></table></body></html> ";

            File.WriteAllText("C:\\Parcial-1\\" + Nombre + ".html", html);
            File.WriteAllText("C:\\Parcial-1\\Logo.html", html1);
            File.WriteAllText("C:\\Parcial-1\\descripcion.html", html2);



        }

        static string Input (string txt)
        {
            Console.Write(txt);
            string val = Console.ReadLine();

            if (val.Length < 1)
            {
                Input(txt);
            }

            return val;
        }
    }
}
