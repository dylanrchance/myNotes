using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myNotes.Models
{
    public class Notes
    {
        public int ID {get; set;}
        public string Title { get; set; }
        public string Note { get; set; }
        public string CreatedOn { get; set; }
        public string IsDeleted { get; set; }
        public int CategoryID { get; set; }
        public int UsersID { get; set; }
    }
}