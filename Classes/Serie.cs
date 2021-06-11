using System;
namespace CRUD_CadastroSeries.Classes
{
    public class Serie : EntidadeBase
    {
        private Genero Genero {get; set;}

        private string Titulo {get;set;}

        private string Descricao {get;set;}

        private int Ano{get;set;}

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            string returning = "";
            returning += "Gênero: " + this.Genero + Environment.NewLine;
            returning += "Título: " + this.Titulo + Environment.NewLine;
            returning += "Descrição: " + this.Descricao + Environment.NewLine;
            returning += "Ano de ínicio: " + this.Ano + Environment.NewLine;
            return returning; 
        }

    }
}