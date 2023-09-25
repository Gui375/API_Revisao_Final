using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Interfaces
{
    public interface IAluno
    {
        Task<IEnumerable<Aluno>> ObterTodos();
        Task<Aluno> ObterPorId(Guid id);

        void Adicionar(Aluno aluno);
        void Atualizar (Aluno aluno);   
    }
}
