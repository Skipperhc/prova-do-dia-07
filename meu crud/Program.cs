using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meu_crud {
    class Program {
        static void Main(string [] args) {
            Pessoa pessoa = new Pessoa();
            Boolean sair = true;
            int idade = 0;
            string nome = "";

            while(sair) {
                Console.WriteLine("insira o nome de um sujeito");
                nome = Console.ReadLine();
                Console.WriteLine("indique a idade da pessoa");
                idade = Convert.ToInt32(Console.ReadLine());

                pessoa.addPessoa(nome, idade);

                Console.WriteLine("deseja adicinar mais um sujeito\n01 - sim | 02 - não");
                string resposta = Console.ReadLine();
                if(resposta == "não") {
                    sair = false;
                    }
                }

            pessoa.lista = pessoa.lista.OrderByDescending(x => x.Idade).ToList();
            foreach(var person in pessoa.lista) {
                Console.WriteLine($"o nome: {person.Nome} e a idade: {person.Idade}");
                }
            Console.WriteLine("o sujeito mais velho é: " + pessoa.lista[0].Nome + " com " + pessoa.lista[0].Idade);

            foreach(var Person in pessoa.maior18()) {
                Console.WriteLine($"Nome: {Person.Nome} e idade: {Person.Idade}");
                }

            }
        }
    }
