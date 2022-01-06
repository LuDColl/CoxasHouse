using Commom;
using Domain;
using Infraestructure;
using Infraestructure.UnitOfWork.Interfaces;
using Services.Interfaces;

namespace Services
{
    public class PessoaService : IPessoaService
    {
        private IPessoaUnitOfWork _unitOfWork;

        public PessoaService(IPessoaUnitOfWork pessoaUnitOfWork)
        {
            _unitOfWork = pessoaUnitOfWork;
        }

        public async Task<int?> PostPessoaAsync(Pessoa pessoa)
        {
            ValidarPessoa(pessoa);

            await _unitOfWork.PessoaRepository.PostPessoaAsync(pessoa);

            await _unitOfWork.Commit();

            return pessoa.IdPessoa;
        }

        private void ValidarPessoa(Pessoa pessoa)
        {
            if (new DateTime((DateTime.Now - pessoa.DataNascimento).Ticks).Year < 18)
                throw new DomainException("Proibido menores de Idade");
        }
    }
}
