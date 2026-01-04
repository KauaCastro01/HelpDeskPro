using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskPro.SupportAdmin.Models
{
    public class AnexosModel
    {
        public int Id { get; set; }
        public string CaminhoArquivo { get; set; }
        public int TicketId { get; set; }
    }
}
