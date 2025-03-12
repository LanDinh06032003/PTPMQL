using Microsoft.EntityFrameworkCore;
 using FirstWebMVC.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace FirstWebMVC.Data {
    public class ApplicationDbContenxt : DbContext {
        public ApplicationDbContenxt(DbContextOptions<ApplicationDbContenxt> options) : base(options){}
       public DbSet<Student> Student {get; set;}
     }
 }
