

using Destruct.Models;

Fisica pf = new Fisica("Samuel", 21, "124.223.092-01");

// pf.Apresentar();


var (nome, idade, cpf) = pf;

Console.WriteLine(nome);
Console.WriteLine(cpf);
Console.WriteLine(idade);