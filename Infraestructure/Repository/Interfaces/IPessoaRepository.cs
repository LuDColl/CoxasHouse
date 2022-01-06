using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Interfaces
{
    public interface IPessoaRepository
    {
        Task PostPessoaAsync(Pessoa pessoa);
    }
}
