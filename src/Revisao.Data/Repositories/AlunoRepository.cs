using Newtonsoft.Json;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Repositories
{
    public class AlunoRepository : IAluno
    {

        #region Metodos Arquivos
        private readonly string _AlunoCaminhoArquivo;
        public AlunoRepository()
        {
            _AlunoCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonData", "Aluno.json");
        }

        private List<Aluno> LerProdutosDoArquivo()
        {
            if (!System.IO.File.Exists(_AlunoCaminhoArquivo))
            {
                return new List<Aluno>();
            }

            string json = System.IO.File.ReadAllText(_AlunoCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<Aluno>>(json);
        }
        private int ObterProximoCodigoDisponivel()
        {
            List<Aluno> alunos = LerProdutosDoArquivo();
            if (alunos.Any())
            {
                return alunos.Max(p => p.codigo_id) + 1;
            }
            else
            {
                return 1;
            }
        }
        private void EscreverProdutosNoArquivo(List<Aluno> alunos)
        {
            string json = JsonConvert.SerializeObject(alunos);
            System.IO.File.WriteAllText(_AlunoCaminhoArquivo, json);
        }
        #endregion

        #region Funcoes
        public void Adicionar(Aluno aluno)
        {
            List<Aluno> alunos = new List<Aluno>();
            int proximoCodigo = ObterProximoCodigoDisponivel();
            alunos.Add(aluno);
            EscreverProdutosNoArquivo(alunos);
        }

        public void Atualizar(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public Task<Aluno> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Aluno>> ObterTodos()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
