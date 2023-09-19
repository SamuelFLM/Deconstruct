using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Destruct.Models
{
    public abstract class Pessoa
    {
        public Pessoa() { }
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        protected string Nome { get; set; }
        protected int Idade { get; set; }

        public abstract void Apresentar();
    }
}