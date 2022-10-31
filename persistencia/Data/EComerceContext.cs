using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistencia.Data
{
    internal class EComerceContext : DbContext
    {
        public EComerceContext(DbContextOptions<EComerceContext> options) : base(options)
        {

            //todo - criar contexto no banco de dados
        }
    }
}
