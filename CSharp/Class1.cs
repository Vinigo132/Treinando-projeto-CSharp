using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp;
using Interface;
using Enum;


namespace CSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            Pessoa person = new Pessoa();

            person.Nome = "marcos";
            person.estado = "SP";
            person.idade = 29;


            var person2 = new Pessoa();

            person2.Nome = "jujuba";
            person2.estado = "MA";
            person2.idade = 27;


            Animal animal = new Animal();
            animal.Nome = "macaco";
            animal.Especie = "mitico";
            animal.NomeDono = "igao";


            var pesssoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.jao;
            Pessoas pessoa3 = (Pessoas)4;

            Console.WriteLine(pessoa3);

        }
    }
}
