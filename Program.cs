using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;
using Projeto01.Servicos;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula 01 - COTI Informática");

            Cliente cliente = new Cliente();

            Console.WriteLine("Informe o código do Cliente:");
            cliente.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Nome do Cliente:");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("Informe o Email do Cliente:");
            cliente.Email = Console.ReadLine();

            Console.WriteLine("\n\tDados do Cliente:");
            Console.WriteLine("\tCodigo....: " + cliente.Codigo);
            Console.WriteLine("\tNome......: " + cliente.Nome);
            Console.WriteLine("\tEmail.....: " + cliente.Email);

            ClienteService service = new ClienteService();
            service.GravarArquivo(cliente);

            Console.WriteLine("\nArquivo TXT gravado com sucesso.");

            Console.ReadKey();
        }
    }
}
