
using System;
using System.Collections.Generic;

namespace testCrud.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Edicao { get; set; }
        public string Data_de_Lancamento { get; set; }
        public string Editora { get; set; }
        public string Autor { get; set; }
        public Autores Autores{ get; set; }

        public Livro()
        {

        }

        public Livro(int id, string nome, string edicao, string data_de_Lancamento, string editora, string autor, Autores autores)
        {
            Id = id;
            Nome = nome;
            Edicao = edicao;
            Data_de_Lancamento = data_de_Lancamento;
            Editora = editora;
            Autor = autor;
            Autores = autores;
        }
    }
}
