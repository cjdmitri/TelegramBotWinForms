using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramBotWinForms.Models;

namespace TelegramBotWinForms
{
    public class AppDbContext : DbContext
    {
        //Необходимо скачать и установить
        //Microsoft.EntityFrameworkCore.Sqlite.Design
        //Microsoft.EntityFrameworkCore.Tools
        //Microsoft.EntityFrameworkCore.Sqlite


        public DbSet<History> Histories { get; set; }
        public DbSet<Template> Templates { get; set; }


        public AppDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlite("Filename=DataBase.sqlite");
           
        }

        /*
         Создаём «миграции». Для этого, сохранив и откомпилировав наш код (просто чтобы удостовериться в отсутствии явных опечаток) 
         переходим в командную строку NuGet и выполняем следующую команду.
         
        PM> Add-Migration -Name "FirstMigration" -Context "AppContext"

        Генерируем файл БД. Для этого в командной строке NuGet выполняем следующую команду

        PM> Update-Database -Context "AppContext"
         */
    }
}
