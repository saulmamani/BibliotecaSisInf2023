using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BibliotecaSisInf.Context
{
    public partial class BibliotecaContext : DbContext
    {
        public BibliotecaContext()
            : base("name=BibliotecaContext")
        {
        }
    }
}
