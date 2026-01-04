using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskPro.OpenCall.Model
{
    public class ChamadoModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime? DataFechamento { get; set; }
        public string Status { get; set; } = "Aberto";
        public string? Prioridade { get; set; }
        public int UsuarioClientId { get; set; }
        public int? UsuarioAdminId { get; set; }
    }
}
