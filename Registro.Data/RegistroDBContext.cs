using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Registro.Data
{
    public class RegistroDBContext : DbContext
    {

        

        public RegistroDBContext(DbContextOptions<RegistroDBContext> options)
             : base(options)
        {

        }

    }
}
