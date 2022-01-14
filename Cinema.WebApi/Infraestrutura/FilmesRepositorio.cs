using Cinema.WebApi.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cinema.WebApi.Infraestrutura
{
    public sealed class FilmesRepositorio
    {
        private readonly CinemaDbContext _dbContext;

        public FilmesRepositorio(CinemaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task InserirAsync(Filme novoFilme, CancellationToken cancellationToken = default)
        {
            await _dbContext.Filmes.AddAsync(novoFilme, cancellationToken);
        }

        public void Alterar(Filme filme)
        {

        }

        public async Task<Filme> RecuperarPorIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _dbContext
                            .Filmes
                            .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
        }

        public async Task CommitAsync(CancellationToken cancellationToken = default)
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
