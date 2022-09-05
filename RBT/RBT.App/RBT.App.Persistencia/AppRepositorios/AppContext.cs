using Microsoft.EntityFrameworkCore;

namespace RBT.App.Persistencia
{

    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        
    }

}