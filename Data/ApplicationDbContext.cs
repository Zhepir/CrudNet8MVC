using Microsoft.EntityFrameworkCore;
using CrudNet8MVC.Models;

namespace CrudNet8MVC.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext>options): base(options) 
        { 

        }

        //AGREGAR LOS MODELOS AQUI

        public DbSet<Contacto> Contacto {  get; set; }
    }
}
