using myNotes.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace myNotes.DAL
{
    public class NotesConttext : DbContext
    {
        public NotesConttext() : base("myNotesDatabase")
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<Categories> Categories { get; set; }


    }
}