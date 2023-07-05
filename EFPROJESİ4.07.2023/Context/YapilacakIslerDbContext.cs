using EFPROJESİ4._07._2023.Configuration;
using EFPROJESİ4._07._2023.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EFPROJESİ4._07._2023.Context
{
    public class YapilacakIslerDbContext : DbContext
    {
        public DbSet<TodoItem> todoItems => Set<TodoItem>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                            @"server=(localdb)\MSSQLLocalDB; database=YapilacakIslerDb;trusted_connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ToDoItemEntityTypeConfiguration());
        }
        public override int SaveChanges()
        {

            foreach (EntityEntry girdi in ChangeTracker.Entries()) 
            {
                //bir şey ekleyip silme yaptıgında bu foreach e girer.
                if (girdi.State == EntityState.Deleted && girdi.Entity is TodoItem)  
                    //bir nesne girdi ve bu nesne siliniyor ve türü todoıtem olmalı.
                {
                    girdi.State = EntityState.Unchanged;
                    TodoItem item = (TodoItem)girdi.Entity;
                    item.Deleted = true;
                    
                }
               
            }
            return base.SaveChanges();
           
        }

    }

}