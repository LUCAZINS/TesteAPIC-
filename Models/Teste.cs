using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrilhaApiDesafio.Models{
public class Teste
    {
        public int Id { get; set; }
        public string Titulo1 { get; set; }
        public string Descricao1 { get; set; }
        public DateTime Data { get; set; }
        public EnumStatusTarefa Status { get; set; }
    }
}
