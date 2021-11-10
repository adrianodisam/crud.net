using System;
using System.Collections.Generic;



namespace testCrud.Models
{
    public class Editora
    {
        public int Id { get; set; }
        public int CPNJ { get; set; }
        public string Nome { get; set; }//CPNJ (com validação se é valido ou não) Nome, endereço completo. 
        public string Endereco { get; set; }
        public ICollection<Autores> Autores { get; set; } = new List<Autores>();
  

        public Editora()
        {

        }

        public Editora(int id, char CNPJ , string nome, string endereco)
        {
            Id = Id;
            CPNJ = CNPJ;
            Nome = nome;
            Endereco = endereco;
        }

    }
}
