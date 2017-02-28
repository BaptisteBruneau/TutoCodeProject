using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TutoCodeProject.Models;
namespace TutoCodeProject.DataAccessLayer
{
    public class SalesERPDAL : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public SalesERPDAL()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Créer une table selon la classe Employé. 
            modelBuilder.Entity<Employee>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);

            //INFO: La relation avec la connection string (web.config) se fait grâce à la propriété name de cette dernière. Celle-ci doit avoir
            //le même nom que la classe.
        }
    }
}