using Domain;

namespace Services.Interfaces
{
    public interface IPessoaService
    {
        Task<int?> PostPessoaAsync(Pessoa pessoa);
    }
}
