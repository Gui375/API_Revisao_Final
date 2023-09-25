using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{
    public class Aluno
    {
        public Aluno(int Codigo_Id,string Nome, int Idade, string cpf,string ra,bool ativo) 
        {
            codigo_id = Codigo_Id;
            nome = Nome;
            idade = Idade;
            CPF = cpf;
            RA = ra;
            Ativo = ativo;
        }

        public Aluno(string Nome, int Idade, string cpf,string ra)
        {
          
            nome = Nome;
            idade = Idade;
            CPF = cpf;
            RA= ra;
            Ativo = Ativo;
        }

        public Aluno(string Nome, int Idade, string cpf, string ra, bool ativo) : this(Nome, Idade, cpf, ra)
        {
        }

        public int codigo_id { get; set; }
        public string nome { get;  set; }
        public int idade { get; set; }
        public string CPF { get; set; }
        public string RA { get; set; }
        public bool Ativo { get; set; }



        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;

        public void GerarNota(int Nota, int atividades)
        {
            int soma = 0;
            soma =Nota/atividades;
        }
    }
}
