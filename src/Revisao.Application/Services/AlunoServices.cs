using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
    public class AlunoServices : IAlunosServices
    {
        #region Construtores
        private readonly IAluno _alunoRepository;
        private IMapper _mapper;
       public AlunoServices( IAluno alunoRpository, IMapper mapper) 
        {
            _alunoRepository = alunoRpository;
            _mapper = mapper;
        } 
        #endregion

        public void Adicionar(NovoAlunoViewModel NovoAluno)
        {
            var novoAluno = _mapper.Map<Aluno>(NovoAluno);
            _alunoRepository.Adicionar(novoAluno);
        }

        public void Atualizar(AlunoViewModel aluno)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AlunoViewModel>> ObterPorCategoria(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<AlunoViewModel> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AlunoViewModel>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
