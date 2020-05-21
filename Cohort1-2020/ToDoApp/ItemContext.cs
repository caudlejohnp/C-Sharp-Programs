using System;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace ToDoApp
{
    public class ItemContext : DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            string DatabaseFile = Path.Combine(ProjectBase.FullName, "ToDoItems.db");

            //to check what the path of the file is, uncomment the file below
            //Console.WriteLine("using database file :" + DatabaseFile);

            optionsBuilder.UseSqlite("Data Source= " + DatabaseFile);
        }
    }
}
