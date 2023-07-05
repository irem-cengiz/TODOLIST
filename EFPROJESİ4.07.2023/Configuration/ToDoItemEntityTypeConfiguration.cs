using EFPROJESİ4._07._2023.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EFPROJESİ4._07._2023.Configuration
{
    public class ToDoItemEntityTypeConfiguration : IEntityTypeConfiguration<TodoItem>
    {
        public void Configure(EntityTypeBuilder<TodoItem> builder)
        {
            builder.HasData(
              new TodoItem { Id = 1, Title = "Proje teklifini tamamla", Done = false },
              new TodoItem { Id = 2, Title = "Sunum slaytlarını hazırla", Done = false },
              new TodoItem { Id = 3, Title = "Kod değişikliklerini gözden geçir", Done = true },
              new TodoItem { Id = 4, Title = "Takip e-postalarını gönder", Done = true }
          );
        }
    }
}

