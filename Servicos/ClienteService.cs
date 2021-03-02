using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;
using System.IO;

namespace Projeto01.Servicos
{
    class ClienteService
    {
        public void GravarArquivo(Cliente cliente)
        {
            StreamWriter stream = new StreamWriter("C:\\Users\\gabri\\Desktop\\Curso.Net\\Aula01\\ArquivoTXT\\cliente.txt");

            stream.WriteLine("Codigo....: " + cliente.Codigo);
            stream.WriteLine("Nome......: " + cliente.Nome);
            stream.WriteLine("Email.....: " + cliente.Email);

            stream.Close();
        }
    }
}
