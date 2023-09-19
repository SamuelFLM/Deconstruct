

using Destruct.Models;

Fisica pf = new Fisica("Samuel", 21, "124.223.092-01");

pf.Apresentar();

var (nomePF, idadePF, cpfPF) = pf;

Console.WriteLine(nomePF);
Console.WriteLine(cpfPF);
Console.WriteLine(idadePF);


Juridica juridica = new Juridica("EMPRESA DEV JR", "51-421342113/0000.1");

juridica.Apresentar();

(string nomeJ, string cnpjJ) = juridica;

Console.WriteLine(nomeJ);
Console.WriteLine(cnpjJ);