using Revisao.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Interfaces
{
    public interface IAlunosServices
    {
        Task<IEnumerable<AlunoViewModel>> ObterTodos();
        Task<AlunoViewModel> ObterPorId(Guid id);
        Task<IEnumerable<AlunoViewModel>> ObterPorCategoria(int codigo);

        void Adicionar(NovoAlunoViewModel aluno);
        void Atualizar(AlunoViewModel aluno);
    }
}
