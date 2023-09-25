using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.ViewModels
{
    public class NovoAlunoViewModel
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public string CPF { get; set; }
        public string RA { get; set; }
        public bool Ativo { get; set; }
    }
}
