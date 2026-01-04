using HelpDeskPro.OpenCall.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskPro.OpenCall.Service
{
    public class UsuarioAdminService
    {
        private readonly AppDbContext _db;
        public UsuarioAdminService(AppDbContext db)
        {
            _db = db;
        }
    }
}
