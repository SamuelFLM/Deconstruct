using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Destruct.Models
{
    public sealed class Fisica : Pessoa
    {
        public Fisica() { }
        public Fisica(string nome, int idade, string cpf) : base(nome, idade)
        {
            CPF = cpf;
        }

        private string CPF { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"\nID: {CPF}\n".ToUpper());
            Console.WriteLine($"Nome: {base.Nome}\n".ToUpper());
            Console.WriteLine($"Idade: {base.Idade}".ToUpper());
        }

        public void Deconstruct(out string nome, out int idade, out string cpf)
        {
            nome = Nome;
            idade = Idade;
            cpf = CPF;
        }
    }
}