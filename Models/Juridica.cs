using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deconstruct.Models
{
    public sealed class Juridica : Pessoa
    {
        public Juridica() { }

        public Juridica(string nome, string cnpj) : base(nome)
        {
            CNPJ = cnpj;
        }
        private string CNPJ { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"\nID: {CNPJ}\n".ToUpper());
            Console.WriteLine($"Empresa: {base.Nome}\n".ToUpper());
        }

        public void Deconstruct(out string nome, out string cnjp)
        {
            nome = Nome;
            cnjp = CNPJ;
        }
    }
}