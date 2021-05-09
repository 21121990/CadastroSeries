using System;
namespace CadastroSeries
{
    public class Series : EntidadeBase
    {

        public Genero Genero { get; set; }
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public int Ano { get; set; }

        public Series(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano;
            return retorno; 
        }
        public Series()
        {

        }

        public string retonaTitulo()
        {
            return this.Titulo;
        }
        public int retornaID(){
            return this.Id;
        }



    }



}