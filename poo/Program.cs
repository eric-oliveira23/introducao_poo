using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //Instanciar objeto da classe aluno
            Aluno a = new Aluno();
            a.nome = "Eric";
            a.nota1 = 8;
            a.nota2 = 10;
            a.mensagem();

            Console.ReadKey();
        }
    }
}
