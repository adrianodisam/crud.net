using System;
using System.Collections.Generic;

namespace testCrud.Models
{
    public class Autores 
    {
    

        public int Id  { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Celular  { get; set; }
        public string Email { get; set; }
        public Editora  Editora{ get; set; }
        public ICollection<Livro> Livros { get; set; } = new List<Livro>();

        public Autores()
        {

        }

        public Autores(int id,string nome, string cpf, string celular, string email, Editora editora)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Celular = celular;
            Email = email;
            Editora = editora;
        }

  
     
    }


}
