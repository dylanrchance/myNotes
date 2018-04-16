using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using myNotes.Models;

namespace myNotes.DAL
{
    public class NotesInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<NotesConttext>
    {

        protected override void Seed(NotesConttext context)
        {
            var users = new List<Users>
            {
                //new Users{ID = 1, Name = "John Doe", Email = "testemail@ttest.com",
                //CreatedOn = DateTime.Parse("2018-09-20") },
                //new Users{ID = 2, Name = "Alaska", Email = "snake@slither.com",
                //CreatedOn = DateTime.Parse("1996-02-21") },
                //new Users{ID = 3, Name = "Alyssa Edwards", Email = "beyondbelief@aol.com",
                //CreatedOn = DateTime.Parse("1976-1-14") }

            };

            context.SaveChanges();

            var notes = new List<Notes>
            {
                //new Notes{ID = 1, Title = "Title", Note = "notte", CategoryID = 1,
                //CreatedOn = "Monday", IsDeleted = "Maybe"},
                //new Notes{ID = 2, Title = "This is why I'm a Snake", Note = "Because I won AS3", CategoryID = 2,
                //CreatedOn = "Monday", IsDeleted = "Maybe"},
                // new Notes{ID = 3, Title = "Unique Title", Note = "Unique notte", CategoryID = 3,
                //CreatedOn = "Yesterday", IsDeleted = "Nope"}
            };

            context.SaveChanges();

            var categories = new List<Categories>
            {
                new Categories{ID = 1, Name = "Home" },
                new Categories{ID = 2, Name = "SnakesOnly" },
                new Categories{ID = 3, Name = "Work" }
            };

            context.SaveChanges();
        }
    }
}