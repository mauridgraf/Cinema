using CSharpFunctionalExtensions;
using System;

namespace Cinema.WebApi.Dominio
{
    public sealed class Filme
    {
        private Filme() { }
        public Filme(Guid id, string titulo, int duracao, string sinopse)
        {
            Id = id;
            Titulo = titulo;
            Duracao = duracao;
            Sinopse = sinopse;
        }

        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public int Duracao { get; set; }
        public string Sinopse { get; set; }

        public static Result<Filme> Criar(string titulo, int duracao, string sinopse)
        {
            if (titulo.Length <= 3)
                return Result.Failure<Filme>("Títilo do filme muito curto");

            var filme = new Filme(Guid.NewGuid(), titulo, duracao, sinopse);
            return filme;
        }
    }
}
