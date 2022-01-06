using Domain;
using Infraestructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Infraestructure.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly DbSet<Pessoa> _pessoas;

        public PessoaRepository(CoxaDbContext coxaDbContext)
        {
            _pessoas = coxaDbContext.Pessoas;
        }

        public async Task PostPessoaAsync(Pessoa pessoa)
        {
            await _pessoas.AddAsync(pessoa);
        }
    }
}
