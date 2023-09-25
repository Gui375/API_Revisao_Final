using AutoMapper;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.AutoMapper
{
    public class ApplicationToDomain : Profile
    {
        public ApplicationToDomain()
        {
            CreateMap<AlunoViewModel, Aluno>()
               .ConstructUsing(q => new Aluno(q.codigo_id, q.nome, q.idade, q.CPF,q.RA,q.Ativo));

            CreateMap<NovoAlunoViewModel, Aluno>()
              .ConstructUsing(q => new Aluno( q.nome, q.idade, q.CPF, q.RA, q.Ativo));
        }    
        
    }
}
