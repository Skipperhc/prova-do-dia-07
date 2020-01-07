using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meu_crud {
    class Pessoa {

        public List<Pessoa> lista = new List<Pessoa>();
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void addPessoa(string nome, int idade) {
            lista.Add(new Pessoa() {
                Idade = idade,
                Nome = nome
                });
            }
        
        public List<Pessoa> maior18() {
            List<Pessoa> refinado = lista.FindAll(x => x.Idade > 18);
            return refinado;
            }

        }
    }
