using Infraestructure.Repository.Interfaces;
using Infraestructure.UnitOfWork.Interfaces;
namespace Infraestructure.UnitOfWork
{
    public class PessoaUnitOfWork : IPessoaUnitOfWork
    {
        private CoxaDbContext _dbContext;

        public IPessoaRepository PessoaRepository { get; }

        public PessoaUnitOfWork(IPessoaRepository pessoaRepository, CoxaDbContext coxaDbContext)
        {
            PessoaRepository = pessoaRepository;
            _dbContext = coxaDbContext;
        }

        public async Task Commit()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
