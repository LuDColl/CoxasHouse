using Infraestructure.Repository.Interfaces;

namespace Infraestructure.UnitOfWork.Interfaces
{
    public interface IPessoaUnitOfWork
    {
        IPessoaRepository PessoaRepository { get; }
        Task Commit();
    }
}
