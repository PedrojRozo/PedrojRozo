using Persistencia;
using Dominio;
using System;

namespace aplicacion
{
    class Program
    {
        //private static IRepositorioCliente repoCliente = new RepositorioCliente  (new Persistencia.AplicacionContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //addCliente();
        }

        public static void addCliente (){
            var cliente = new Cliente (
                Nombre = "Pedro",
                Edad = 38,
                Documento = 80778223,
                Tipo_Documento = 1
                
            );
            repoCliente.AddCliente(cliente);


        }
    }
}
